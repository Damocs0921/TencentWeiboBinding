using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using TXWBB;
using System.IO;

namespace TCWBTest
{

	public class MainRequestDelegate : WeiboRequestDelegate
	{
		public override void DidReceiveRawData (NSData data, int reqno)
		{
			NSString strRes = new NSString (data, NSStringEncoding.UTF8);
			string s = strRes.ToString ();
			Console.WriteLine ("rawdata" + s);
		} 

		public override void DidFailWithError (NSError error, int reqno)
		{
			Console.WriteLine ("error" + error.UserInfo.ToString());
		}

		public override void DidNeedRelogin (NSError error, int reqno)
		{
			Console.WriteLine ("didneedrelogin");
		}


	}

	public class MainAuthDelegate:WeiboAuthDelegate
	{
		public override void DidAuthFinished (WeiboApiObject wbobj)
		{
			Console.WriteLine ("authfinished " + wbobj.AccessToken + wbobj.Openid + wbobj.AppKey + wbobj.AppSecret + wbobj.RefreshToken);
		}

		public override void DidAuthFailWithError (NSError error)
		{
			Console.WriteLine ("autherror " + error.UserInfo.ToString ());
		}

		public override void DidCheckAuthValid (bool bResult, string strSuggestion)
		{
			Console.WriteLine ("ret = " + bResult + " suggestion " + strSuggestion);
		}

		public override void DidAuthCanceled (WeiboApiObject wbobj)
		{
			Console.WriteLine ("cancel");
		}

	}

	public class MainViewController:UIViewController
	{
		public MainViewController ()
		{
			ErrorLog.ResetErrorLog ();
			ErrorLog.WriteErrorLog ("fsdafsdfdsaf1\n");
			ErrorLog.WriteErrorLog ("fsdafsdfdsaf2\n");
			ErrorLog.WriteErrorLog ("fsdafsdfdsaf3");

		}

		public WeiboApi wbapi;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad ();
			this.View.BackgroundColor = UIColor.White;

			MainAuthDelegate auth = new MainAuthDelegate ();
			MainRequestDelegate req = new MainRequestDelegate ();


			if (wbapi == null) {
				wbapi = new WeiboApi ("801213517", "9819935c0ad171df934d0ffb340a3c2d", "http://www.ying7wang7.com", 0, 0);
			}
			UIButton btn = new UIButton ();
			btn.Frame = new System.Drawing.RectangleF (50, 50, 150, 50);
			btn.SetTitle ("login", UIControlState.Normal);
			btn.TouchUpInside += delegate(object sender, EventArgs e) {
				try
				{
					wbapi.LoginWithDelegate(auth,this);
				    Console.WriteLine("click");
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
					
				Console.WriteLine("cancel");
			};

			btn.SetTitleColor (UIColor.Red, UIControlState.Normal);
			this.View.AddSubview (btn);

			UIImage img = UIImage.FromFile("icon.png");

			int i = 0;

			UIButton bt = new UIButton ();
			bt.Frame = new System.Drawing.RectangleF (50, 150, 150, 50);
			bt.SetTitle ("postWB", UIControlState.Normal);
			bt.TouchUpInside += delegate(object sender, EventArgs e) {

				i++;
				try
				{

					NSMutableDictionary pr = NSMutableDictionary.FromObjectsAndKeys(new object[]{"json",i.ToString(),img},new object[]{"format","content","pic"});
					wbapi.RequestWithParams(pr,"t/add_pic","POST",req);

					Console.WriteLine("click");
					//wbapi.CancelAuth();
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}




				Console.WriteLine("cancel");
			};

			bt.SetTitleColor (UIColor.Red, UIControlState.Normal);
			this.View.AddSubview (bt);


			RateViewWithNum rv = new RateViewWithNum (new System.Drawing.RectangleF (50, 250, 200, 30));
			this.View.AddSubview (rv);

		}
	}
}

