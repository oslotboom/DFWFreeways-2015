using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {
        public static List<AerialGalleryItem> spur408_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.spur408_freeway_images());
            itemList.AddRange(AerialGalleryList.spur408_i20_images());
            return itemList;
        }

        public static List<AerialGalleryItem> spur408_freeway_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"","20_spur408_looking_ne_2006-05-30_ADJ_1050.jpg", "20_spur408_looking_ne_2006-05-30_ADJ.jpg", "aerial", 
                    "Spur 408",
                    "Spur 408, looking north",
                    "Spur 408",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2011,4,16),"","17_spur408_at_loop12_2006-05-30_1050.jpg", "17_spur408_at_loop12_2006-05-30_2424x1726.jpg", "aerial", 
                    "Spur 408",
                    "Spur 408, looking north",
                    "Spur 408",
                    "Looking north at Loop 12."),

                new AerialGalleryItem(new DateTime(2011,4,16),"","19_spur408_at_loop12_2006-05-30_ADJ_1050.jpg", "19_spur408_at_loop12_2006-05-30_ADJ.jpg", "aerial", 
                    "Spur 408",
                    "Spur 408, looking north",
                    "Spur 408",
                    "Looking north at Loop 12.")

           
            };
        }


    }
}