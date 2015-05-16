using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> bush_carrollton_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0211.JPG","20110416_aerial_0211-1050.jpg", "20110416_aerial_0211-2560.jpg", "aerial", 
                    "Bush Turnpike at Rosemeade Parkway",
                    "Bush Turnpike at Rosemeade Parkway, looking southwest",
                    "Bush Turnpike at Rosemeade Parkway",
                    "Looking southwest at Rosemeade Parkway."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0216.JPG","20110416_aerial_0216-1050.jpg", "20110416_aerial_0216-2560.jpg", "aerial", 
                    "Bush Turnpike at Kelly Blvd",
                    "Bush Turnpike at Kelly Blvd, looking west",
                    "Bush Turnpike at Kelly Blvd",
                    "Looking west at Kelly Blvd."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0218.JPG","20110416_aerial_0218-1050.jpg", "20110416_aerial_0218-2560.jpg", "aerial", 
                    "Bush Turnpike at Kelly Blvd",
                    "Bush Turnpike at Kelly Blvd, looking west",
                    "Bush Turnpike at Kelly Blvd",
                    "Looking west at Kelly Blvd.")
          
            };
        }
    }
}