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
using Ex.Adapters;

namespace Ex
{
    [Activity(Label = "CoverFlow")]
    public class SecondActivity : Activity
    {
        List<SfCarouselItem> carouselList;
        SfCarousel carousel;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            carousel = new SfCarousel(this);
            carousel.ItemWidth = 700;
            carousel.ItemHeight = 700;

            carousel.Adapter = new CarouselViewAdapter(this);

            carouselList = new List<SfCarouselItem>();
            carouselList.Add(new SfCarouselItem(this));
            carouselList.Add(new SfCarouselItem(this));
            carouselList.Add(new SfCarouselItem(this));
            carouselList.Add(new SfCarouselItem(this));

            carousel.DataSource = carouselList;
            SetContentView(carousel);




        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.CustomMenu, menu);
            return true;
        }

        

        public override bool OnMenuItemSelected(int featureId, IMenuItem item)
        {
            Console.WriteLine("1");
            if (item.ItemId == Resource.Id.action_Insertbutton)
            {
                carouselList.Add(new SfCarouselItem(this));
                carousel.DataSource = carouselList;
                Console.WriteLine("Insert");

            }
            else
            {
                try
                {
                    carouselList.RemoveAt(carousel.SelectedIndex);
                    carousel.DataSource = carouselList;
                    Console.WriteLine("Deleted");
                }
                catch { }
            }



            return base.OnMenuItemSelected(featureId, item);


        }
    }
}