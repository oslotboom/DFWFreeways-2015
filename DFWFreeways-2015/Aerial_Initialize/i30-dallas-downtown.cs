using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

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
                new AerialGalleryItem(new DateTime(2009,6,23),"","15a_i30_canyon_2005-05-30_ADJ_900.jpg", "15a_i30_canyon_2005-05-30_ADJ_2424x1593.png", "aerial", 
                    "I-30 downtown canyon",
                    "I-30 downtown canyon looking northeast",
                    "I-30 downtown canyon",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,6,23),"","10a_i30_looking_e_at_i45_2005-05-30_600.jpg", "10a_i30_looking_e_at_i45_2005-05-30_1830x2369.png", "aerial", 
                    "I-30 downtown canyon",
                    "I-30 downtown canyon looking northeast",
                    "I-30 downtown canyon",
                    "Looking northeast with the Central Expressway insection in the foreground."),

                new AerialGalleryItem(new DateTime(2009,6,23),"","15a_i30_canyon_2005-05-30_ADJ_900.jpg", "15a_i30_canyon_2005-05-30_ADJ_2424x1593.png", "aerial", 
                    "I-30 at I-35E",
                    "I-30 at I-35E looking east",
                    "I-30 at I-35E",
                    "Looking east.",
                    new AerialStatus ("2015", "Obsolete", "Interchange is rebuilt and expanded by the Horseshoe Project." ) 
                )

            };
        }
    }
}