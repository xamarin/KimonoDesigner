using System;
using System.Collections.Generic;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Defines the based shape that all other Kimono Shape types will inherit from.
	/// </summary>
	[Table("Shape")]
	public class KimonoShape : KimonoBounds, IKimonoCodeGeneration, IKimonoPropertyConsumer
	{
		#region Private Variables
		/// <summary>
		/// The default name of the shape.
		/// </summary>
		private string _name = "Shape";

		/// <summary>
		/// The default, custom <c>KimonoStyle</c> that is attached to the shape.
		/// </summary>
		internal KimonoStyle _style = new KimonoStyle();

		/// <summary>
		/// The visibility of the shape.
		/// </summary>
		internal bool _visible = true;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public override string Name
		{
			get { return _name; }
			set
			{
				var name = value.Trim();
				if (name == "")
				{
					_name = "Shape";
				}
				else
				{
					_name = name;
				}
			}
		}

		/// <summary>
		/// Gets or sets the name of the element as it will be called in generated source
		/// code.
		/// </summary>
		/// <value>The name of the element.</value>
		internal string ElementName { get; set; } = "";

		/// <summary>
		/// Gets or sets the style.
		/// </summary>
		/// <value>The <c>KimonoStyle</c> that will be used to draw this shape.</value>
		[Child]
		public virtual KimonoStyle Style
		{
			get { return _style; }
			set { _style = value; }
		}

		/// <summary>
		/// Gets or sets the control points that define the path of the shape.
		/// </summary>
		/// <value>A collection of <c>KimonoHandle</c> objects.</value>
		[Ignore]
		public List<KimonoHandle> ControlPoints { get; set; } = new List<KimonoHandle>();

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShape"/> is visible.
		/// </summary>
		/// <value><c>true</c> if visible; otherwise, <c>false</c>.</value>
		public virtual bool Visible
		{
			get { return _visible; }
			set { _visible = value; }
		}

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:KimonoCore.KimonoShape"/> is editable.
		/// </summary>
		/// <remarks>An "Editable Shape" is one that is composed of a set of data points (such as
		/// <c>KimonoVector</c> or <c>KimonoBezier</c>) or a group of objects (such as <c>KimonoShapeGroup</c>).</remarks>
		/// <value><c>true</c> if is editable; otherwise, <c>false</c>.</value>
		[Ignore]
		public virtual bool IsEditable
		{
			get { return false; }
		}

		/// <summary>
		/// Gets or sets the layer depth from the bottom to the top controlling how shapes are overlapping
		/// on the design surface.
		/// </summary>
		/// <value>The layer depth.</value>
		public int LayerDepth { get; set; } = 0;

		/// <summary>
		/// Gets the possible connection points that a `KimonoProperty` can be connected to this
		/// `KimonoShape`.
		/// </summary>
		/// <value>The array of `KimonoPropertyConnectionPoint`.</value>
		[Ignore]
		public virtual KimonoPropertyConnectionPoint[] ConnectionPoints
		{
			get { 
				// Return available connection points
				return new KimonoPropertyConnectionPoint[] {
					KimonoPropertyConnectionPoint.Rect,
					KimonoPropertyConnectionPoint.Top,
					KimonoPropertyConnectionPoint.Left,
					KimonoPropertyConnectionPoint.Bottom,
					KimonoPropertyConnectionPoint.Right,
					KimonoPropertyConnectionPoint.Width,
					KimonoPropertyConnectionPoint.Height,
					KimonoPropertyConnectionPoint.RotationDegrees,
					KimonoPropertyConnectionPoint.Style,
					KimonoPropertyConnectionPoint.Visible
				}; 
			}
		}

		/// <summary>
		/// Gets or sets the list of `KimonoProperty` objects connected to the various 
		/// `KimonoPropertyConnectionPoint`s that will need to be evaulated before drawing
		/// this `KimonoShape`.
		/// </summary>
		/// <value>The property connections.</value>
		[Children]
		public List<KimonoPropertyConnection> PropertyConnections { get; set; } = new List<KimonoPropertyConnection>();
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShape"/> class.
		/// </summary>
		public KimonoShape()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShape"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public KimonoShape(float left, float top, float right, float bottom) : base(left, top, right, bottom)
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShape"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="state">State.</param>
		public KimonoShape(float left, float top, float right, float bottom, KimonoShapeState state) : base(left, top, right, bottom, state)
		{
			Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		internal void Initialize()
		{
			Style.Name = "Custom";
			Style.StyleType = KimonoStyleType.Custom;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Connects the given `KimonoProperty` to the given `KimonoPropertyConnectionPoint` on
		/// this `KimonoShape`.
		/// </summary>
		/// <param name="connectionPoint">The `KimonoPropertyConnectionPoint` to connect to.</param>
		/// <param name="property">The `KimonoProperty` to connect.</param>
		public virtual void AddPropertyConnection(KimonoPropertyConnectionPoint connectionPoint, KimonoProperty property)
		{
			// Is this connection point already used?
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Found?
				if (connection.ConnectionPoint == connectionPoint)
				{
					// Yes, replace the connected property
					connection.ConnectedProperty = property;
					return;
				}
			}

			// Not found, add
			PropertyConnections.Add(new KimonoPropertyConnection(connectionPoint, property));
		}

		/// <summary>
		/// Removes the property connection.
		/// </summary>
		/// <param name="connection">The `KimonoPropertyConnection` to remove.</param>
		public virtual void RemovePropertyConnection(KimonoPropertyConnection connection)
		{
			// Remove the connection from the collection
			PropertyConnections.Remove(connection);
		}

		/// <summary>
		/// Removes any connection using this property.
		/// </summary>
		/// <param name="property">The `KimonoProperty` to remove.</param>
		public virtual void RemoveProperty(KimonoProperty property)
		{
			// Remove any connection that is using this property
			for (int n = PropertyConnections.Count - 1; n >= 0; --n)
			{
				// Grab the connection
				var connection = PropertyConnections[n];

				// Found match?
				if (connection.ConnectedProperty == property)
				{
					// Yes, break this connection
					PropertyConnections.RemoveAt(n);
				}
			}
		}

		/// <summary>
		/// Evaluates all of the `KimonoProperty` objects attached to this `KimonoShape` by
		/// executling their Obi Scripts and updating the values with the results.
		/// </summary>
		public virtual void EvaluateConnectedProperties()
		{
			// Process all property connections
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Evaluate the connection by executing any Obi Script
				// attached to it
				var result = connection.ConnectedProperty.Evaluate();

				// Did the script run successfully?
				if (result.Successful)
				{
					// Update the connected item on this shape
					UpdatePropertyConnectionPoint(connection);
				}

			}

			// Process style as well
			Style.EvaluateConnectedProperties();
		}

		/// <summary>
		/// Updates a `KimonoPropertyConnectionPoint` on this `KimonoShape` with the results
		/// of a Obi Script run on an attached `KimonoProperty`.
		/// </summary>
		/// <param name="connection">Connection.</param>
		public virtual void UpdatePropertyConnectionPoint(KimonoPropertyConnection connection)
		{
			// Take action based on the connection point
			switch (connection.ConnectionPoint)
			{
				case KimonoPropertyConnectionPoint.Rect:
					Rect = connection.ConnectedProperty.ToRect();
					BoundsChanged();
					break;
				case KimonoPropertyConnectionPoint.Top:
					Top = connection.ConnectedProperty.ToFloat();
					BoundsChanged();
					break;
				case KimonoPropertyConnectionPoint.Left:
					Left = connection.ConnectedProperty.ToFloat();
					BoundsChanged();
					break;
				case KimonoPropertyConnectionPoint.Bottom:
					Bottom = connection.ConnectedProperty.ToFloat();
					BoundsChanged();
					break;
				case KimonoPropertyConnectionPoint.Right:
					Right = connection.ConnectedProperty.ToFloat();
					BoundsChanged();
					break;
				case KimonoPropertyConnectionPoint.Width:
					Width = connection.ConnectedProperty.ToFloat();
					BoundsChanged();
					break;
				case KimonoPropertyConnectionPoint.Height:
					Height = connection.ConnectedProperty.ToFloat();
					BoundsChanged();
					break;
				case KimonoPropertyConnectionPoint.RotationDegrees:
					var amount = connection.ConnectedProperty.ToInt();
					if (amount > -1 && amount < 366) RotationDegrees = amount;
					break;
				case KimonoPropertyConnectionPoint.Style:
					Style = connection.ConnectedProperty.ToStyle();
					break;
				case KimonoPropertyConnectionPoint.Visible:
					Visible = connection.ConnectedProperty.ToBool();
					break;
			}
		}

		/// <summary>
		/// Places the shape in the editing mode.
		/// </summary>
		public virtual void StartEditing()
		{
			// Enter the editing state
			State = KimonoShapeState.Editing;
		}

		/// <summary>
		/// Ends the editing mode.
		/// </summary>
		public virtual void EndEditing()
		{
			// Exit the editing state
			ControlPoints.Clear();
			Select();
		}

		/// <summary>
		/// Uncouples the deleted style from the shape.
		/// </summary>
		/// <param name="deletedStyle">The <c>KimonoStyle</c> to delete.</param>
		public virtual void UncoupleDeletedStyle(KimonoStyle deletedStyle)
		{
			// Is this shape attached to the style being removed?
			if (Style == deletedStyle)
			{
				// Yes, move to a custom style
				Style = deletedStyle.Clone(false);
				Style.Name = "Custom";
				Style.StyleType = KimonoStyleType.Custom;
			}
		}

		public virtual void CalculateConfromingGradientCoordinates(KimonoGradient gradient, out SKPoint startPoint, out SKPoint endPoint)
		{
			// Generate conforming coordinates
			startPoint = new SKPoint();
			endPoint = new SKPoint();

			// Anything to process?
			if (gradient == null) return;

			// Save current values
			var start = gradient.StartPoint.Clone();
			var end = gradient.EndPoint.Clone();

			// Calculate ratio of change
			var offsetX = 0f;
			var shrinkX = true;
			var offsetY = 0f;
			var shrinkY = true;

			// Adjust start and end points
			if (Width < gradient.PreviewWidth)
			{
				offsetX = Width / gradient.PreviewWidth;
				shrinkX = true;
			}
			else
			{
				offsetX = gradient.PreviewWidth / Width;
				shrinkX = false;
			}

			if (Height < gradient.PreviewHeight)
			{
				offsetY = Height / gradient.PreviewHeight;
				shrinkY = true;
			}
			else
			{
				offsetY = gradient.PreviewHeight / Height;
				shrinkY = false;
			}

			// Calculate resized X positions
			if (shrinkX)
			{
				start.X = (start.X * offsetX) + Rect.Left;
				end.X = (end.X * offsetX) + Rect.Left;
			}
			else
			{
				start.X = (start.X / offsetX) + Rect.Left;
				end.X = (end.X / offsetX) + Rect.Left;
			}

			// Calculate resized Y positions
			if (shrinkY)
			{
				start.Y = (start.Y * offsetY) + Rect.Top;
				end.Y = (end.Y * offsetY) + Rect.Top;
			}
			else
			{
				start.Y = (start.Y / offsetY) + Rect.Top;
				end.Y = (end.Y / offsetY) + Rect.Top;
			}

			// Save new coordinates
			startPoint.X = start.X;
			startPoint.Y = start.Y;

			endPoint.X = end.X;
			endPoint.Y = end.Y;
		}

		/// <summary>
		/// Conforms the gradient to shape by fitting it to the bounds of the shape.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> to conform.</param>
		/// <param name="paint">The <c>SKPaint</c> that the gradient is being attached to.</param>
		public virtual void ConformGradientToShape(KimonoGradient gradient, SKPaint paint)
		{
			// Anything to process?
			if (gradient == null) return;

			// Generate conforming coordinates
			var start = new SKPoint();
			var end = new SKPoint();
			CalculateConfromingGradientCoordinates(gradient,out start, out end);

			// Apply change to the paint
			paint.Shader = gradient.ConformingShader(start, end);

		}

		/// <summary>
		/// Converts the current shape to a vector.
		/// </summary>
		/// <returns>The shape as a <c>KimonoVector</c>.</returns>
		public virtual KimonoShapeVector ToVector()
		{
			return null;
		}

		/// <summary>
		/// Converts the current shape to a path.
		/// </summary>
		/// <returns>The shape as a <c>SKPath</c>.</returns>
		public virtual SKPath ToPath()
		{
			// Construct new path
			var path = new SKPath();

			// Return path
			return path;
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Gets the style fill paint for code.
		/// </summary>
		/// <value>The style fill paint for code.</value>
		public string StyleFillPaintForCode(CodeOutputLibrary outputLibrary)
		{
			// Is this shape using a custom style?
			if (outputLibrary == CodeOutputLibrary.SkiaSharp || Style.StyleType == KimonoStyleType.Custom || Style.StyleType == KimonoStyleType.Custom)
			{
				return $"{Style.ElementName}FillPaint";
			}
			else
			{
				return $"{Style.ElementName}.Fill";
			}
		}

		/// <summary>
		/// Gets the style frame paint for code.
		/// </summary>
		/// <value>The style frame paint for code.</value>
		public string StyleFramePaintForCode(CodeOutputLibrary outputLibrary)
		{
			// Is this shape using a custom style?
			if (outputLibrary == CodeOutputLibrary.SkiaSharp || Style.StyleType == KimonoStyleType.Custom || Style.StyleType == KimonoStyleType.Custom)
			{
				return $"{Style.ElementName}FramePaint";
			}
			else
			{
				return $"{Style.ElementName}.Frame";
			}
		}

		/// <summary>
		/// Conforms the attached gradient to the shapes bounds for code.
		/// </summary>
		/// <returns>The fill gradient conformed in code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public string ConformedFillGradientCode(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Anything to process?
			if (Style.FillGradient != null)
			{
				// Get conforming coordinates
				var startPoint = new SKPoint();
				var endPoint = new SKPoint();
				CalculateConfromingGradientCoordinates(Style.FillGradient, out startPoint, out endPoint);

				// Conform gradient
				sourceCode += $"{StyleFillPaintForCode(outputLibrary)}.Shader = {Style.FillGradient.ToCSharp(outputLibrary, startPoint, endPoint)}";
			}

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Conforms the attached gradient to the shapes bounds for code.
		/// </summary>
		/// <returns>The frame gradient conformed in code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public string ConformedFrameGradientCode(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Anything to process?
			if (Style.FrameGradient != null)
			{
				// Get conforming coordinates
				var startPoint = new SKPoint();
				var endPoint = new SKPoint();
				CalculateConfromingGradientCoordinates(Style.FrameGradient, out startPoint, out endPoint);

				// Conform gradient
				sourceCode += $"{StyleFramePaintForCode(outputLibrary)}.Shader = {Style.FrameGradient.ToCSharp(outputLibrary, startPoint, endPoint)};";
			}

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Converts the shapes path to C# Skia based code.
		/// </summary>
		/// <returns>The path as code.</returns>
		public override string ToSkiaSharpPath()
		{
			return "";
		}


		/// <summary>
		/// Converts the shape to C# code using the Skia library.
		/// </summary>
		/// <returns>The shape as code.</returns>
		public override string ToSkiaSharp()
		{
			return "";
		}

		/// <summary>
		/// Converts this shape C# using the KimonoCore library.
		/// </summary>
		/// <returns>The kimono core.</returns>
		public override string ToKimonoCore()
		{
			return "";
		}

		/// <summary>
		/// Converts this shape to C# code.
		/// </summary>
		/// <returns>The shape as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public override string ToCSharp(CodeOutputLibrary outputLibrary)
		{
			return "";
		}

		/// <summary>
		/// Checks to see if a property is attached to the given connection point. If so, the
		/// property is used in code generation, else the default code is used.
		/// </summary>
		/// <returns>The source code for the possible connection point.</returns>
		/// <param name="connectionPoint">The `KimonoPropertyConnectionPoint` to test for a connection.</param>
		/// <param name="defaultCode">The default source code that will be used if no code is attached to the given point.</param>
		public virtual string CheckForConnection(KimonoPropertyConnectionPoint connectionPoint, string defaultCode)
		{
			// Scan for used properties
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Is there an active connection to the given point?
				if (connection.ConnectionPoint == connectionPoint)
				{
					// Yes, add this property and return its name
					return KimonoCodeGenerator.AddSupportingProperty(connection.ConnectedProperty);
				}
			}

			// Not found, use the default code
			return defaultCode;
		}

		/// <summary>
		/// Converts all connected points to KimonoCore source code objects.
		/// </summary>
		/// <returns>The code to rebuild the connections are source code.</returns>
		public virtual string ConnectionsToKimonoCore()
		{
			var sourceCode = "";

			// Anything to process?
			if (PropertyConnections.Count < 1) return "";

			// Start list
			sourceCode += $"// Property connections for {Name}.\n";

			// Process all connections
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Accumulate the connection point
				KimonoCodeGenerator.AddSupportingProperty(connection.ConnectedProperty);

				// Add code for point
				sourceCode += $"{ElementName}.PropertyConnections.Add(new KimonoPropertyConnection(KimonoPropertyConnectionPoint.{connection.ConnectionPoint} , {connection.ConnectedProperty.ElementName}));\n";
			}

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts this object to source code for the given OS, Language and Library.
		/// </summary>
		/// <returns>The object represented as source code in a `string`.</returns>
		/// <param name="outputOS">The `CodeOutputOS`.</param>
		/// <param name="outputLanguage">The `CodeOutputLanguage`.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary`.</param>
		public override string ToCode(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Is this shape using a custom style?
			if (Style.StyleType == KimonoStyleType.Custom || Style.StyleType == KimonoStyleType.CustomText)
			{
				// Yes, include it in the source code
				Style.Name = $"{Name} Style";
				Style.ElementName = KimonoCodeGenerator.MakeElementName(Style.Name);

				// Take action based on the output language
				switch (outputLanguage)
				{
					case CodeOutputLanguage.CSharp:
						sourceCode += Style.ToCSharp(outputLibrary);
						break;
					case CodeOutputLanguage.ObiScript:
						sourceCode += Style.ToObiScript();
						break;
				}
			}
			else
			{
				// Accumulate linked styles
				KimonoCodeGenerator.AddSupportingStyle(Style);
			}

			// Return results
			return sourceCode;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clones the attached style.
		/// </summary>
		/// <returns>A duplicate <c>KimonoStyle</c>.</returns>
		internal KimonoStyle CloneAttachedStyle()
		{
			// Take action based on the style type
			if (Style.StyleType == KimonoStyleType.Custom ||
				Style.StyleType == KimonoStyleType.CustomText)
			{
				// Custom style needs to be cloned
				return Style.Clone(false);
			}
			else
			{
				// Linked styles should be directly
				// attached sans cloning
				return Style;
			}
		}

		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone of this shape as a base <c>KimonoBounds</c>.</returns>
		public override KimonoBounds Clone()
		{
			// Duplicate shape
			var newShape = new KimonoShape(this.Left, this.Top, this.Right, this.Bottom, this.State)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Style = CloneAttachedStyle(),
				Visible = this.Visible,
				LayerDepth = this.LayerDepth
			};

			// Clone control points
			foreach (KimonoHandle handle in ControlPoints)
			{
				// Duplicate handle and add to collection
				newShape.ControlPoints.Add(handle.Clone());
			}

			// Clone any property connections
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Add duplicate connection
				newShape.PropertyConnections.Add(connection.Clone());
			}

			// Return new shape
			return newShape;
		}
		#endregion
	}
}
