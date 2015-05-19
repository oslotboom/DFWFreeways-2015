using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> i35e_north_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i35e_north_market_center_images());
            itemList.AddRange(AerialGalleryList.i35e_north_american_airlines_center_images());
            itemList.AddRange(AerialGalleryList.i35e_north_i35e_i635_images());
            itemList.AddRange(AerialGalleryList.i35e_north_i35e_bush_images());
            itemList.AddRange(AerialGalleryList.i35e_north_i35e_sh121_images());

            return itemList;
        }
    }
}