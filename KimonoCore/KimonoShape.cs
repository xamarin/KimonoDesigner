using System;
using System.Collections.Generic;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines the based shape that all other Kimono Shape types will inherit from.
	/// </summary>
	public class KimonoShape : KimonoBounds
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
		public string Name
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
		/// Gets or sets the style.
		/// </summary>
		/// <value>The <c>KimonoStyle</c> that will be used to draw this shape.</value>
		public virtual KimonoStyle Style
		{
			get { return _style; }
			set { _style = value; }
		}

		/// <summary>
		/// Gets or sets the control points that define the path of the shape.
		/// </summary>
		/// <value>A collection of <c>KimonoHandle</c> objects.</value>
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

		/// <summary>
		/// Conforms the gradient to shape by fitting it to the bounds of the shape.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> to conform.</param>
		/// <param name="paint">The <c>SKPaint</c> that the gradient is being attached to.</param>
		public virtual void ConformGradientToShape(KimonoGradient gradient, SKPaint paint)
		{
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
				end.X  = (end.X * offsetX) + Rect.Left;
			}
			else
			{
				start.X  = (start.X  / offsetX) + Rect.Left;
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

			// Apply change to the paint
			paint.Shader = gradient.ConformingShader(new SKPoint(start.X ,start.Y), new SKPoint(end.X, end.Y));

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

			// Return new shape
			return newShape;
		}
		#endregion
	}
}
