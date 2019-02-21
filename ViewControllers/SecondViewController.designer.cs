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
	[Register ("SecondViewController")]
	partial class SecondViewController
	{
		[Outlet]
		UIKit.NSLayoutConstraint leadingConstraint { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint trailingConstraint { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (leadingConstraint != null) {
				leadingConstraint.Dispose ();
				leadingConstraint = null;
			}

			if (trailingConstraint != null) {
				trailingConstraint.Dispose ();
				trailingConstraint = null;
			}
		}
	}
}
