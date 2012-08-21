
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
using Android.Util;

namespace Sample
{
	class FieldLayout: LinearLayout
    {
		int _width;
        public FieldLayout(Context context, IAttributeSet attrs) : base (context, attrs)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            _width = metrics.WidthPixels;
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {	
			LayoutParameters = new FrameLayout.LayoutParams((int)(_width / 3.2), FrameLayout.LayoutParams.WrapContent);
            
            base.OnLayout(changed, l, t, r, b);

        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            int count = ChildCount;
            int maxHeight = 0;
            int maxWidth = 0;

            for (int i = 0; i < count; i++)
            {
                View child = GetChildAt(i);

                if (child.Visibility != ViewStates.Gone)
                {
                    MeasureChild(child, widthMeasureSpec, heightMeasureSpec);
                    maxHeight += child.MeasuredHeight;
                }

            }

            maxWidth += PaddingLeft + PaddingRight;
            maxHeight += PaddingTop + PaddingBottom;

			LayoutParameters = new FrameLayout.LayoutParams((int)(_width / 3.2), FrameLayout.LayoutParams.WrapContent);
            SetMeasuredDimension(ResolveSize((int)(_width / 3.2), widthMeasureSpec), ResolveSize(maxHeight, heightMeasureSpec));
        }
	}
}

