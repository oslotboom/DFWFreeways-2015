using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> bush_plano_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0167.JPG","20110416_aerial_0167-1050.jpg", "20110416_aerial_0167-2560.jpg", "aerial", 
                    "Bush Turnpike at Coit",
                    "Bush Turnpike at Coit, looking west",
                    "Bush Turnpike at Coit",
                    "Looking west at Coit.",
                    new AerialStatus ("2018", "Modified", "Two new lanes were added in the median, opened in November 2016." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0169.JPG","20110416_aerial_0169-1050.jpg", "20110416_aerial_0169-2560.jpg", "aerial", 
                    "Bush Turnpike at Coit",
                    "Bush Turnpike at Coit, looking west",
                    "Bush Turnpike at Coit",
                    "Looking west at Coit.",
                    new AerialStatus ("2018", "Modified", "Two new lanes were added in the median, opened in November 2016." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0172.JPG","20110416_aerial_0172-1050.jpg", "20110416_aerial_0172-2560.jpg", "aerial", 
                    "Bush Turnpike at Hillcrest",
                    "Bush Turnpike at Hillcrest, looking west",
                    "Bush Turnpike at Hillcrest",
                    "Looking west at Hillcrest.",
                    new AerialStatus ("2018", "Modified", "Two new lanes were added in the median, opened in November 2016." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0173.JPG","20110416_aerial_0173-1050.jpg", "20110416_aerial_0173-2560.jpg", "aerial", 
                    "Bush Turnpike at Preston",
                    "Bush Turnpike at Preston, looking west",
                    "Bush Turnpike at Preston",
                    "Looking west at Preston.",
                    new AerialStatus ("2018", "Modified", "Two new lanes were added in the median, opened in November 2016." )),                
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0175.JPG","20110416_aerial_0175-1050.jpg", "20110416_aerial_0175-2560.jpg", "aerial", 
                    "Bush Turnpike at Preston",
                    "Bush Turnpike at Preston, looking west",
                    "Bush Turnpike at Preston",
                    "Looking west at Preston.",
                    new AerialStatus ("2018", "Modified", "Two new lanes were added in the median, opened in November 2016." )),
                new AerialGalleryItem(new DateTime(2005,4,11),"","07_190_looking_e_at_preston_aerial_2005-04-11_7a_900.jpg", "07_190_looking_e_at_preston_aerial_2005-04-11_7a_2166x1600.png", "aerial", 
                    "Bush Turnpike at Preston",
                    "Bush Turnpike at Preston, looking east",
                    "Bush Turnpike at Preston",
                    "Looking east at Preston.",
                    new AerialStatus ("2018", "Modified", "Two new lanes were added in the median, opened in November 2016." )),
                new AerialGalleryItem(new DateTime(2005,4,11),"","06_190_looking_e_at_toll_plaza_aerial_2005-04-11_6a_ADJ_900.jpg", "06_190_looking_e_at_toll_plaza_aerial_2005-04-11_6a_ADJ_2265x1783.png", "aerial", 
                    "Bush Turnpike at Coit",
                    "Bush Turnpike at Coit, looking east",
                    "Bush Turnpike at Coit",
                    "Looking east at Coit.",
                    new AerialStatus ("2015", "Partially obsolete", "The cash lanes at the toll plaza were closed when the plaza became all electronic." )),                
                new AerialGalleryItem(new DateTime(2005,4,11),"","05_190_looking_e_w_of_75_2005-04-11_ADJ_900.jpg", "05_190_looking_e_w_of_75_2005-04-11_ADJ_2244x1483.png", "aerial", 
                    "Bush Turnpike at Custer",
                    "Bush Turnpike at Custer, looking east",
                    "Bush Turnpike at Custer",
                    "Looking east at Custer.",
                    new AerialStatus ("2018", "Modified", "Two new lanes were added in the median, opened in November 2016." ))

            };
        }
    }
}