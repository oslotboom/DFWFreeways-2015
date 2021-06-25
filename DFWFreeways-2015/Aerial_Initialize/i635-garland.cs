using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> i635_garland_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3060.JPG","20120406_3060-1050.jpg", "20120406_3060-2560.jpg", "aerial", 
                    "I-635 in Garland",
                    "I-635 in Garland, looking southeast",
                    "I-635 in Garland",
                    "Looking southeast at Jupiter Road")
           
            };
        }
    }
}