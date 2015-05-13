using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i20_dallas_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i20_dallas_i20_us67_images());
            itemList.AddRange(AerialGalleryList.i20_dallas_i20_i35e_images());
            itemList.AddRange(AerialGalleryList.i20_dallas_i20_i45_images());
            itemList.AddRange(AerialGalleryList.i20_dallas_i20_us175_images());
            itemList.AddRange(AerialGalleryList.i20_dallas_i20_i635_images());
            itemList.AddRange(AerialGalleryList.i20_dallas_i20_spur408_images());

            return itemList;
        }
    }
}