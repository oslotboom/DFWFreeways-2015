using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i35e_south_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i35e_south_downtown_images());
            itemList.AddRange(AerialGalleryList.i35e_south_i20_images());
            return itemList;
        }
    }
}