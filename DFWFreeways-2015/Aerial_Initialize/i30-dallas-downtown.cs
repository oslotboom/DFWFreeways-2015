using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {
        public static List<AerialGalleryItem> i30_dallas_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i30_dallas_downtown_images());
            itemList.AddRange(AerialGalleryList.i30_dallas_east_dallas_images());
            itemList.AddRange(AerialGalleryList.i30_dallas_us80_images());
            itemList.AddRange(AerialGalleryList.i30_dallas_i635_images());
            itemList.AddRange(AerialGalleryList.i30_dallas_garland_images());
            itemList.AddRange(AerialGalleryList.i30_dallas_white_rock_lake_images());

            return itemList;
        }


        public static List<AerialGalleryItem> i30_dallas_downtown_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0120.JPG","20090623_aerial_0120-1050.jpg", "20090623_aerial_0120-2560.jpg", "aerial", 
                    "I-30 at I-45",
                    "I-30 at I-45 looking north",
                    "I-30 at I-45",
                    "Looking north, with I-30 crossing from left to right."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0126.JPG","20090623_aerial_0126-1050.jpg", "20090623_aerial_0126-2560.jpg", "aerial", 
                    "I-30 at I-45",
                    "I-30 at I-45 looking northwest",
                    "I-30 at I-45",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0127.JPG","20090623_aerial_0127-1050.jpg", "20090623_aerial_0127-2560.jpg", "aerial", 
                    "I-30 at I-45",
                    "I-30 at I-45 looking northwest",
                    "I-30 at I-45",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0128.JPG","20090623_aerial_0128-1050.jpg", "20090623_aerial_0128-2560.jpg", "aerial", 
                    "I-30 at I-45",
                    "I-30 at I-45 looking west",
                    "I-30 at I-45",
                    "Looking west, with I-30 on the left side."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0136.JPG","20090623_aerial_0136-1050.jpg", "20090623_aerial_0136-2560.jpg", "aerial", 
                    "I-30 at I-45",
                    "I-30 at I-45 looking northwest",
                    "I-30 at I-45",
                    "Looking northwest, with I-30 on the ground level."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0139.JPG","20090623_aerial_0139-1050.jpg", "20090623_aerial_0139-2560.jpg", "aerial", 
                    "I-30 at I-45",
                    "I-30 at I-45 looking northwest",
                    "I-30 at I-45",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0141.JPG","20090623_aerial_0141-1050.jpg", "20090623_aerial_0141-2560.jpg", "aerial", 
                    "I-30 at I-45",
                    "I-30 at I-45 looking west",
                    "I-30 at I-45",
                    "Looking west along I-30."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0143.JPG","20090623_aerial_0143-700.jpg", "20090623_aerial_0143-1700.jpg", "aerial", 
                    "I-30 at I-45",
                    "I-30 at I-45 looking southwest",
                    "I-30 at I-45",
                    "Looking southwest along I-30."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0145.JPG","20090623_aerial_0145-700.jpg", "20090623_aerial_0145-1700.jpg", "aerial", 
                    "I-30 at I-45",
                    "I-30 at I-45 looking southwest",
                    "I-30 at I-45",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","15a_i30_canyon_2005-05-30_ADJ_900.jpg", "15a_i30_canyon_2005-05-30_ADJ_2424x1593.png", "aerial", 
                    "I-30 downtown canyon",
                    "I-30 downtown canyon looking northeast",
                    "I-30 downtown canyon",
                    "Looking northeast. This section of freeway is scheduled to be rebuilt, with work expected to start in 2025."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","10a_i30_looking_e_at_i45_2005-05-30_600.jpg", "10a_i30_looking_e_at_i45_2005-05-30_1830x2369.png", "aerial", 
                    "I-30 downtown canyon",
                    "I-30 downtown canyon looking northeast",
                    "I-30 downtown canyon",
                    "Looking northeast with the Central Expressway insection in the foreground. This section of freeway is scheduled to be rebuilt, with work expected to start in 2025.")

            };
        }

        public static List<AerialGalleryItem> i30_dallas_white_rock_lake_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3063.JPG","20120406_3063-1050.jpg", "20120406_3063-2560.jpg", "aerial", 
                    "White Rock Lake",
                    "White Rock Lake, looking south",
                    "White Rock Lake",
                    "Looking south along Buckner Boulevard."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3065.JPG","20120406_3065-1050.jpg", "20120406_3065-2560.jpg", "aerial", 
                    "White Rock Lake",
                    "White Rock Lake, looking east",
                    "White Rock Lake",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3067.JPG","20120406_3067-1050.jpg", "20120406_3067-2560.jpg", "aerial", 
                    "",
                    "Lakewood Country Club, looking southeast",
                    "Lakewood Country Club",
                    "Lakewood Country Club looking southeast."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0502.JPG","20110416_aerial_0502-1050.jpg", "20110416_aerial_0502-2560.jpg", "aerial", 
                    "White Rock Lake",
                    "White Rock Lake, looking north",
                    "White Rock Lake",
                    "Looking north."),

            };
        }
    }
}