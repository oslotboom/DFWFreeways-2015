using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {
        public static List<AerialGalleryItem> us80_i635_images()
        {
            return i635_us80_images();
        }

        public static List<AerialGalleryItem> i635_us80_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2012,4,6),"20110416_aerial_0506.JPG","20110416_aerial_0506-1050.jpg", "20110416_aerial_0506-2560.jpg", "aerial", 
                    "I-635 at US 80",
                    "I-635 at US 80, looking north",
                    "I-635 at US 80",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20110416_aerial_0508.JPG","20110416_aerial_0508-1050.jpg", "20110416_aerial_0508-2560.jpg", "aerial", 
                    "I-635 at US 80",
                    "I-635 at US 80, looking north",
                    "I-635 at US 80",
                    "Looking north along I-635"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20110416_aerial_0509.JPG","20110416_aerial_0509-1050.jpg", "20110416_aerial_0509-2560.jpg", "aerial", 
                    "I-635 at US 80",
                    "I-635 at US 80, looking north",
                    "I-635 at US 80",
                    "Looking north along I-635"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20110416_aerial_0512.JPG","20110416_aerial_0512-1050.jpg", "20110416_aerial_0512-2560.jpg", "aerial", 
                    "I-635 at US 80",
                    "I-635 at US 80, looking northwest",
                    "I-635 at US 80",
                    "Looking northwest"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20110416_aerial_0517.JPG","20110416_aerial_0517-1050.jpg", "20110416_aerial_0517-2560.jpg", "aerial", 
                    "I-635 at US 80",
                    "I-635 at US 80, looking west",
                    "I-635 at US 80",
                    "Looking west along US 80"),
                new AerialGalleryItem(new DateTime(2012,4,6),"20110416_aerial_0519.JPG","20110416_aerial_0519-1050.jpg", "20110416_aerial_0519-2560.jpg", "aerial", 
                    "I-635 at US 80",
                    "I-635 at US 80, looking ",
                    "I-635 at US 80",
                    "Looking west")           
            };
        }
    }
}