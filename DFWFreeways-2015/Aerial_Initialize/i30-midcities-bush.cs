using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {
        public static List<AerialGalleryItem> bush_i30_images()
        {
            return i30_midcities_bush_images();
        }

        public static List<AerialGalleryItem> i30_midcities_bush_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0338.JPG","20110416_aerial_0338-1050.jpg", "20110416_aerial_0338-2560.jpg", "aerial", 
                    "I-30 at Bush Turnpike",
                    "I-30 at Bush Turnpike, looking south",
                    "I-30 at Bush Turnpike",
                    "Looking south along the Bush Turnpike."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0349.JPG","20110416_aerial_0349-1050.jpg", "20110416_aerial_0349-2560.jpg", "aerial", 
                    "I-30 at Bush Turnpike",
                    "I-30 at Bush Turnpike, looking south",
                    "I-30 at Bush Turnpike",
                    "Looking south along the Bush Turnpike."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0402.JPG","20110416_aerial_0402-1050.jpg", "20110416_aerial_0402-2560.jpg", "aerial", 
                    "I-30 at Bush Turnpike",
                    "I-30 at Bush Turnpike, looking north",
                    "I-30 at Bush Turnpike",
                    "Looking north along the Bush Turnpike."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0405.JPG","20110416_aerial_0405-1050.jpg", "20110416_aerial_0405-2560.jpg", "aerial", 
                    "I-30 at Bush Turnpike",
                    "I-30 at Bush Turnpike, looking north",
                    "I-30 at Bush Turnpike",
                    "Looking north along the Bush Turnpike."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0342.JPG","20110416_aerial_0342-1050.jpg", "20110416_aerial_0342-2560.jpg", "aerial", 
                    "Bush Turnpike north of I-30",
                    "Bush Turnpike north of I-30, looking north",
                    "Bush Turnpike north of I-30",
                    "Looking north along the Bush Turnpike north of I-30."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0347.JPG","20110416_aerial_0347-1050.jpg", "20110416_aerial_0347-2560.jpg", "aerial", 
                    "Bush Turnpike north of I-30",
                    "Bush Turnpike north of I-30, looking north",
                    "Bush Turnpike north of I-30",
                    "Looking north along the Bush Turnpike north of I-30.")


          
            };
        }
    }
}