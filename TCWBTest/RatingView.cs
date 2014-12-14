using System;
using MonoTouch.UIKit;
using System.Linq;
using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;
using System.Drawing;
using System.Collections.Generic;

namespace TCWBTest
{
	public class RateViewWithNum:UIView
	{

		UIButton[] numBtns;

		public RateViewWithNum (RectangleF frame)
		{
			this.Frame = frame;
			this.Layer.MasksToBounds = true;
			this.Layer.CornerRadius = 10.0f;


			numBtns = new UIButton[5];

			for (int i = 0; i < 5; i++) {

				numBtns[i] = new UIButton ();
				numBtns[i].Frame = new RectangleF (frame.Width / 5 * i, 0 , frame.Width / 5 - 1, frame.Height);
				numBtns[i].Tag = i;
				numBtns[i].BackgroundColor = UIColor.Gray;
				numBtns[i].SetTitleColor (UIColor.White, UIControlState.Normal);
				numBtns[i].SetTitle ((i+1).ToString (), UIControlState.Normal);
				numBtns[i].TouchUpInside += HandleTouchUpInside;

				this.AddSubview (numBtns[i]);
			}

		}

		void HandleTouchUpInside (object sender, EventArgs e)
		{
			UIButton btn = (UIButton)sender;
			int tag = btn.Tag;

			for (int i = 0; i < 5; i++) 
			{
				if (i <= tag) {
					numBtns [i].BackgroundColor = UIColor.Red;
				} else {
					numBtns [i].BackgroundColor = UIColor.Gray;
				}

			}

		}


	}
}


