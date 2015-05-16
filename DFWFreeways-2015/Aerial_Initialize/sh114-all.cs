using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> sh114_irving_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.sh114_irving_las_colinas_images());
            itemList.AddRange(AerialGalleryList.sh114_irving_bush_images());
            itemList.AddRange(AerialGalleryList.sh114_irving_diamond_images());
            return itemList;
        }
    }
}