
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
	public class FieldViewModel : MvxViewModel
	{
		string _name;
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                FirePropertyChanged("Name");
            }
        }

        string _value;
        public String Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                FirePropertyChanged("Value");
            }
        }

        public FieldViewModel()
        {
            Name = "Name";
            Value = "Value";
        }
	}
}

