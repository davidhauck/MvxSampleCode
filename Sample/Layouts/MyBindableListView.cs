
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
	public class MyBindableListView : MvxBindableListView
    {
        Context _context;

        public MyBindableListView(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            Initialize(context);
        }
        public MyBindableListView(Context context, IAttributeSet attrs, MvxBindableListAdapter idk) :
            base(context, attrs, idk)
        {
            Initialize(context);
        }

        void Initialize(Context context)
        {
            _context = context;
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
			base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            DisplayMetrics metrics = _context.Resources.DisplayMetrics;
            int width = metrics.WidthPixels;

            int count = ChildCount;
            int maxHeight = 0;

            for (int i = 0; i < count; i++)
            {
                View child = GetChildAt(i);

                if (child.Visibility != ViewStates.Gone)
                {
                    MeasureChild(child, widthMeasureSpec, heightMeasureSpec);
                    maxHeight += child.MeasuredHeight;
                }
            }


            SetMeasuredDimension(ResolveSize(width, widthMeasureSpec), ResolveSize(MeasuredHeight, heightMeasureSpec));

            //base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        }
    }
}

