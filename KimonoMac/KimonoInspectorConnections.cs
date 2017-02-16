using System;
using System.Collections.Generic;
using Foundation;
using AppKit;
using CoreGraphics;
using KimonoCore;
using KimonoCore.Mac;
using SkiaSharp;

namespace KimonoMac
{
	/// <summary>
	/// Handles the inspector for `KimonoProperty` objects connected to Kimono objects.
	/// </summary>
	public partial class KimonoInspectorConnections : NSView
	{
		#region Private Variables
		/// <summary>
		/// The property consumer.
		/// </summary>
		private IKimonoPropertyConsumer _propertyConsumer = null;

		/// <summary>
		/// The connection list.
		/// </summary>
		private SourceListItem Connections = null;

		/// <summary>
		/// The selected point.
		/// </summary>
		private KimonoPropertyConnectionPoint selectedPoint = KimonoPropertyConnectionPoint.Undefined;

		/// <summary>
		/// The available properties.
		/// </summary>
		private List<KimonoProperty> AvailableProperties = new List<KimonoProperty>();
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the design surface.
		/// </summary>
		/// <value>The design surface.</value>
		public KimonoDesignSurface DesignSurface { get; set; }

		/// <summary>
		/// Gets or sets the property consumer.
		/// </summary>
		/// <value>The property consumer.</value>
		public IKimonoPropertyConsumer PropertyConsumer
		{
			get { return _propertyConsumer; }
			set
			{
				_propertyConsumer = value;
				UpdateInspector();
			}
		}
		#endregion

		#region Constructors
		public KimonoInspectorConnections (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Finds the connection.
		/// </summary>
		/// <returns>The `KimonoPropertyConnection` if found, else `null`.</returns>
		/// <param name="point">The `KimonoPropertyConnectionPoint` to search for a connection to.</param>
		private KimonoPropertyConnection FindConnection(KimonoPropertyConnectionPoint point)
		{
			// Scan all connections
			foreach (KimonoPropertyConnection connection in PropertyConsumer.PropertyConnections)
			{
				// Found?
				if (connection.ConnectionPoint == point) return connection;
			}

			// Not found
			return null;
		}

		/// <summary>
		/// Finds the name of the property that a connection point is connected to.
		/// </summary>
		/// <returns>The name of the connected property, or "(none)" if not connected.</returns>
		/// <param name="point">The `KimonoPropertyConnectionPoint` to test.</param>
		private string ConnectedTo(KimonoPropertyConnectionPoint point)
		{
			var connection = FindConnection(point);

			// Found?
			if (connection == null)
			{
				// No
				return "(none)";
			}
			else
			{
				// Yes, return connected property name
				return connection.ConnectedProperty.Name;
			}
		}

		/// <summary>
		/// Updates the available properties list.
		/// </summary>
		/// <param name="point">The connection point to update the list for.</param>
		private void UpdateAvailableProperties(KimonoPropertyConnectionPoint point)
		{
			// Empty property list
			AvailableProperties.Clear();
			PropertyDropdown.RemoveAllItems();
			PropertyDropdown.AddItem("None");

			// Find existing connection
			KimonoProperty connectedProperty = null;
			var connection = FindConnection(point);

			// Connected?
			if (connection != null)
			{
				// Yes, get connected property
				connectedProperty = connection.ConnectedProperty;
			}

			// Scan available properties to see if any are valid for the current point
			var n = 0;
			foreach (KimonoProperty property in DesignSurface.Portfolio.Properties)
			{
				// Take action based on the connection point type
				switch (point)
				{
					case KimonoPropertyConnectionPoint.AdjustsAlpha:
					case KimonoPropertyConnectionPoint.AdjustsBrightness:
					case KimonoPropertyConnectionPoint.AdjustsHue:
					case KimonoPropertyConnectionPoint.AdjustsSaturation:
					case KimonoPropertyConnectionPoint.HasFill:
					case KimonoPropertyConnectionPoint.HasEndHead:
					case KimonoPropertyConnectionPoint.HasFillBlur:
					case KimonoPropertyConnectionPoint.HasFillJitter:
					case KimonoPropertyConnectionPoint.HasFillShadow:
					case KimonoPropertyConnectionPoint.HasFrame:
					case KimonoPropertyConnectionPoint.HasFrameBlur:
					case KimonoPropertyConnectionPoint.HasFrameDash:
					case KimonoPropertyConnectionPoint.HasFrameJitter:
					case KimonoPropertyConnectionPoint.HasFrameShadow:
					case KimonoPropertyConnectionPoint.HasStartHead:
					case KimonoPropertyConnectionPoint.IsStreamlined:
					case KimonoPropertyConnectionPoint.IsVerticalText:
					case KimonoPropertyConnectionPoint.StrikeThruText:
					case KimonoPropertyConnectionPoint.UnderlineText:
					case KimonoPropertyConnectionPoint.Visible:
						// Is boolean property?
						if (property is KimonoPropertyBoolean)
						{
							// Yes, add it to list
							AvailableProperties.Add(property);
							PropertyDropdown.AddItem(property.Name);
							++n;
						}
						break;
					case KimonoPropertyConnectionPoint.AlphaAdjustment:
					case KimonoPropertyConnectionPoint.Bottom:
					case KimonoPropertyConnectionPoint.BrightnessAdjustment:
					case KimonoPropertyConnectionPoint.CornerRadius:
					case KimonoPropertyConnectionPoint.DepthOffset:
					case KimonoPropertyConnectionPoint.FillHorizontalBlurAmount:
					case KimonoPropertyConnectionPoint.FillJitterDeviation:
					case KimonoPropertyConnectionPoint.FillJitterLength:
					case KimonoPropertyConnectionPoint.FillShadowHorizontalBlurAmount:
					case KimonoPropertyConnectionPoint.FillShadowHorizontalOffset:
					case KimonoPropertyConnectionPoint.FillShadowVerticalBlurAmount:
					case KimonoPropertyConnectionPoint.FillShadowVerticalOffset:
					case KimonoPropertyConnectionPoint.FillVerticalBlurAmount:
					case KimonoPropertyConnectionPoint.FrameHorizontalBlurAmount:
					case KimonoPropertyConnectionPoint.FrameJitterDeviation:
					case KimonoPropertyConnectionPoint.FrameJitterLength:
					case KimonoPropertyConnectionPoint.FrameShadowHorizontalBlurAmount:
					case KimonoPropertyConnectionPoint.FrameShadowHorizontalOffset:
					case KimonoPropertyConnectionPoint.FrameShadowVerticalBlurAmount:
					case KimonoPropertyConnectionPoint.FrameShadowVerticalOffset:
					case KimonoPropertyConnectionPoint.FrameVerticalBlurAmount:
					case KimonoPropertyConnectionPoint.HeadInnerRatio:
					case KimonoPropertyConnectionPoint.HeadOuterRatio:
					case KimonoPropertyConnectionPoint.Height:
					case KimonoPropertyConnectionPoint.HueAdjustment:
					case KimonoPropertyConnectionPoint.Left:
					case KimonoPropertyConnectionPoint.NumberOfPoints:
					case KimonoPropertyConnectionPoint.NumberOfSides:
					case KimonoPropertyConnectionPoint.Right:
					case KimonoPropertyConnectionPoint.RotationDegrees:
					case KimonoPropertyConnectionPoint.SkipPoints:
					case KimonoPropertyConnectionPoint.TextScaleX:
					case KimonoPropertyConnectionPoint.TextSize:
					case KimonoPropertyConnectionPoint.TextSkewX:
					case KimonoPropertyConnectionPoint.Top:
					case KimonoPropertyConnectionPoint.Width:
						// Is number property?
						if (property is KimonoPropertyNumber)
						{
							// Yes, add it to list
							AvailableProperties.Add(property);
							PropertyDropdown.AddItem(property.Name);
							++n;
						}
						break;
					case KimonoPropertyConnectionPoint.BaseColor:
					case KimonoPropertyConnectionPoint.FillColor:
					case KimonoPropertyConnectionPoint.FillShadowLinkedColor:
					case KimonoPropertyConnectionPoint.FrameColor:
					case KimonoPropertyConnectionPoint.FrameShadowLinkedColor:
						// Is color property?
						if (property is KimonoPropertyColor)
						{
							// Yes, add it to list
							AvailableProperties.Add(property);
							PropertyDropdown.AddItem(property.Name);
							++n;
						}
						break;
					case KimonoPropertyConnectionPoint.FillGradient:
					case KimonoPropertyConnectionPoint.FrameGradient:
						// Is gradient property?
						if (property is KimonoPropertyGradient)
						{
							// Yes, add it to list
							AvailableProperties.Add(property);
							PropertyDropdown.AddItem(property.Name);
							++n;
						}
						break;
					case KimonoPropertyConnectionPoint.FontFamilyName:
					case KimonoPropertyConnectionPoint.Text:
						// Is text property?
						if (property is KimonoPropertyText)
						{
							// Yes, add it to list
							AvailableProperties.Add(property);
							PropertyDropdown.AddItem(property.Name);
							++n;
						}
						break;
					case KimonoPropertyConnectionPoint.Rect:
						// Is rectangle property?
						if (property is KimonoPropertyRect)
						{
							// Yes, add it to list
							AvailableProperties.Add(property);
							PropertyDropdown.AddItem(property.Name);
							++n;
						}
						break;
					case KimonoPropertyConnectionPoint.Style:
						// Is style property?
						if (property is KimonoPropertyStyle)
						{
							// Yes, add it to list
							AvailableProperties.Add(property);
							PropertyDropdown.AddItem(property.Name);
							++n;
						}
						break;
				}

				// Is this the connected property?
				if (property == connectedProperty)
				{
					// Yes, select it in the list
					PropertyDropdown.SelectItem(n);
				}
			}

			// Update UI
			PropertyDropdown.Enabled = (AvailableProperties.Count > 0);
		}

		/// <summary>
		/// Updates the connection list.
		/// </summary>
		/// <param name="refreshList">If set to <c>true</c> refresh list.</param>
		private void UpdateConnectionList(bool refreshList)
		{
			// Clear
			Connections.Clear();

			// Anything to process?
			if (PropertyConsumer == null) return;

			// Repopulate
			foreach (KimonoPropertyConnectionPoint point in PropertyConsumer.ConnectionPoints)
			{
				// Handle the connection being selected
				Connections.AddItem($"{point}", (FindConnection(point) == null) ? "IconDisconnected" : "IconConnected", () =>
				 {
					 // Update the UI
					 selectedPoint = point;
					 UpdateAvailableProperties(point);
				 });
			}

			// Empty list?
			if (Connections.Count == 0)
			{
				Connections.AddItem("(empty)", "IconDocFolder");
			}

			// Refresh source list?
			if (refreshList)
			{
				ConnectionList.ReloadData();
				ConnectionList.ExpandItem(null, true);
			}
		}

		/// <summary>
		/// Breaks the given connection to a point.
		/// </summary>
		/// <param name="point">The `KimonoPropertyConnectionPoint` to break connection with.</param>
		private void BreakConnection(KimonoPropertyConnectionPoint point)
		{
			// Scan all connections
			foreach (KimonoPropertyConnection connection in PropertyConsumer.PropertyConnections)
			{
				// Found?
				if (connection.ConnectionPoint == point)
				{
					// Yes, remove it and end
					PropertyConsumer.PropertyConnections.Remove(connection);
					return;
				}
			}
		}

		/// <summary>
		/// Makes the connection between a given connection point and a property.
		/// </summary>
		/// <param name="point">The `KimonoPropertyConnectionPoint` to connect to.</param>
		/// <param name="property">The `KimonoProperty` to connect to the point.</param>
		private void MakeConnection(KimonoPropertyConnectionPoint point, KimonoProperty property)
		{
			var connection = FindConnection(point);

			// Found?
			if (connection == null)
			{
				// No, build new connection
				PropertyConsumer.PropertyConnections.Add(new KimonoPropertyConnection(point, property));
			}
			else
			{
				// Yes, update existing connection
				connection.ConnectedProperty = property;
			}
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public void Initialize()
		{
			// Configure the source list
			ConnectionList.Initialize();

			// Add connections
			Connections = new SourceListItem("Connection Points");
			ConnectionList.AddItem(Connections);

			// Display side list
			ConnectionList.ReloadData();
			ConnectionList.ExpandItem(null, true);
		}

		/// <summary>
		/// Updates the inspector.
		/// </summary>
		public void UpdateInspector()
		{
			// Update UI
			UpdateConnectionList(true);
		}

		/// <summary>
		/// Moves the inspector to the given location.
		/// </summary>
		/// <returns>The next location based on the inspector's size.</returns>
		/// <param name="y">The y coordinate.</param>
		public nfloat MoveTo(nfloat y)
		{
			// Set position
			var offset = y - Frame.Height;
			Frame = new CGRect(0, offset, Frame.Width, Frame.Height);
			return offset;
		}
		#endregion

		#region Custom Actions
		/// <summary>
		/// Handles the property changing
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void PropertyChanged(Foundation.NSObject sender)
		{
			// Save undo point
			DesignSurface.SaveUndoPoint();

			// Take action based on the selected item
			if (PropertyDropdown.IndexOfSelectedItem == 0)
			{
				// Break current connection
				BreakConnection(selectedPoint);
			}
			else
			{
				// Make connection
				MakeConnection(selectedPoint, AvailableProperties[(int)PropertyDropdown.IndexOfSelectedItem - 1]);
			}

			// Update the UI
			UpdateConnectionList(true);
			RaiseConnectionModified();
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when connection modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate ConnectionModified;

		/// <summary>
		/// Raises the connection modified event.
		/// </summary>
		internal void RaiseConnectionModified()
		{
			// Inform caller of event
			if (ConnectionModified != null) ConnectionModified();
		}
		#endregion
	}
}
