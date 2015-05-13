using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {
        public static List<AerialGalleryItem> i635_i30_images()
        {
            return i30_dallas_i635_images();
        }

        public static List<AerialGalleryItem> i30_dallas_i635_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0524.JPG","20110416_aerial_0524-1050.jpg", "20110416_aerial_0524-2560.jpg", "aerial", 
                    "I-30 at I-635",
                    "I-30 at I-635 looking north",
                    "I-30 at I-635",
                    "Looking north along I-635."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0529.JPG","20110416_aerial_0529-1050.jpg", "20110416_aerial_0529-2560.jpg", "aerial", 
                    "I-30 at I-635",
                    "I-30 at I-635 looking northwest",
                    "I-30 at I-635",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0533.JPG","20110416_aerial_0533-1050.jpg", "20110416_aerial_0533-2560.jpg", "aerial", 
                    "I-30 at I-635",
                    "I-30 at I-635 looking northwest",
                    "I-30 at I-635",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0537.JPG","20110416_aerial_0537-1050.jpg", "20110416_aerial_0537-2560.jpg", "aerial", 
                    "I-30 at I-635",
                    "I-30 at I-635 looking southwest",
                    "I-30 at I-635",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0539.JPG","20110416_aerial_0539-1050.jpg", "20110416_aerial_0539-2560.jpg", "aerial", 
                    "I-30 at I-635",
                    "I-30 at I-635 looking southeast",
                    "I-30 at I-635",
                    "Looking southwest.")
            };
        }
    }
}