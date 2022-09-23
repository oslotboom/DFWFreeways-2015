using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> sh114_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.sh114_las_colinas_images());
            itemList.AddRange(AerialGalleryList.sh114_bush_images());
            itemList.AddRange(AerialGalleryList.sh114_westlake_images());
            itemList.AddRange(AerialGalleryList.sh114_sh170_images());
            itemList.AddRange(AerialGalleryList.sh114_diamond_images());
            return itemList;
        }


        public static List<AerialGalleryItem> sh114_westlake_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1405.JPG","20111029_fw_1405-1050.jpg", "20111029_fw_1405-2560.jpg", "aerial", 
                    "SH 114 in Westlake",
                    "SH 114 in Westlake, looking northwest",
                    "SH 114 in Westlake",
                    "Looking northwest at Solana Boulevard with the Solana office development in view.",
                    new AerialStatus ("2022", "Modified", "Frontage roads were added to the freeway in 2023." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1407.JPG","20111029_fw_1407-1050.jpg", "20111029_fw_1407-2560.jpg", "aerial", 
                    "SH 114 in Westlake",
                    "SH 114 in Westlake, looking northwest",
                    "SH 114 in Westlake",
                    "Looking northwest at Solana Boulevard.",
                    new AerialStatus ("2022", "Modified", "Frontage roads were added to the freeway in 2023." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1409.JPG","20111029_fw_1409-1050.jpg", "20111029_fw_1409-2560.jpg", "aerial", 
                    "SH 114 in Westlake",
                    "SH 114 in Westlake, looking northwest",
                    "SH 114 in Westlake",
                    "Looking northwest at Solana Boulevard.",
                    new AerialStatus ("2022", "Modified", "Frontage roads were added to the freeway in 2023." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1416.JPG","20111029_fw_1416-1050.jpg", "20111029_fw_1416-2560.jpg", "aerial", 
                    "SH 114 in Westlake",
                    "SH 114 in Westlake, looking northwest",
                    "SH 114 in Westlake",
                    "Looking northwest at Solana Boulevard.",
                    new AerialStatus ("2022", "Modified", "Frontage roads were added to the freeway in 2023." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1419.JPG","20111029_fw_1419-1050.jpg", "20111029_fw_1419-2560.jpg", "aerial", 
                    "SH 114 in Westlake",
                    "SH 114 in Westlake, looking northwest",
                    "SH 114 in Westlake",
                    "Looking northwest at Solana Boulevard.",
                    new AerialStatus ("2022", "Modified", "Frontage roads were added to the freeway in 2023." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1425.JPG","20111029_fw_1425-1050.jpg", "20111029_fw_1425-2560.jpg", "aerial", 
                    "SH 114 in Westlake",
                    "SH 114 in Westlake, looking northwest",
                    "SH 114 in Westlake",
                    "Looking northwest at Solana Boulevard.",
                    new AerialStatus ("2022", "Modified", "Frontage roads were added to the freeway in 2023." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1427.JPG","20111029_fw_1427-1050.jpg", "20111029_fw_1427-2560.jpg", "aerial", 
                    "SH 114 in Westlake",
                    "SH 114 in Westlake, looking west",
                    "SH 114 in Westlake",
                    "Looking west at Solana Boulevard.",
                    new AerialStatus ("2022", "Modified", "Frontage roads were added to the freeway in 2023." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1429.JPG","20111029_fw_1429-1050.jpg", "20111029_fw_1429-2560.jpg", "aerial", 
                    "SH 114 in Westlake",
                    "SH 114 in Westlake, looking south",
                    "SH 114 in Westlake",
                    "Looking south along Kirkwood Boulevard."),
         
            };
        }

        public static List<AerialGalleryItem> sh170_sh114_images()
        {
            return sh114_sh170_images();
        }

        public static List<AerialGalleryItem> sh114_sh170_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1432.JPG","20111029_fw_1432-1050.jpg", "20111029_fw_1432-2560.jpg", "aerial", 
                    "SH 114 at SH 170",
                    "SH 114 at SH 170, looking northwest",
                    "SH 114 at SH 170",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1435.JPG","20111029_fw_1435-1050.jpg", "20111029_fw_1435-2560.jpg", "aerial", 
                    "SH 114 at SH 170",
                    "SH 114 at SH 170, looking northwest",
                    "SH 114 at SH 170",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1398.JPG","20111029_fw_1398-1050.jpg", "20111029_fw_1398-2560.jpg", "aerial", 
                    "SH 114 at SH 170",
                    "SH 114 at SH 170, looking north",
                    "SH 114 at SH 170",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1403.JPG","20111029_fw_1403-1050.jpg", "20111029_fw_1403-2560.jpg", "aerial", 
                    "SH 114 at SH 170",
                    "SH 114 at SH 170, looking north",
                    "SH 114 at SH 170",
                    "Looking north.")
         
            };
        }

    }

}