// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace HambugerMenuPOC
{
	[Register ("MenuViewController")]
	partial class MenuViewController
	{
		[Outlet]
		UIKit.UIButton FirstButton { get; set; }

		[Outlet]
		UIKit.UIButton SecondButton { get; set; }

		[Outlet]
		UIKit.UIButton ThirdButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FirstButton != null) {
				FirstButton.Dispose ();
				FirstButton = null;
			}

			if (SecondButton != null) {
				SecondButton.Dispose ();
				SecondButton = null;
			}

			if (ThirdButton != null) {
				ThirdButton.Dispose ();
				ThirdButton = null;
			}
		}
	}
}
