using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> dnt_loop12_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0226.JPG","20090623_aerial_0226-1050.jpg", "20090623_aerial_0226-2560.jpg", "aerial", 
                    "Dallas North Tollway at Loop 12",
                    "Dallas North Tollway at Loop 12, looking west",
                    "Dallas North Tollway at Loop 12",
                    "Looking west along Loop 12."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0228.JPG","20090623_aerial_0228-1050.jpg", "20090623_aerial_0228-2560.jpg", "aerial", 
                    "Dallas North Tollway at Loop 12",
                    "Dallas North Tollway at Loop 12, looking south",
                    "Dallas North Tollway at Loop 12",
                    "Looking south along the Dallas North Tollway."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0231.JPG","20090623_aerial_0231-1050.jpg", "20090623_aerial_0231-2560.jpg", "aerial", 
                    "Dallas North Tollway at Loop 12",
                    "Dallas North Tollway at Loop 12, looking south",
                    "Dallas North Tollway at Loop 12",
                    "Looking south along the Dallas North Tollway.")

            
            };
        }
    }
}