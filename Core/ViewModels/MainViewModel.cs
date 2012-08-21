
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
using Cirrious.MvvmCross.Interfaces.Commands;
using Cirrious.MvvmCross.Commands;

namespace Core
{
	public class MainViewModel : MvxViewModel
	{
		private List<DataGroupViewModel> _dataGroups;
        public List<DataGroupViewModel> DataGroups
        {
            get
            {
                return _dataGroups;
            }
            set
            {
                _dataGroups = value;
                FirePropertyChanged("Sets");
            }
        }

		public MainViewModel ()
		{
			DataGroups = new List<DataGroupViewModel>();
			DataGroups.Add(new DataGroupViewModel());
			DataGroups.Add(new DataGroupViewModel());
			DataGroups.Add(new DataGroupViewModel());
			DataGroups.Add(new DataGroupViewModel());
		}
	}
}

