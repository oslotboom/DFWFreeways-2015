using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> bush_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.bush_i30_images());
            itemList.AddRange(AerialGalleryList.bush_sh114_images());
            itemList.AddRange(AerialGalleryList.bush_i635_images());
            itemList.AddRange(AerialGalleryList.bush_i35e_images());
            itemList.AddRange(AerialGalleryList.bush_carrollton_images());
            itemList.AddRange(AerialGalleryList.bush_dnt_images());
            itemList.AddRange(AerialGalleryList.bush_us75_images());
            return itemList;
        }
    }
}