using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> i35e_south_downtown_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0452.JPG","20110416_aerial_0452-1050.jpg", "20110416_aerial_0452-2560.jpg", "aerial", 
                    "I-35E at the Trinity River",
                    "I-35E at the Trinity River, looking northeast",
                    "I-35E at the Trinity River",
                    "Looking northeast.",
                    new AerialStatus ("2015", "Obsolete", "New bridges built 2014-2017" ) ),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0454.JPG","20110416_aerial_0454-1050.jpg", "20110416_aerial_0454-2560.jpg", "aerial", 
                    "I-35E at the Trinity River",
                    "I-35E at the Trinity River, looking northeast",
                    "I-35E at the Trinity River",
                    "Looking northeast.",
                    new AerialStatus ("2015", "Obsolete", "New bridges built 2014-2017" ) ),
                new AerialGalleryItem(new DateTime(2005,5,30),"","18a_i35e_crossing_trinity_2005-05-30_ADJ_900.jpg", "18a_i35e_crossing_trinity_2005-05-30_ADJ_2501x1729.png", "aerial", 
                    "I-35E at the Trinity River",
                    "I-35E at the Trinity River, looking northeast",
                    "I-35E at the Trinity River",
                    "Looking northeast.",
                    new AerialStatus ("2015", "Obsolete", "New bridges built 2014-2017, and Reunion Arena (left side of photo) is demolished." ) ),
                new AerialGalleryItem(new DateTime(2005,5,30),"","19a_i35e_crossing_trinity_2005-05-30_ADJ_900.jpg", "19a_i35e_crossing_trinity_2005-05-30_ADJ_2461x1609.png", "aerial", 
                    "I-35E at the Trinity River",
                    "I-35E at the Trinity River, looking southeast",
                    "I-35E at the Trinity River",
                    "Looking northeast.",
                    new AerialStatus ("2015", "Obsolete", "New bridges built 2014-2017, and Reunion Arena (left side of photo) is demolished." ) )

            };
        }
    }
}