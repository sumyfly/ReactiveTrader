﻿// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Adaptive.ReactiveTrader.Client.iOSTab
{
	[Register ("PricesHeaderCell")]
	partial class PricesHeaderCell
	{
		[Outlet]
		MonoTouch.UIKit.UIView ContainerView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel StatusLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch StatusSwitch { get; set; }

		[Action ("SwitchValueChanged:")]
		partial void SwitchValueChanged (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ContainerView != null) {
				ContainerView.Dispose ();
				ContainerView = null;
			}

			if (StatusLabel != null) {
				StatusLabel.Dispose ();
				StatusLabel = null;
			}

			if (StatusSwitch != null) {
				StatusSwitch.Dispose ();
				StatusSwitch = null;
			}
		}
	}
}
