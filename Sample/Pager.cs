
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
	class Pager: HorizontalScrollView
    {
        int _width;

        public Pager(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            _width = metrics.WidthPixels;
        }

        public override bool OnTouchEvent(MotionEvent e)
        {


            switch (e.Action)
            {
                case MotionEventActions.Up:
				case MotionEventActions.Cancel:
                    int activeFeature = ((ScrollX + (_width / 2)) / _width);
				
        			SmoothScrollTo(activeFeature * _width, 0);
                    break;
            }
            return base.OnTouchEvent(e);
        }

        public override void Fling(int velocityX)
        {
            base.Fling(velocityX);

            int activeFeature = ((ScrollX + (_width / 2)) / _width);
            
            SmoothScrollTo(activeFeature * _width, 0);
        }
    }
}

