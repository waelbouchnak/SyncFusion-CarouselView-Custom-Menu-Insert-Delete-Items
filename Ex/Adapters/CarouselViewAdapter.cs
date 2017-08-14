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
using Com.Syncfusion.Carousel;

namespace Ex.Adapters
{
    public class CarouselViewAdapter : CarouselAdapter
    {
        private Context _context;
        public CarouselViewAdapter(Context context)
        {
            _context = context;

        }
        public override Android.Views.View GetItemView(SfCarousel p0, int p1)
        {
            FrameLayout frameLayout = new FrameLayout(_context);
            SfCarouselItem sfCarouselItem = new SfCarouselItem(_context);
            ImageView imageView = new ImageView(_context);
            imageView.LayoutParameters = new Android.Views.ViewGroup.LayoutParams(p0.ItemWidth, p0.ItemHeight);
            imageView.SetImageResource(_PicturesList[p1]);
            imageView.SetScaleType(ImageView.ScaleType.FitXy);
            frameLayout.AddView(imageView);
            return frameLayout;
        }

        private List<int> _PicturesList = new List<int>() {
        Resource.Drawable.Pic_0, Resource.Drawable.Pic_2,
        Resource.Drawable.Pic_1, Resource.Drawable.Pic_3,
        Resource.Drawable.Pic_2, Resource.Drawable.Pic_4,
        Resource.Drawable.Pic_0, Resource.Drawable.Pic_2,
        Resource.Drawable.Pic_1, Resource.Drawable.Pic_3,
        Resource.Drawable.Pic_0, Resource.Drawable.Pic_2,
        Resource.Drawable.Pic_1, Resource.Drawable.Pic_3,
        Resource.Drawable.Pic_2, Resource.Drawable.Pic_4,
        Resource.Drawable.Pic_0, Resource.Drawable.Pic_2,
        Resource.Drawable.Pic_1, Resource.Drawable.Pic_3,
         };

    }
}