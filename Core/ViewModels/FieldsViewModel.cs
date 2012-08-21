
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
	public class FieldsViewModel : MvxViewModel
	{
		private List<FieldRowViewModel> _fieldRows;
        public List<FieldRowViewModel> FieldRows
        {
            get
            {
                return _fieldRows;
            }
            set
            {
                _fieldRows = value;
                FirePropertyChanged("FieldRows");
            }
        }

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
                FillRows();
                FirePropertyChanged("Fields");
            }
        }

        public FieldsViewModel()
        {
            Fields = new List<FieldViewModel>();
			Fields.Add(new FieldViewModel());
			Fields.Add(new FieldViewModel());
			Fields.Add(new FieldViewModel());
			Fields.Add(new FieldViewModel());
			Fields.Add(new FieldViewModel());
			Fields.Add(new FieldViewModel());
            FillRows();
        }
        public void FillRows()
        {
            FieldRows = new List<FieldRowViewModel>();
            FieldRowViewModel row = new FieldRowViewModel();

            int i = 0;
            foreach (var field in _fields)
            {
                if (i > 2)
                {
                    FieldRows.Add(row);
                    row = new FieldRowViewModel();
                    i = 0;
                }
                row.Fields.Add(field);
                i++;
            }
            FieldRows.Add(row);
        }
	}
}

