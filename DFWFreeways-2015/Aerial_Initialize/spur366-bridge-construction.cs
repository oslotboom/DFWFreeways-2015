using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> spur366_bridge_construction_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0199.JPG","20090623_aerial_0199-1050.jpg", "20090623_aerial_0199-2560.jpg", "aerial", 
                    "Margaret Hunt Hill Bridge construction",
                    "Margaret Hunt Hill Bridge construction, looking southwest",
                    "Margaret Hunt Hill Bridge construction",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0200.JPG","20090623_aerial_0200-1050.jpg", "20090623_aerial_0200-2560.jpg", "aerial", 
                    "Margaret Hunt Hill Bridge construction",
                    "Margaret Hunt Hill Bridge construction, looking southwest",
                    "Margaret Hunt Hill Bridge construction",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0202.JPG","20090623_aerial_0202-1050.jpg", "20090623_aerial_0202-2560.jpg", "aerial", 
                    "Margaret Hunt Hill Bridge construction",
                    "Margaret Hunt Hill Bridge construction, looking southwest",
                    "Margaret Hunt Hill Bridge construction",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0203.JPG","20090623_aerial_0203-1050.jpg", "20090623_aerial_0203-2560.jpg", "aerial", 
                    "Margaret Hunt Hill Bridge construction",
                    "Margaret Hunt Hill Bridge construction, looking south",
                    "Margaret Hunt Hill Bridge construction",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0205.JPG","20090623_aerial_0205-1050.jpg", "20090623_aerial_0205-2560.jpg", "aerial", 
                    "Margaret Hunt Hill Bridge construction",
                    "Margaret Hunt Hill Bridge construction, looking west",
                    "Margaret Hunt Hill Bridge construction",
                    "Looking west.")
            
            };
        }
    }
}