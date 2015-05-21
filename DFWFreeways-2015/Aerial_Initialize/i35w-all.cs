using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i35w_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.i35w_i20_images());
            itemList.AddRange(AerialGalleryList.i35w_i30_images());
            itemList.AddRange(AerialGalleryList.i35w_i820_images());
            itemList.AddRange(AerialGalleryList.i35w_alliance_images());
            itemList.AddRange(AerialGalleryList.i35w_texas_motor_speedway_images());
            return itemList;
        }


        public static List<AerialGalleryItem> i820_i35w_images()
        {
            return i35w_i820_images();
        }

        public static List<AerialGalleryItem> i35w_i820_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2011,10,29),"0111029_fw_1271.JPG","20111029_fw_1271-1050.jpg", "20111029_fw_1271-2560.jpg", "aerial", 
                    "I-35W at I-820",
                    "I-35W at I-820, looking northeast",
                    "I-35W at I-820",
                    "Looking northeast",
                    new AerialStatus ("2015", "Obsolete", "The North Tarrant Express included additional construction at this interchange, in progress in 2015." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1278.JPG","20111029_fw_1278-1050.jpg", "20111029_fw_1278-2560.jpg", "aerial", 
                    "I-35W at I-820",
                    "I-35W at I-820, looking north",
                    "I-35W at I-820",
                    "Looking north",
                    new AerialStatus ("2015", "Obsolete", "The North Tarrant Express included additional construction at this interchange, in progress in 2015." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1279.JPG","20111029_fw_1279-1050.jpg", "20111029_fw_1279-2560.jpg", "aerial", 
                    "I-35W at I-820",
                    "I-35W at I-820, looking north",
                    "I-35W at I-820",
                    "Looking north",
                    new AerialStatus ("2015", "Obsolete", "The North Tarrant Express included additional construction at this interchange, in progress in 2015." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1286.JPG","20111029_fw_1286-1050.jpg", "20111029_fw_1286-2560.jpg", "aerial", 
                    "I-35W at I-820",
                    "I-35W at I-820, looking west",
                    "I-35W at I-820",
                    "Looking west along Loop 820",
                    new AerialStatus ("2015", "Obsolete", "The North Tarrant Express included additional construction at this interchange, in progress in 2015." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1291.JPG","20111029_fw_1291-1050.jpg", "20111029_fw_1291-2560.jpg", "aerial", 
                    "I-35W at I-820",
                    "I-35W at I-820, looking west",
                    "I-35W at I-820",
                    "Looking west",
                    new AerialStatus ("2015", "Obsolete", "The North Tarrant Express included additional construction at this interchange, in progress in 2015." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1295.JPG","20111029_fw_1295-1050.jpg", "20111029_fw_1295-2560.jpg", "aerial", 
                    "I-35W at the US 287 split",
                    "I-35W at the US 287 split, looking northwest",
                    "I-35W at the US 287 split",
                    "Looking northwest at the I-35W/US 287 interchange.",
                    new AerialStatus ("2015", "Obsolete", "This interchange was widened and reconfigured by the North Tarrant Express project." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1303.JPG","20111029_fw_1303-1050.jpg", "20111029_fw_1303-2560.jpg", "aerial", 
                    "I-35W at the US 287 split",
                    "I-35W at the US 287 split, looking northwest",
                    "I-35W at the US 287 split",
                    "Looking northwest at the I-35W/US 287 interchange.",
                    new AerialStatus ("2015", "Obsolete", "This interchange was widened and reconfigured by the North Tarrant Express project." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"","", "", "aerial", 
                    "I-820 at Business 287",
                    "I-820 at Business 287, looking east",
                    "I-820 at Business 287",
                    "I-820 at Business 287, looking east. (Two miles west of the I-35W/I-820 interchange).")
            };
        }

        public static List<AerialGalleryItem> i35w_alliance_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1317.JPG","20111029_fw_1317-1050.jpg", "20111029_fw_1317-2560.jpg", "aerial", 
                    "I-35W at Alliance Airport",
                    "I-35W at Alliance Airport, looking north",
                    "I-35W at Alliance Airport",
                    "Looking north",
                    new AerialStatus ("2015", "Partially obsolete", "The North Tarrant Express added new lanes in this section, with work in progress in 2015." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1322.JPG","20111029_fw_1322-1050.jpg", "20111029_fw_1322-2560.jpg", "aerial", 
                    "I-35W at Alliance Airport",
                    "I-35W at Alliance Airport, looking north",
                    "I-35W at Alliance Airport",
                    "Looking north",
                    new AerialStatus ("2015", "Partially obsolete", "The North Tarrant Express added new lanes in this section, with work in progress in 2015." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1323.JPG","20111029_fw_1323-1050.jpg", "20111029_fw_1323-2560.jpg", "aerial", 
                    "I-35W at Alliance Airport",
                    "I-35W at Alliance Airport, looking north",
                    "I-35W at Alliance Airport",
                    "Looking north",
                    new AerialStatus ("2015", "Partially obsolete", "The North Tarrant Express added new lanes in this section, with work in progress in 2015." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1325.JPG","20111029_fw_1325-1050.jpg", "20111029_fw_1325-2560.jpg", "aerial", 
                    "I-35W at Alliance Airport",
                    "I-35W at Alliance Airport, looking north",
                    "I-35W at Alliance Airport",
                    "Looking north",
                    new AerialStatus ("2015", "Partially obsolete", "The North Tarrant Express added new lanes in this section, with work in progress in 2015." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1327.JPG","20111029_fw_1327-1050.jpg", "20111029_fw_1327-2560.jpg", "aerial", 
                    "I-35W at Alliance Airport",
                    "I-35W at Alliance Airport, looking north",
                    "I-35W at Alliance Airport",
                    "Looking north",
                    new AerialStatus ("2015", "Partially obsolete", "The North Tarrant Express added new lanes in this section, with work in progress in 2015." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1334.JPG","20111029_fw_1334-1050.jpg", "20111029_fw_1334-2560.jpg", "aerial", 
                    "I-35W at SH 170",
                    "I-35W at SH 170, looking west",
                    "I-35W at SH 170",
                    "Looking west",
                    new AerialStatus ("2015", "Scheduled for construction", "The SH 170 tolled main lanes are scheduled to be built between 2016 and 2020." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1340.JPG","20111029_fw_1340-1050.jpg", "20111029_fw_1340-2560.jpg", "aerial", 
                    "I-35W at Alliance Airport",
                    "I-35W at Alliance Airport, looking northwest",
                    "I-35W at Alliance Airport",
                    "Looking northwest"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1342.JPG","20111029_fw_1342-1050.jpg", "20111029_fw_1342-2560.jpg", "aerial", 
                    "I-35W at Alliance Airport",
                    "I-35W at Alliance Airport, looking north",
                    "I-35W at Alliance Airport",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1344.JPG","20111029_fw_1344-1050.jpg", "20111029_fw_1344-2560.jpg", "aerial", 
                    "I-35W at Alliance Airport",
                    "I-35W at Alliance Airport, looking north",
                    "I-35W at Alliance Airport",
                    "Looking north")
            };
        }


        public static List<AerialGalleryItem> sh114_texas_motor_speedway_images()
        {
            return i35w_texas_motor_speedway_images();
        }

        public static List<AerialGalleryItem> i35w_texas_motor_speedway_images()
        {

            return new List<AerialGalleryItem>() {

                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1345.JPG","20111029_fw_1345-1050.jpg", "20111029_fw_1345-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking north",
                    "Texas Motor Speedway",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1347.JPG","20111029_fw_1347-1050.jpg", "20111029_fw_1347-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking north",
                    "Texas Motor Speedway",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1352.JPG","20111029_fw_1352-1050.jpg", "20111029_fw_1352-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking northwest",
                    "Texas Motor Speedway",
                    "Looking northwest"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1358.JPG","20111029_fw_1358-1050.jpg", "20111029_fw_1358-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking northwest",
                    "Texas Motor Speedway",
                    "Looking northwest with the SH 114 intersection in the foreground. "),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1360.JPG","20111029_fw_1360-1050.jpg", "20111029_fw_1360-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking northwest",
                    "Texas Motor Speedway",
                    "Looking northwest with the SH 114 intersection in the foreground."),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1364.JPG","20111029_fw_1364-1050.jpg", "20111029_fw_1364-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking west",
                    "Texas Motor Speedway",
                    "Looking west"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1367.JPG","20111029_fw_1367-1050.jpg", "20111029_fw_1367-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking west",
                    "Texas Motor Speedway",
                    "Looking west"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1373.JPG","20111029_fw_1373-1050.jpg", "20111029_fw_1373-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking west",
                    "Texas Motor Speedway",
                    "Looking west"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1375.JPG","20111029_fw_1375-1050.jpg", "20111029_fw_1375-2560.jpg", "aerial", 
                    "I-35W at Texas Motor Speedway",
                    "I-35W at Texas Motor Speedway, looking ",
                    "I-35W at Texas Motor Speedway",
                    "Looking southbound along I-35W "),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1377.JPG","20111029_fw_1377-1050.jpg", "20111029_fw_1377-2560.jpg", "aerial", 
                    "I-35W at Texas Motor Speedway",
                    "I-35W at Texas Motor Speedway, looking ",
                    "I-35W at Texas Motor Speedway",
                    "Looking southbound along I-35W "),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1378.JPG","20111029_fw_1378-1050.jpg", "20111029_fw_1378-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking southwest",
                    "Texas Motor Speedway",
                    "Looking southwest"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1379.JPG","20111029_fw_1379-1050.jpg", "20111029_fw_1379-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking south",
                    "Texas Motor Speedway",
                    "Looking south"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1380.JPG","20111029_fw_1380-1050.jpg", "20111029_fw_1380-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking south",
                    "Texas Motor Speedway",
                    "Looking south"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1382.JPG","20111029_fw_1382-1050.jpg", "20111029_fw_1382-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking north",
                    "Texas Motor Speedway",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1384.JPG","20111029_fw_1384-1050.jpg", "20111029_fw_1384-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking north",
                    "Texas Motor Speedway",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1385.JPG","20111029_fw_1385-1050.jpg", "20111029_fw_1385-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking north",
                    "Texas Motor Speedway",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1387.JPG","20111029_fw_1387-1050.jpg", "20111029_fw_1387-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking north",
                    "Texas Motor Speedway",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1389.JPG","20111029_fw_1389-1050.jpg", "20111029_fw_1389-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking north",
                    "Texas Motor Speedway",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1391.JPG","20111029_fw_1391-1050.jpg", "20111029_fw_1391-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking north",
                    "Texas Motor Speedway",
                    "Looking north"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1393.JPG","20111029_fw_1393-1050.jpg", "20111029_fw_1393-2560.jpg", "aerial", 
                    "Texas Motor Speedway",
                    "Texas Motor Speedway, looking ",
                    "Texas Motor Speedway",
                    "Looking "),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1395.JPG","20111029_fw_1395-1050.jpg", "20111029_fw_1395-2560.jpg", "aerial", 
                    "I-35W at Texas Motor Speedway",
                    "I-35W at Texas Motor Speedway, looking north",
                    "I-35W at Texas Motor Speedway",
                    "Looking northbound along I-35W"),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1396.JPG","20111029_fw_1396-1050.jpg", "20111029_fw_1396-2560.jpg", "aerial", 
                    "I-35W at Texas Motor Speedway",
                    "I-35W at Texas Motor Speedway, looking north",
                    "I-35W at Texas Motor Speedway",
                    "Looking northbound along I-35W")


            };
        }

    }




}