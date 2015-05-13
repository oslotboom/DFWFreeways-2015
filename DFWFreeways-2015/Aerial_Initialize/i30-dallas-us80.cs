using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i30_dallas_us80_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2005,5,30),"", "16_i30_us80_split_2005-05-30_900.jpg", "16_i30_us80_split_2005-05-30_2471x1471.png", "aerial", 
                    "I-30 at US 80",
                    "I-30 at US 80 looking northeast",
                    "I-30 at US 80",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,5,30),"", "17_i30_us80_split_2005-05-30_900.jpg", "17_i30_us80_split_2005-05-30_2301x1496.png", "aerial", 
                    "I-30 at US 80",
                    "I-30 at US 80 looking northeast",
                    "I-30 at US 80",
                    "Looking north east with Loop 12(Buckner Blv) crossing in the lower part of the photo."),
                 new AerialGalleryItem(new DateTime(2005,5,30),"", "18_i30_us80_split_2005-05-30_900.jpg", "18_i30_us80_split_2005-05-30_2353x1619.png", "aerial", 
                    "I-30 at US 80",
                    "I-30 at US 80 looking east",
                    "I-30 at US 80",
                    "Looking east."),
                 new AerialGalleryItem(new DateTime(2005,5,30),"", "19_i30_us80_split_2005-05-30_900.jpg", "19_i30_us80_split_2005-05-30_2238x1488.png", "aerial", 
                    "I-30 at US 80",
                    "I-30 at US 80 looking east",
                    "I-30 at US 80",
                    "Looking east."),
                 new AerialGalleryItem(new DateTime(2005,5,30),"", "21_i30_us80_split_2005-05-30_900.jpg", "21_i30_us80_split_2005-05-30_2150x1290.png", "aerial", 
                    "I-30 at US 80",
                    "I-30 at US 80 looking southeast",
                    "I-30 at US 80",
                    "Looking southeast.",
                    new AerialStatus ("2015", "Partially obsolete", "Big Town Mall on the right side of the photo was demolished around 2006." )
                ),
                 new AerialGalleryItem(new DateTime(2005,5,30),"", "20_i30_us80_split_2005-05-30_900.jpg", "20_i30_us80_split_2005-05-30_2096x1373.png", "aerial", 
                    "I-30 at US 80",
                    "I-30 at US 80 looking southeast",
                    "I-30 at US 80",
                    "Looking southeast."),
            };
        }
    }
}