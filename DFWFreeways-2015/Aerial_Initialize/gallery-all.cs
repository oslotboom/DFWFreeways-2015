using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {

        public static List<AerialGalleryItem> gallery_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>();
            itemList.AddRange(us75_all_images());
            itemList.AddRange(i635_preston_images());
            itemList.AddRange(spur366_all_images());
            itemList.AddRange(i35e_north_all_images());
            itemList.AddRange(i635_bush_images());
            itemList.AddRange(i635_garland_images());
            itemList.AddRange(dnt_all_images());
            itemList.AddRange(sh121_colony_images());
            itemList.AddRange(bush_carrollton_images());
            itemList.AddRange(bush_plano_images());
            itemList.AddRange(i30_dallas_all_images());
            itemList.AddRange(us80_i635_images());
            itemList.AddRange(i635_i20_images());
            itemList.AddRange(us175_all_images());
            itemList.AddRange(i45_dallas_images());
            itemList.AddRange(i45_i20_images());
            itemList.AddRange(i35e_south_all_images());
            itemList.AddRange(us67_i20_images());
            itemList.AddRange(spur408_all_images());
            itemList.AddRange(loop12_trinity_images());
            itemList.AddRange(loop12_davis_images());
            itemList.AddRange(i30_landry_all_images());
            itemList.AddRange(sh114_all_images());
            itemList.AddRange(us287_south_freeway_images());
            itemList.AddRange(i35w_i20_images());
            itemList.AddRange(i30_fort_worth_downtown_images());
            itemList.AddRange(i30_fort_worth_arlington_images());
            itemList.AddRange(i30_fort_worth_i820_images());
            itemList.AddRange(i20_west_fort_worth_images());
            itemList.AddRange(i20_west_i820_images());
            itemList.AddRange(i35w_i820_images());
            itemList.AddRange(i35w_alliance_images());
            itemList.AddRange(i35w_texas_motor_speedway_images());
            itemList.AddRange(sh170_frontage_images());
            itemList.AddRange(sh199_frontage_images());

            return itemList;
        }

    }
}


