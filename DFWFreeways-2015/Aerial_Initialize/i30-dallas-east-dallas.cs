using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i30_dallas_east_dallas_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3069.JPG","20120406_3069-1050.jpg", "20120406_3069-2560.jpg", "aerial", 
                    "I-30 east Dallas",
                    "I-30 east Dallas looking southeast",
                    "I-30 east Dallas looking southeast",
                    "Looking southeast. The large structure was originally a Ford auto assembly plant."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3071.JPG","20120406_3071-1050.jpg", "20120406_3071-2560.jpg", "aerial", 
                    "I-30 east Dallas",
                    "I-30 east Dallas looking east",
                    "I-30 east Dallas looking east",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3073.JPG","20120406_3073-1050.jpg", "20120406_3073-2560.jpg", "aerial", 
                    "I-30 east Dallas",
                    "I-30 east Dallas looking east",
                    "I-30 east Dallas looking east",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0498.JPG","20110416_aerial_0498-1050.jpg", "20110416_aerial_0498-2560.jpg", "aerial", 
                    "I-30 east Dallas",
                    "I-30 east Dallas looking west",
                    "I-30 east Dallas looking west",
                    "Looking west. The structure in the middle of the freeweay is for the HOV lane operations."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20110416_aerial_0500.JPG","20110416_aerial_0500-1050.jpg", "20110416_aerial_0500-2560.jpg", "aerial", 
                    "I-30 east Dallas",
                    "I-30 east Dallas looking west",
                    "I-30 east Dallas looking west",
                    "Looking west.")
            };
        }
    }
}