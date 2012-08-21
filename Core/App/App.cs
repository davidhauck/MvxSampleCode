
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

namespace Core
{
	public class App : MvxApplication, IMvxServiceProducer<IMvxStartNavigation>
	{           
		public App()
		{
			var startAppObject = new StartAppObject();
            this.RegisterServiceInstance<IMvxStartNavigation>(startAppObject);
		}
	}
}

