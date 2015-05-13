using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i35e_south_i20_images()
        {
            return i20_dallas_i20_i35e_images();
        }


        public static List<AerialGalleryItem> i20_dallas_i20_i35e_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2005,5,30),"","12a_i20_at_i35e_looking_e_2005-05-30_900.jpg", "12a_i20_at_i35e_looking_e_2005-05-30_2402x1211.png", "aerial", 
                    "I-20 at I-35E",
                    "I-20 at I-35E, looking east",
                    "I-20 at I-35E",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","13a_i20_at_i35e_looking_e_2005-05-30_900.jpg", "13a_i20_at_i35e_looking_e_2005-05-30_2442x1661.png", "aerial", 
                    "I-20 at I-35E",
                    "I-20 at I-35E, looking east",
                    "I-20 at I-35E",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","14a_i20_at_i35e_looking_se_2005-05-30_900.jpg", "14a_i20_at_i35e_looking_se_2005-05-30_2359x1577.png", "aerial", 
                    "I-20 at I-35E",
                    "I-20 at I-35E, looking east-southeast",
                    "I-20 at I-35E",
                    "Looking east-southeast."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","15a_i20_at_i35e_looking_se_2005-05-30_900.jpg", "15a_i20_at_i35e_looking_se_2005-05-30_2782x1557.png", "aerial", 
                    "I-20 at I-35E",
                    "I-20 at I-35E, looking southeast",
                    "I-20 at I-35E",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","16a_i35e_at_i20_looking_s_2005-05-30_900.jpg", "16a_i35e_at_i20_looking_s_2005-05-30_2662x1706.png", "aerial", 
                    "I-20 at I-35E",
                    "I-20 at I-35E, looking south-southeast",
                    "I-20 at I-35E",
                    "Looking south-southeast."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","17a_i35e_at_i20_looking_s_2005-05-30_900.jpg", "17a_i35e_at_i20_looking_s_2005-05-30_2546x1767.png", "aerial", 
                    "I-20 at I-35E",
                    "I-20 at I-35E, looking south",
                    "I-20 at I-35E",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","18a_i35e_at_i20_looking_s_2005-05-30_900.jpg", "18a_i35e_at_i20_looking_s_2005-05-30_2637x1670.png", "aerial", 
                    "I-20 at I-35E",
                    "I-20 at I-35E, looking southwest",
                    "I-20 at I-35E",
                    "Looking southwest.")

            };
        }
    }
}