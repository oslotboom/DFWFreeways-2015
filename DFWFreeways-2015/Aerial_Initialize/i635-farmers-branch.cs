using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> i635_farmers_branch_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2005,4,11),"","12_635_looking_e_w_of_midway_2005-04-11_900.jpg", "12_635_looking_e_w_of_midway_2005-04-11_2577x1417.png", "aerial", 
                    "I-635 in Farmers Branch",
                    "I-635 in Farmers Branch, looking east-northeast",
                    "I-635 in Farmers Branch",
                    "Looking east-northeast.",
                    new AerialStatus ("2015", "Obsolete", "Freeway has been rebuilt and expanded by the LBJ Express Project, completed in 2015" )),
                new AerialGalleryItem(new DateTime(2005,4,11),"","13_635_looking_e_at_marsh_2005-04-11_900.jpg", "13_635_looking_e_at_marsh_2005-04-11_2615x1783.png", "aerial", 
                    "I-635 in Farmers Branch",
                    "I-635 in Farmers Branch, looking east-northeast",
                    "I-635 in Farmers Branch",
                    "Looking east-northeast.",
                    new AerialStatus ("2015", "Obsolete", "Freeway has been rebuilt and expanded by the LBJ Express Project, completed in 2015" ))
            
            };
        }
    }
}