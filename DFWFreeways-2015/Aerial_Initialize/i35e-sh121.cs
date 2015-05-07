using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        //public static AerialGalleryList i35e_north_i35e_sh121(string fileServer, string folderPath)
        //{
        //    AerialGalleryList aerialGalleryList = new AerialGalleryList(fileServer, folderPath);
        //    aerialGalleryList.PageHeader = new PageHeader("I-35E at SH 121 Rayburn Turnpike", "", GetShieldPath("i35e"), "i35e-north", "I-35E North", "May 5, 2015 (created)");

        //    aerialGalleryList.ItemList = i35e_north_i35e_sh121_images();
        //    return aerialGalleryList;
        //}

        public static List<AerialGalleryItem> i35e_north_i35e_sh121_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0248.JPG","20110416_aerial_0248-1050.jpg", "20110416_aerial_0248-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking west",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0249.JPG","20110416_aerial_0249-1050.jpg", "20110416_aerial_0249-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking west",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0250.JPG","20110416_aerial_0250-1050.jpg", "20110416_aerial_0250-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking west",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0252.JPG","20110416_aerial_0252-1050.jpg", "20110416_aerial_0252-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking west",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0253.JPG","20110416_aerial_0253-1050.jpg", "20110416_aerial_0253-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking west-southwest",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking west-southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0254.JPG","20110416_aerial_0254-1050.jpg", "20110416_aerial_0254-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking southwest",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0255.JPG","20110416_aerial_0255-1050.jpg", "20110416_aerial_0255-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking southwest",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0256.JPG","20110416_aerial_0256-1050.jpg", "20110416_aerial_0256-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking southeast",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0258.JPG","20110416_aerial_0258-1050.jpg", "20110416_aerial_0258-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking north",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0260.JPG","20110416_aerial_0260-1050.jpg", "20110416_aerial_0260-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking northwest",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking northwest along I-35E northbound."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0261.JPG","20110416_aerial_0261-1050.jpg", "20110416_aerial_0261-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "II-35E at SH 121 Rayburn Turnpike, looking northwest",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking northwest.")
                //new AerialGalleryItem(new DateTime(2011,4,16),"","", "", "aerial", 
                //    "I-35E at SH 121 Rayburn Turnpike",
                //    "II-35E at SH 121 Rayburn Turnpike, looking ",
                //    "I-35E at SH 121 Rayburn Turnpike",
                //    "Looking ."),
                //new AerialGalleryItem(new DateTime(2011,4,16),"","", "", "aerial", 
                //    "I-35E at SH 121 Rayburn Turnpike",
                //    "II-35E at SH 121 Rayburn Turnpike, looking ",
                //    "I-35E at SH 121 Rayburn Turnpike",
                //    "Looking ."),
                //new AerialGalleryItem(new DateTime(2011,4,16),"","", "", "aerial", 
                //    "I-35E at SH 121 Rayburn Turnpike",
                //    "II-35E at SH 121 Rayburn Turnpike, looking ",
                //    "I-35E at SH 121 Rayburn Turnpike",
                //    "Looking ."),
                //new AerialGalleryItem(new DateTime(2011,4,16),"","", "", "aerial", 
                //    "I-35E at SH 121 Rayburn Turnpike",
                //    "II-35E at SH 121 Rayburn Turnpike, looking ",
                //    "I-35E at SH 121 Rayburn Turnpike",
                //    "Looking ."),
                //new AerialGalleryItem(new DateTime(2011,4,16),"","", "", "aerial", 
                //    "I-35E at SH 121 Rayburn Turnpike",
                //    "II-35E at SH 121 Rayburn Turnpike, looking ",
                //    "I-35E at SH 121 Rayburn Turnpike",
                //    "Looking ."),
            };
        }
    }
}