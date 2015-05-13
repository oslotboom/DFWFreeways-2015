using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i20_dallas_i20_i635_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2005,5,30),"","5_i20_looking_e_at_i635_2006-05-30_900.jpg", "5_i20_looking_e_at_i635_2006-05-30_2471x1648.png", "aerial", 
                    "I-20 at I-635",
                    "I-20 at I-635, looking east",
                    "I-20 at I-635",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","6_i20_looking_e_at_i635_2006-05-30_900.jpg", "6_i20_looking_e_at_i635_2006-05-30_2467x1227.png", "aerial", 
                    "I-20 at I-635",
                    "I-20 at I-635, looking east",
                    "I-20 at I-635",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","7_i635_looking_s_at_i20_2006-05-30_ADJ_900.jpg", "7_i635_looking_s_at_i20_2006-05-30_ADJ_2619x1405.png", "aerial", 
                    "I-20 at I-635",
                    "I-20 at I-635, looking south",
                    "I-20 at I-635",
                    "Looking south.")
          
            };
        }
    }
}