using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i45_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i45_dallas_images());
            itemList.AddRange(AerialGalleryList.i45_i30_images());
            itemList.AddRange(AerialGalleryList.i45_i20_images());
            return itemList;
        }
    }
}