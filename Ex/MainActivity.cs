using Android.App;
using Android.Widget;
using Android.OS;
using Ex.Adapters;
using static Android.Resource;
using static Android.Resource.Menu;
using Com.Syncfusion.Carousel;
using System.Collections.Generic;
using Android.Views;
using System;
using Android.Content;

namespace Ex
{
    [Activity(Label = "", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {



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
}

