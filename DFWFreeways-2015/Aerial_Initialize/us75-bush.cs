using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> bush_us75_images()
        {
            return us75_bush_images();
        }

        public static List<AerialGalleryItem> us75_bush_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2005,4,11),"","01_75_looking_n_at_190_2005-04-11_1a_900.jpg", "01_75_looking_n_at_190_2005-04-11_1a_2817x1825.png", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking northeast",
                    "US 75 in Richardson",
                    "Looking northeast at the Bush Turnpike"),
                new AerialGalleryItem(new DateTime(2005,4,11),"","02_75_looking_n_at_190_2005-04-11_2a_900.jpg", "02_75_looking_n_at_190_2005-04-11_2a_2812x1691.png", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking northeast",
                    "US 75 in Richardson",
                    "Looking northeast"),
                new AerialGalleryItem(new DateTime(2005,4,11),"","190_looking_e_at_75_aerial_2005-04-11_6a_900.jpg", "190_looking_e_at_75_aerial_2005-04-11_6a_1956x1419.png", "aerial", 
                    "Bush Turnpike in Richardson",
                    "Bush Turnpike in Richardson, looking east",
                    "Bush Turnpike in Richardson",
                    "Looking east along the Bush Turnpike"),
                new AerialGalleryItem(new DateTime(2005,4,11),"","190_looking_e_at_75_aerial_2005-04-11_7a_ADJ_600.jpg", "190_looking_e_at_75_aerial_2005-04-11_7a_ADJ_1610x2115.png", "aerial", 
                    "Bush Turnpike in Richardson",
                    "Bush Turnpike in Richardson, looking east",
                    "Bush Turnpike in Richardson",
                    "Looking east along the Bush Turnpike"),
                new AerialGalleryItem(new DateTime(2005,4,11),"","190_looking_e_at_75_aerial_2005-04-11_8a_900.jpg", "190_looking_e_at_75_aerial_2005-04-11_8a_2660x1775.png", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking southeast",
                    "US 75 in Richardson",
                    "Looking southeast"),
                new AerialGalleryItem(new DateTime(2005,4,11),"","00_75_looking_n_at_190_2005-04-11_0a_ADJ_600.jpg", "00_75_looking_n_at_190_2005-04-11_0a_ADJ_1814x2250.png", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking north",
                    "US 75 in Richardson",
                    "Looking north along US 75 at the Bush Turnpike"),
                new AerialGalleryItem(new DateTime(2005,4,11),"","75_looking_s_at_190_aerial_2005-04-11_10a_ADJ_900.jpg", "75_looking_s_at_190_aerial_2005-04-11_10a_ADJ_2232x1473.png", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking south",
                    "US 75 in Richardson",
                    "Looking south along US 75 at the Bush Turnpike"),                
                new AerialGalleryItem(new DateTime(2005,4,11),"","75_looking_s_at_190_aerial_2005-04-11_11a_ADJ_600.jpg", "75_looking_s_at_190_aerial_2005-04-11_11a_ADJ_1729x2228.png", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking south",
                    "US 75 in Richardson",
                    "Looking south along US 75 at the Bush Turnpike"),
                new AerialGalleryItem(new DateTime(2005,4,11),"","75_at_northern_telecom_2005-04-11_4a_ADJ_900.jpg", "75_at_northern_telecom_2005-04-11_4a_ADJ_2739x1454.png", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking east",
                    "US 75 in Richardson",
                    "Looking east at Galatyn Parkway"),
                new AerialGalleryItem(new DateTime(2005,4,11),"","75_looking_n_at_190_aerial_2005-04-11_1a_ADJ_900.jpg", "75_looking_n_at_190_aerial_2005-04-11_1a_ADJ_2536x1641.png", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking north",
                    "US 75 in Richardson",
                    "Looking north at Galatyn Parkway"),
                new AerialGalleryItem(new DateTime(2005,4,11),"","75_looking_n_at_190_aerial_2005-04-11_2a_ADJ_900.jpg", "75_looking_n_at_190_aerial_2005-04-11_2a_ADJ_1818x2410.png", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking north-northeast",
                    "US 75 in Richardson",
                    "Looking north-northeast at Galatyn Parkway"),
                new AerialGalleryItem(new DateTime(2005,4,11),"","75_looking_n_at_190_aerial_2005-04-11_3a_900.jpg", "75_looking_n_at_190_aerial_2005-04-11_3a_2744x1781.png", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking northeast",
                    "US 75 in Richardson",
                    "Looking northeast at Galatyn Parkway"),
                new AerialGalleryItem(new DateTime(2009,9,1),"","75n_plano_950.jpg", "75n_plano_1600.jpg", "aerial", 
                    "US 75 in Richardson",
                    "US 75 in Richardson, looking north",
                    "US 75 in Richardson",
                    "Looking north along US 75, north of the Bush Turnpike"),
           
            };
        }
    }
}