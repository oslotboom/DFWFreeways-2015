using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {
        public static List<AerialGalleryItem> dnt_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.dnt_park_cities_images());
            itemList.AddRange(AerialGalleryList.dnt_loop12_images());
            itemList.AddRange(AerialGalleryList.dnt_i635_images());
            itemList.AddRange(AerialGalleryList.dnt_addison_images());
            itemList.AddRange(AerialGalleryList.dnt_bush_images());
            itemList.AddRange(AerialGalleryList.dnt_plano_images());
            itemList.AddRange(AerialGalleryList.dnt_sh121_images());
            
            return itemList;
        }

        public static List<AerialGalleryItem> dnt_addison_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0249.JPG","20090623_aerial_0249-1050.jpg", "20090623_aerial_0249-2560.jpg", "aerial", 
                    "Galleria complex on the east side of the tollway",
                    "Galleria complex on the east side of the tollway, looking southwest",
                    "Dallas North Tollway in Addison",
                    "Looking southwest at the Galleria Dallas complex."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0255.JPG","20090623_aerial_0255-1050.jpg", "20090623_aerial_0255-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking south",
                    "Dallas North Tollway in Addison",
                    "Looking south at Spring Valley."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0259.JPG","20090623_aerial_0259-1050.jpg", "20090623_aerial_0259-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking south",
                    "Dallas North Tollway in Addison",
                    "Looking south at Spring Valley."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0261.JPG","20090623_aerial_0261-1050.jpg", "20090623_aerial_0261-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking north",
                    "Dallas North Tollway in Addison",
                    "Looking north at Arapaho."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0262.JPG","20090623_aerial_0262-1050.jpg", "20090623_aerial_0262-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking north",
                    "Dallas North Tollway in Addison",
                    "Looking north at Arapaho."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0263.JPG","20090623_aerial_0263-1050.jpg", "20090623_aerial_0263-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking northwest",
                    "Dallas North Tollway in Addison",
                    "Looking northwest.",
                    new AerialStatus ("2015", "Partially obsolete", "The toll plaza was removed when NTTA switched to all-electronic toll collection." )),

                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0264.JPG","20090623_aerial_0264-1050.jpg", "20090623_aerial_0264-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking northwest",
                    "Dallas North Tollway in Addison",
                    "Looking northwest at the Mark Kay headquarters. I worked there as a contractor in 2014."),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0266.JPG","20090623_aerial_0266-1050.jpg", "20090623_aerial_0266-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking northwest",
                    "Dallas North Tollway in Addison",
                    "Looking northwest at the Mary Kay building.",
                    new AerialStatus ("2015", "Partially obsolete", "The pool and fountain in front of the building have been removed." )),

                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0267.JPG","20090623_aerial_0267-1050.jpg", "20090623_aerial_0267-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking west",
                    "Dallas North Tollway in Addison",
                    "Looking west at the Mark Kay building.",
                    new AerialStatus ("2015", "Partially obsolete", "The pool and fountain in front of the building have been removed." )),
                new AerialGalleryItem(new DateTime(2009,6,23),"20090623_aerial_0268.JPG","20090623_aerial_0268-1050.jpg", "20090623_aerial_0268-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking southwest",
                    "Dallas North Tollway in Addison",
                    "Looking southwest.",
                    new AerialStatus ("2015", "Partially obsolete", "The pool and fountain in front of the building have been removed." )),

                new AerialGalleryItem(new DateTime(2009,6,17),"20090617_aerial_0080.JPG","20090617_aerial_0080-1050.jpg", "20090617_aerial_0080-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking southeast",
                    "Dallas North Tollway in Addison",
                    "Looking southeast south of Trinity Mills."),
                new AerialGalleryItem(new DateTime(2009,6,17),"20090617_aerial_0076.JPG","20090617_aerial_0076-1050.jpg", "20090617_aerial_0076-2560.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking northwest",
                    "Dallas North Tollway in Addison",
                    "Looking northwest across the Addison Circle complex."),
                new AerialGalleryItem(new DateTime(2009,6,17),"20090617_aerial_0074.JPG","20090617_aerial_0074-1050.jpg", "20090617_aerial_0074-2650.jpg", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking north",
                    "Dallas North Tollway in Addison",
                    "Looking north at Arapaho.",
                    new AerialStatus ("2015", "Partially obsolete", "The toll plaza was removed when NTTA switched to all-electronic toll collection." )),

                new AerialGalleryItem(new DateTime(2005,4,11),"","24_dnt_looking_n_at_spring_valley_2005-04-11_ADJ_900.jpg", "24_dnt_looking_n_at_spring_valley_2005-04-11_ADJ_1747x1701.png", "aerial", 
                    "Dallas North Tollway",
                    "Dallas North Tollway, looking north",
                    "Dallas North Tollway",
                    "Looking north at Spring Valley, with the Addison Airport runway visible."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","17a_dnt_looking_s_at_alpha_2005-04-11_900.jpg", "17a_dnt_looking_s_at_alpha_2005-04-11_2729x1714.png", "aerial", 
                    "Dallas North Tollway",
                    "Dallas North Tollway, looking south",
                    "Dallas North Tollway",
                    "Looking south at Alpha."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","18_dnt_looking_s_at_southern_2005-04-11_ADJ_900.jpg", "18_dnt_looking_s_at_southern_2005-04-11_ADJ_2572x1658.png", "aerial", 
                    "Dallas North Tollway",
                    "Dallas North Tollway, looking south",
                    "Dallas North Tollway",
                    "Looking south, south of Spring Valley."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","19_dnt_looking_s_at_belt_line_2005-04-11_900.jpg", "19_dnt_looking_s_at_belt_line_2005-04-11_2159x1653.png", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking south",
                    "Dallas North Tollway in Addison",
                    "Looking south at Belt Line."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","20_dnt_looking_s_at_belt_line_2005-04-11_900.jpg", "20_dnt_looking_s_at_belt_line_2005-04-11_2321x1823.png", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking south",
                    "Dallas North Tollway in Addison",
                    "Looking south at Belt Line."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","21_dnt_looking_s_at_arapahoe_2005-04-11_ADJ_600.jpg", "21_dnt_looking_s_at_arapahoe_2005-04-11_ADJ_1729x2743.png", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking south",
                    "Dallas North Tollway in Addison",
                    "Looking south at Belt Line."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","22_prestonwood_mall_location_2005-04-11_ADJ_900.jpg", "22_prestonwood_mall_location_2005-04-11_ADJ_2812x1782.png", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking ",
                    "Dallas North Tollway in Addison",
                    "This is the location of the former Prestonwood Town Center Mall in April 2005, looking south. Demolition of the mall was complete and site work was underway for redevelopment. The outline of the Walmart Supercenter can be seen in the foreground. It opened in January 2006. The south half of the property became a retail strip center, opening soon after the Walmart."),
                new AerialGalleryItem(new DateTime(2005,4,11),"","23_prestonwood_mall_location_looking_n_2005-04-11_900.jpg", "23_prestonwood_mall_location_looking_n_2005-04-11_2799x1836.png", "aerial", 
                    "Dallas North Tollway in Addison",
                    "Dallas North Tollway in Addison, looking north",
                    "Dallas North Tollway in Addison",
                    "Looking north across the site of the former Prestonwood Town Center Mall, which was demolished.")

            
            };
        }
    }
}