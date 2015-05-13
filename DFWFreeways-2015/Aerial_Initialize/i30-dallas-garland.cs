﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> i30_dallas_garland_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"","31_i30_looking_ne_e_of_i635_2005-05-30_750.jpg", "31_i30_looking_ne_e_of_i635_2005-05-30_1550x1871.png", "aerial", 
                    "I-30 in Garland",
                    "I-30 in Garland looking northeast",
                    "I-30 in Garland",
                    "Looking northeast along I-30."),
                new AerialGalleryItem(new DateTime(2011,4,16),"","32_i30_looking_ne_e_of_i635_2005-05-30_900.jpg", "32_i30_looking_ne_e_of_i635_2005-05-30_1557x1426.png", "aerial", 
                    "I-30 in Garland",
                    "I-30 in Garland looking northeast",
                    "I-30 in Garland",
                    "Looking northeast along I-30."),
                new AerialGalleryItem(new DateTime(2011,4,16),"","30e_lake_hubbard_crossing_sept2008_950.jpg", "30e_lake_hubbard_crossing_sept2008_2112.jpg", "aerial", 
                    "I-30 at Lake Ray Hubbard",
                    "I-30 at Lake Ray Hubbard looking northeast",
                    "I-30 in Garland",
                    "Looking northeast along I-30.")
            };
        }
    }
}