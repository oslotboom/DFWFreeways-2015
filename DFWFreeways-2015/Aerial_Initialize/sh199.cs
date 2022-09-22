using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DFWFreeways.Models;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> sh199_frontage_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1482.JPG","20111029_fw_1482-1050.jpg", "20111029_fw_1482-2560.jpg", "aerial", 
                    "SH 199 frontage roads",
                    "SH 199 frontage roads looking northwest",
                    "SH 199frontage roads",
                    "Looking northwest.",
                    new AerialStatus ("2022", "Modified", "Main lanes bridges were added at Lake Worth in 2023." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1486.JPG","20111029_fw_1486-1050.jpg", "20111029_fw_1486-2560.jpg", "aerial", 
                    "SH 199 frontage roads",
                    "SH 199 frontage roads looking northwest",
                    "SH 199frontage roads",
                    "Looking northwest.",
                    new AerialStatus ("2022", "Modified", "Main lanes bridges were added at Lake Worth in 2023." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1488.JPG","20111029_fw_1488-1050.jpg", "20111029_fw_1488-2560.jpg", "aerial", 
                    "SH 199 frontage roads",
                    "SH 199 frontage roads looking northwest",
                    "SH 199frontage roads",
                    "Looking northwest.",
                    new AerialStatus ("2022", "Modified", "Main lanes bridges were added at Lake Worth in 2023." )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1491.JPG","20111029_fw_1491-1050.jpg", "20111029_fw_1491-2560.jpg", "aerial", 
                    "SH 199 frontage roads",
                    "SH 199 frontage roads looking northwest",
                    "SH 199frontage roads",
                    "Looking northwest.",
                    new AerialStatus ("2022", "Modified", "Main lanes bridges were added at Lake Worth in 2023." ))
           
            };
        }
    }
}