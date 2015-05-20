using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public class AerialGalleryItem
    {
        private string _lowRes;
        public DateTime ImageDate { get; set; }
        public string Thumbnail { get; set; }
        public string LowRes
        {
            get
            {
                return _lowRes;
            }
            set
            {
                _lowRes = value;
                //set the thumbnail image based on the lowRes file name. This assumes only one occurrence of "-" in the lowres file name
                if (_lowRes.Split('-').Length == 2)
                    Thumbnail = _lowRes.Split('-')[0] + "-280.jpg";
                else
                {
                    //assume the file has the form _***.jpg
                    Thumbnail = _lowRes.Substring(0, _lowRes.LastIndexOf('_')) + "-280.jpg";
                }
            }
        }

        public string HighRes { get; set; }
        public string Original { get; set; }
        public string Folder { get; set; }
        public string GalleryShortCaption { get; set; }
        public string GalleryLongCaption { get; set; }
        public string MouseOver { get; set; }
        public string PageCaption { get; set; }
        public AerialStatus Status { get; set; }

        public AerialGalleryItem(
            DateTime imageDate,
            string original,
            string lowRes,
            string highRes,
            string folder,
            string galleryShortCaption,
            string galleryLongCaption,
            string mouseOver,
            string pageCaption,
            AerialStatus status = null
            )
        {
            ImageDate = imageDate;
            LowRes = lowRes;
            HighRes = highRes;
            Original = original;
            Folder = folder;
            GalleryShortCaption = galleryShortCaption;
            GalleryLongCaption = galleryLongCaption;
            MouseOver = mouseOver;
            PageCaption = pageCaption;
            Status = status;
        }


    }

    public class AerialStatus
    {
        public string StatusDate { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public AerialStatus(string statusDate, string status, string note)
        {
            StatusDate = statusDate;
            Status = status;
            Note = note;
        }
    }

    public partial class AerialGalleryList
    {
        public string FileServer { get; set; }
        public string FolderPath { get; set; }
        public PageHeader PageHeader { get; set; }
        public string Text { get; set; }
        public List<AerialGalleryItem> ItemList { get; set; }

        public AerialGalleryList() { }

        public AerialGalleryList(string fileServer, string folderPath)
        {
            FileServer = fileServer;
            FolderPath = folderPath + "/";
        }

        public AerialGalleryList(string fileServer, string folderPath, PageHeader pageheader)
        {
            FileServer = fileServer;
            FolderPath = folderPath + "/";
            PageHeader = pageheader;
        }

        private static string GetShieldPath(string id)
        {
            return "~/images/shields/shield-" + id + ".png";
        }

        public static string[] Descriptions(string page)
        {
            string[] info = new string[4];
            //fields are title, subtitle, return Url text, last updated
            switch (page)
            {
                case "i35e_north_all": info = new string[] { "I-35E North All Aerials", "", "I-35E North", "June 1, 2015" }; break;
                case "i35e_north_i35e_i635": info = new string[] { "I-35E at I-635", "", "I-35E North", "June 1, 2015" }; break;
                case "i35e_north_american_airlines_center": info = new string[] { "American Airlines Center", "", "I-35E North", "June 1, 2015" }; break;
                case "i35e_north_market_center": info = new string[] { "I-35E at Dallas Market Center", "", "I-35E North", "June 1, 2015" }; break;
                case "i35e_north_i35e_sh121": info = new string[] { "I-35E at SH 121/Sam Rayburn Turnpike", "", "I-35E North", "June 1, 2015" }; break;
                case "i35e_north_i35e_bush": info = new string[] { "I-35E at Bush Turnpike", "", "I-35E North", "June 1, 2015" }; break;
                case "bush_bush_i35e": info = new string[] { "Bush Turnpike at I-35E", "", "Bush Turnpike", "June 1, 2015" }; break;
                case "i20_dallas_all": info = new string[] { "I-20 All Aerials", "", "I-20 Dallas", "June 1, 2015" }; break;
                case "i20_dallas_i20_i35e": info = new string[] { "I-20 at I-35E", "", "I-20 Dallas", "June 1, 2015" }; break;
                case "i20_dallas_i20_us67": info = new string[] { "I-20 at US 67", "", "I-20 Dallas", "June 1, 2015" }; break;
                case "i20_dallas_i20_i45": info = new string[] { "I-20 at I-45", "", "I-20 Dallas", "June 1, 2015" }; break;
                case "i20_dallas_i20_us175": info = new string[] { "I-20 at US 175", "", "I-20 Dallas", "June 1, 2015" }; break;
                case "i20_dallas_i20_spur408": info = new string[] { "I-20 at Spur 408", "", "I-20 Dallas", "June 1, 2015" }; break;
                case "i20_dallas_i20_i635": info = new string[] { "I-20 at I-635", "", "I-20 Dallas", "June 1, 2015" }; break;
                case "i30_dallas_downtown": info = new string[] { "I-30 at I-45 and the Downtown Canyon", "", "I-30 Dallas", "June 1, 2015" }; break;
                case "i30_dallas_us80": info = new string[] { "I-30 at US 80", "", "I-30 Dallas", "June 1, 2015" }; break;
                case "i30_dallas_i635": info = new string[] { "I-30 at I-635", "", "I-30 Dallas", "June 1, 2015" }; break;
                case "i30_dallas_east_dallas": info = new string[] { "I-30 in East Dallas", "", "I-30 Dallas", "June 1, 2015" }; break;
                case "i45_all": info = new string[] { "All I-45 Aerials", "", "I-45", "June 1, 2015" }; break;
                case "i45_dallas": info = new string[] { "I-45 in Dallas", "", "I-45", "June 1, 2015" }; break;
                case "i45_i30": info = new string[] { "I-45 at I-30", "", "I-45", "June 1, 2015" }; break;
                case "i45_i20": info = new string[] { "I-45 at I-20", "", "I-45", "June 1, 2015" }; break;
                case "i35e_south_all": info = new string[] { "I-35E South All Aerials", "", "I-35E South", "June 1, 2015" }; break;
                case "i35e_south_i20": info = new string[] { "I-35E at I-20", "", "I-35E South", "June 1, 2015" }; break;
                case "i35e_south_downtown": info = new string[] { "I-35E at the Trinity River, Downtown", "", "I-35E South", "June 1, 2015" }; break;
                case "i635_us75": info = new string[] { "I-635 at US 75", "The High Five Interchange", "I-635", "June 1, 2015" }; break;
                case "i635_bush": info = new string[] { "I-635 at Bush Turnpike", "", "I-635", "June 1, 2015" }; break;
                case "i635_i35e": info = new string[] { "I-635 at I-35E Stemmons Freeway", "", "I-635", "June 1, 2015" }; break;
                case "i635_dnt": info = new string[] { "I-635 at the Dallas North Tollway", "Photos obsolete, for historical reference", "I-635", "June 1, 2015" }; break;
                case "i635_i30": info = new string[] { "I-635 at I-30", "", "I-635", "June 1, 2015" }; break;
                case "i635_us80": info = new string[] { "I-635 at US 80", "", "I-635", "June 1, 2015" }; break;
                case "i635_i20": info = new string[] { "I-635 at Preston Road", "", "I-635", "June 1, 2015" }; break;
                case "i635_preston": info = new string[] { "I-635 at Preston Road", "Original Freeway Before the LBJ Express", "I-635", "June 1, 2015" }; break;
                case "i635_farmers_branch": info = new string[] { "I-635 Farmers Branch", "Original Freeway Before the LBJ Express", "I-635", "June 1, 2015" }; break;
                case "i635_garland": info = new string[] { "I-635 in Garland", "", "I-635", "June 1, 2015" }; break;
                case "us67_i20": info = new string[] { "US 67 at I-20", "", "US 67", "June 1, 2015" }; break;
                case "us75_all": info = new string[] { "US 75 All Aerials", "", "US 75", "June 1, 2015" }; break;
                case "us75_i635": info = new string[] { "US 75 at I-635 LBJ Freeway", "", "US 75", "June 1, 2015" }; break;
                case "us75_dallas": info = new string[] { "US 75 in Dallas South of Loop 12", "", "US 75", "June 1, 2015" }; break;
                case "us75_loop12": info = new string[] { "US 75 from Mockingbird to Loop 12", "", "US 75", "June 1, 2015" }; break;
                case "us75_bush": info = new string[] { "US 75 at the Bush Turnpike and the Telecom Corridor", "", "US 75", "June 1, 2015" }; break;
                case "us80_all": info = new string[] { "US 80 All Aerials", "", "US 80", "June 1, 2015" }; break;
                case "us80_i635": info = new string[] { "US 80 at I-635", "", "US 80", "June 1, 2015" }; break;
                case "us80_i30": info = new string[] { "US 80 at I-30", "", "US 80", "June 1, 2015" }; break;
                case "us175_i20": info = new string[] { "US 175 at I-20", "", "US 175", "June 1, 2015" }; break;
                case "sh183_diamond": info = new string[] { "SH 183 at the Texas Stadium site", "All Photos for Historical Reference", "SH 183 Dallas", "June 1, 2015" }; break;
                case "sh114_diamond": info = new string[] { "SH 114 at the Texas Stadium site", "All Photos for Historical Reference", "SH 114", "June 1, 2015" }; break;
                case "sh114_all": info = new string[] { "All SH 114 Aerials", "", "SH 114", "June 1, 2015" }; break;
                case "sh114_las_colinas": info = new string[] { "SH 114 at Las Colinas", "", "SH 114", "June 1, 2015 (create)" }; break;
                case "sh114_bush": info = new string[] { "SH 114 at the Bush Turnpike", "", "SH 114", "June 1, 2015" }; break;
                case "sh114_texas_motor_speedway": info = new string[] { "SH 114 at the Texas Motor Speedway", "", "SH 114", "June 1, 2015" }; break;
                case "sh114_westlake": info = new string[] { "SH 114 at Solana in Westlake", "", "SH 114", "June 1, 2015 (create)" }; break;
                case "sh114_sh170": info = new string[] { "SH 114 at SH 170", "", "SH 114", "June 1, 2015 (create)" }; break;
                case "bush_i30": info = new string[] { "Bush Turnpike at I-30", "", "Bush Turnpike", "June 1, 2015" }; break;
                case "bush_sh114": info = new string[] { "Bush Turnpike at SH 114 Carpenter Freeway", "", "Bush Turnpike", "June 1, 2015" }; break;
                case "bush_i635": info = new string[] { "Bush Turnpike at I-635 LBJ Freeway", "", "Bush Turnpike", "June 1, 2015" }; break;
                case "bush_i35e": info = new string[] { "Bush Turnpike at I-35E Stemmons Freeway", "", "Bush Turnpike", "June 1, 2015" }; break;
                case "bush_carrollton": info = new string[] { "Bush Turnpike in Carrollton", "", "Bush Turnpike", "June 1, 2015" }; break;
                case "bush_dnt": info = new string[] { "Bush Turnpike at the Dallas North Tollway", "", "Bush Turnpike", "June 1, 2015" }; break;
                case "bush_plano": info = new string[] { "Bush Turnpike in Plano and Richardson", "", "Bush Turnpike", "June 1, 2015" }; break;
                case "bush_us75": info = new string[] { "Bush Turnpike at US 75 Central Expressway", "", "Bush Turnpike", "June 1, 2015" }; break;
                case "spur366_all": info = new string[] { "Woodall Rodgers Freeway All Aerials", "", "Woodall Rodgers Freeway", "June 1, 2015 (create)" }; break;
                case "spur366_margaret_hunt_hill_bridge": info = new string[] { "Margaret Hunt Hill Bridge", "", "Woodall Rodgers Freeway", "June 1, 2015 (create)" }; break;
                case "spur366_bridge_construction": info = new string[] { "Margaret Hunt Hill Bridge Construction", "", "Woodall Rodgers Freeway", "June 1, 2015 (create)" }; break;
                case "spur366_2012": info = new string[] { "Klyde Warren Park Nearly Complete", "", "Woodall Rodgers Freeway", "June 1, 2015 (create)" }; break;
                case "spur366_pre_klyde_warren": info = new string[] { "Before Klyde Warren Park", "", "Woodall Rodgers Freeway", "June 1, 2015 (create)" }; break;
                case "dnt_sh121": info = new string[] { "At SH 121 and the Legacy Area", "", "Dallas North Tollway", "June 1, 2015 (create)" }; break;
                case "dnt_plano": info = new string[] { "In Plano", "", "Dallas North Tollway", "June 1, 2015 (create)" }; break;
                case "dnt_bush": info = new string[] { "At Bush Turnpike", "", "Dallas North Tollway", "June 1, 2015 (review, add photo)" }; break;
                case "dnt_addison": info = new string[] { "In Addison", "", "Dallas North Tollway", "June 1, 2015 (review, add photo)" }; break;
                case "dnt_i635": info = new string[] { "At I-635 LBJ Freeway", "Interchange Modifications completed in 2015", "Dallas North Tollway", "June 1, 2015 (review, add photo)" }; break;
                case "dnt_loop12": info = new string[] { "At Loop 12", "", "Dallas North Tollway", "June 1, 2015 (review, add photo)" }; break;
                case "dnt_park_cities": info = new string[] { "At Mockingbird Lane", "", "Dallas North Tollway", "June 1, 2015 (review, add photo)" }; break;
                case "sh121_all": info = new string[] { "All SH 121 Aerials", "", "SH 121/Sam Rayburn Turnpike", "June 1, 2015 (create)" }; break;
                case "sh121_dnt": info = new string[] { "At the Dallas North Tollway", "", "SH 121/Sam Rayburn Turnpike", "June 1, 2015 (create)" }; break;
                case "sh121_colony": info = new string[] { "Construction in the Colony area", "", "SH 121", "June 1, 2015 (review and update caption)" }; break;
                case "sh121_i35e": info = new string[] { "At I-35E Stemmons Freeway", "", "SH 121", "June 1, 2015 (update)" }; break;
                case "loop12_diamond": info = new string[] { "Loop 12 at the Texas Stadium site", "All Photos for Historical Reference", "Loop 12", "June 1, 2015" }; break;
                case "loop12_all": info = new string[] { "All Loop 12 Photos", "", "Loop 12", "June 1, 2015" }; break;
                case "loop12_trinity": info = new string[] { "Trinity River Crossing", "", "Loop 12", "June 1, 2015" }; break;
                case "loop12_davis": info = new string[] { "At Davis/Jefferson Streets", "", "Loop 12", "June 1, 2015" }; break;
                case "loop12_i30": info = new string[] { "At I-30 Landry Highway", "", "Loop 12", "June 1, 2015" }; break;
                case "spur408_all": info = new string[] { "All Spur 408 Aerials", "", "Spur 408", "June 1, 2015" }; break;
                case "spur408_freeway": info = new string[] { "Aerial views", "", "Spur 408", "June 1, 2015" }; break;
                case "spur408_i20": info = new string[] { "At I-20", "", "Spur 408", "June 1, 2015" }; break;
                case "i30_landry_all": info = new string[] { "All Aerials for I-30 Tom Landry Highway", "", "I-30 Landry Highway", "June 1, 2015" }; break;
                case "i30_landry_sh360": info = new string[] { "I-30 at SH 360", "Six Flags Over Texas", "I-30 Landry Highway", "June 1, 2015" }; break;
                case "i30_landry_stadiums": info = new string[] { "Arlington Stadiums", "", "I-30 Landry Highway", "June 1, 2015" }; break;
                case "i30_landry_bush": info = new string[] { "I-30 at Bush Turnpike", "", "I-30 Landry Highway", "June 1, 2015" }; break;
                case "i30_landry_loop12": info = new string[] { "I-30 at Loop 12", "", "I-30 Landry Highway", "June 1, 2015" }; break;
                case "i30_landry_i820_east": info = new string[] { "I-30 at I-820 East", "", "I-30 Landry Highway", "June 1, 2015" }; break;
                case "i30_landry_i35w": info = new string[] { "I-30 at I35W", "The Fort Worth Mixmaster", "I-30 Landry Highway", "June 1, 2015" }; break;
                case "i30_landry_lone_star": info = new string[] { "Lone Star Park Horse Track", "", "I-30 Landry Highway", "June 1, 2015" }; break;
                case "i30_landry_trinity": info = new string[] { "Original Trinity River Bridge", "For Historical Reference", "I-30 Landry Highway", "June 1, 2015" }; break;
                case "sh360_i30": info = new string[] { "SH 360 at I-30 and Six Flags", "", "SH 360", "June 1, 2015" }; break;
                case "i20_west_all": info = new string[] { "I-20 All Aerials", "Fort Worth", "I-20 Fort Worth", "June 1, 2015 (create)" }; break;
                case "i20_west_i35w": info = new string[] { "I-20 at I-35W", "South Fort Worth", "I-20 Fort Worth", "June 1, 2015 (create)" }; break;
                case "i20_west_fort_worth": info = new string[] { "I-20 South Fort Worth", "", "I-20 Fort Worth", "June 1, 2015 (create)" }; break;
                case "i20_west_i820": info = new string[] { "I-20 at I-820", "Southwest Fort Worth", "I-20 Fort Worth", "June 1, 2015 (create)" }; break;
                case "i35w_all": info = new string[] { "All I-35W Aerials", "", "I-35W", "June 1, 2015 (create)" }; break;
                case "i35w_i20": info = new string[] { "I-35W at I-20", "South Fort Worth", "I-35W", "June 1, 2015 (create)" }; break;
                case "i35w_i30": info = new string[] { "I-35W at I-30", "Fort Worth Mixmaster", "I-35W", "June 1, 2015 (create)" }; break;
                case "i35w_i820": info = new string[] { "I-35W at I-820", "North Fort Worth", "I-35W", "June 1, 2015 (create)" }; break;
                case "i35w_alliance": info = new string[] { "I-35W at Alliance", "North Fort Worth", "I-35W", "June 1, 2015 (create)" }; break;
                case "i35w_texas_motor_speedway": info = new string[] { "I-35W at Alliance", "North Fort Worth", "I-35W", "June 1, 2015 (create)" }; break;
                case "i30_fort_worth_all": info = new string[] { "All I-30 Fort Worth Aerials", "", "I-30 Fort Worth", "June 1, 2015 (create)" }; break;
                case "i30_fort_worth_downtown": info = new string[] { "I-30 Downtown Fort Worth", "", "I-30 Fort Worth", "June 1, 2015 (create)" }; break;
                case "i30_fort_worth_i35w": info = new string[] { "I-30 at I-35W", "The Fort Worth Mixmaster", "I-30 Fort Worth", "June 1, 2015 (create)" }; break;
                case "i30_fort_worth_arlington": info = new string[] { "I-30 West Fort Worth", "Arlington Heights Area", "I-30 Fort Worth", "June 1, 2015 (create)" }; break;
                case "i30_fort_worth_i820": info = new string[] { "I-30 at I-820", "West Fort Worth", "I-30 Fort Worth", "June 1, 2015 (create)" }; break;

            }
            return info;
        }

        public static string PageText(string page)
        {
            //Text to be displayed at the top of the page.
            string text = "";
            switch (page)
            {
                case "i35e_north_i35e_i635":
                case "i635_i35e": text = "This interchanged was substantially modified for the LBJ Express project, completed in 2015. The images below are all obsolete and are included to show the original interchange."; break;
                case "i635_farmers_branch": text = "Interstate 635 was rebuilt and expanded for the LBJ Express Project, completed in 2015. This section of freeway now has frontage roads and tolled express lanes in a trench in the center of the freeway."; break;
                case "i635_dnt": text = "The I-635 main lanes were widened for the LBJ Express Project, completed in 2015. The overall configuration of the interchange remained the same."; break;
                case "i635_preston": text = "The I-635 main lanes were widened and managed lanes were added for the LBJ Express Project, completed in 2015."; break;
                case "us75_loop12": text = "The Bush Presidential Library opened on April 25, 2013."; break;
                case "us75_bush": text = "2015 status: The highway features are still accurate, but there has been some new development on the land around the freeway."; break;
                case "sh183_dallas_diamond": text = "All these photos are now obsolete due to the implosion of Texas Stadium in 2010, expansion of the freeways and TxDOT's construction staging yard at the stadium site. TxDOT now calls the area the Diamond Interchange, although I have not heard any other organization use that name."; break;
                case "sh114_irving_diamond": text = "All these photos are now obsolete due to the implosion of Texas Stadium in 2010, expansion of the freeways and TxDOT's construction staging yard at the stadium site. TxDOT now calls the area the Diamond Interchange, although I have not heard any other organization use that name."; break;
                case "bush_carrollton": text = "The section of the Bush Turnpike through Carrollton was the second most controversial freeway in the ranking of North Texas freeway controversies. See the Bush Turnpike book excerpt and Chapter 2 for details"; break;
                case "bush_i30": text = "The section of the Bush Turnpike through the neighborhood north of I-30 was the third most controversial freeway in the ranking of North Texas freeway controversies. See the Bush Turnpike book excerpt and Chapter 2 for details"; break;
                case "spur366_bridge_construction": text = "Construction was just underway at the time of this June 2009 photo. The bridge opened in March 2012."; break;
                case "spur366_2012": text = "Klyde Warren Park opened in October 2012."; break;
                case "spur366_pre_klyde_warren": text = "Klyde Warren Park opened in October 2012 on a deck over the trenched section of the freeway. There has also been new development along the freeway since these photos were taken, including Museum Tower, the Perot Museum, and Hunt Oil Headquarters."; break;
                case "dnt_i635": text = "The I-635 main lanes were widened for the LBJ Express Project, completed in 2015. The overall configuration of the interchange remained the same. Changes to the Dallas North Tollway were minimal."; break;
                case "dnt_sh121": text = "The interchange was completed in November 2011."; break;
                case "sh121_dnt": text = "The interchange was completed in November 2011."; break;
                case "loop12_diamond": text = "All these photos are now obsolete due to the implosion of Texas Stadium in 2010, expansion of the freeways and TxDOT's construction staging yard at the stadium site. TxDOT now calls the area the Diamond Interchange, although I have not heard any other organization use that name."; break;
                case "i30_landry_sh360": text = "All these photos are now obsolete due to construction of the 4-level interchange at SH 360, which was underway in 2016."; break;
                case "i30_landry_trinity": text = "Construction began on the new bridge in 2014. The new bridge will feature two pedestrian bridges with long-span signature arches."; break;
            }
            return text;
        }

    }
}



//public class AerialGalleryList {
//    public List<AerialGalleryItem> ItemList { get; set; }


//    public static AerialGalleryList Initialize_i635_us75 () {
//        AerialGalleryList list = new AerialGalleryList();
//        list.ItemList = new List<AerialGalleryItem>() {
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0007.JPG","20090623_aerial_0007-1050.JPG", "20090623_aerial_0007-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking north.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking north.",
//                "US 75 at I-635",
//                "Looking north.",
//                "2015 Status","Accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0009.JPG","20090623_aerial_0009-1050.JPG", "20090623_aerial_0009-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking northwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking northwest.",
//                "US 75 at I-635",
//                "Looking northwest.",
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0010.JPG","20090623_aerial_0010-1050.JPG", "20090623_aerial_0010-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0011.JPG","20090623_aerial_0011-1050.JPG", "20090623_aerial_0011-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0012.JPG","20090623_aerial_0012-1050.JPG", "20090623_aerial_0012-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0013.JPG","20090623_aerial_0013-1050.JPG", "20090623_aerial_0013-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),                
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0014.JPG","20090623_aerial_0014-1050.JPG", "20090623_aerial_0014-2560.JPG", "high-five", 
//                    "High Five Interchange, US 75 at I-635, looking southwest.","High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0015.JPG","20090623_aerial_0015-1050.JPG", "20090623_aerial_0015-2560.JPG", "high-five", 
//                    "High Five Interchange, US 75 at I-635, looking southwest.","High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0016.JPG","20090623_aerial_0016-1050.JPG", "20090623_aerial_0016-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.","High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0017.JPG","20090623_aerial_0017-1050.JPG", "20090623_aerial_0017-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.","High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0018.JPG","20090623_aerial_0018-1050.JPG", "20090623_aerial_0018-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.","High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0019.JPG","20090623_aerial_0019-1050.JPG", "20090623_aerial_0019-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.","High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0020.JPG","20090623_aerial_0020-1050.JPG", "20090623_aerial_0020-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.","High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0021.JPG","20090623_aerial_0021-1050.JPG", "20090623_aerial_0021-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.","High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),  
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0022.JPG","20090623_aerial_0022-1050.JPG", "20090623_aerial_0022-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking east.","High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking east.",
//                "US 75 at I-635",
//                "Looking east.",                           
//                "2015 Status","Mostly accurate"), 
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0024.JPG","20090623_aerial_0024-1050.JPG", "20090623_aerial_0024-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking north.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking north.",
//                "US 75 at I-635",
//                "Looking north.",
//                "2015 Status","Accurate"), 
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0025.JPG","20090623_aerial_0025-1050.JPG", "20090623_aerial_0025-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking northwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking northwest.",
//                "US 75 at I-635",
//                "Looking northwest.",
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0026.JPG","20090623_aerial_0026-1050.JPG", "20090623_aerial_0026-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0027.JPG","20090623_aerial_0027-1050.JPG", "20090623_aerial_0027-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0028.JPG","20090623_aerial_0028-1050.JPG", "20090623_aerial_0028-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0029.JPG","20090623_aerial_0029-1050.JPG", "20090623_aerial_0029-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),  
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0030.JPG","20090623_aerial_0030-1050.JPG", "20090623_aerial_0030-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),            
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0031.JPG","20090623_aerial_0031-1050.JPG", "20090623_aerial_0031-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),              
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0032.JPG","20090623_aerial_0032-1050.JPG", "20090623_aerial_0032-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),              
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0033.JPG","20090623_aerial_0033-1050.JPG", "20090623_aerial_0033-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),             
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0034.JPG","20090623_aerial_0034-1050.JPG", "20090623_aerial_0034-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),              
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0036.JPG","20090623_aerial_0036-1050.JPG", "20090623_aerial_0036-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),            
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0037.JPG","20090623_aerial_0037-1050.JPG", "20090623_aerial_0037-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0038.JPG","20090623_aerial_0038-1050.JPG", "20090623_aerial_0038-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),            
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0039.JPG","20090623_aerial_0039-1050.JPG", "20090623_aerial_0039-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking north.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking north.",
//                "US 75 at I-635",
//                "Looking north.",
//                "2015 Status","Accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0040.JPG","20090623_aerial_0040-1050.JPG", "20090623_aerial_0040-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking northwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking northwest.",
//                "US 75 at I-635",
//                "Looking northwest.",
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0042.JPG","20090623_aerial_0042-1050.JPG", "20090623_aerial_0042-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0043.JPG","20090623_aerial_0043-1050.JPG", "20090623_aerial_0043-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0045.JPG","20090623_aerial_0045-1050.JPG", "20090623_aerial_0045-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),            
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0048.JPG","20090623_aerial_0048-1050.JPG", "20090623_aerial_0048-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"), 
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0050.JPG","20090623_aerial_0050-1050.JPG", "20090623_aerial_0050-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"), 
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0052.JPG","20090623_aerial_0052-1050.JPG", "20090623_aerial_0052-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"), 
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0053.JPG","20090623_aerial_0053-1050.JPG", "20090623_aerial_0053-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking west.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking west,",
//                "US 75 at I-635",
//                "Looking west.",                    
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0054.JPG","20090623_aerial_0054-1050.JPG", "20090623_aerial_0054-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),   
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0058.JPG","20090623_aerial_0058-1050.JPG", "20090623_aerial_0058-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),   
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0060.JPG","20090623_aerial_0060-1050.JPG", "20090623_aerial_0060-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),   
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0063.JPG","20090623_aerial_0063-1050.JPG", "20090623_aerial_0063-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),   
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0066.JPG","20090623_aerial_0066-1050.JPG", "20090623_aerial_066-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"),
//            new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0068.JPG","20090623_aerial_0068-1050.JPG", "20090623_aerial_068-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southwest.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southwest.",
//                "US 75 at I-635",
//                "Looking southwest.",                           
//                "2015 Status","Mostly accurate"), 
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0070.JPG","20090623_aerial_0070-1050.JPG", "20090623_aerial_0037-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0071.JPG","20090623_aerial_0071-1050.JPG", "20090623_aerial_0071-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0073.JPG","20090623_aerial_0073-1050.JPG", "20090623_aerial_0073-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking south.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking south.",
//                "US 75 at I-635",
//                "Looking south.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0075.JPG","20090623_aerial_0075-1050.JPG", "20090623_aerial_0075-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking southeast.",
//                "High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking southeast.",
//                "US 75 at I-635",
//                "Looking southeast.",                           
//                "2015 Status","Mostly accurate"),
//           new AerialGalleryItem(new DateTime(2006,6,23),"20090623_aerial_0076.JPG","20090623_aerial_0076-1050.JPG", "20090623_aerial_0076-2560.JPG", "high-five", 
//                "High Five Interchange, US 75 at I-635, looking east.","High Five Interchange, US 75 (Central Expressway) at I-635 (LBJ Freeway), looking east.",
//                "US 75 at I-635",
//                "Looking east.",                           
//                "2015 Status","Mostly accurate")

//        };
//        return list;
//    }
//}