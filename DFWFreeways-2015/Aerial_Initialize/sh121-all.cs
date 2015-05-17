using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> sh121_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.sh121_i35e_images());
            itemList.AddRange(AerialGalleryList.sh121_colony_images());
            itemList.AddRange(AerialGalleryList.sh121_dnt_images());
            return itemList;
        }
    }
}