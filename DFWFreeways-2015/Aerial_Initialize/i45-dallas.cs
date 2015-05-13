using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DFWFreeways.Models;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> i45_dallas_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0458.JPG","20110416_aerial_0458-1050.jpg", "20110416_aerial_0458-2560.jpg", "aerial", 
                    "I-45 area",
                    "I-45 area looking northwest",
                    "I-45",
                    "Looking northwest. I-45 is toward the right of this photo. "),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0460.JPG","20110416_aerial_0460-1050.jpg", "20110416_aerial_0460-2560.jpg", "aerial", 
                    "I-45",
                    "I-45 looking north",
                    "I-45",
                    "Looking north near South Lamar."),  
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0464.JPG","20110416_aerial_0464-1050.jpg", "20110416_aerial_0464-2560.jpg", "aerial", 
                    "I-45",
                    "I-45 looking northwest",
                    "I-45",
                    "Looking northwest north of South Lamar. "),            
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0466.JPG","20110416_aerial_0466-1050.jpg", "20110416_aerial_0466-2560.jpg", "aerial", 
                    "I-45",
                    "I-45 looking northwest",
                    "I-45",
                    "Looking northwest north of South Lamar. "),            
                new AerialGalleryItem(new DateTime(2005,5,30),"","29a_i45_at_trinity_looking_n_2005-05-30_ADJ_900.jpg", "29a_i45_at_trinity_looking_n_2005-05-30_ADJ_2022x1704.png", "aerial", 
                    "I-45",
                    "I-45 looking northwest",
                    "I-45",
                    "Looking northwest with the Trinity River bridge ahead."),            
                new AerialGalleryItem(new DateTime(2005,5,30),"","30a_i45_at_trinity_looking_n_2005-05-30_ADJ_900.jpg", "30a_i45_at_trinity_looking_n_2005-05-30_ADJ_2425x1790.png", "aerial", 
                    "I-45",
                    "I-45 looking ",
                    "I-45",
                    "Looking . "),            
                new AerialGalleryItem(new DateTime(2005,5,30),"","33a_i45_at_loop12_looking_s_2005-05-30_900.jpg", "33a_i45_at_loop12_looking_s_2005-05-30_2531x1821.png", "aerial", 
                    "I-45",
                    "I-45 looking southeast",
                    "I-45",
                    "Looking southeast at Loop 12."),            
                new AerialGalleryItem(new DateTime(2005,5,30),"","34a_i45_at_loop12_looking_s_2005-05-30_900.jpg", "34a_i45_at_loop12_looking_s_2005-05-30_2569x1706.png", "aerial", 
                    "I-45",
                    "I-45 looking southeast",
                    "I-45",
                    "Looking . "),            
                new AerialGalleryItem(new DateTime(2005,5,30),"","28a_i45_at_loop9_looking_n_2005-05-30_900.jpg", "28a_i45_at_loop9_looking_n_2005-05-30_2546x1821.png", "aerial", 
                    "I-45",
                    "I-45 looking northwest",
                    "I-45",
                    "Looking northwest south of Loop 12."),            
                new AerialGalleryItem(new DateTime(2005,5,30),"","26a_i45_n_of_i20_looking_s_2005-05-30_900.jpg", "26a_i45_n_of_i20_looking_s_2005-05-30_1714x1658.png", "aerial", 
                    "I-45",
                    "I-45 looking southeast",
                    "I-45",
                    "Looking southeast north of I20."),          
                new AerialGalleryItem(new DateTime(2005,5,30),"","27a_i45_n_of_i20_looking_s_2005-05-30_900.jpg", "27a_i45_n_of_i20_looking_s_2005-05-30_2159x1821.png", "aerial", 
                    "I-45",
                    "I-45 looking south",
                    "I-45",
                    "Looking south north of I-20.")    
            };
        }
    }
}