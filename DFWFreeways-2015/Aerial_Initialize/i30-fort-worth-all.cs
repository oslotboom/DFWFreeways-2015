﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i30_fort_worth_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i30_fort_worth_downtown_images());
            itemList.AddRange(AerialGalleryList.i30_fort_worth_i35w_images()); 
            itemList.AddRange(AerialGalleryList.i30_fort_worth_arlington_images());
            itemList.AddRange(AerialGalleryList.i30_fort_worth_i820_images());
            return itemList;
        }


        public static List<AerialGalleryItem> i30_fort_worth_downtown_images()
        {
            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_001.JPG","20090928_ft_worth_001-1050.jpg", "20090928_ft_worth_001-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking south",
                    "I-30 downtown Fort Worth",
                    "Looking south"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_003.JPG","20090928_ft_worth_003-1050.jpg", "20090928_ft_worth_003-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking southeast",
                    "I-30 downtown Fort Worth",
                    "Looking southeast"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_004.JPG","20090928_ft_worth_004-1050.jpg", "20090928_ft_worth_004-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking east",
                    "I-30 downtown Fort Worth",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_005.JPG","20090928_ft_worth_005-1050.jpg", "20090928_ft_worth_005-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking east",
                    "I-30 downtown Fort Worth",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_006.JPG","20090928_ft_worth_006-1050.jpg", "20090928_ft_worth_006-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking northeast",
                    "I-30 downtown Fort Worth",
                    "Looking northeast"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_008.JPG","20090928_ft_worth_008-1050.jpg", "20090928_ft_worth_008-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking northeast",
                    "I-30 downtown Fort Worth",
                    "Looking northeast"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_012.JPG","20090928_ft_worth_012-1050.jpg", "20090928_ft_worth_012-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking northeast",
                    "I-30 downtown Fort Worth",
                    "Looking northeast"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_014.JPG","20090928_ft_worth_014-1050.jpg", "20090928_ft_worth_014-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking northeast",
                    "I-30 downtown Fort Worth",
                    "Looking northeast"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_015.JPG","20090928_ft_worth_015-1050.jpg", "20090928_ft_worth_015-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking north",
                    "I-30 downtown Fort Worth",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_016.JPG","20090928_ft_worth_016-1050.jpg", "20090928_ft_worth_016-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking north",
                    "I-30 downtown Fort Worth",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_282.JPG","20090928_ft_worth_282-1050.jpg", "20090928_ft_worth_282-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking ",
                    "I-30 downtown Fort Worth",
                    "Looking east along Lancaster, the original path of I-30 through downtown Fort Worth"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_285.JPG","20090928_ft_worth_285-1050.jpg", "20090928_ft_worth_285-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking ",
                    "I-30 downtown Fort Worth",
                    "Looking east along Lancaster, the original path of I-30 through downtown Fort Worth"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_289.JPG","20090928_ft_worth_289-1050.jpg", "20090928_ft_worth_289-2560.jpg", "aerial", 
                    "I-30 downtown Fort Worth",
                    "I-30 downtown Fort Worth, looking east",
                    "I-30 downtown Fort Worth",
                    "Looking east")

            };
        }


        public static List<AerialGalleryItem> i30_fort_worth_arlington_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_265.JPG","20090928_ft_worth_265-1050.jpg", "20090928_ft_worth_265-2560.jpg", "aerial", 
                    "I-30 west Fort Worth",
                    "I-30 west Fort Worth, looking east",
                    "I-30 west Fort Worth",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_268.JPG","20090928_ft_worth_268-1050.jpg", "20090928_ft_worth_268-2560.jpg", "aerial", 
                    "I-30 west Fort Worth",
                    "I-30 west Fort Worth, looking east",
                    "I-30 west Fort Worth",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_270.JPG","20090928_ft_worth_270-1050.jpg", "20090928_ft_worth_270-2560.jpg", "aerial", 
                    "I-30 west Fort Worth",
                    "I-30 west Fort Worth, looking east",
                    "I-30 west Fort Worth",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_271.JPG","20090928_ft_worth_271-1050.jpg", "20090928_ft_worth_271-2560.jpg", "aerial", 
                    "I-30 west Fort Worth",
                    "I-30 west Fort Worth, looking east",
                    "I-30 west Fort Worth",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_276.JPG","20090928_ft_worth_276-1050.jpg", "20090928_ft_worth_276-2560.jpg", "aerial", 
                    "I-30 west Fort Worth",
                    "I-30 west Fort Worth, looking east",
                    "I-30 west Fort Worth",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_279.JPG","20090928_ft_worth_279-1050.jpg", "20090928_ft_worth_279-2560.jpg", "aerial", 
                    "I-30 west Fort Worth",
                    "I-30 west Fort Worth, looking east",
                    "I-30 west Fort Worth",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_259.JPG","20090928_ft_worth_259-1050.jpg", "20090928_ft_worth_259-2560.jpg", "aerial", 
                    "I-30 at Joint Reserve Base",
                    "I-30 at Joint Reserve Base, looking north",
                    "I-30 at Joint Reserve Base",
                    "Looking north at the Joint Reserve Base runway, on the north side of I-30"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_260.JPG","20090928_ft_worth_260-1050.jpg", "20090928_ft_worth_260-2560.jpg", "aerial", 
                    "I-30 at Joint Reserve Base",
                    "I-30 at Joint Reserve Base, looking north",
                    "I-30 at Joint Reserve Base",
                    "Looking north at the Joint Reserve Base runway, on the north side of I-30"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_262.JPG","20090928_ft_worth_262-1050.jpg", "20090928_ft_worth_262-2560.jpg", "aerial", 
                    "I-30 at Joint Reserve Base",
                    "I-30 at Joint Reserve Base, looking north",
                    "I-30 at Joint Reserve Base",
                    "Looking north at the Joint Reserve Base runway, on the north side of I-30"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_264.JPG","20090928_ft_worth_264-1050.jpg", "20090928_ft_worth_264-2560.jpg", "aerial", 
                    "I-30 at Joint Reserve Base",
                    "I-30 at Joint Reserve Base, looking north",
                    "I-30 at Joint Reserve Base",
                    "Looking north at the Joint Reserve Base runway, on the north side of I-30")

            };
        }

        public static List<AerialGalleryItem> i820_i30_west_images()
        {
            return i30_fort_worth_i820_images();
        }

        public static List<AerialGalleryItem> i30_fort_worth_i820_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_194.JPG","20090928_ft_worth_194-1050.jpg", "20090928_ft_worth_194-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking northwest",
                    "I-30 at I-820",
                    "Looking northwest"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_198.JPG","20090928_ft_worth_198-1050.jpg", "20090928_ft_worth_198-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking northwest",
                    "I-30 at I-820",
                    "Looking northwest"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_200.JPG","20090928_ft_worth_200-1050.jpg", "20090928_ft_worth_200-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking west",
                    "I-30 at I-820",
                    "Looking west"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_201.JPG","20090928_ft_worth_201-700.jpg", "20090928_ft_worth_201-1700.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking west",
                    "I-30 at I-820",
                    "Looking west"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_203.JPG","20090928_ft_worth_203-1050.jpg", "20090928_ft_worth_203-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking south",
                    "I-30 at I-820",
                    "Looking south"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_206.JPG","20090928_ft_worth_206-1050.jpg", "20090928_ft_worth_206-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking southeast",
                    "I-30 at I-820",
                    "Looking southeast"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_209.JPG","20090928_ft_worth_209-1050.jpg", "20090928_ft_worth_209-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking east",
                    "I-30 at I-820",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_211.JPG","20090928_ft_worth_211-700.jpg", "20090928_ft_worth_211-1700.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking east",
                    "I-30 at I-820",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_216.JPG","20090928_ft_worth_216-1050.jpg", "20090928_ft_worth_216-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking northeast",
                    "I-30 at I-820",
                    "Looking northeast"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_221.JPG","20090928_ft_worth_221-1050.jpg", "20090928_ft_worth_221-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking north",
                    "I-30 at I-820",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_224.JPG","20090928_ft_worth_224-1050.jpg", "20090928_ft_worth_224-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking north",
                    "I-30 at I-820",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_227.JPG","20090928_ft_worth_227-1050.jpg", "20090928_ft_worth_227-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking northwest",
                    "I-30 at I-820",
                    "Looking northwest"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_228.JPG","20090928_ft_worth_228-1050.jpg", "20090928_ft_worth_228-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking northwest",
                    "I-30 at I-820",
                    "Looking northwest"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_229.JPG","20090928_ft_worth_229-1050.jpg", "20090928_ft_worth_229-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking southwest",
                    "I-30 at I-820",
                    "Looking southwest"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_234.JPG","20090928_ft_worth_234-1050.jpg", "20090928_ft_worth_234-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking southeast",
                    "I-30 at I-820",
                    "Looking southeast"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_235.JPG","20090928_ft_worth_235-1050.jpg", "20090928_ft_worth_235-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking east",
                    "I-30 at I-820",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_237.JPG","20090928_ft_worth_237-1050.jpg", "20090928_ft_worth_237-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking east",
                    "I-30 at I-820",
                    "Looking east"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_240.JPG","20090928_ft_worth_240-1050.jpg", "20090928_ft_worth_240-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking northeast",
                    "I-30 at I-820",
                    "Looking northeast"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_246.JPG","20090928_ft_worth_246-1050.jpg", "20090928_ft_worth_246-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking north",
                    "I-30 at I-820",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_249.JPG","20090928_ft_worth_249-1050.jpg", "20090928_ft_worth_249-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking north",
                    "I-30 at I-820",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_253.JPG","20090928_ft_worth_253-700.jpg", "20090928_ft_worth_253-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking north",
                    "I-30 at I-820",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_254.JPG","20090928_ft_worth_254-1050.jpg", "20090928_ft_worth_254-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking north",
                    "I-30 at I-820",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_257.JPG","20090928_ft_worth_257-1050.jpg", "20090928_ft_worth_257-2560.jpg", "aerial", 
                    "I-30 at I-820",
                    "I-30 at I-820, looking northwest",
                    "I-30 at I-820",
                    "Looking northwest")
            };
        }

    }




}


                    //new AerialStatus ("2015", "Obsolete", "The North Tarrant Express included additional construction at this interchange, in progress in 2015." )