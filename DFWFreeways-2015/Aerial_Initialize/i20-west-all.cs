using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i20_west_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i20_west_i35w_images());
            itemList.AddRange(AerialGalleryList.i20_west_fort_worth_images());
            itemList.AddRange(AerialGalleryList.i20_west_i820_images());
            return itemList;
        }


        public static List<AerialGalleryItem> i35w_i20_images()
        {
            return i20_west_i35w_images();
        }

        public static List<AerialGalleryItem> i20_west_i35w_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_099.JPG","20090928_ft_worth_099-700.jpg", "20090928_ft_worth_099-1700.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking south",
                    "I-20 at I-35W south Fort Worth",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_101.JPG","20090928_ft_worth_101-1050.jpg", "20090928_ft_worth_101-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking southeast",
                    "I-20 at I-35W south Fort Worth",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_105.JPG","20090928_ft_worth_105-1050.jpg", "20090928_ft_worth_105-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking east",
                    "I-20 at I-35W south Fort Worth",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_107.JPG","20090928_ft_worth_107-1050.jpg", "20090928_ft_worth_107-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking east",
                    "I-20 at I-35W south Fort Worth",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_110.JPG","20090928_ft_worth_110-1050.jpg", "20090928_ft_worth_110-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking east",
                    "I-20 at I-35W south Fort Worth",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_112.JPG","20090928_ft_worth_112-1050.jpg", "20090928_ft_worth_112-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking east",
                    "I-20 at I-35W south Fort Worth",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_115.JPG","20090928_ft_worth_115-1050.jpg", "20090928_ft_worth_115-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking northeast",
                    "I-20 at I-35W south Fort Worth",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_118.JPG","20090928_ft_worth_118-1050.jpg", "20090928_ft_worth_118-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking northeast",
                    "I-20 at I-35W south Fort Worth",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_121.JPG","20090928_ft_worth_121-1050.jpg", "20090928_ft_worth_121-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking northeast",
                    "I-20 at I-35W south Fort Worth",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_124.JPG","20090928_ft_worth_124-1050.jpg", "20090928_ft_worth_124-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking north",
                    "I-20 at I-35W south Fort Worth",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_128.JPG","20090928_ft_worth_128-700.jpg", "20090928_ft_worth_128-1700.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking north",
                    "I-20 at I-35W south Fort Worth",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_134.JPG","20090928_ft_worth_134-700.jpg", "20090928_ft_worth_134-1700.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking north",
                    "I-20 at I-35W south Fort Worth",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_135.JPG","20090928_ft_worth_135-1050.jpg", "20090928_ft_worth_135-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking north",
                    "I-20 at I-35W south Fort Worth",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_138.JPG","20090928_ft_worth_138-1050.jpg", "20090928_ft_worth_138-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking north",
                    "I-20 at I-35W south Fort Worth",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_140.JPG","20090928_ft_worth_140-1050.jpg", "20090928_ft_worth_140-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking north",
                    "I-20 at I-35W south Fort Worth",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_142.JPG","20090928_ft_worth_142-1050.jpg", "20090928_ft_worth_142-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking north",
                    "I-20 at I-35W south Fort Worth",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_144.JPG","20090928_ft_worth_144-700.jpg", "20090928_ft_worth_144-1700.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking north",
                    "I-20 at I-35W south Fort Worth",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_149.JPG","20090928_ft_worth_149-1050.jpg", "20090928_ft_worth_149-2560.jpg", "aerial", 
                    "I-20 at I-35W",
                    "I-20 at I-35W south Fort Worth, looking north",
                    "I-20 at I-35W south Fort Worth",
                    "Looking north.")
            
            };
        }


        public static List<AerialGalleryItem> chisholm_trail_parkway_fort_worth_images()
        {
            return i20_west_fort_worth_images();
        }
        public static List<AerialGalleryItem> i20_west_fort_worth_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_161.JPG","20090928_ft_worth_161-1050.jpg", "20090928_ft_worth_161-2560.jpg", "aerial", 
                    "I-20 at SH 183",
                    "I-20 at SH 183, looking northwest",
                    "I-20 at SH 183",
                    "Looking northwest.",
                    new AerialStatus ("2015", "Obsolete", "The Chisholm Trail Parkway main lanes and interchange opened at this location in 2014." )),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_164.JPG","20090928_ft_worth_164-700.jpg", "20090928_ft_worth_164-1700.jpg", "aerial", 
                    "I-20 at SH 183",
                    "I-20 at SH 183, looking northwest",
                    "I-20 at SH 183",
                    "Looking northwest along SH 183.",
                    new AerialStatus ("2015", "Obsolete", "The Chisholm Trail Parkway main lanes and interchange opened at this location in 2014." )),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_165.JPG","20090928_ft_worth_165-1050.jpg", "20090928_ft_worth_165-2560.jpg", "aerial", 
                    "I-20 at SH 183",
                    "I-20 at SH 183, looking northwest",
                    "I-20 at SH 183",
                    "Looking northwest along SH 183.",
                    new AerialStatus ("2015", "Obsolete", "The Chisholm Trail Parkway main lanes and interchange opened at this location in 2014." )),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_158.JPG","20090928_ft_worth_158-700.jpg", "20090928_ft_worth_158-1700.jpg", "aerial", 
                    "I-20 in south Fort worth",
                    "I-20 in south Fort worth, looking east",
                    "I-20 in south Fort worth",
                    "Looking east at Trail Lake Drive."),
          
            };
        }


        public static List<AerialGalleryItem> i820_i20_images()
        {
            return i20_west_i820_images();
        }

        public static List<AerialGalleryItem> i20_west_i820_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_167.JPG","20090928_ft_worth_167-1050.jpg", "20090928_ft_worth_167-2560.jpg", "aerial", 
                    "I-20 at I-820 west",
                    "I-20 at I-820 west, looking west",
                    "I-20 at I-820 west",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_169.JPG","20090928_ft_worth_169-1050.jpg", "20090928_ft_worth_169-2560.jpg", "aerial", 
                    "I-20 at I-820 west",
                    "I-20 at I-820 west, looking west",
                    "I-20 at I-820 west",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_170.JPG","20090928_ft_worth_170-1050.jpg", "20090928_ft_worth_170-2560.jpg", "aerial", 
                    "I-20 at I-820 west",
                    "I-20 at I-820 west, looking south",
                    "I-20 at I-820 west",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_172.JPG","20090928_ft_worth_172-1050.jpg", "20090928_ft_worth_172-2560.jpg", "aerial", 
                    "I-20 at I-820 west",
                    "I-20 at I-820 west, looking southeast",
                    "I-20 at I-820 west",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_174.JPG","20090928_ft_worth_174-1050.jpg", "20090928_ft_worth_174-2560.jpg", "aerial", 
                    "I-20 at I-820 west",
                    "I-20 at I-820 west, looking east",
                    "I-20 at I-820 west",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_176.JPG","20090928_ft_worth_176-1050.jpg", "20090928_ft_worth_176-2560.jpg", "aerial", 
                    "I-20 at I-820 west",
                    "I-20 at I-820 west, looking east",
                    "I-20 at I-820 west",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_182.JPG","20090928_ft_worth_182-1050.jpg", "20090928_ft_worth_182-2560.jpg", "aerial", 
                    "I-20 at I-820 west",
                    "I-20 at I-820 west, looking north",
                    "I-20 at I-820 west",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_185.JPG","20090928_ft_worth_185-1050.jpg", "20090928_ft_worth_185-2560.jpg", "aerial", 
                    "I-20 at I-820 west",
                    "I-20 at I-820 west, looking north",
                    "I-20 at I-820 west",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_188.JPG","20090928_ft_worth_188-1050.jpg", "20090928_ft_worth_188-2560.jpg", "aerial", 
                    "I-20 at I-820 west",
                    "I-20 at I-820 west, looking north",
                    "I-20 at I-820 west",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_191.JPG","20090928_ft_worth_191-1050.jpg", "20090928_ft_worth_191-2560.jpg", "aerial", 
                    "I-20 at I-820 west",
                    "I-20 at I-820 west, looking northwest",
                    "I-20 at I-820 west",
                    "Looking northwest.")          
            };
        }


    }
}