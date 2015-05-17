using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> sh121_colony_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2005,4,11),"","26_121_looking_ne_at_121bus_2005-04-11_26a_900.jpg", "26_121_looking_ne_at_121bus_2005-04-11_26a_2447x1775.png", "aerial", 
                    "SH 121 in The Colony area",
                    "SH 121 in The Colony area, looking north",
                    "SH 121 in The Colony area",
                    "Looking north near Carrollton Parkway."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","24_121_looking_ne_at_colonyy_2005-04-11_24a_ADJ_900.jpg", "24_121_looking_ne_at_colonyy_2005-04-11_24a_ADJ_2280x1760.png", "aerial", 
                    "SH 121 in The Colony area",
                    "SH 121 in The Colony area, looking northeast",
                    "SH 121 in The Colony area",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","21_121_looking_ne_at_legacy_2005-04-11_21a_ADJ_900.jpg", "21_121_looking_ne_at_legacy_2005-04-11_21a_ADJ_2130x1710.png", "aerial", 
                    "SH 121 in The Colony area",
                    "SH 121 in The Colony area, looking northeast",
                    "SH 121 in The Colony area",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","18_121_jcpenney_2005-04-11_18a_900.jpg", "18_121_jcpenney_2005-04-11_18a_2744x1706.png", "aerial", 
                    "JC Penney headquarters",
                    "JC Penney headquarters, looking northeast",
                    "JC Penney headquarters",
                    "JC Penney headquarters, looking northeast. In 2015 the area behind and to the left (north) of the JC Penney building is being developed with large new offices for Toyota USA, Fedex Office and Liberty Mutual Insurance.")
            
            };
        }
    }
}