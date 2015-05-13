using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i45_i20_images()
        {
            return i20_dallas_i20_i45_images();
        }

        public static List<AerialGalleryItem> i20_dallas_i20_i45_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2005,5,30),"","20a_i34_at_i20_looking_s_2005-05-30_900.jpg", "20a_i34_at_i20_looking_s_2005-05-30_1965x1661.png", "aerial", 
                    "I-20 at I-45",
                    "I-20 at I-45, looking southeast",
                    "I-20 at I-45",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","21a_i45_at_i20_looking_s_2005-05-30_900.jpg", "21a_i45_at_i20_looking_s_2005-05-30_2373x1623.png", "aerial", 
                    "I-20 at I-45",
                    "I-20 at I-45, looking south",
                    "I-20 at I-45",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","22a_i45_at_i20_looking_sw_2005-05-30_900.jpg", "22a_i45_at_i20_looking_sw_2005-05-30_2767x1592.png", "aerial", 
                    "I-20 at I-45",
                    "I-20 at I-45, looking south",
                    "I-20 at I-45",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","23a_i45_at_i20_looking_sw_2005-05-30_900.jpg", "23a_i45_at_i20_looking_sw_2005-05-30_2332x1371.png", "aerial", 
                    "I-20 at I-45",
                    "I-20 at I-45, looking southwest",
                    "I-20 at I-45",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","25a_i20_e_of_i45_looking_e_2005-05-30_900.jpg", "", "aerial", 
                    "I-20 at I-45",
                    "I-20 at I-45, looking east",
                    "I-20 at I-45",
                    "Looking east along I-20 east of the I-45 interchange.")
            };
        }
    }
}