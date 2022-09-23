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
                    "The Campus at Legacy West",
                    "Looking northeast",
                    "The Campus at Legacy West,",
                    "Looking northeast. This building with 2 million square feet was built in 1992 to be the JC Penney headquarters. JC Penney sustained financial difficulty in the late 2010s and was affected by the Covid pandemic. The company downsized, selling the headquarters campus and entirely vacating this building. In May 2022 it was announced that Penney would move its headquarters staff back into the building. In 2017 construction was completed on huge commercial projects in the area behind and to the left (north) of this building, including Legacy West and Toyota North America headquarters.")
            
            };
        }
    }
}