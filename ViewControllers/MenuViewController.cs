using System;

using UIKit;

namespace HambugerMenuPOC
{
    public partial class MenuViewController : UIViewController
    {
        protected MenuViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            FirstButton.TouchUpInside += (sender, e) => {

                UIStoryboard storyboard = UIStoryboard.FromName("Main", null);
                UIViewController firstViewController = storyboard.InstantiateViewController("FirstVC") as UIViewController;
                this.NavigationController.PushViewController(firstViewController,true);
            };

            SecondButton.TouchUpInside += (sender, e) => {

                UIStoryboard storyboard = UIStoryboard.FromName("Main", null);
                UIViewController firstViewController = storyboard.InstantiateViewController("SecondVC") as UIViewController;
                this.NavigationController.PushViewController(firstViewController, true);
            };

            ThirdButton.TouchUpInside += (sender, e) => {

                UIStoryboard storyboard = UIStoryboard.FromName("Main", null);
                UIViewController firstViewController = storyboard.InstantiateViewController("ThirdVC") as UIViewController;
                this.NavigationController.PushViewController(firstViewController, true);
            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

