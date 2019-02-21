using System;

using UIKit;

namespace HambugerMenuPOC
{
    public partial class ViewController : UIViewController
    {
        bool _hamburgerMenuIsVisible = false;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

            InitializeView();
        }

        private void InitializeView()
        {
            AddHamburgerMenuItem();
        }

        protected void SetConstraint(NSLayoutConstraint lead , NSLayoutConstraint trail)
        {
            leadingConstraint = lead;
            trailingConstraint = trail;
        }

        private void AddHamburgerMenuItem()
        {
            UIBarButtonItem HamburgerButton = new UIBarButtonItem();
            HamburgerButton.Image = UIImage.FromBundle("HamburgerMenu");
            HamburgerButton.Clicked += MenuClickedAction;
            NavigationItem.LeftBarButtonItem = HamburgerButton;
            NavigationItem.LeftBarButtonItem.TintColor = UIColor.Cyan;
        }

        private void MenuClickedAction(object sender, EventArgs e)
        {
            if (!_hamburgerMenuIsVisible)
            {
                leadingConstraint.Constant = 150;
                trailingConstraint.Constant = -150;
                _hamburgerMenuIsVisible = true;
            }
            else
            {
                leadingConstraint.Constant = 0;
                trailingConstraint.Constant = 0;
                _hamburgerMenuIsVisible = false;
            }

            UIView.Animate(0.3, 0, UIViewAnimationOptions.CurveEaseIn, AnimationAction, AnimationCompletionHandler);
        }

        private void AnimationAction()
        {
            this.View.LayoutIfNeeded();
        }

        private void AnimationCompletionHandler()
        {
            //Completion of Animation
        }

    }
}
