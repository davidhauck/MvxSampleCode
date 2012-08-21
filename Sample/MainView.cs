
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Binding.Android.Views;
using Core;

namespace Sample
{
	[Activity]			
	public class MainView : MvxBindingActivityView<MainViewModel>
	{
		protected override void OnViewModelSet ()
		{
			SetContentView(Resource.Layout.MainView);

			// Create your application here
		}
	}
}

