using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> dnt_park_cities_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0215.JPG","20090623_aerial_0215-1050.jpg", "20090623_aerial_0215-2560.jpg", "aerial", 
                    "Dallas North Tollway at Mockingbird",
                    "Dallas North Tollway at Mockingbird, looking south",
                    "Dallas North Tollway at Mockingbird",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0218.JPG","20090623_aerial_0218-1050.jpg", "20090623_aerial_0218-2560.jpg", "aerial", 
                    "Dallas North Tollway at Mockingbird",
                    "Dallas North Tollway at Mockingbird, looking south",
                    "Dallas North Tollway at Mockingbird",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0222.JPG","20090623_aerial_0222-1050.jpg", "20090623_aerial_0222-2560.jpg", "aerial", 
                    "Dallas North Tollway at Mockingbird",
                    "Dallas North Tollway at Mockingbird, looking south",
                    "Dallas North Tollway at Mockingbird",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0225.JPG","20090623_aerial_0225-1050.jpg", "20090623_aerial_0225-2560.jpg", "aerial", 
                    "Dallas North Tollway at Mockingbird",
                    "Dallas North Tollway at Mockingbird, looking south",
                    "Dallas North Tollway at Mockingbird",
                    "Looking south.")

            
            };
        }
    }
}