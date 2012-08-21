
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
	public class DataGroupViewModel : MvxViewModel
	{
		private  List<FieldsViewModel> _data;
        public List<FieldsViewModel> Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
                FirePropertyChanged("Data");
            }
        }

		public DataGroupViewModel ()
		{
			Data = new  List<FieldsViewModel>();
			Data.Add(new FieldsViewModel());
			Data.Add(new FieldsViewModel());
			Data.Add(new FieldsViewModel());
			Data.Add(new FieldsViewModel());
		}
	}
}

