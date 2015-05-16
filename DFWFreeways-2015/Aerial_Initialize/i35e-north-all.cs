using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        //public static AerialGalleryList i35e_north_all(string fileServer, string folderPath)
        //{
        //    AerialGalleryList aerialGalleryList = new AerialGalleryList(fileServer, folderPath);
        //    aerialGalleryList.PageHeader = new PageHeader("I-35E Aerial Views", "", GetShieldPath("i35e"), "i35e-north", "I-35E North", "May 4, 2015 (created)");

        //    List<AerialGalleryItem> temp =  AerialGalleryList.i35e_north_market_center_images();
        //    aerialGalleryList.ItemList = new List<AerialGalleryItem>(AerialGalleryList.i35e_north_market_center_images());
        //    aerialGalleryList.ItemList.AddRange(AerialGalleryList.i35e_north_american_airlines_center_images());
        //    aerialGalleryList.ItemList.AddRange(AerialGalleryList.i35e_north_i35e_i635_images());
        //    aerialGalleryList.ItemList.AddRange(AerialGalleryList.i35e_north_i35e_bush_images());
        //    aerialGalleryList.ItemList.AddRange(AerialGalleryList.i35e_north_i35e_sh121_images());

        //    return aerialGalleryList;
        //}

        public static List<AerialGalleryItem> i35e_north_all_images()
        {
            //AerialGalleryList aerialGalleryList = new AerialGalleryList(fileServer, folderPath);
            //aerialGalleryList.PageHeader = new PageHeader("I-35E Aerial Views", "", GetShieldPath("i35e"), "i35e-north", "I-35E North", "May 4, 2015 (created)");

            //List<AerialGalleryItem> temp = AerialGalleryList.i35e_north_market_center_images();
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i35e_north_market_center_images());
            itemList.AddRange(AerialGalleryList.i35e_north_american_airlines_center_images());
            itemList.AddRange(AerialGalleryList.i35e_north_i35e_i635_images());
            itemList.AddRange(AerialGalleryList.i35e_north_i35e_bush_images());
            itemList.AddRange(AerialGalleryList.i35e_north_i35e_sh121_images());

            return itemList;
        }
    }
}