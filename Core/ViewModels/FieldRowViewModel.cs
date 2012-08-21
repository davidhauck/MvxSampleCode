
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
	public class FieldRowViewModel : MvxViewModel
	{ 
		private List<FieldViewModel> _fields;
        public List<FieldViewModel> Fields
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

        public FieldRowViewModel()
        {
            Fields = new List<FieldViewModel>();
        }
	}
}

