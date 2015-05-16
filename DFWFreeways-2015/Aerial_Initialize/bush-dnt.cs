using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {
        public static List<AerialGalleryItem> dnt_bush_images()
        {
            return bush_dnt_images();
        }

        public static List<AerialGalleryItem> bush_dnt_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0208.JPG","20110416_aerial_0208-1050.jpg", "20110416_aerial_0208-2560.jpg", "aerial", 
                    "Bush Turnpike at Dallas North Tollway",
                    "Bush Turnpike at Dallas North Tollway, looking southeast",
                    "Bush Turnpike at Dallas North Tollway",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","10_190_looking_e_at_dnt_2005-04-11_10a_900.jpg", "10_190_looking_e_at_dnt_2005-04-11_10a_2835x1843.png", "aerial", 
                    "Bush Turnpike at Dallas North Tollway",
                    "Bush Turnpike at Dallas North Tollway, looking east",
                    "Bush Turnpike at Dallas North Tollway",
                    "Looking east along the Bush Turnpike.",
                    new AerialStatus ("2015", "Mostly accurate", "Apartments have been built on the upper right side." )),
                new AerialGalleryItem(new DateTime(2005,4,11),"","09_190_looking_e_at_dnt_2005-04-11_9a_900.jpg", "09_190_looking_e_at_dnt_2005-04-11_9a_2792x1557.png", "aerial", 
                    "Bush Turnpike at Dallas North Tollway",
                    "Bush Turnpike at Dallas North Tollway, looking northeast",
                    "Bush Turnpike at Dallas North Tollway",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","08_dnt_looking_n_at_190_2005-04-11_8a_ADJ_900.jpg", "08_dnt_looking_n_at_190_2005-04-11_8a_ADJ_1830x2342.png", "aerial", 
                    "Bush Turnpike at Dallas North Tollway",
                    "Bush Turnpike at Dallas North Tollway, looking north",
                    "Bush Turnpike at Dallas North Tollway",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2008,9,1),"","dnt_pgbt_close_view_950.jpg", "", "aerial", 
                    "Bush Turnpike at Dallas North Tollway",
                    "Bush Turnpike at Dallas North Tollway",
                    "Bush Turnpike at Dallas North Tollway",
                    "Close-in view. Photo by Justin Cozart."),
                new AerialGalleryItem(new DateTime(2008,9,1),"","dnt_pgbt_looking_n_950.jpg", "dnt_pgbt_looking_n_1938.jpg", "aerial", 
                    "Bush Turnpike at Dallas North Tollway",
                    "Bush Turnpike at Dallas North Tollway, looking north",
                    "Bush Turnpike at Dallas North Tollway",
                    "Looking north. Photo by Justin Cozart."),
                new AerialGalleryItem(new DateTime(2008,9,1),"","dnt_pgbt_looking_nw_950.jpg", "dnt_pgbt_looking_nw_2200.jpg", "aerial", 
                    "Bush Turnpike at Dallas North Tollway",
                    "Bush Turnpike at Dallas North Tollway, looking northwest",
                    "Bush Turnpike at Dallas North Tollway",
                    "Looking northwest. Photo by Justin Cozart.")

          
            };
        }
    }
}