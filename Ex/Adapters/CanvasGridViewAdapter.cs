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
using Android.Graphics.Drawables;
using System.Drawing;
using Android.Content.Res;
using Android.Graphics;

namespace Ex.Adapters
{
    public class CanvasGridViewAdapter : BaseAdapter
    {
        Context context;

        public CanvasGridViewAdapter(Context c)
        {
            context = c;
        }

        public override int Count
        {
            get { return 3; } // Number OF items 
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

         public override View GetView(int position, View convertView, ViewGroup parent)
        {
            Canvas canvas = new Canvas();
             View MyView = new View(context);

            Random rand = new Random();
            int i = (rand.Next() + 177);
            if (i % 2 == 0)
            {
                Paint paint = new Paint();
                paint.Color = Android.Graphics.Color.Red;
                // paint.SetStyle(  Paint.Style.Stroke);
                canvas.DrawCircle(100, 100, 60, paint);
            }
            else
            {
                Paint paint = new Paint();
                paint.Color = Android.Graphics.Color.Azure;
                //paint.SetStyle(Paint.Style.Stroke);
                float x = 100;
                float y = 100;
                float radius = 20;
                canvas.DrawCircle(10, 10, 8, paint);

            }

            canvas.DrawColor(Android.Graphics.Color.Red);
            MyView.Draw(canvas);

            return MyView;

           
        }
        

    };

}
