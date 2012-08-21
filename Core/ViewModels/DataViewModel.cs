
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
using Cirrious.MvvmCross.ViewModels;

namespace Core
{
	public class DataViewModel : MvxViewModel
	{
		private FieldsViewModel _fields;
        public FieldsViewModel Fields
        {
            get
            {
                return _fields;
            }
            set
            {
                _fields = value;
                FirePropertyChanged("Fields");
            }
        }

		public DataViewModel ()
		{
			Fields = new FieldsViewModel();
		}
	}
}

