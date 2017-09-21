using System;
using System.Collections.Generic;
using System.Diagnostics;
using TestRefit.Network;
using UIKit;

namespace TestRefit.iOS
{
    public partial class ViewController : UIViewController
    {
        //int count = 1;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += delegate
            {

                this.CallAPI();
                //var title = string.Format("{0} clicks!", count++);
                //Button.SetTitle(title, UIControlState.Normal);
            };
        }

        private async void CallAPI(){
            WS ws = new WS();
            List<Recipe> list = await ws.CallService();
            Debug.Write("ok");

        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
