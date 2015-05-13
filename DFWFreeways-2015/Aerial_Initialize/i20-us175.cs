using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i20_dallas_i20_us175_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2005,5,30),"","1_us175_looking_se_at_i20_2006-05-30_900.jpg", "1_us175_looking_se_at_i20_2006-05-30_2427x1419.png", "aerial", 
                    "I-20 at US 175",
                    "I-20 at US 175, looking southeast",
                    "I-20 at US 175",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","2_us175_looking_se_at_i20_2006-05-30_ADJ_900.jpg", "2_us175_looking_se_at_i20_2006-05-30_ADJ_2427x1552.png", "aerial", 
                    "I-20 at US 175",
                    "I-20 at US 175, looking southeast",
                    "I-20 at US 175",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","3_us175_looking_s_at_i20_2006-05-30_900.jpg", "3_us175_looking_s_at_i20_2006-05-30_2383x1572.png", "aerial", 
                    "I-20 at US 175",
                    "I-20 at US 175, looking south-southeast",
                    "I-20 at US 175",
                    "Looking south-southeast."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","4_us175_looking_s_at_i20_2006-05-30_900.jpg", "4_us175_looking_s_at_i20_2006-05-30_280.jpg", "aerial", 
                    "I-20 at US 175",
                    "I-20 at US 175, looking south",
                    "I-20 at US 175",
                    "Looking south.")
          
            };
        }
    }
}