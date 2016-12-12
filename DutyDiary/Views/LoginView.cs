﻿using System;
using UIKit;
using System.Collections.Generic;

namespace DutyDiary
{
	public class LoginView : UIView
	{
		public UIButton submitButton { get; }
		public UITextField userTextField { get; }
		public UITextField passTextField { get; }

		public LoginView(CoreGraphics.CGRect bounds) : base(bounds)
		{
			BackgroundColor = UIColor.Orange;

			submitButton = new UIButton();
			submitButton.TranslatesAutoresizingMaskIntoConstraints = false;
			submitButton.SetTitle("Submit", UIControlState.Normal);
			submitButton.SetTitleColor(UIColor.White, UIControlState.Normal);
			submitButton.BackgroundColor = UIColor.Clear;
			submitButton.Layer.CornerRadius = 3;
			submitButton.Layer.BorderWidth = 1.5f;
			submitButton.Layer.BorderColor = (UIColor.White).CGColor;

			userTextField = new UITextField();
			userTextField.TranslatesAutoresizingMaskIntoConstraints = false;
			userTextField.Placeholder = "Email Address";
			userTextField.BorderStyle = UITextBorderStyle.RoundedRect;

			passTextField = new UITextField();
			passTextField.TranslatesAutoresizingMaskIntoConstraints = false;
			passTextField.Placeholder = "Password";
			passTextField.BorderStyle = UITextBorderStyle.RoundedRect;

			var subviews = new UIView[]{ submitButton, userTextField, passTextField };
			AddSubviews(subviews);
			setupConstraints();
		}

		public override void UpdateConstraints()
		{
			// Check to see if the View needs to update it's constraints
			if (NeedsUpdateConstraints())
			{
				setupConstraints(); // Setup our constraints
			}
			base.UpdateConstraints(); // Important, always call this last
		}

		void setupConstraints()
		{
			Console.WriteLine("[LoginView] setupConstraints");
			var constraints = new List<NSLayoutConstraint>();

			// Constraints were copy-pasted; therefore,
			// the comments on the side are no longer correct.

			constraints.Add(
				NSLayoutConstraint.Create(
					submitButton, // View we want to constrain
					NSLayoutAttribute.CenterY, // Vertically Center
					NSLayoutRelation.Equal, // Relationship
					this, // View we want to constrain to
					NSLayoutAttribute.CenterY, // Attribute to constrain to
					1, // Multiplier
					0 // constant
				)
			);
			constraints.Add(
				NSLayoutConstraint.Create(
					submitButton, // View we want to constrain
					NSLayoutAttribute.CenterX, // Vertically Center
					NSLayoutRelation.Equal, // Relationship
					this, // View we want to constrain to
					NSLayoutAttribute.CenterX, // Attribute to constrain to
					1, // Multiplier
					0 // constant
				)
			);
			constraints.Add(
				NSLayoutConstraint.Create(
					submitButton, // View we want to constrain
					NSLayoutAttribute.Height, // Vertically Center
					NSLayoutRelation.Equal, // Relationship
					1, // Multiplier
					44 // constant
				)
			);
			constraints.Add(
				NSLayoutConstraint.Create(
					submitButton, // View we want to constrain
					NSLayoutAttribute.Width, // Vertically Center
					NSLayoutRelation.Equal, // Relationship
					1, // Multiplier
					Frame.Width - 30 // constant
				)
			);

			constraints.Add(
				NSLayoutConstraint.Create(
					passTextField, // View we want to constrain
					NSLayoutAttribute.CenterX, // Vertically Center
					NSLayoutRelation.Equal, // Relationship
					this, // View we want to constrain to
					NSLayoutAttribute.CenterX, // Attribute to constrain to
					1, // Multiplier
					0 // constant
				)
			);
			constraints.Add(
				NSLayoutConstraint.Create(
					passTextField, // View we want to constrain
					NSLayoutAttribute.Width,
					NSLayoutRelation.Equal, // Relationship
					1, // Multiplier
					Frame.Width - 30 // constant
				)
			);
			constraints.Add(
				NSLayoutConstraint.Create(
					passTextField, // View we want to constrain
					NSLayoutAttribute.Height, // Vertically Center
					NSLayoutRelation.Equal, // Relationship
					1, // Multiplier
					30 // constant
				)
			);
			constraints.Add(
				NSLayoutConstraint.Create(
					submitButton, // View we want to constrain
					NSLayoutAttribute.Top,
					NSLayoutRelation.Equal, // Relationship
					passTextField, // View we want to constrain to
					NSLayoutAttribute.Bottom, // Attribute to constrain to
					1, // Multiplier
					15 // constant
				)
			);

			constraints.Add(
				NSLayoutConstraint.Create(
					userTextField, // View we want to constrain
					NSLayoutAttribute.CenterX,
					NSLayoutRelation.Equal, // Relationship
					this, // View we want to constrain to
					NSLayoutAttribute.CenterX, // Attribute to constrain to
					1, // Multiplier
					0 // constant
				)
			);
			constraints.Add(
				NSLayoutConstraint.Create(
					userTextField, // View we want to constrain
					NSLayoutAttribute.Width,
					NSLayoutRelation.Equal, // Relationship
					1, // Multiplier
					Frame.Width - 30 // constant
				)
			);
			constraints.Add(
				NSLayoutConstraint.Create(
					userTextField, // View we want to constrain
					NSLayoutAttribute.Height,
					NSLayoutRelation.Equal, // Relationship
					1, // Multiplier
					30 // constant
				)
			);
			constraints.Add(
				NSLayoutConstraint.Create(
					passTextField, // View we want to constrain
					NSLayoutAttribute.Top,
					NSLayoutRelation.Equal, // Relationship
					userTextField, // View we want to constrain to
					NSLayoutAttribute.Bottom, // Attribute to constrain to
					1, // Multiplier
					10 // constant
				)
			);

			AddConstraints(constraints.ToArray());
		}
	}
}