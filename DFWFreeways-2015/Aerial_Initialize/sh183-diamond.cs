using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DFWFreeways.Models;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> loop12_diamond_images()
        {
            return sh183_diamond_images();
        }

        public static List<AerialGalleryItem> sh114_diamond_images()
        {
            return sh183_diamond_images();
        }


        public static List<AerialGalleryItem> sh183_diamond_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0327.JPG","20110416_aerial_0327-1050.jpg", "20110416_aerial_0327-2560.jpg", "aerial", 
                    "SH 183 at Loop 12, at the Texas Stadium site",
                    "SH 183 at Loop 12, Looking northeast",
                    "SH 183 at Loop 12",
                    "Looking northeast, showing the cleared site of Texas Stadium. In 2012 TxDOT built a construction staging facility on the site.",
                    new AerialStatus ("2018", "Obsolete", "SH 183 was expanded and two connection ramps were added at the SH 183/Loop 12 interchange, with work complete in 2018." )
                ),
                new AerialGalleryItem(new DateTime(2005,5,30),"","26a_loop12_at_183_with_texas_stadium_2005-05-30_900.jpg", "26a_loop12_at_183_with_texas_stadium_2005-05-30_2759x1798.png", "aerial", 
                    "Loop 12 at SH 183",
                    "Loop 12 at SH 183, looking north",
                    "Loop 12 at SH 183, looking north",
                    "Loop 12 at SH 183, looking north",
                    new AerialStatus ("2018", "Historical Archive", "Texas Stadium was demolished in 2010, Loop 12 has been widened and widening of SH 183 completed in 2018." )),
                new AerialGalleryItem(new DateTime(2005,5,30),"","33a_loop12_looking_s_at_texas_stadium_2005-05-30_900.jpg", "33a_loop12_looking_s_at_texas_stadium_2005-05-30_2820x1763.png", "aerial", 
                    "Loop 12 at SH 183",
                    "Loop 12 at SH 183, looking south",
                    "Loop 12 at SH 183, looking south",
                    "Loop 12 at SH 183, looking south",
                    new AerialStatus ("2018", "Historical Archive", "Texas Stadium was demolished in 2010, Loop 12 has been widened and widening of SH 183 completed in 2018." )),
                new AerialGalleryItem(new DateTime(2005,5,30),"","34a_loop12_at_texas_stadium_looking_south_2005-05-30_900.jpg", "34a_loop12_at_texas_stadium_looking_south_2005-05-30_2795x1821.png", "aerial", 
                    "Loop 12 at SH 114",
                    "Loop 12 at SH 114, looking south",
                    "Loop 12 at SH 114, looking south",
                    "Loop 12 at SH 114, looking south",
                    new AerialStatus ("2018", "Historical Archive", "Texas Stadium was demolished in 2010. In 2012, Loop 12 and SH 114 were widened, and two connectors were added at this intersection." )),
                new AerialGalleryItem(new DateTime(2005,5,30),"","32a_114_with_texas_stadium_2005-05-30_900.jpg", "32a_114_with_texas_stadium_2005-05-30_2660x1771.png", "aerial", 
                    "SH 114 at SH 183",
                    "SH 114 at SH 183, looking southeast",
                    "SH 114 at SH 183",
                    "Looking southeast along SH 114 with the SH 183 interchange in the distance.",
                    new AerialStatus ("2018", "Historical Archive", "Texas Stadium was demolished in 2010. Managed lanes have been added to SH 114, and both of the bridges over SH 114 have been removed." )),
                new AerialGalleryItem(new DateTime(2005,5,30),"","28a_183_looking_e_at_loop12_2005-05-30_600.jpg", "28a_183_looking_e_at_loop12_2005-05-30_1830x2797.png", "aerial", 
                    "SH 183 at Loop 12",
                    "SH 183 at Loop 12, looking east",
                    "SH 183 at Loop 12",
                    "Looking east along SH 183 at Loop 12.",
                    new AerialStatus ("2018", "Historical Archive", "Texas Stadium was demolished in 2010. Expansion of SH 183 and modernization of the interchange at Loop 12 completed in 2018." )),
                new AerialGalleryItem(new DateTime(2005,5,30),"","36a_183_at_114_2005_looking_s_2005-05-30_900.jpg", "36a_183_at_114_2005_looking_s_2005-05-30_2807x1767.png", "aerial", 
                    "SH 114 at Spur 482",
                    "SH 114 at Spur 482, looking southwest",
                    "SH 114 at Spur 482",
                    "SH 114 at Spur 482, looking southwest.",
                    new AerialStatus ("2018", "Obsolete", "This interchange was modified by the expansion of SH 183, which completed in 2018. " )),
                new AerialGalleryItem(new DateTime(2005,5,30),"","24a_spur_482_looking_ne_2005-05-30_900.jpg", "24a_spur_482_looking_ne_2005-05-30_2812x1821.png", "aerial", 
                    "SH 183 at Spur 482",
                    "SH 183 at Spur 482, looking northeast",
                    "SH 183 at Spur 482",
                    "SH 183 at Spur 482, looking northeast.",
                    new AerialStatus ("2018", "Obsolete", "This interchange was modified by the expansion of SH 183, which began in 2015 and completed in 2018." )),
                new AerialGalleryItem(new DateTime(2005,5,30),"","27a_loop12_at_114_looking_n_2005-05-30_900.jpg", "27a_loop12_at_114_looking_n_2005-05-30_1812x2718.png", "aerial", 
                    "Loop 12 at SH 114",
                    "Loop 12 at SH 114",
                    "Loop 12 at SH 114",
                    "Loop 12 at SH 114, Looking north.",
                    new AerialStatus ("2018", "Obsolete", "Loop 12 was expanded and the SH 114 was modified, with work completed in July 2012." )),
                new AerialGalleryItem(new DateTime(2005,5,30),"","30a_114_at_183_looking_se__2005-05-30_900.jpg", "30a_114_at_183_looking_se__2005-05-30_2599x1783.png", "aerial", 
                    "SH 183 at SH 114",
                    "SH 183 at SH 114, looking southeast",
                    "SH 183 at SH 114",
                    "SH 183 at SH 114, looking southeast.",
                    new AerialStatus ("2018", "Obsolete", "Work to expand SH 183 began in 2015 and completed in 2018. The row of warehouse-style buildings on the north (left) side of the freeway was cleared in 2014." ))
           
            };
        }
    }
}