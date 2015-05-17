using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i635_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i635_us75_images());
            itemList.AddRange(AerialGalleryList.i635_bush_images());
            itemList.AddRange(AerialGalleryList.i635_i35e_images());
            itemList.AddRange(AerialGalleryList.i635_farmers_branch_images());
            itemList.AddRange(AerialGalleryList.i635_preston_images());
            itemList.AddRange(AerialGalleryList.i635_dnt_images());
            itemList.AddRange(AerialGalleryList.i635_garland_images());
            itemList.AddRange(AerialGalleryList.i635_i30_images());
            itemList.AddRange(AerialGalleryList.i635_us80_images());
            return itemList;
        }
    }
}