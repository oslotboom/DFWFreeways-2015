using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DFWFreeways.Models;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> sh170_frontage_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1446.JPG","20111029_fw_1446-1050.jpg", "20111029_fw_1446-2560.jpg", "aerial", 
                    "SH 170 frontage roads",
                    "SH 170 frontage roads looking west",
                    "SH 170 frontage roads",
                    "Looking west at US 377.",
                    new AerialStatus ("2022", "Obsolete", "Freeway main lanes were added in 2023" )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1450.JPG","20111029_fw_1450-1050.jpg", "20111029_fw_1450-2560.jpg", "aerial", 
                    "SH 170 frontage roads",
                    "SH 170 frontage roads looking west",
                    "SH 170 frontage roads",
                    "Looking west at US 377.",
                    new AerialStatus ("2022", "Obsolete", "Freeway main lanes were added in 2023" )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1453.JPG","20111029_fw_1453-1050.jpg", "20111029_fw_1453-2560.jpg", "aerial", 
                    "SH 170 frontage roads",
                    "SH 170 frontage roads looking west",
                    "SH 170 frontage roads",
                    "Looking west.",
                    new AerialStatus ("2022", "Obsolete", "Freeway main lanes were added in 2023" )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1457.JPG","20111029_fw_1457-1050.jpg", "20111029_fw_1457-2560.jpg", "aerial", 
                    "SH 170 frontage roads",
                    "SH 170 frontage roads looking southwest",
                    "SH 170 frontage roads",
                    "Looking southwest.",
                    new AerialStatus ("2022", "Obsolete", "Freeway main lanes were added in 2023" )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1461.JPG","20111029_fw_1461-1050.jpg", "20111029_fw_1461-2560.jpg", "aerial", 
                    "SH 170 frontage roads",
                    "SH 170 frontage roads looking southwest",
                    "SH 170 frontage roads",
                    "Looking southwest.",
                    new AerialStatus ("2022", "Obsolete", "Freeway main lanes were added in 2023" )),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1464.JPG","20111029_fw_1464-1050.jpg", "20111029_fw_1464-2560.jpg", "aerial", 
                    "SH 170 frontage roads",
                    "SH 170 frontage roads looking southwest",
                    "SH 170 frontage roads",
                    "Looking southwest."),
                new AerialGalleryItem(new DateTime(2011,10,29),"20111029_fw_1334.JPG","20111029_fw_1334-1050.jpg", "20111029_fw_1334-2560.jpg", "aerial", 
                    "SH 170 frontage roads",
                    "SH 170 frontage roads looking southwest",
                    "SH 170 frontage roads",
                    "Looking west at I-35W.",
                    new AerialStatus ("2022", "Obsolete", "Direct connection ramps to I-35W were added in 2023" ))
            
            };
        }
    }
}