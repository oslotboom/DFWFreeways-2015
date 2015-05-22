using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> us75_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.us75_i635_images());
            itemList.AddRange(AerialGalleryList.us75_dallas_images());
            itemList.AddRange(AerialGalleryList.us75_loop12_images());
            itemList.AddRange(AerialGalleryList.us75_bush_images());
            return itemList;
        }

    }
}