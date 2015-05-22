using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> us175_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.us175_dallas_images());
            itemList.AddRange(AerialGalleryList.us175_i20_images());
            return itemList;
        }


        public static List<AerialGalleryItem> us175_dallas_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0468.JPG","20110416_aerial_0468-1050.jpg", "20110416_aerial_0468-2560.jpg", "aerial", 
                    "US 175 S.M. Wright Freeway",
                    "US 175 S.M. Wright Freeway, looking north",
                    "US 175 S.M. Wright Freeway",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0473.JPG","20110416_aerial_0473-1050.jpg", "20110416_aerial_0473-2560.jpg", "aerial", 
                    "US 175 S.M. Wright Freeway",
                    "US 175 S.M. Wright Freeway, looking northeast",
                    "US 175 S.M. Wright Freeway",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0476.JPG","20110416_aerial_0476-1050.jpg", "20110416_aerial_0476-2560.jpg", "aerial", 
                    "US 175 S.M. Wright Freeway",
                    "US 175 S.M. Wright Freeway, looking northeast",
                    "US 175 S.M. Wright Freeway",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0481.JPG","20110416_aerial_0481-1050.jpg", "20110416_aerial_0481-2560.jpg", "aerial", 
                    "US 175 S.M. Wright Freeway",
                    "US 175 S.M. Wright Freeway, looking northeast",
                    "US 175 S.M. Wright Freeway",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0483.JPG","20110416_aerial_0483-1050.jpg", "20110416_aerial_0483-2560.jpg", "aerial", 
                    "US 175 S.M. Wright Freeway",
                    "US 175 S.M. Wright Freeway, looking northeast",
                    "US 175 S.M. Wright Freeway",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0487.JPG","20110416_aerial_0487-1050.jpg", "20110416_aerial_0487-2560.jpg", "aerial", 
                    "US 175 S.M. Wright Freeway",
                    "US 175 S.M. Wright Freeway, looking northeast",
                    "US 175 S.M. Wright Freeway",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0489.JPG","20110416_aerial_0489-1050.jpg", "20110416_aerial_0489-1700.jpg", "aerial", 
                    "US 175 S.M. Wright Freeway",
                    "US 175 S.M. Wright Freeway, looking northeast",
                    "US 175 S.M. Wright Freeway",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0492.JPG","20110416_aerial_0492-1050.jpg", "20110416_aerial_0492-2560.jpg", "aerial", 
                    "US 175 S.M. Wright Freeway",
                    "US 175 S.M. Wright Freeway, looking northeast",
                    "US 175 S.M. Wright Freeway",
                    "Looking northeast.")

            };
        }

    }
}