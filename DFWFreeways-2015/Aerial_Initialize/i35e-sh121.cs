﻿using System;
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
                    "I-35E at SH 121 Rayburn Turnpike, looking west",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0249.JPG","20110416_aerial_0249-1050.jpg", "20110416_aerial_0249-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking west",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0250.JPG","20110416_aerial_0250-1050.jpg", "20110416_aerial_0250-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking west",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0252.JPG","20110416_aerial_0252-1050.jpg", "20110416_aerial_0252-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking west",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0253.JPG","20110416_aerial_0253-1050.jpg", "20110416_aerial_0253-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking west-southwest",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking west-southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0254.JPG","20110416_aerial_0254-1050.jpg", "20110416_aerial_0254-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking southwest",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0255.JPG","20110416_aerial_0255-1050.jpg", "20110416_aerial_0255-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking southwest",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0256.JPG","20110416_aerial_0256-1050.jpg", "20110416_aerial_0256-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking southeast",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0258.JPG","20110416_aerial_0258-1050.jpg", "20110416_aerial_0258-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking north",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0260.JPG","20110416_aerial_0260-1050.jpg", "20110416_aerial_0260-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking northwest",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking northwest along I-35E northbound."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0261.JPG","20110416_aerial_0261-1050.jpg", "20110416_aerial_0261-2560.jpg", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking northwest",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","27_121_at_35e_2005-04-11_27a_900.jpg", "27_121_at_35e_2005-04-11_27a_2821x1722.png", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking north",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","28_121_at_35e_2005-04-11_28a_900.jpg", "28_121_at_35e_2005-04-11_28a_2721x1812.png", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking northeast",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","29_121_at_35e_2005-04-11_29a_900.jpg", "29_121_at_35e_2005-04-11_29a_1732x2805.png", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking east along SH 121/Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","30_121_at_35e_2005-04-11_30a_900.jpg", "30_121_at_35e_2005-04-11_30a_2224x790.png", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking east",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","31_121_at_35e_2005-04-11_31a_900.jpg", "31_121_at_35e_2005-04-11_31a_2835x1775.png", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking southeast",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","32_121_at_35e_2005-04-11_32a_900.jpg", "32_121_at_35e_2005-04-11_32a_2624x1785.png", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking southeast along I-35E",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking southeast along I-35E."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","33_121_at_35e_2005-04-11_33a_900.jpg", "33_121_at_35e_2005-04-11_33a_2812x1843.png", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking southeast",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","34_121_at_35e_2005-04-11_34a_900.jpg", "34_121_at_35e_2005-04-11_34a_2736x1760.png", "aerial", 
                    "I-35E at SH 121 Rayburn Turnpike",
                    "I-35E at SH 121 Rayburn Turnpike, looking south",
                    "I-35E at SH 121 Rayburn Turnpike",
                    "Looking south.")
            };
        }
    }
}