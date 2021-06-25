using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DFWFreeways.Models;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {
        //public static AerialGalleryList i35e_north_market_center(string fileServer, string folderPath)
        //{
        //    AerialGalleryList aerialGalleryList = new AerialGalleryList(fileServer, folderPath);
        //    aerialGalleryList.PageHeader = new PageHeader("Dallas Market Center", "", GetShieldPath("i35e"), "i35e-north", "I-35E North", "May 3, 2015 (created)");
        //    aerialGalleryList.ItemList = AerialGalleryList.i35e_north_market_center_images();
            
        //    return aerialGalleryList;
        //}

        public static List<AerialGalleryItem> i35e_north_market_center_images()
        {
            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3275.JPG","20120406_3275-1050.jpg", "20120406_3275-2560.jpg", "aerial", 
                    "I-35E looking southeast at Medical District Drive.",
                    "I-35E Stemmons Freeway looking southeast at Medical District Drive.",
                    "Looking southeast at Medical District Drive",
                    "Looking southeast at Medical District Drive"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3276.JPG","20120406_3276-1050.jpg", "20120406_3276-2560.jpg", "aerial", 
                    "I-35E looking southeast at Medical District Drive.",
                    "I-35E Stemmons Freeway looking southeast at Medical District Drive.",
                    "Looking southeast at Medical District Drive",
                    "Looking southeast at Medical District Drive"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3283.JPG","20120406_3283-1050.jpg", "20120406_3283-2560.jpg", "aerial", 
                    "I-35E looking southeast at Medical District Drive.",
                    "I-35E Stemmons Freeway looking southeast at Medical District Drive.",
                    "Looking southeast at Medical District Drive",
                    "Looking southeast at Medical District Drive"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3288.JPG","20120406_3288-1050.jpg", "20120406_3288-2560.jpg", "aerial", 
                    "I-35E looking southeast at Medical District Drive.",
                    "I-35E Stemmons Freeway looking southeast at Medical District Drive.",
                    "Looking southeast at Medical District Drive",
                    "Looking southeast at Medical District Drive"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3295.JPG","20120406_3295-1050.jpg", "20120406_3295-2560.jpg", "aerial", 
                    "I-35E looking southeast at Medical District Drive.",
                    "I-35E Stemmons Freeway looking southeast at Medical District Drive.",
                    "Looking southeast at Medical District Drive",
                    "Looking southeast at Medical District Drive"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3299.JPG","20120406_3299-1050.jpg", "20120406_3299-2560.jpg", "aerial", 
                    "I-35E looking southeast at Wycliff.",
                    "I-35E Stemmons Freeway looking southeast at Wycliff.",
                    "Looking southeast at Wycliff",
                    "Looking southeast at Wycliff"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3301.JPG","20120406_3301-1050.jpg", "20120406_3301-2560.jpg", "aerial", 
                    "I-35E looking southeast at Wycliff.",
                    "I-35E Stemmons Freeway looking southeast at Wycliff.",
                    "Looking southeast at Wycliff",
                    "Looking southeast at Wycliff"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3304.JPG","20120406_3304-1050.jpg", "20120406_3304-2560.jpg", "aerial", 
                    "I-35E looking southeast at Wycliff.",
                    "I-35E Stemmons Freeway looking southeast at Wycliff.",
                    "Looking southeast at Wycliff",
                    "Looking southeast at Wycliff"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3307.JPG","20120406_3307-1050.jpg", "20120406_3307-2560.jpg", "aerial", 
                    "I-35E looking southeast at Market Center.",
                    "I-35E Stemmons Freeway looking southeast at Market Center.",
                    "Looking southeast at Market Center",
                    "Looking southeast at Market Center."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3310.JPG","20120406_3310-1050.jpg", "20120406_3310-2560.jpg", "aerial", 
                    "I-35E looking southeast at Market Center.",
                    "I-35E Stemmons Freeway looking southeast at Market Center.",
                    "Looking southeast at Market Center",
                    "Looking southeast at Market Center."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3315.JPG","20120406_3315-1050.jpg", "20120406_3315-2560.jpg", "aerial", 
                    "I-35E looking east at Market Center.",
                    "I-35E Stemmons Freeway looking east at Market Center.",
                    "Looking east at Market Center",
                    "Looking east at Market Center."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3317.JPG","20120406_3317-1050.jpg", "20120406_3317-2560.jpg", "aerial", 
                    "I-35E looking northeast at Dallas Market Center.",
                    "I-35E Stemmons Freeway looking northeast at Dallas Market Center.",
                    "Looking northeast at Dallas Market Center",
                    "Looking northeast at Dallas Market Center.")
            };
        }
    }
}