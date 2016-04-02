﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EllipticCurves
{
	public partial class EllipticCurveInput: ContentPage
	{
		StartPage parent;

		ECPoint point;

		string errorP="";
		string errorA="";
		string errorB="";
		string errorX="";
		string errorY="";

		public EllipticCurveInput (StartPage page)
		{
			InitializeComponent ();

			parent = page;

			point = new ECPoint ();

			this.BindingContext = point;
		}



		protected void invalidateErrors(){
			stackResults.Children.Clear ();

			bool isError = false;

			if (errorP != "") {
				stackResults.Children.Add (new Label { TextColor=Color.Red, Text = errorP,VerticalOptions=LayoutOptions.StartAndExpand });
				isError = true;
			}
			if (errorA != "") {
				stackResults.Children.Add (new Label { TextColor=Color.Red, Text = errorA, VerticalOptions=LayoutOptions.StartAndExpand });
				isError = true;			
			}
			if (errorB != "") {
				stackResults.Children.Add (new Label { TextColor=Color.Red, Text = errorB,VerticalOptions=LayoutOptions.StartAndExpand });	
				isError = true;
			}
			if (errorX != "") {
				stackResults.Children.Add (new Label { TextColor=Color.Red, Text = errorX,VerticalOptions=LayoutOptions.StartAndExpand });	
				isError = true;
			}
			if (errorY != "") {
				stackResults.Children.Add (new Label { TextColor=Color.Red, Text = errorY,VerticalOptions=LayoutOptions.StartAndExpand });	
				isError = true;
			}

			if (isError) {
				frameResult.OutlineColor = Color.Red;		
				operationsButton.IsEnabled = false;
			} else {
				frameResult.OutlineColor = Color.Green;
				operationsButton.IsEnabled = true;
			}
		}

		// HANDLERS

		public void handler_changedPValidate(object sender, EventArgs e){
			try{
				Entry current = sender as Entry;
				if ( current.Text != null && current.Text != ""){
					point.FieldChar = new BigInteger(entryP.Text, 10);
				}
				errorP = "";
			} catch{
				errorP = "Неверное значение 'p' = " + entryP.Text;
			} finally{
				invalidateErrors();
			}
		}
		public void handler_changedAValidate(object sender, EventArgs e){
			try{
				Entry current = sender as Entry;
				if ( current.Text != null && current.Text != ""){
					point.a = new BigInteger(entryA.Text, 10);
				}
				errorA = "";
			} catch{
				errorA = "Неверное значение 'a' = " + entryA.Text;
			} finally{
				invalidateErrors();
			}
		}

		public void handler_changedBValidate(object sender, EventArgs e){
			try{
				Entry current = sender as Entry;
				if ( current.Text != null && current.Text != ""){
					point.b = new BigInteger(entryB.Text, 10);
				}
				errorB = "";
			} catch{
				errorB = "Неверное значение 'b' = " + entryB.Text;
			} finally{
				invalidateErrors();
			}
		}

		public void handler_changedXValidate(object sender, EventArgs e){
			try{
				Entry current = sender as Entry;
				if ( current.Text != null && current.Text != ""){
					point.x = new BigInteger(entryX.Text, 10);
				}
				errorX = "";
			} catch{
				errorX = "Неверное значение 'x' = " + entryX.Text;
			} finally{
				invalidateErrors();
			}
		}

		public void handler_changedYValidate(object sender, EventArgs e){
			try{
				Entry current = sender as Entry;
				if ( current.Text != null && current.Text != ""){
					point.y = new BigInteger(entryY.Text, 10);
				}
				errorY = "";
			} catch{
				errorY = "Неверное значение 'y' = " + entryY.Text;
			} finally{
				invalidateErrors();
			}
		}

		private void handler_operationsButtonClick(object sender, EventArgs e)
		{
			this.Navigation.PushAsync(new Operations(parent, point));
		}
	}
}

