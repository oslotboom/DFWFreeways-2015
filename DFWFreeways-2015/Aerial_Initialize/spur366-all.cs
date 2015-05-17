using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> spur366_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.spur366_2012_images());
            itemList.AddRange(AerialGalleryList.spur366_margaret_hunt_hill_bridge_images());
            itemList.AddRange(AerialGalleryList.spur366_bridge_construction_images());
            itemList.AddRange(AerialGalleryList.spur366_pre_klyde_warren_images());
            return itemList;
        }
    }
}