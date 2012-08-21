
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
using Android.Util;

namespace Sample
{
	class MyBindableLinearLayout: MvxBindableLinearLayout
    {
        Context _context;
        public MyBindableLinearLayout(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            _context = context;
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            DisplayMetrics metrics = _context.Resources.DisplayMetrics;
            int width = metrics.WidthPixels;

			int count = ChildCount;

            SetMeasuredDimension(ResolveSize(width, widthMeasureSpec), ResolveSize(MeasuredHeight, heightMeasureSpec));
        }
	}
}

