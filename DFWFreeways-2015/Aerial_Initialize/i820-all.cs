using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i820_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i820_i30_west_images());
            itemList.AddRange(AerialGalleryList.i820_i30_east_images());
            itemList.AddRange(AerialGalleryList.i820_i35w_images());

            return itemList;
        }
    }
}