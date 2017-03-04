using System;
using System.Collections.Generic;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// A Kimono Portfolio holds a collection of <c>KimonoSketches</c>, <c>KimonoStyles</c> and <c>KimonoColors</c>
	/// that define a given Kimono Designer project.
	/// </summary>
	[Table("Portfolio")]
	public class KimonoPortfolio : IKimonoCodeGeneration
	{
		#region Private Variables
		/// <summary>
		/// The currently selected sketch.
		/// </summary>
		internal KimonoSketch _selectedSketch = null;

		/// <summary>
		/// Holds the number that will be assigned to the next new <c>KimonoSketch</c> created
		/// in this portfolio.
		/// </summary>
		internal int NewSketchNumber = 0;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		[PrimaryKey]
		public string UniqueID { get; set; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Gets or sets the name of the element as it will be called in generated source
		/// code.
		/// </summary>
		/// <value>The name of the element.</value>
		internal string ElementName { get; set; } = "";

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; } = "Portfolio";

		/// <summary>
		/// Gets or sets the namespace.
		/// </summary>
		/// <value>The namespace.</value>
		public string Namespace { get; set; } = "Kimono";

		/// <summary>
		/// Gets or sets the author.
		/// </summary>
		/// <value>The author.</value>
		public string Author { get; set; } = "Unknown";

		/// <summary>
		/// Gets or sets the copyright.
		/// </summary>
		/// <value>The copyright.</value>
		public string Copyright { get; set; } = "";

		/// <summary>
		/// Gets or sets the sketches.
		/// </summary>
		/// <value>The sketches.</value>
		[Children]
		public List<KimonoSketch> Sketches { get; set; } = new List<KimonoSketch>();

		/// <summary>
		/// Gets or sets the styles.
		/// </summary>
		/// <value>The styles.</value>
		[Children]
		public List<KimonoStyle> Styles { get; set; } = new List<KimonoStyle>();

		/// <summary>
		/// Gets or sets the colors.
		/// </summary>
		/// <value>The colors.</value>
		[Children]
		public List<KimonoColor> Colors { get; set; } = new List<KimonoColor>();

		/// <summary>
		/// Gets or sets the gradients.
		/// </summary>
		/// <value>The gradients.</value>
		[Children]
		public List<KimonoGradient> Gradients { get; set; } = new List<KimonoGradient>();

		/// <summary>
		/// Gets or sets the properties.
		/// </summary>
		/// <value>The properties.</value>
		[Children]
		public List<KimonoProperty> Properties { get; set; } = new List<KimonoProperty>();

		/// <summary>
		/// Gets or sets the selected sketch.
		/// </summary>
		/// <value>The selected sketch.</value>
		[Ignore]
		public KimonoSketch SelectedSketch
		{
			get { return _selectedSketch; }
			set
			{
				RaiseSelectedSketchWillChange(_selectedSketch);
				_selectedSketch = value;
				RaiseSelectedSketchDidChange(_selectedSketch);
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPortfolio"/> class.
		/// </summary>
		public KimonoPortfolio()
		{
			
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPortfolio"/> class.
		/// </summary>
		/// <param name="data">The TextBase data stream to initialize this instance with.</param>
		public KimonoPortfolio(string data)
		{
			// Initialize from the TextBase stream.
			LoadFromTextBase(data);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPortfolio"/> class.
		/// </summary>
		/// <param name="initialize">If <c>true</c>, the new instance will be initialized with the default values.</param>
		/// <remarks><c>initialize</c> is set to <c>false</c> when a clone is being made of given <c>KimonoPortfolio</c>.</remarks>
		public KimonoPortfolio(bool initialize)
		{
			// Should this instance be initialized?
			if (initialize) Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		internal void Initialize()
		{
			// Add an initial sketch
			AddNewSketch();

			// Set default copyright
			Copyright = $"Copyright (c) {DateTime.Now.ToString("yyyy")}. All rights reserved.";

			// Add the default style
			var style = new KimonoStyle()
			{
				Name = "Default",
				StyleType = KimonoStyleType.Default
			};
			Styles.Add(style);
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Ensures the sketch name is valid.
		/// </summary>
		/// <param name="sketch">Sketch to check the name of.</param>
		public void EnsureSketchNameIsValid(KimonoSketch sketch)
		{

			// Make sure name is valid
			sketch.Name = Kimono.MakeValidItemName("Sketch", sketch.Name);

			// Make sketch name unique
			while (IsSketchNameUsed(sketch)) {
				// Increment name
				sketch.Name = Kimono.IncrementName(sketch.Name);
			}

		}

		/// <summary>
		/// Tests to see if a sketch's name is unique
		/// </summary>
		/// <returns><c>true</c>, if sketch name has been used, <c>false</c> otherwise.</returns>
		/// <param name="sketch">The sketch to check.</param>
		public bool IsSketchNameUsed(KimonoSketch sketch)
		{
			// Scan all sketches
			foreach (KimonoSketch existingSketch in Sketches)
			{
				// Found?
				if (existingSketch != sketch && existingSketch.Name == sketch.Name) return true;
			}

			// Not found
			return false;
		}

		/// <summary>
		/// Ensures the property name is valid.
		/// </summary>
		/// <param name="property">Property to check the name of.</param>
		public void EnsurePropertyNameIsValid(KimonoProperty property)
		{

			// Make sure name is valid
			property.Name = Kimono.MakeValidItemName("Property", property.Name);

			// Make name unique
			while (IsPropertyNameUsed(property))
			{
				// Increment name
				property.Name = Kimono.IncrementName(property.Name);
			}

		}

		/// <summary>
		/// Tests to see if a property's name is unique
		/// </summary>
		/// <returns><c>true</c>, if property name has been used, <c>false</c> otherwise.</returns>
		/// <param name="property">The property to check.</param>
		public bool IsPropertyNameUsed(KimonoProperty property)
		{
			// Scan all properties
			foreach (KimonoProperty existingProperty in Properties)
			{
				// Found?
				if (existingProperty != property && existingProperty.Name == property.Name) return true;
			}

			// Not found
			return false;
		}

		/// <summary>
		/// Ensures the color name is valid.
		/// </summary>
		/// <param name="color">Color to check the name of.</param>
		public void EnsureColorNameIsValid(KimonoColor color)
		{

			// Make sure name is valid
			color.Name = Kimono.MakeValidItemName("Color", color.Name);

			// Make name unique
			while (IsColorNameUsed(color))
			{
				// Increment name
				color.Name = Kimono.IncrementName(color.Name);
			}

		}

		/// <summary>
		/// Tests to see if a color's name is unique
		/// </summary>
		/// <returns><c>true</c>, if color name has been used, <c>false</c> otherwise.</returns>
		/// <param name="color">The color to check.</param>
		public bool IsColorNameUsed(KimonoColor color)
		{
			// Scan all colors
			foreach (KimonoColor existingColor in Colors)
			{
				// Found?
				if (existingColor != color && existingColor.Name == color.Name) return true;
			}

			// Not found
			return false;
		}

		/// <summary>
		/// Ensures the gradient name is valid.
		/// </summary>
		/// <param name="gradient">gradient to check the name of.</param>
		public void EnsureGradientNameIsValid(KimonoGradient gradient)
		{

			// Make sure name is valid
			gradient.Name = Kimono.MakeValidItemName("Gradient", gradient.Name);

			// Make name unique
			while (IsGradientNameUsed(gradient))
			{
				// Increment name
				gradient.Name = Kimono.IncrementName(gradient.Name);
			}

		}

		/// <summary>
		/// Tests to see if a gradient's name is unique
		/// </summary>
		/// <returns><c>true</c>, if gradient name has been used, <c>false</c> otherwise.</returns>
		/// <param name="gradient">The gradient to check.</param>
		public bool IsGradientNameUsed(KimonoGradient gradient)
		{
			// Scan all gradients
			foreach (KimonoGradient existingGradient in Gradients)
			{
				// Found?
				if (existingGradient != gradient && existingGradient.Name == gradient.Name) return true;
			}

			// Not found
			return false;
		}

		/// <summary>
		/// Ensures the style name is valid.
		/// </summary>
		/// <param name="style">KimonoStyle to check the name of.</param>
		public void EnsureStyleNameIsValid(KimonoStyle style)
		{

			// Make sure name is valid
			style.Name = Kimono.MakeValidItemName("Style", style.Name);

			// Make name unique
			while (IsStyleNameUsed(style))
			{
				// Increment name
				style.Name = Kimono.IncrementName(style.Name);
			}

		}

		/// <summary>
		/// Tests to see if a style's name is unique
		/// </summary>
		/// <returns><c>true</c>, if style name has been used, <c>false</c> otherwise.</returns>
		/// <param name="style">The style to check.</param>
		public bool IsStyleNameUsed(KimonoStyle style)
		{
			// Scan all styles
			foreach (KimonoStyle existingStyle in Styles)
			{
				// Found?
				if (existingStyle != style && existingStyle.Name == style.Name) return true;
			}

			// Not found
			return false;
		}

		/// <summary>
		/// Finds the given <c>KimonoSketch</c> by its Unique ID.
		/// </summary>
		/// <returns>The <c>KimonoSketch</c> if found, else <c>null</c>.</returns>
		/// <param name="uniqueID">Unique identifier.</param>
		public KimonoSketch FindSketch(string uniqueID)
		{
			// Scan all sketches
			foreach (KimonoSketch sketch in Sketches)
			{
				// Found?
				if (sketch.UniqueID == uniqueID) return sketch;
			}

			// Not found
			return null;
		}

		/// <summary>
		/// Finds the given <c>KimonoColor</c> by its unique ID.
		/// </summary>
		/// <returns>The <c>KimonoColor</c> if found, else <c>null</c>.</returns>
		/// <param name="uniqueID">Unique identifier.</param>
		public KimonoColor FindColor(string uniqueID)
		{
			// Scan all colors
			foreach (KimonoColor color in Colors)
			{
				// Found?
				if (color.UniqueID == uniqueID) return color;
			}

			// Not found
			return null;
		}

		/// <summary>
		/// Finds the given `KimonoProperty` by its unique ID.
		/// </summary>
		/// <returns>The `KimonoProperty` if founs, else `null`.</returns>
		/// <param name="uniqueID">Unique identifier.</param>
		public KimonoProperty FindProperty(string uniqueID)
		{
			// Scan all properties
			foreach (KimonoProperty property in Properties)
			{
				// Found?
				if (property.UniqueID == uniqueID) return property;
			}

			// Not found
			return null;
		}

		/// <summary>
		/// Finds the gradient by its unique ID.
		/// </summary>
		/// <returns>The <c>KimonoGradient</c> if found, else <c>null</c>.</returns>
		/// <param name="uniqueID">Unique identifier.</param>
		public KimonoGradient FindGradient(string uniqueID)
		{
			// Scan all gradients
			foreach (KimonoGradient gradient in Gradients)
			{
				// Found?
				if (gradient.UniqueID == uniqueID) return gradient;
			}

			// Not found
			return null;
		}

		/// <summary>
		/// Finds the given <c>KimonoStyle</c> by its Unique ID.
		/// </summary>
		/// <returns>The <c>KimonoStyle</c> if found, else <c>null</c>.</returns>
		/// <param name="uniqueID">Unique identifier.</param>
		public KimonoStyle FindStyle(string uniqueID)
		{
			// Scan all sketches
			foreach (KimonoStyle style in Styles)
			{
				// Found?
				if (style.UniqueID == uniqueID) return style;
			}

			// Not found
			return null;
		}

		/// <summary>
		/// Adds the a new <c>KimonoSketch</c> to this portfolio.
		/// </summary>
		public void AddNewSketch()
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Add a new sketch to the collection
			var sketch = new KimonoSketch();
			sketch.Name = $"Untitled {++NewSketchNumber}";
			sketch.Portfolio = this;
			Sketches.Add(sketch);
			SelectedSketch = sketch;

			// Update the UI
			RaiseSketchesModified();
		}

		/// <summary>
		/// Duplicates the selected sketch.
		/// </summary>
		public void DuplicateSelectedSketch()
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Clone the selected sketch
			var sketch = SelectedSketch.Clone();
			sketch.Name = Kimono.IncrementName(sketch.Name);
			sketch.Portfolio = this;
			Sketches.Add(sketch);
			SelectedSketch = sketch;

			// Update the UI
			RaiseSketchesModified();
		}

		/// <summary>
		/// Deletes the selected sketch.
		/// </summary>
		public void DeleteSelectedSketch()
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Remove the current sketch
			Sketches.Remove(SelectedSketch);

			// Select the first sketch if it is available
			if (Sketches.Count > 0)
			{
				SelectedSketch = Sketches[0];
			}
			else
			{
				SelectedSketch = null;
			}

			// Update the UI
			RaiseSketchesModified();
		}

		/// <summary>
		/// Adds the new gradient.
		/// </summary>
		/// <returns>The new gradient.</returns>
		public KimonoGradient AddNewGradient()
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Add new gradient
			var gradient = new KimonoGradient();
			EnsureGradientNameIsValid(gradient);
			Gradients.Add(gradient);

			// Update UI
			RaiseGradientsModified(gradient);

			// Return new gradient
			return gradient;
		}

		/// <summary>
		/// Adds a new <c>KimonoColor</c> to this portfolio.
		/// </summary>
		/// <returns>The new <c>KimonoColor</c>.</returns>
		public KimonoColor AddNewColor()
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// And new color
			var color = new KimonoColor();
			EnsureColorNameIsValid(color);
			Colors.Add(color);

			// Update UI
			RaiseColorsModified(color);

			// Return new color
			return color;
		}

		/// <summary>
		/// Adds a new <c>KimonoColor</c> to this portfolio based off of a given
		/// <c>SKColor</c>.
		/// </summary>
		/// <returns>The new <c>KimonoColor</c>.</returns>
		/// <param name="baseColor">Base color.</param>
		public KimonoColor AddNewColor(SKColor baseColor)
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// And new color
			var color = new KimonoColor(baseColor);
			Colors.Add(color);

			// Update UI
			RaiseColorsModified(color);

			// Return new color
			return color;
		}

		/// <summary>
		/// Adds a new boolean property.
		/// </summary>
		/// <returns>The new `KimonoPropertyBoolean`.</returns>
		public KimonoPropertyBoolean AddPropertyBoolean()
		{
			// Add property
			var property = new KimonoPropertyBoolean();
			AddNewProperty(property);

			// Return new property
			return property;
		}

		/// <summary>
		/// Adds a new library property.
		/// </summary>
		/// <returns>The new `KimonoPropertyBoolean`.</returns>
		public KimonoPropertyLibrary AddPropertyLibrary()
		{
			// Add property
			var property = new KimonoPropertyLibrary();
			AddNewProperty(property);

			// Return new property
			return property;
		}

		/// <summary>
		/// Adds a new color property.
		/// </summary>
		/// <returns>The new `KimonoPropertyColor`.</returns>
		public KimonoPropertyColor AddPropertyColor()
		{
			// Add property
			var property = new KimonoPropertyColor();
			AddNewProperty(property);

			// Return new property
			return property;
		}

		/// <summary>
		/// Adds a new gradient property.
		/// </summary>
		/// <returns>The new `KimonoPropertyGradient`.</returns>
		public KimonoPropertyGradient AddPropertyGradient()
		{
			// Add property
			var property = new KimonoPropertyGradient();
			AddNewProperty(property);

			// Return new property
			return property;
		}

		/// <summary>
		/// Adds a new number property.
		/// </summary>
		/// <returns>The new `KimonoPropertyNumber`.</returns>
		public KimonoPropertyNumber AddPropertyNumber()
		{
			// Add property
			var property = new KimonoPropertyNumber();
			AddNewProperty(property);

			// Return new property
			return property;
		}

		/// <summary>
		/// Adds a new rect property.
		/// </summary>
		/// <returns>The new `KimonoPropertyRect`.</returns>
		public KimonoPropertyRect AddPropertyRect()
		{
			// Add property
			var property = new KimonoPropertyRect();
			AddNewProperty(property);

			// Return new property
			return property;
		}

		/// <summary>
		/// Adds a new style property.
		/// </summary>
		/// <returns>The new `KimonoPropertyStyle`.</returns>
		public KimonoPropertyStyle AddPropertyStyle()
		{
			// Add property
			var property = new KimonoPropertyStyle();
			AddNewProperty(property);

			// Return new property
			return property;
		}

		/// <summary>
		/// Adds a new text property.
		/// </summary>
		/// <returns>The new `KimonoPropertyText`.</returns>
		public KimonoPropertyText AddPropertyText()
		{
			// Add property
			var property = new KimonoPropertyText();
			AddNewProperty(property);

			// Return new property
			return property;
		}

		/// <summary>
		/// Adds the given `KimonoProperty` to this portfolio
		/// </summary>
		/// <param name="property">The `KimonoProperty` to add.</param>
		public void AddNewProperty(KimonoProperty property)
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Ensure name is unique
			EnsurePropertyNameIsValid(property);

			// And new property
			Properties.Add(property);

			// Update UI
			RaisePropertyModified(property);
		}

		/// <summary>
		/// Duplicates the given <c>KimonoColor</c> and adds it to the portfolio's collection
		/// of colors.
		/// </summary>
		/// <param name="color">The <c>KimonoColor</c> to duplicate.</param>
		public void DuplicateColor(KimonoColor color)
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Add new color
			var newColor = color.Clone();
			newColor.Name = Kimono.IncrementName(newColor.Name);
			Colors.Add(newColor);

			// Update UI
			RaiseColorsModified(newColor);
		}

		/// <summary>
		/// Duplicates the property.
		/// </summary>
		/// <returns>The new `KimonoProperty`.</returns>
		/// <param name="property">The `KimonoProperty` to duplicate.</param>
		public KimonoProperty DuplicateProperty(KimonoProperty property)
		{
			// Make clone
			var newProperty = property.Clone();
			newProperty.Name = Kimono.IncrementName(newProperty.Name);
			AddNewProperty(newProperty);

			// Return new property
			return newProperty;
		}

		/// <summary>
		/// Duplicates the gradient.
		/// </summary>
		/// <param name="gradient">The `KimonoGradient` to duplicate.</param>
		public void DuplicateGradient(KimonoGradient gradient)
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Add new gradient
			var newGradient = gradient.Clone();
			newGradient.Name = Kimono.IncrementName(newGradient.Name);
			Gradients.Add(newGradient);

			// Update UI
			RaiseGradientsModified(newGradient);
		}

		/// <summary>
		/// Deletes the given <c>KimonoColor</c> from the portfolio.
		/// </summary>
		/// <param name="color">The <c>KimonoColor</c> to delete.</param>
		public void DeleteColor(KimonoColor color)
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Remove and update the UI
			Colors.Remove(color);
			RaiseColorsModified(null);

			// Unlink from any color that might have been
			// using it as a base
			foreach (KimonoColor subColor in Colors)
			{
				if (subColor.BaseColor == color) subColor.BaseColor = null;
			}

			// Unlink color from any gradient
			foreach (KimonoGradient gradient in Gradients)
			{
				// Check each color in the gradient
				foreach (KimonoHandle handle in gradient.ControlPoints)
				{
					// Using the color?
					if (handle.LinkedColor == color)
					{
						// Yes, break link
						handle.Color = color.Color;
						handle.LinkedColor = null;
					}
				}
			}

			// Unlink color from any style that might have been
			// using it
			foreach (KimonoStyle style in Styles)
			{
				if (style.FillColor == color) style.FillColor = null;
				if (style.FrameColor == color) style.FrameColor = null;
			}

			// Scan all objects for the style being removed
			foreach (KimonoSketch sketch in Sketches)
			{
				foreach (KimonoShape shape in sketch.Shapes)
				{
					// Uncouple this color from any shapes
					if (shape.Style.FillColor == color) shape.Style.FillColor = null;
					if (shape.Style.FrameColor == color) shape.Style.FrameColor = null;

					// Is this a group
					if (shape is KimonoShapeGroup)
					{
						// Yes, cascade the delete through the group
						var group = shape as KimonoShapeGroup;
						group.DeleteColor(color);
					}
				}
			}

			// Update UI
			RaiseSelectedShapeChanged(SelectedSketch.SelectedShape);
		}

		/// <summary>
		/// Deletes the given gradient from the portfolio.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> to delete.</param>
		public void DeleteGradient(KimonoGradient gradient)
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Remove gradient
			Gradients.Remove(gradient);
			RaiseGradientsModified(null);

			// Unlink gradient from any style that might have been
			// using it
			foreach (KimonoStyle style in Styles)
			{
				if (style.FillGradient == gradient) style.FillGradient = null;
				if (style.FrameGradient == gradient) style.FrameGradient = null;
			}

			// Scan all objects for the style being removed
			foreach (KimonoSketch sketch in Sketches)
			{
				foreach (KimonoShape shape in sketch.Shapes)
				{
					// Uncouple this color from any shapes
					if (shape.Style.FillGradient == gradient) shape.Style.FillGradient = null;
					if (shape.Style.FrameGradient == gradient) shape.Style.FrameGradient = null;

					// Is this a group
					if (shape is KimonoShapeGroup)
					{
						// Yes, cascade the delete through the group
						var group = shape as KimonoShapeGroup;
						group.DeleteGradient(gradient);
					}
				}
			}

			// Update UI
			RaiseSelectedShapeChanged(SelectedSketch.SelectedShape);
		}

		/// <summary>
		/// Deletes the given property.
		/// </summary>
		/// <param name="property">The `KimonoProperty` to delete.</param>
		public void DeleteProperty(KimonoProperty property)
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Remove property
			Properties.Remove(property);
			RaisePropertyModified(null);

			// Unlink property from any color that might have been
			// using it
			foreach (KimonoColor color in Colors)
			{
				color.RemoveProperty(property);
			}

			// Unlink gradient from any style that might have been
			// using it
			foreach (KimonoStyle style in Styles)
			{
				style.RemoveProperty(property);
			}

			// Scan all objects for the style being removed
			foreach (KimonoSketch sketch in Sketches)
			{
				sketch.RemoveProperty(property);
			}

			// Update UI
			RaiseSelectedShapeChanged(SelectedSketch.SelectedShape);
		}

		/// <summary>
		/// Adds the a new <c>KimonoStyle</c> to the portfolio.
		/// </summary>
		public void AddNewStyle()
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Add new style
			var style = new KimonoStyle();
			EnsureStyleNameIsValid(style);
			Styles.Add(style);

			// Update the UI
			RaiseStylesModified(style);
		}

		/// <summary>
		/// Duplicates the given <c>KimonoStyle</c> adding it to the portfolio's collection
		/// of styles.
		/// </summary>
		/// <param name="style">The <c>KimonoStyle</c> to duplicate.</param>
		public void DuplicateStyle(KimonoStyle style)
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Add new style and refresh list
			var newStyle = style.Clone(false);
			newStyle.Name = Kimono.IncrementName(newStyle.Name);
			Styles.Add(newStyle);

			// Update the UI
			RaiseStylesModified(newStyle);
		}

		/// <summary>
		/// Takes the custom <c>KimonoStyle</c> of the currently selected <c>KimonoShape</c>, converts
		/// it to a named, shared style and adds it to the portfolio's collection of styles.
		/// </summary>
		public void ConvertSelectedShapeToStyle()
		{
			// Anything to process
			if (SelectedSketch.SelectedShape == null) return;

			// Save undo point
			RaiseRequestNewUndoPoint();

			// Convert to style
			switch (SelectedSketch.SelectedShape.Style.StyleType)
			{
				case KimonoStyleType.Custom:
					SelectedSketch.SelectedShape.Style.StyleType = KimonoStyleType.Standard;
					break;
				case KimonoStyleType.CustomText:
					SelectedSketch.SelectedShape.Style.StyleType = KimonoStyleType.Text;
					break;
			}
			SelectedSketch.SelectedShape.Style.Name = $"{SelectedSketch.SelectedShape.Name} Style";
			Styles.Add(SelectedSketch.SelectedShape.Style);

			// Update the UI
			RaiseStylesModified(SelectedSketch.SelectedShape.Style);
		}

		/// <summary>
		/// Deletes the given <c>KimonoStyle</c> from the portfolio's collection of styles.
		/// </summary>
		/// <param name="style">Style.</param>
		public void DeleteStyle(KimonoStyle style)
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Remove the given style
			Styles.Remove(style);
			RaiseStylesModified(null);

			// Scan all objects for the style being removed
			foreach (KimonoSketch sketch in Sketches)
			{
				foreach (KimonoShape shape in sketch.Shapes)
				{
					// Uncouple this style
					shape.UncoupleDeletedStyle(style);
				}
			}

			// Update UI
			RaiseSelectedShapeChanged(SelectedSketch.SelectedShape);
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts the shapes path to C# Skia based code.
		/// </summary>
		/// <returns>The path as code.</returns>
		public virtual string ToSkiaSharpPath()
		{
			return "";
		}


		/// <summary>
		/// Converts the shape to C# code using the Skia library.
		/// </summary>
		/// <returns>The shape as code.</returns>
		public virtual string ToSkiaSharp()
		{
			return "";
		}

		/// <summary>
		/// Converts this shape C# using the KimonoCore library.
		/// </summary>
		/// <returns>The kimono core.</returns>
		public string ToKimonoCore()
		{
			return "";
		}

		/// <summary>
		/// Converts this shape to C# code.
		/// </summary>
		/// <returns>The shape as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public string ToCSharp(CodeOutputLibrary outputLibrary)
		{
			return "";
		}

		/// <summary>
		/// Builds the C# using statements.
		/// </summary>
		/// <returns>The required using statements based on what other features have been selected.</returns>
		/// <param name="outputOS">The `CodeOutputOS` to write code for.</param>
		/// <param name="outputLibrary">Output library.</param>
		public virtual string ToCSharpUsingStatements(CodeOutputOS outputOS, CodeOutputLibrary outputLibrary)
		{
			var usingStatements = "";

			// Add any supporting using statements based
			// on the selected OS
			switch (outputOS)
			{
				case CodeOutputOS.Android:
					usingStatements += "using Android.App;\n" +
						"using Android.Widget;\n" +
						"using Android.OS;\n" +
						"using Android.Graphics;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.Android;\n";
					}
					break;
				case CodeOutputOS.iOS:
					usingStatements += "using Foundation;\n" +
						"using UIKit;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.iOS;\n";
					}
					break;
				case CodeOutputOS.tvOS:
					usingStatements += "using Foundation;\n" +
						"using UIKit;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.tvOS;\n";
					}
					break;
				case CodeOutputOS.macOS:
					usingStatements += "using Foundation;\n" +
						"using AppKit;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.Mac;\n";
					}
					break;
				case CodeOutputOS.Windows:
				case CodeOutputOS.WindowsWPF:
					usingStatements += "using System.Drawing;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.Windows;\n";
					}
					break;
				case CodeOutputOS.WindowsUWP:
					usingStatements += "using Windows.UI.Xaml.Media.Imaging;\n" +
						"using System.IO;\n" +
						"using Windows.Storage.Streams;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.Windows.UWP;\n";
					}
					break;
			}

			// Return code
			return usingStatements;
		}

		/// <summary>
		/// Converts this shape to C# code.
		/// </summary>
		/// <returns>The shape as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public virtual string ToCSharp(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var usingStatements = "";
			var sourceCode = "";
			var initializers = "";
			var privateVariables = "";
			var privateMethodsCode = "";
			var publicMethodsCode = "";
			var computedProperties = "";
			var overrideMethods = "";

			// Process all sketches in this portfolio
			foreach (KimonoSketch sketch in Sketches)
			{
				// Add the methods required to draw this sketch
				sketch.PortfolioSketchMethods(outputOS, outputLibrary, ref privateMethodsCode, ref publicMethodsCode);
			}

			// Assemble using statements
			usingStatements = "using System;\n" +
				"using SkiaSharp;\n";

			// Cross platform?
			if (outputOS == CodeOutputOS.CrossPlatform)
			{
				// Yes, add all platform's using statements
				// Add Android platform
				usingStatements += "\n#if __Android__\n" +
					ToCSharpUsingStatements(CodeOutputOS.Android, outputLibrary) +
					"#endif\n\n";

				// Add iOS platforms
				usingStatements += "#if __IOS__ \n" +
					ToCSharpUsingStatements(CodeOutputOS.iOS, outputLibrary) +
					"#endif\n\n";

				// Add tvOS platforms
				usingStatements += "#if __TVOS__ \n" +
					ToCSharpUsingStatements(CodeOutputOS.tvOS, outputLibrary) +
					"#endif\n\n";

				// Add macOS platform
				usingStatements += "#if __MACOS__\n" +
					ToCSharpUsingStatements(CodeOutputOS.macOS, outputLibrary) +
					"#endif\n\n";

				// Add Windows and Window WPF platforms
				usingStatements += "#if (WINDOWS || WINDOWS_WPF)\n" +
					ToCSharpUsingStatements(CodeOutputOS.Windows, outputLibrary) +
					"#endif\n\n";

				// Add Windows UWP platform
				usingStatements += "#if WINDOWS_UWP\n" +
					ToCSharpUsingStatements(CodeOutputOS.WindowsUWP, outputLibrary) +
					"#endif\n";
			}
			else
			{
				// No, add only the specific OS using statements
				usingStatements += ToCSharpUsingStatements(outputOS, outputLibrary);
			}

			// Assemble precode items in reverse order to ensure dependencies are registered first
			initializers = KimonoCodeGenerator.InitializerForSupportStyles(outputLanguage, outputLibrary);
			initializers = KimonoCodeGenerator.InitializerForSupportGradients(outputLanguage, outputLibrary) + initializers;

			// Assemble private variables
			if (KimonoCodeGenerator.SupportingGradients.Count > 0) privateVariables = KimonoCodeGenerator.AddCarriageIfNeeded(privateVariables);
			privateVariables += KimonoCodeGenerator.PrivateVariablesForSupportingGradients(outputLanguage, outputLibrary);

			// Assemble computed properties
			if (KimonoCodeGenerator.SupportingColors.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingColors(outputLanguage, outputLibrary);

			if (KimonoCodeGenerator.SupportingGradients.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingGradients(outputLanguage, outputLibrary);

			if (KimonoCodeGenerator.SupportingStyles.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingStyles(outputLanguage, outputLibrary);

			// Convert this portfolio to a class
			sourceCode += $"{usingStatements}\n" +
				$"namespace {KimonoCodeGenerator.MakeElementName(Namespace)} " + "{\n" +
				"\t/// <summary>\n" +
				$"\t/// Author: {Author}\n" +
				$"\t/// {Copyright}\n" +
				"\t/// </summary>\n" +
				$"\t/// <remarks>Generated by Kimono Designer {DateTime.Now.ToString("D")}.</remarks>\n" +
				$"\tpublic class {ElementName}\n" + "\t{\n";

			// Any private variables?
			if (privateVariables != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Private Variables\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(privateVariables, 2) +
					"#endregion\n\n";
			}

			// Any computed properties?
			if (computedProperties != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Computed Properties\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(computedProperties, 2) +
					"#endregion\n\n";
			}

			// Add constructors
			sourceCode += "\t\t#region Constructors\n" +
				"\t\t/// <summary>\n" +
				$"\t\t/// Creates a new instance of the {ElementName} class.\n" +
				"\t\t/// </summary>\n" +
				$"\t\tpublic {ElementName}() " + "{\n" +
				"\t\t\tInitialize();\n" +
				"\t\t}\n\n";

			// Add initializer
			sourceCode += "\t\t/// <summary>\n" +
				$"\t\t/// Initializes this new instance of the {ElementName} class.\n" +
				"\t\t/// </summary>\n" +
				"\t\tinternal void Initialize() {\n";

			// Any initialization code?
			if (initializers != "")
			{
				// Yes, include code
				sourceCode += KimonoCodeGenerator.IncreaseIndentLevel(initializers, 3);
			}

			// Complete costructor
			sourceCode += "\n\t\t}\n" +
				"\t\t#endregion\n\n";

			// Any private methods?
			if (privateMethodsCode != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Private Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(privateMethodsCode, 2) +
					"#endregion\n\n";
			}

			// Any private methods?
			if (publicMethodsCode != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Public Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(publicMethodsCode, 2) +
					"#endregion\n\n";
			}

			// Any override methods?
			if (overrideMethods != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Override Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(overrideMethods, 2) +
					"#endregion\n\n";
			}

			// Close class
			sourceCode += "\t}\n" +
				"}\n";

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Converts this sketch to C# code using the KimonoCore library.
		/// </summary>
		/// <returns>The sketch as source code.</returns>
		/// <param name="outputOS">The `CodeOutputOS` to create code for.</param>
		/// <param name="outputLanguage">The `CodeOutputLanguage` to use.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public virtual string ToCSharpKimono(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var usingStatements = "";
			var sourceCode = "";
			var initializers = "";
			var privateVariables = "";
			var privateMethodsCode = "";
			var publicMethodsCode = "";
			var computedProperties = "";
			var overrideMethods = "";

			// Assemble using statements
			usingStatements = "using System;\n" +
				"using SkiaSharp;\n" +
				"using KimonoCore;\n";

			// Take action based on the outputOS
			switch (outputOS)
			{
				case CodeOutputOS.Android:
					usingStatements += "using KimonoCore.Android;\n";
					break;
				case CodeOutputOS.CrossPlatform:
					usingStatements += "using KimonoCore.Forms;\n";
					break;
				case CodeOutputOS.iOS:
					usingStatements += "using KimonoCore.iOS;\n";
					break;
				case CodeOutputOS.macOS:
					usingStatements += "using KimonoCore.Mac;\n";
					break;
				case CodeOutputOS.tvOS:
					usingStatements += "using KimonoCore.tvOS;\n";
					break;
				case CodeOutputOS.Windows:
				case CodeOutputOS.WindowsWPF:
					usingStatements += "using KimonoCore.Windows;\n";
					break;
				case CodeOutputOS.WindowsUWP:
					usingStatements += "using KimonoCore.Windows.UWP;\n";
					break;
			}

			// Start initializers
			initializers += "// Initialize Portfolio\n" +
				$"Name = \"{Name}\";\n" +
				$"Namespace = \"{Namespace}\";\n" +
				$"Author = \"{Author}\";\n" +
				$"Copyright = \"{Copyright}\";\n" +
				$"ObiScriptPortfolio.Portfolio = this;\n\n";

			// Add sketches
			foreach (KimonoSketch sketch in Sketches)
			{
				// Add sketch to portfolio
				initializers += sketch.ToKimonoCore().Replace("var ","");
				initializers = KimonoCodeGenerator.AddCarriageIfNeeded(initializers);
				initializers += $"Sketches.Add({sketch.ElementName});\n";
			}

			// Assemble precode items in reverse order to ensure dependencies are registered first
			var baseInitializers = KimonoCodeGenerator.InitializerForSupportStyles(outputLanguage, outputLibrary);
			baseInitializers = KimonoCodeGenerator.InitializerForSupportColors(outputLanguage, outputLibrary) + baseInitializers;
			baseInitializers = KimonoCodeGenerator.InitializerForSupportGradients(outputLanguage, outputLibrary) + baseInitializers;
			baseInitializers = KimonoCodeGenerator.CodeForSupportLocalProperties(outputLanguage, outputLibrary) + baseInitializers;

			// Accumulate objects for portfolio
			var accumulation = KimonoCodeGenerator.CodeToAccumulatePortfolioElements("Portfolio.");
			if (accumulation != "")
			{
				// Include accumulators
				initializers += "\n" + accumulation;
			}

			// Assemble full initializer code
			initializers = baseInitializers + initializers;

			// Assemble private variables
			if (KimonoCodeGenerator.SupportingGradients.Count > 0) privateVariables = KimonoCodeGenerator.AddCarriageIfNeeded(privateVariables);
			privateVariables += KimonoCodeGenerator.PrivateVariablesForSupportingGradients(outputLanguage, outputLibrary);

			// Assemble computed properties
			if (KimonoCodeGenerator.SupportingColors.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingColors(outputLanguage, outputLibrary);

			if (KimonoCodeGenerator.SupportingGradients.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingGradients(outputLanguage, outputLibrary);

			if (KimonoCodeGenerator.SupportingStyles.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingStyles(outputLanguage, outputLibrary);

			if (KimonoCodeGenerator.GlobalProperties.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.CodeForSupportGlobalProperties(outputLanguage, outputLibrary);

			computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSketches(outputLanguage, outputLibrary);

			// Start class
			sourceCode += $"{usingStatements}\n" +
				$"namespace {KimonoCodeGenerator.MakeElementName(Namespace)} " +"{\n" +
				"\t/// <summary>\n" +
				$"\t/// Author: {Author}\n" +
				$"\t/// {Copyright}\n" +
				"\t/// </summary>\n" +
				$"\t/// <remarks>Generated by Kimono Designer {DateTime.Now.ToString("D")}.</remarks>\n" +
				$"\tpublic class {ElementName} : KimonoPortfolio\n " + "\t{\n";

			// Any private variables?
			if (privateVariables != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Private Variables\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(privateVariables, 2) +
					"#endregion\n\n";
			}

			// Any computed properties?
			if (computedProperties != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Computed Properties\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(computedProperties, 2) +
					"#endregion\n\n";
			}

			// Make parameter list
			var parameters = KimonoCodeGenerator.CodeForSupportParameterProperties(outputLanguage, outputLibrary);
			var paramList = KimonoCodeGenerator.CodeForInitializeParameterProperties(outputLanguage, outputLibrary);

			// Add constructors
			sourceCode += "\t\t#region Constructors\n" +
				"\t\t/// <summary>\n" +
				$"\t\t/// Creates a new instance of the {ElementName} class.\n" +
				"\t\t/// </summary>\n" +
				$"\t\tpublic {ElementName}({parameters}) " + "{\n" +
				$"\t\t\tInitialize({paramList});\n" +
				"\t\t}\n\n";

			// Add initializer
			sourceCode += "\t\t/// <summary>\n" +
				$"\t\t/// Initializes this new instance of the {ElementName} class.\n" +
				"\t\t/// </summary>\n" +
				$"\t\tinternal void Initialize({parameters}) " +"{\n";

			// Any initialization code?
			if (initializers != "")
			{
				// Yes, include code
				sourceCode += KimonoCodeGenerator.IncreaseIndentLevel(initializers, 3);
			}

			// Complete costructor
			sourceCode += "\n\t\t}\n" +
				"\t\t#endregion\n\n";

			// Any private methods?
			if (privateMethodsCode != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Private Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(privateMethodsCode, 2) +
					"#endregion\n\n";
			}

			// Any private methods?
			if (publicMethodsCode != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Public Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(publicMethodsCode, 2) +
					"#endregion\n\n";
			}

			// Any override methods?
			if (overrideMethods != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Override Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(overrideMethods, 2) +
					"#endregion\n\n";
			}

			// Close class
			sourceCode += "\t}\n" +
				"}\n";

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Converts this object to source code for the given OS, Language and Library.
		/// </summary>
		/// <returns>The object represented as source code in a `string`.</returns>
		/// <param name="outputOS">The `CodeOutputOS`.</param>
		/// <param name="outputLanguage">The `CodeOutputLanguage`.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary`.</param>
		public virtual string ToCode(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Define element name
			ElementName = KimonoCodeGenerator.MakeElementName(Name);

			// Take action based on the language
			switch (outputLanguage)
			{
				case CodeOutputLanguage.CSharp:
					// Take action based on the output library
					switch (outputLibrary)
					{
						case CodeOutputLibrary.SkiaSharp:
							sourceCode += ToCSharp(outputOS, outputLanguage, outputLibrary);
							break;
						case CodeOutputLibrary.KimonoCore:
							sourceCode += ToCSharpKimono(outputOS, outputLanguage, outputLibrary);
							break;
					}
					break;
				case CodeOutputLanguage.ObiScript:
					sourceCode += "// Portfolios are not supported in ObiScript\n";
					break;
			}

			// Return code
			return sourceCode;
		}

        /// <summary>
        /// Generates F# representation of <c>this</c>
        /// </summary>
        /// <returns>The F# code.</returns>
        /// <param name="outputLibrary">Output library.</param>
        public override string ToFSharp (CodeOutputLibrary outputLibrary) => FSharpCodeGenerator.ToCode (this, outputLibrary);

        /// <summary>
        /// Forwards to extension method
        /// </summary>
        /// <returns>The Skia representation of <c>this</c>.</returns>
        public override string ToFSharpSkia () => this.ToFSharpSkiaImpl ();

        /// <summary>
        /// Forwards to extension method
        /// </summary>
        /// <returns>The KimonoCore representation of <c>this</c>.</returns>
        public override string ToFSharpKimonoCore () => this.ToFSharpKimonoCoreImpl ();

		#endregion

		#region Cloning
		/// <summary>
		/// Relinks the colors after a clone operation.
		/// </summary>
		internal void RelinkColors()
		{
			// Process all colors
			foreach (KimonoColor color in Colors)
			{
				// Relink if needed
				if (color.BaseColor != null) color.BaseColor = FindColor(color.UniqueID);

				// Relink properties
				foreach (KimonoPropertyConnection connection in color.PropertyConnections)
				{
					if (connection.ConnectedProperty != null) connection.ConnectedProperty = FindProperty(connection.ConnectedProperty.UniqueID);
				}
			}
		}

		/// <summary>
		/// Relinks the gradient after a clone operation.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> to relink.</param>
		internal void RelinkGradient(KimonoGradient gradient)
		{
			// Relink if needed
			foreach (KimonoHandle handle in gradient.ControlPoints)
			{
				if (handle.LinkedColor != null) handle.LinkedColor = FindColor(handle.LinkedColor.UniqueID);
			}
		}

		/// <summary>
		/// Relinks the given <c>KimonoStyle</c> after a clone operation.
		/// </summary>
		/// <param name="style">The <c>KimonoStyle</c> to relink.</param>
		internal void RelinkStyle(KimonoStyle style)
		{
			// Relink if needed
			if (style.FillColor != null) style.FillColor = FindColor(style.FillColor.UniqueID);
			if (style.FrameColor != null) style.FrameColor = FindColor(style.FrameColor.UniqueID);
			if (style.FillGradient != null) style.FillGradient = FindGradient(style.FillGradient.UniqueID);
			if (style.FrameGradient != null) style.FrameGradient = FindGradient(style.FrameGradient.UniqueID);
			if (style.FrameShadow.LinkedColor != null) style.FrameShadow.LinkedColor = FindColor(style.FrameShadow.LinkedColor.UniqueID);
			if (style.FillShadow.LinkedColor != null) style.FillShadow.LinkedColor = FindColor(style.FillShadow.LinkedColor.UniqueID);
		
			// Relink properties
			foreach (KimonoPropertyConnection connection in style.PropertyConnections)
			{
				if (connection.ConnectedProperty != null) connection.ConnectedProperty = FindProperty(connection.ConnectedProperty.UniqueID);
			}
		}

		/// <summary>
		/// Relinks the given <c>KimonoShape</c> after a clone operation.
		/// </summary>
		/// <param name="parent">The parent object of this object.</param>
		/// <param name="shape">The <c>KimonoShape</c> to relink.</param>
		internal void RelinkShape(object parent, KimonoShape shape)
		{
			// Relink style based on type
			if (shape.Style.StyleType == KimonoStyleType.Custom ||
				shape.Style.StyleType == KimonoStyleType.CustomText)
			{
				RelinkStyle(shape.Style);
			}
			else
			{
				shape.Style = FindStyle(shape.Style.UniqueID);
			}

			// Relink properties
			foreach (KimonoPropertyConnection connection in shape.PropertyConnections)
			{
				if (connection.ConnectedProperty != null) connection.ConnectedProperty = FindProperty(connection.ConnectedProperty.UniqueID);
			}

			// Is the shape a group
			if (shape is KimonoShapeGroup)
			{
				var group = shape as KimonoShapeGroup;
				group.Parent = parent;

				// Process all child shapes in the group
				foreach (KimonoShape subshape in group.Shapes)
				{
					// Link subshape
					RelinkShape(group, subshape);
				}
			}
		}

		/// <summary>
		/// Relinks the given <c>KimonoSketch</c> after a clone operation.
		/// </summary>
		/// <param name="sketch">The <c>KimonoSketch</c> to relink.</param>
		internal void RelinkSketch(KimonoSketch sketch)
		{
			// Reconnect property
			sketch.Portfolio = this;

			// Is this the selected sketch?
			if (SelectedSketch.UniqueID == sketch.UniqueID)
			{
				// Yes, relink
				SelectedSketch = sketch;
			}

			// Process all shapes
			foreach (KimonoShape shape in sketch.Shapes)
			{
				RelinkShape(sketch, shape);
			}
		}

		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>A deep clone of this <c>KimonoPortfolio</c>.</returns>
		public KimonoPortfolio Clone()
		{
			//Console.WriteLine("** Cloning Portfolio ->");

			// Create new instance
			var newPortfolio = new KimonoPortfolio(false)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Namespace = this.Namespace,
				Author = this.Author,
				Copyright = this.Copyright,
				NewSketchNumber = this.NewSketchNumber,
				SelectedSketch = this.SelectedSketch
			};

			// Clone properties
			foreach (KimonoProperty property in Properties)
			{
				newPortfolio.Properties.Add(property.Clone());
			}

			// Clone colors
			foreach (KimonoColor color in Colors)
			{
				newPortfolio.Colors.Add(color.Clone());
			}
			newPortfolio.RelinkColors();

			// Clone gradients
			foreach (KimonoGradient gradient in Gradients)
			{
				var gradientCopy = gradient.Clone();
				newPortfolio.RelinkGradient(gradientCopy);
				newPortfolio.Gradients.Add(gradientCopy);
			}

			// Clone styles
			foreach (KimonoStyle style in Styles)
			{
				var styleCopy = style.Clone(true);
				newPortfolio.RelinkStyle(styleCopy);
				newPortfolio.Styles.Add(styleCopy);
			}

			// Clone sketches
			foreach (KimonoSketch sketch in Sketches)
			{
				var sketchCopy = sketch.Clone();
				newPortfolio.RelinkSketch(sketchCopy);
				newPortfolio.Sketches.Add(sketchCopy);
			}

			// Return new object
			return newPortfolio;
		}
		#endregion

		#region Save and Load 
		/// <summary>
		/// Saves this portfolio to a TextBase formatted data stream.
		/// </summary>
		/// <returns>The TextBase stream representing this `KimonoPortfolio`.</returns>
		public string SaveToTextBase()
		{
			var database = new KimonoTextBase();

			return database.Save(this);
		}

		/// <summary>
		/// Loads this portfolio from a TextBase formatted data stream.
		/// </summary>
		/// <param name="data">The TextBase data stream to load.</param>
		public void LoadFromTextBase(string data)
		{
			var database = new KimonoTextBase();

			// Restore object from data
			database.Load(data, this);

			var x = this;

			// Set selected sketch
			SelectedSketch = Sketches[0];

			// Relink colors
			RelinkColors();

			// Relink gradients
			foreach (KimonoGradient gradient in Gradients)
			{
				RelinkGradient(gradient);
			}

			// Relink styles
			foreach (KimonoStyle style in Styles)
			{
				RelinkStyle(style);
			}

			// Relink sketches
			foreach (KimonoSketch sketch in Sketches)
			{
				sketch.Portfolio = this;
				RelinkSketch(sketch);
			}
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when a new undo point is requested.
		/// </summary>
		public event Kimono.PortfolioEventDelegate RequestNewUndoPoint;

		/// <summary>
		/// Occurs when sketches collection is modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate SketchesModified;

		/// <summary>
		/// Occurs when selected sketch will change.
		/// </summary>
		public event Kimono.SketchEventDelegate SelectedSketchWillChange;

		/// <summary>
		/// Occurs when selected sketch did change.
		/// </summary>
		public event Kimono.SketchEventDelegate SelectedSketchDidChange;

		/// <summary>
		/// Occurs when styles collection is modified.
		/// </summary>
		public event Kimono.StyleEventDelegate StylesModified;

		/// <summary>
		/// Occurs when selected shape changed.
		/// </summary>
		public event Kimono.ShapeEventDelegate SelectedShapeChanged;

		/// <summary>
		/// Occurs when colors collection is modified.
		/// </summary>
		public event Kimono.ColorEventDelegate ColorsModified;

		/// <summary>
		/// Occurs when gradients collection is modified.
		/// </summary>
		public event Kimono.GradientEventDelegate GradientsModified;

		/// <summary>
		/// Occurs when property collection is modified.
		/// </summary>
		public event Kimono.PropertyEventDelegate PropertyModified;

		/// <summary>
		/// Raises the property modified event.
		/// </summary>
		/// <param name="property">The `KimonoProperty` that was modified.</param>
		internal void RaisePropertyModified(KimonoProperty property)
		{
			// Inform caller of event
			if (PropertyModified != null) PropertyModified(property);
		}

		/// <summary>
		/// Raises the gradients modified event.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> that was modified.</param>
		internal void RaiseGradientsModified(KimonoGradient gradient)
		{
			// Inform caller of event
			if (GradientsModified != null) GradientsModified(gradient);
		}

		/// <summary>
		/// Raises the request new undo point event.
		/// </summary>
		internal void RaiseRequestNewUndoPoint()
		{
			// Inform caller of event
			if (RequestNewUndoPoint != null) RequestNewUndoPoint();
		}

		/// <summary>
		/// Raises the sketches modified event.
		/// </summary>
		internal void RaiseSketchesModified()
		{
			// Inform caller of event
			if (SketchesModified != null) SketchesModified();
		}

		/// <summary>
		/// Raises the selected sketch will change event.
		/// </summary>
		/// <param name="sketch">The <c>KimonoSketch</c> that will change.</param>
		internal void RaiseSelectedSketchWillChange(KimonoSketch sketch)
		{
			// Inform caller of event
			if (SelectedSketchWillChange != null) SelectedSketchWillChange(sketch);
		}

		/// <summary>
		/// Raises the selected sketch did change event.
		/// </summary>
		/// <param name="sketch">The <c>KimonoSketch</c> that did change.</param>
		internal void RaiseSelectedSketchDidChange(KimonoSketch sketch)
		{
			// Inform caller of event
			if (SelectedSketchDidChange != null) SelectedSketchDidChange(sketch);
		}

		/// <summary>
		/// Raises the styles modified event.
		/// </summary>
		/// <param name="style">The <c>KimonoStyle</c> that was modified.</param>
		internal void RaiseStylesModified(KimonoStyle style)
		{
			// Inform caller of event
			if (StylesModified != null) StylesModified(style);
		}

		/// <summary>
		/// Raises the selected shape changed event.
		/// </summary>
		/// <param name="selected">The new <c>KimonoShape</c> that was selected.</param>
		internal void RaiseSelectedShapeChanged(KimonoShape selected)
		{
			// Inform caller of event
			if (SelectedShapeChanged != null) SelectedShapeChanged(selected);
		}

		/// <summary>
		/// Raises the colors modified event.
		/// </summary>
		/// <param name="color">The <c>KimonoColor</c> that was modified.</param>
		internal void RaiseColorsModified(KimonoColor color)
		{
			// Inform caller of event
			if (ColorsModified != null) ColorsModified(color);
		}
		#endregion
	}
}
