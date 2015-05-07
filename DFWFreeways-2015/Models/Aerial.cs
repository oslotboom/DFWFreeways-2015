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
        public string LowRes {
            get
            {
                return _lowRes;
            }
            set
            {
                _lowRes = value;
                //set the thumbnail image based on the lowRes file name. This assumes only one occurrence of "-" in the lowres file name
                if (_lowRes.Split('-').Length==2)
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

        public AerialGalleryItem (
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
            //fields are title, subtitle, return Url test, last updated
            switch (page) {
                case "i35e_north_all": info = new string[] { "I-35E All Aerials", "", "I-35E North", "June 1, 2015" }; break;
                case "i35e_north_i35e_i635": info = new string[] { "I-35E at I-635", "", "I-35E North", "June 1, 2015" }; break;
                case "i35e_north_american_airlines_center": info = new string[] { "American Airlines Center", "", "I-35E North", "June 1, 2015" }; break;
                case "i35e_north_market_center": info = new string[] { "I-35E at Dallas Market Center", "", "I-35E North", "June 1, 2015" }; break;
                case "i35e_north_i35e_sh121": info = new string[] { "I-35E at SH 121/Sam Rayburn Turnpike", "", "I-35E North", "June 1, 2015" }; break;
                case "i35e_north_i35e_bush": info = new string[] { "I-35E at Bush Turnpike", "", "I-35E North", "June 1, 2015" }; break;
                case "bush_bush_i35e": info = new string[] { "Bush Turnpike at I-35E", "", "Bush Turnpike", "June 1, 2015" }; break;

                    }
            return info;
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