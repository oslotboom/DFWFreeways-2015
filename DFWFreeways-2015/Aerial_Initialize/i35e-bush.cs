using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        //public static AerialGalleryList i35e_north_i35e_bush(string fileServer, string folderPath)
        //{
        //    AerialGalleryList aerialGalleryList = new AerialGalleryList(fileServer, folderPath);
        //    aerialGalleryList.PageHeader = new PageHeader("I-35E at Bush Turnpike", "", GetShieldPath("i35e"), "i35e-north", "I-35E North", "May 5, 2015 (created)");

        //    aerialGalleryList.ItemList = i35e_north_i35e_bush_images();
        //    return aerialGalleryList;
        //}

        public static List<AerialGalleryItem> i35e_north_i35e_bush_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0222.JPG","20110416_aerial_0222-1050.jpg", "20110416_aerial_0222-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking southwest",
                    "I-35E at Bush Turnpike",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0224.JPG","20110416_aerial_0224-1050.jpg", "20110416_aerial_0224-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking southwest",
                    "I-35E at Bush Turnpike",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0227.JPG","20110416_aerial_0227-1050.jpg", "20110416_aerial_0227-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking south",
                    "I-35E at Bush Turnpike",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0229.JPG","20110416_aerial_0229-1050.jpg", "20110416_aerial_0229-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking south",
                    "I-35E at Bush Turnpike",
                    "Looking south"),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0231.JPG","20110416_aerial_0231-1050.jpg", "20110416_aerial_0231-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking south",
                    "I-35E at Bush Turnpike",
                    "Looking south"),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0233.JPG","20110416_aerial_0233-1050.jpg", "20110416_aerial_0233-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking east",
                    "I-35E at Bush Turnpike",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0237.JPG","20110416_aerial_0237-1050.jpg", "20110416_aerial_0237-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking north",
                    "I-35E at Bush Turnpike",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0238.JPG","20110416_aerial_0238-1050.jpg", "20110416_aerial_0238-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking northwest",
                    "I-35E at Bush Turnpike",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0240.JPG","20110416_aerial_0240-1050.jpg", "20110416_aerial_0240-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking northwest",
                    "I-35E at Bush Turnpike",
                    "Looking northwest"),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0242.JPG","20110416_aerial_0242-1050.jpg", "20110416_aerial_0242-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking northwest",
                    "I-35E at Bush Turnpike",
                    "Looking northwest"),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0244.JPG","20110416_aerial_0244-1050.jpg", "20110416_aerial_0244-2560.jpg", "aerial", 
                    "I-35E at Bush Turnpike",
                    "I-35E Stemmons Freeway at Bush Turnpike, looking west",
                    "I-35E at Bush Turnpike",
                    "Looking west")
            };
        }
    }
}