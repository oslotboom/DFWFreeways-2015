using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i30_landry_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i30_landry_sh360_images());
            itemList.AddRange(AerialGalleryList.i30_landry_i820_east_images());
            itemList.AddRange(AerialGalleryList.i30_landry_bush_images());
            itemList.AddRange(AerialGalleryList.i30_landry_i35w_images());
            itemList.AddRange(AerialGalleryList.i30_landry_loop12_images());
            itemList.AddRange(AerialGalleryList.i30_landry_stadiums_images());
            itemList.AddRange(AerialGalleryList.i30_landry_trinity_images());
            itemList.AddRange(AerialGalleryList.i30_landry_lone_star_images());
            return itemList;
        }

        public static List<AerialGalleryItem> sh360_i30_images()
        {
            return i30_landry_sh360_images();
        }


        public static List<AerialGalleryItem> i30_landry_sh360_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0351.JPG","20110416_aerial_0351-1050.jpg", "20110416_aerial_0351-2560.jpg", "aerial", 
                    "I-30 at Six Flags and SH 360",
                    "I-30 at Six Flags and SH 360, looking west",
                    "I-30 at Six Flags and SH 360",
                    "Looking west at the SH 360-Six Flags Boulevard intersection.",
                    new AerialStatus ("2015", "Archive", "Construction of a four-level interchange began in 2016." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0352.JPG","20110416_aerial_0352-1050.jpg", "20110416_aerial_0352-2560.jpg", "aerial", 
                    "I-30 at Six Flags and SH 360",
                    "I-30 at Six Flags and SH 360, looking west",
                    "I-30 at Six Flags and SH 360",
                    "Looking west.",
                    new AerialStatus ("2015", "Archive", "Construction of a four-level interchange began in 2016." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0355.JPG","20110416_aerial_0355-1050.jpg", "20110416_aerial_0355-2560.jpg", "aerial", 
                    "I-30 at Six Flags and SH 360",
                    "I-30 at Six Flags and SH 360, looking west",
                    "I-30 at Six Flags and SH 360",
                    "Looking west along I-30.",
                    new AerialStatus ("2015", "Archive", "Construction of a four-level interchange began in 2016." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0356.JPG","20110416_aerial_0356-1050.jpg", "20110416_aerial_0356-2560.jpg", "aerial", 
                    "I-30 at Six Flags and SH 360",
                    "I-30 at Six Flags and SH 360, looking southwest",
                    "I-30 at Six Flags and SH 360",
                    "Looking southwest.",
                    new AerialStatus ("2015", "Archive", "Construction of a four-level interchange began in 2016." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0358.JPG","20110416_aerial_0358-1050.jpg", "20110416_aerial_0358-2560.jpg", "aerial", 
                    "I-30 at Six Flags and SH 360",
                    "I-30 at Six Flags and SH 360, looking southwest",
                    "I-30 at Six Flags and SH 360",
                    "Looking southwest.",
                    new AerialStatus ("2015", "Archive", "Construction of a four-level interchange began in 2016." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0360.JPG","20110416_aerial_0360-1050.jpg", "20110416_aerial_0360-2560.jpg", "aerial", 
                    "I-30 at Six Flags and SH 360",
                    "I-30 at Six Flags and SH 360, looking southwest",
                    "I-30 at Six Flags and SH 360",
                    "Looking southwest.",
                    new AerialStatus ("2015", "Archive", "Construction of a four-level interchange began in 2016." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0362.JPG","20110416_aerial_0362-1050.jpg", "20110416_aerial_0362-2560.jpg", "aerial", 
                    "I-30 at Six Flags and SH 360",
                    "I-30 at Six Flags and SH 360, looking southwest",
                    "I-30 at Six Flags and SH 360",
                    "Looking southwest.",
                    new AerialStatus ("2015", "Archive", "Construction of a four-level interchange began in 2016." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0364.JPG","20110416_aerial_0364-1050.jpg", "20110416_aerial_0364-2560.jpg", "aerial", 
                    "I-30 at Baird Farm Road",
                    "I-30 at Baird Farm Road, looking west",
                    "I-30 at Baird Farm Road",
                    "Looking west at Baird Farm Road with Six Flag Hurricane Harbor in the foreground."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0365.JPG","20110416_aerial_0365-1050.jpg", "20110416_aerial_0365-2560.jpg", "aerial", 
                    "I-30 at Baird Farm Road",
                    "I-30 at Baird Farm Road, looking west",
                    "I-30 at Baird Farm Road",
                    "Looking west at Baird Farm Road."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0368.JPG","20110416_aerial_0368-1050.jpg", "20110416_aerial_0368-2560.jpg", "aerial", 
                    "I-30 in Arlington",
                    "I-30 in Arlington",
                    "I-30 in Arlington",
                    "Looking west with the Collins Road crossing ahead."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0395.JPG","20110416_aerial_0395-1050.jpg", "20110416_aerial_0395-2560.jpg", "aerial", 
                    "Six Flags Over Texas",
                    "Six Flags Over Texas, looking north",
                    "Six Flags Over Texas",
                    "Looking north over Six Flags."),
                 new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0396.JPG","20110416_aerial_0396-1050.jpg", "20110416_aerial_0396-2560.jpg", "aerial", 
                    "Six Flags Over Texas",
                    "Six Flags Over Texas, looking north",
                    "Six Flags Over Texas",
                    "Looking north over Six Flags.")
        
            };
        }



        public static List<AerialGalleryItem> i30_landry_stadiums_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0372.JPG","20110416_aerial_0372-1050.jpg", "20110416_aerial_0372-2560.jpg", "aerial", 
                    "Dallas Cowboys AT&T Stadium",
                    "Dallas Cowboys AT&T Stadium, looking south",
                    "Dallas Cowboys AT&T Stadium",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0376.JPG","20110416_aerial_0376-1050.jpg", "20110416_aerial_0376-2560.jpg", "aerial", 
                    "Dallas Cowboys AT&T Stadium",
                    "Dallas Cowboys AT&T Stadium, looking northeast",
                    "Dallas Cowboys AT&T Stadium",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0378.JPG","20110416_aerial_0378-1050.jpg", "20110416_aerial_0378-2560.jpg", "aerial", 
                    "Dallas Cowboys AT&T Stadium",
                    "Dallas Cowboys AT&T Stadium, looking northeast",
                    "Dallas Cowboys AT&T Stadium",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0380.JPG","20110416_aerial_0380-1050.jpg", "20110416_aerial_0380-2560.jpg", "aerial", 
                    "Dallas Cowboys AT&T Stadium",
                    "Dallas Cowboys AT&T Stadium, looking north",
                    "Dallas Cowboys AT&T Stadium",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0381.JPG","20110416_aerial_0381-1050.jpg", "20110416_aerial_0381-2560.jpg", "aerial", 
                    "Dallas Cowboys AT&T Stadium",
                    "Dallas Cowboys AT&T Stadium, looking north",
                    "Dallas Cowboys AT&T Stadium",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0383.JPG","20110416_aerial_0383-1050.jpg", "20110416_aerial_0383-2560.jpg", "aerial", 
                    "Dallas Cowboys AT&T Stadium",
                    "Dallas Cowboys AT&T Stadium, looking northwest",
                    "Dallas Cowboys AT&T Stadium",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0386.JPG","20110416_aerial_0386-1050.jpg", "20110416_aerial_0386-2560.jpg", "aerial", 
                    "Texas Rangers Ballpark",
                    "Texas Rangers Ballpark, looking north",
                    "Texas Rangers Ballpark",
                    "Looking north.",
                    new AerialStatus ("2022", "Stadium Modified", "The stadium was retired from baseball use with the opening of the retractable-roof Globe Life Field in 2020, which was built in the lower edge of this view. The baseball field is removed and has been replaced with a football field." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0388.JPG","20110416_aerial_0388-1050.jpg", "20110416_aerial_0388-2560.jpg", "aerial", 
                    "Texas Rangers Ballpark",
                    "Texas Rangers Ballpark, looking north",
                    "Texas Rangers Ballpark",
                    "Looking north.",
                    new AerialStatus ("2022", "Stadium Modified", "The stadium was retired from baseball use with the opening of the retractable-roof Globe Life Field in 2020. The baseball field is removed and has been replaced with a football field." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0391.JPG","20110416_aerial_0391-1050.jpg", "20110416_aerial_0391-2560.jpg", "aerial", 
                    "Texas Rangers Ballpark",
                    "Texas Rangers Ballpark, looking northwest",
                    "Texas Rangers Ballpark",
                    "Looking northwest.",
                    new AerialStatus ("2022", "Stadium Modified", "The stadium was retired from baseball use with the opening of the retractable-roof Globe Life Field in 2020. The baseball field is removed and has been replaced with a football field." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0394.JPG","20110416_aerial_0394-1050.jpg", "20110416_aerial_0394-2560.jpg", "aerial", 
                    "Texas Rangers Ballpark",
                    "Texas Rangers Ballpark, looking west",
                    "Texas Rangers Ballpark",
                    "Looking west. In 2017 construction began on the new Rangers stadium on the parking lot just left (south) of the existing stadium.",
                    new AerialStatus ("2022", "Stadium Modified", "The stadium was retired from baseball use with the opening of the retractable-roof Globe Life Field in 2020, which was built in the left side of this view. The baseball field is removed and has been replaced with a football field." ))
         
            };
        }



        public static List<AerialGalleryItem> bush_i30_images()
        {
            return i30_landry_bush_images();
        }

        public static List<AerialGalleryItem> i30_landry_bush_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0338.JPG","20110416_aerial_0338-1050.jpg", "20110416_aerial_0338-2560.jpg", "aerial", 
                    "I-30 at Bush Turnpike",
                    "I-30 at Bush Turnpike, looking south",
                    "I-30 at Bush Turnpike",
                    "Looking south along the Bush Turnpike."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0349.JPG","20110416_aerial_0349-1050.jpg", "20110416_aerial_0349-2560.jpg", "aerial", 
                    "I-30 at Bush Turnpike",
                    "I-30 at Bush Turnpike, looking south",
                    "I-30 at Bush Turnpike",
                    "Looking south along the Bush Turnpike."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0402.JPG","20110416_aerial_0402-1050.jpg", "20110416_aerial_0402-2560.jpg", "aerial", 
                    "I-30 at Bush Turnpike",
                    "I-30 at Bush Turnpike, looking north",
                    "I-30 at Bush Turnpike",
                    "Looking north along the Bush Turnpike."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0405.JPG","20110416_aerial_0405-1050.jpg", "20110416_aerial_0405-2560.jpg", "aerial", 
                    "I-30 at Bush Turnpike",
                    "I-30 at Bush Turnpike, looking north",
                    "I-30 at Bush Turnpike",
                    "Looking north along the Bush Turnpike."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0342.JPG","20110416_aerial_0342-1050.jpg", "20110416_aerial_0342-2560.jpg", "aerial", 
                    "Bush Turnpike north of I-30",
                    "Bush Turnpike north of I-30, looking north",
                    "Bush Turnpike north of I-30",
                    "Looking north along the Bush Turnpike north of I-30. The neighborhood on the left side initiated the lawsuit which lasted 17 years."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0347.JPG","20110416_aerial_0347-1050.jpg", "20110416_aerial_0347-2560.jpg", "aerial", 
                    "Bush Turnpike north of I-30",
                    "Bush Turnpike north of I-30, looking north",
                    "Bush Turnpike north of I-30",
                    "Looking north along the Bush Turnpike north of I-30.")
            };
        }

        public static List<AerialGalleryItem> loop12_i30_images()
        {
            return i30_landry_loop12_images();
        }


        public static List<AerialGalleryItem> i30_landry_loop12_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2011,4,16),"","8_loop12_at_i30_looking_ne_2005-05-30_ADJ_900.jpg", "8_loop12_at_i30_looking_ne_2005-05-30_ADJ_2467x1532.png", "aerial", 
                    "I-30 at Loop12",
                    "I-30 at Loop12, looking northeast",
                    "I-30 at Loop12",
                    "Looking northeast, showing the crazy loop connections that are a vestige of the old Dallas-Fort Worth Turnpike.",
                    new AerialStatus ("2015", "Modified", "The I-30 bridge though the interchange has been rebuilt and widened. Loop 12 in the foreground (lower part of photo) was widened with new lanes in the median." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"","10_i30_looking_e_at_loop12_2005-05-30_ADJ_900.jpg", "10_i30_looking_e_at_loop12_2005-05-30_ADJ_2268x1740.png", "aerial", 
                    "I-30 at Loop12",
                    "I-30 at Loop12, looking east",
                    "I-30 at Loop12",
                    "Looking east.",
                    new AerialStatus ("2015", "Modified", "The I-30 bridge though the interchange has been rebuilt and widened." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"","12_i30_looking_e_at_loop12_2005-05-30_900.jpg", "12_i30_looking_e_at_loop12_2005-05-30_2462x1715.png", "aerial", 
                    "I-30 at Loop12",
                    "I-30 at Loop12, looking east",
                    "I-30 at Loop12",
                    "Looking east.",
                    new AerialStatus ("2015", "Modified", "The I-30 bridge though the interchange has been rebuilt and widened." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"","15_i30_looking_e_w_of_loop12_2005-05-30_ADJ_900.jpg", "15_i30_looking_e_w_of_loop12_2005-05-30_ADJ_2253x1659.png", "aerial", 
                    "I-30 at Loop12",
                    "I-30 at Loop12, looking east",
                    "I-30 at Loop12",
                    "Looking east along I-30, west of the Loop 12 interchange.",
                    new AerialStatus ("2018", "Modified", "HOT lanes were added in the unused concrete in the middle of the freeway." ))

            };
        }


        public static List<AerialGalleryItem> i820_i30_east_images()
        {

            return i30_landry_i820_east_images();

        }

        public static List<AerialGalleryItem> i30_landry_i820_east_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_050.JPG","20090928_ft_worth_050-1050.jpg", "20090928_ft_worth_050-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking northeast",
                    "I-30 at I-820 east",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_052.JPG","20090928_ft_worth_052-1050.jpg", "20090928_ft_worth_052-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking north",
                    "I-30 at I-820 east",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_053.JPG","20090928_ft_worth_053-700.jpg", "20090928_ft_worth_053-1700.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking north",
                    "I-30 at I-820 east",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_054.JPG","20090928_ft_worth_054-1050.jpg", "20090928_ft_worth_054-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking north",
                    "I-30 at I-820 east",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_057.JPG","20090928_ft_worth_057-1050.jpg", "20090928_ft_worth_057-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking north",
                    "I-30 at I-820 east",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_059.JPG","20090928_ft_worth_059-1050.jpg", "20090928_ft_worth_059-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking northwest",
                    "I-30 at I-820 east",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_064.JPG","20090928_ft_worth_064-700.jpg", "20090928_ft_worth_064-1700.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking west",
                    "I-30 at I-820 east",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_066.JPG","20090928_ft_worth_066-1050.jpg", "20090928_ft_worth_066-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking south",
                    "I-30 at I-820 east",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_069.JPG","20090928_ft_worth_069-1050.jpg", "20090928_ft_worth_069-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking southeast",
                    "I-30 at I-820 east",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_072.JPG","20090928_ft_worth_072-1050.jpg", "20090928_ft_worth_072-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking east",
                    "I-30 at I-820 east",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_073.JPG","20090928_ft_worth_073-1050.jpg", "20090928_ft_worth_073-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking east",
                    "I-30 at I-820 east",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_074.JPG","20090928_ft_worth_074-1050.jpg", "20090928_ft_worth_074-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking east",
                    "I-30 at I-820 east",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_075.JPG","20090928_ft_worth_075-700.jpg", "20090928_ft_worth_075-1700.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking east",
                    "I-30 at I-820 east",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_076.JPG","20090928_ft_worth_076-1050.jpg", "20090928_ft_worth_076-2560.jpg", "aerial", 
                    "I-30 at I-820 east",
                    "I-30 at I-820 east, looking east",
                    "I-30 at I-820 east",
                    "Looking east.")

            };
        }

        public static List<AerialGalleryItem> i35w_i30_images()
        {
            return i30_landry_i35w_images();
        }
        public static List<AerialGalleryItem> i30_fort_worth_i35w_images()
        {
            return i30_landry_i35w_images();
        }

        public static List<AerialGalleryItem> i30_landry_i35w_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_018.JPG","20090928_ft_worth_018-1050.jpg", "20090928_ft_worth_018-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking northeast",
                    "I-30 at I-35W",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_020.JPG","20090928_ft_worth_020-1050.jpg", "20090928_ft_worth_020-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking northeast",
                    "I-30 at I-35W",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_022.JPG","20090928_ft_worth_022-1050.jpg", "20090928_ft_worth_022-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking north",
                    "I-30 at I-35W",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_025.JPG","20090928_ft_worth_025-1050.jpg", "20090928_ft_worth_025-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking north",
                    "I-30 at I-35W",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_027.JPG","20090928_ft_worth_027-1050.jpg", "20090928_ft_worth_027-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking north",
                    "I-30 at I-35W",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_029.JPG","20090928_ft_worth_029-1050.jpg", "20090928_ft_worth_029-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking north",
                    "I-30 at I-35W",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_031.JPG","20090928_ft_worth_031-1050.jpg","20090928_ft_worth_031-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking north",
                    "I-30 at I-35W",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_033.JPG","20090928_ft_worth_033-1050.jpg", "20090928_ft_worth_033-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking northwest",
                    "I-30 at I-35W",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_035.JPG","20090928_ft_worth_035-1050.jpg", "20090928_ft_worth_035-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking northwest",
                    "I-30 at I-35W",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_037.JPG","20090928_ft_worth_037-1050.jpg", "20090928_ft_worth_037-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking northwest",
                    "I-30 at I-35W",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_041.JPG","20090928_ft_worth_041-1050.jpg", "20090928_ft_worth_041-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking northwest",
                    "I-30 at I-35W",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_043.JPG","20090928_ft_worth_043-1050.jpg", "20090928_ft_worth_043-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking west",
                    "I-30 at I-35W",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_046.JPG","20090928_ft_worth_046-700.jpg", "20090928_ft_worth_046-1700.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking west",
                    "I-30 at I-35W",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_047.JPG","20090928_ft_worth_047-1050.jpg", "20090928_ft_worth_047-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking west",
                    "I-30 at I-35W",
                    "Looking west."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_048.JPG","20090928_ft_worth_048-1050.jpg", "20090928_ft_worth_048-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking north",
                    "I-30 at I-35W",
                    "Looking north along I-35W.",
                    new AerialStatus ("2018", "Obsolete", "I-35W was rebuilt and expanded during the The North Tarrant Express project, completed in 2019." )),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_289.JPG","20090928_ft_worth_289-1050.jpg", "20090928_ft_worth_289-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking east",
                    "I-30 at I-35W",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_292.JPG","20090928_ft_worth_292-1050.jpg", "20090928_ft_worth_292-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking east",
                    "I-30 at I-35W",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_296.JPG","20090928_ft_worth_296-1050.jpg", "20090928_ft_worth_296-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking northeast",
                    "I-30 at I-35W",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_297.JPG","20090928_ft_worth_297-1050.jpg", "20090928_ft_worth_297-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking northeast",
                    "I-30 at I-35W",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_298.JPG","20090928_ft_worth_298-700.jpg", "20090928_ft_worth_298-1700.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking northeast",
                    "I-30 at I-35W",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_302.JPG","20090928_ft_worth_302-1050.jpg", "20090928_ft_worth_302-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking east",
                    "I-30 at I-35W",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_306.JPG","20090928_ft_worth_306-1050.jpg", "20090928_ft_worth_306-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking east",
                    "I-30 at I-35W",
                    "Looking east."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_310.JPG","20090928_ft_worth_310-1050.jpg", "20090928_ft_worth_310-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking northeast",
                    "I-30 at I-35W",
                    "Looking northeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_314.JPG","20090928_ft_worth_314-1050.jpg", "20090928_ft_worth_314-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking north",
                    "I-30 at I-35W",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_316.JPG","20090928_ft_worth_316-1050.jpg", "20090928_ft_worth_316-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking north",
                    "I-30 at I-35W",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_318.JPG","20090928_ft_worth_318-1050.jpg", "20090928_ft_worth_318-2560.jpg", "aerial", 
                    "I-30 at I-35W",
                    "I-30 at I-35W, looking ",
                    "I-30 at I-35W",
                    "Looking .")


            };
        }

        public static List<AerialGalleryItem> i30_landry_lone_star_images()
        {
            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0337.JPG","20110416_aerial_0337-1050.jpg", "20110416_aerial_0337-2560.jpg", "aerial", 
                    "Lone Star Park horse track",
                    "Lone Star Park horse track, looking south",
                    "Lone Star Park horse track",
                    "Looking south."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0336.JPG","20110416_aerial_0336-1050.jpg", "20110416_aerial_0336-2560.jpg", "aerial", 
                    "Lone Star Park horse track",
                    "Lone Star Park horse track, looking southwest",
                    "Lone Star Park horse track",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0335.JPG","20110416_aerial_0335-1050.jpg", "20110416_aerial_0335-2560.jpg", "aerial", 
                    "Lone Star Park horse track",
                    "Lone Star Park horse track, looking southwest",
                    "Lone Star Park horse track",
                    "Looking southwest.")
            };
        }

        public static List<AerialGalleryItem> i30_landry_trinity_images()
        {
            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2005,5,30),"","21a_i30_downtown_dallas_2005-05-30_900.jpg", "21a_i30_downtown_dallas_2005-05-30_2615x1706.jpg", "aerial", 
                    "I-30 original Trinity River bridge",
                    "I-30 original Trinity River bridge, looking west",
                    "I-30 original Trinity River bridge",
                    "Looking west.",
                    new AerialStatus ("2018", "Historical Archive", "A new, wider bridge was built 2014-2017. The bridge shown in this photo was demolished. Reunion Arena, visible on the right side in the center, was demolished in 2009." )),
                new AerialGalleryItem(new DateTime(2005,5,30),"", "22a_i30_downtown_dallas_2005-05-30_900.jpg","22a_i30_downtown_dallas_2005-05-30_2649x1449.png", "aerial", 
                    "I-30 original Trinity River bridge",
                    "I-30 original Trinity River bridge, looking west",
                    "I-30 original Trinity River bridge",
                    "Looking west.",
                    new AerialStatus ("2018", "Historical Archive", "A new, wider bridge was built 2014-2017. The bridge shown in this photo was demolished." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0446.JPG", "20110416_aerial_0446-1050.jpg","20110416_aerial_0446-2560.jpg", "aerial", 
                    "I-30 original Trinity River bridge",
                    "I-30 original Trinity River bridge, looking west",
                    "I-30 original Trinity River bridge",
                    "Looking west.",
                    new AerialStatus ("2018", "Historical Archive", "A new, wider bridge was built 2014-2017. The bridge shown in this photo was demolished." )),
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0443.JPG", "20110416_aerial_0443-1050.jpg","20110416_aerial_0443-2560.jpg", "aerial", 
                    "I-30 at Hampton",
                    "I-30 at Hampton, looking east",
                    "I-30 at Hampton",
                    "Looking east along I-30 at Hampton"),
            };
        }



    }

}