using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DFWFreeways.Models;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i35e_north_american_airlines_center_images()
        {

        return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3320.JPG","20120406_3320-1050.jpg", "20120406_3320-2560.jpg", "aerial", 
                    "American Airlines Center",
                    "American Airlines Center, looking east",
                    "American Airlines Center",
                    "Looking east. Most of the parking lot around the AAC has been developed since this photo."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3322.JPG","20120406_3322-1050.jpg", "20120406_3322-2560.jpg", "aerial", 
                    "American Airlines Center",
                    "American Airlines Center, looking east",
                    "American Airlines Center",
                    "Looking east. Most of the parking lot around the AAC has been developed since this photo."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3324.JPG","20120406_3324-1050.jpg", "20120406_3324-2560.jpg", "aerial", 
                    "American Airlines Center",
                    "American Airlines Center, looking northeast",
                    "American Airlines Center",
                    "Looking northeast. Most of the parking lot around the AAC has been developed since this photo.",
                    new AerialStatus ("2015", "Partially obsolete", "Parking lot has been developed." ) ),
                    //new AerialStatus (StatusDate="2015", Status="Partially obsolete", Note="Parking lot has been developed" ) ),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3328.JPG","20120406_3328-1050.jpg", "20120406_3328-2560.jpg", "aerial", 
                    "American Airlines Center",
                    "American Airlines Center, looking northeast",
                    "American Airlines Center",
                    "Looking northeast. Most of the parking lot around the AAC has been developed since this photo."),
                new AerialGalleryItem(new DateTime(2005,5,30),"","5a_aac_looking_n_2005-05-30_900.jpg", "", "aerial", 
                    "American Airlines Center",
                    "American Airlines Center, looking north",
                    "American Airlines Center",
                    "Looking north with the W Hotel under construction."),
                new AerialGalleryItem(new DateTime(2012,4,6),"20120406_3330.JPG","20120406_3330-700.jpg", "20120406_3330-1700.jpg", "aerial", 
                    "W Hotel and residences",
                    "W Hotel and residences, looking east",
                    "W Hotel and residences",
                    "W Hotel and residences just south of the AAC, looking east")




                    

            };
    }
    }
}