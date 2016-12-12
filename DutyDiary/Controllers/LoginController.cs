using System;
using UIKit;

namespace DutyDiary
{
	public class LoginController : UIViewController
	{
		readonly static string title = "Login";
		LoginView view;

		public override void LoadView()
		{
			view = new LoginView(UIScreen.MainScreen.Bounds);
			view.submitButton.TouchUpInside += submitButton_TouchUpInside;
			View = view;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			Title = title;
		}

		void submitButton_TouchUpInside(object sender, EventArgs e)
		{
			if (View.BackgroundColor == UIColor.Orange)
			{
				View.BackgroundColor = UIColor.Purple;
			}
			else
			{
				View.BackgroundColor = UIColor.Orange;
			}
		}
	}
}
