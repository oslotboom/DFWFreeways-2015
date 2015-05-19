using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    /* classes for home page */
    public class HomePage
    {
        public string ResultsString { get; set; }
        public string PdfPath { get; set; }
        public bool IsMobileDevice { get; set; }
        public List<DownloadItem> Chapters { get; set; }
        public List<DownloadItem> ExcerptsRegional { get; set; }
        public List<DownloadItem> ExcerptsDallas { get; set; }
        public List<DownloadItem> ExcerptsMidCities { get; set; }
        public List<DownloadItem> ExcerptsFortWorth { get; set; }
        public DownloadItem CompleteBook { get; set; }

        public List<KeyValuePair<string, List<DownloadItem>>> Excerpts { get; set; }
        public List<KeyValuePair<string, List<Link>>> Links { get; set; }

        //Constructor, initialize values
        public HomePage() {
            Excerpts = new List<KeyValuePair<string, List<DownloadItem>>>();
            InitializeChapters();
            InitializeExcerptsRegional();
            InitializeExcerptsDallas();
            InitializeExcerptsMidCities();
            InitializeExcerptsFortWorth();

            InitializeLinks();

            CompleteBook = new DownloadItem("Dallas-Fort-Worth_Freeways_book-20140610.pdf", "", "Dallas-Fort Worth Freeways, Texas-Sized Ambition", "541", "124 MB", "CompleteBook", "",  true);

        }

        private void InitializeChapters()
        {

            DownloadItem chapter0 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-00_cover_contents_20140803.pdf", "", "Cover, Contents and Foreword", "8", "1 MB", "ChCoverContents", "", false);

            DownloadItem chapter1 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-01-20140803.pdf", "1", "Putting North Texas Style into Freeway Openings and Celebrations", "42", "13 MB", "ChEvents", "Huge parties, crazy stunts and big-name politicians celebrated North Texas freeways", false);
            DownloadItem chapter2 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-02-20140803.pdf", "2", "Planning, Controversy and Cancellations", "32", "7 MB", "ChPlanning", "A ranking of the top freeway controversies, the long list of canceled freeways", false);
            DownloadItem chapter3 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-03-20140803.pdf", "3", "Central Expressway, the Original", "43", "11 MB", "ChCentralOriginal", "The first freeway in North Texas. See the original 1940s-era freeway and the origins of technology in the corridor", false);
            DownloadItem chapter4 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-04-20140803.pdf", "4", "Central Expressway, the Modern Freeway", "30", "9 MB", "ChCentralModern", "The huge controversy, the High Five, the Telecom Corridor and today's distinctive freeway", true);
            DownloadItem chapter5 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-05-20140803.pdf", "5", "Stemmons Freeway and the John F. Kennedy Assassination", "31", "6 MB", "ChStemmonsJFK", "See the Stemmons Freeway photos and solve the mystery of the Stemmons Freeway sign in Dealey Plaza.", true);
            DownloadItem chapter6 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-06-20140803.pdf", "6", "Dallas Freeways", "166", "40 MB", "ChDallasFreeways", "Stemmons, LBJ, Thornton Freeway, Woodall Rodgers, the toll roads and the rest of the Dallas Freeways", false);
            DownloadItem chapter7 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-07-20140803.pdf", "7", "Freeway Adventures in Dallas", "24", "5 MB", "ChDallasFreewayAdventures", "In 1970 a highly distinctive and unusual freeway safety film narrated by Mel Blanc was produced", false);
            DownloadItem chapter8 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-08-20140803.pdf", "8", "Texas Stadium Freeways", "22", "6 MB", "ChTexasStadium", "More closely surrounded by freeways than any other stadium in history. See the origins, great moments, freeway history and implosion.", false);
            DownloadItem chapter9 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-09-20140803.pdf", "9", "Tom Landry Highway", "29", "9 MB", "ChTomLandryHighway", "Originally the Dallas-Fort Worth Turnpike, home of North Texas stadiums and Six Flags Over Texas", false);
            DownloadItem chapter10 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-10-20140803.pdf", "10", "Mid-Cities Freeways", "45", "11 MB", "ChMidCitiesFreeways", "SH 114 and the Delta 191 crash, Las Colinas, the original North Texas freeway tunnel", true);
            DownloadItem chapter11 = new DownloadItem("Dallas-Fort-Worth-Freeways-book-11-20140803.pdf", "11", "Fort Worth Freeways", "67", "17 MB", "ChFortWorthFreeways", "Freeway histories, the Lancaster Elevated controversy, the life and death of the downtown freeway loop", false);
            DownloadItem index = new DownloadItem("Dallas-Fort-Worth-Freeways-book-12-author-index-20140803.pdf", "", "Index, About the Author", "10", "1 MB", "ChIndexAuthor", "", true);

            DownloadItem[] chapters = { chapter0, chapter1, chapter2, chapter3, chapter4, chapter5, chapter6, chapter7, chapter8, chapter9, chapter10, chapter11, index };

            Chapters = new List<DownloadItem>(chapters);
        }


        private void InitializeExcerptsDallas()
        {
            //Build the list of Excerpts
            DownloadItem ExStemmonsFreeway = new DownloadItem("", "", "Stemmons Freeway, Interstate 35E North", "21", "12 MB", "ExStemmonsFreeway", "", true);
            DownloadItem ExTrinityParkway = new DownloadItem("", "", "Trinity Parkway", "12", "6 MB", "ExTrinityParkway", "", false);
            DownloadItem ExWoodallRodgers = new DownloadItem("", "", "Woodall Rodgers Freeway, Spur 366", "16", "9 MB", "ExWoodallRodgers", "", false);
            DownloadItem ExLBJ = new DownloadItem("", "", "LBJ Freeway, Interstate 635", "13", "8 MB", "ExLBJ", "", false);
            DownloadItem Ex30EThornton = new DownloadItem("", "", "Interstate 30 East, the R.L. Thornton Freeway", "12", "6 MB", "Ex30EThornton", "", true);
            DownloadItem ExBush = new DownloadItem("", "", "Bush Turnpike, SH 190 and SH 161", "17", "8 MB", "ExBush", "", false);
            DownloadItem ExDNT = new DownloadItem("", "", "Dallas North Tollway", "15", "10 MB", "ExDNT", "", true);
            DownloadItem Ex175 = new DownloadItem("", "", "US 175, C.F. Hawn and S.M. Wright Freeways", "8", "4 MB", "Ex175", "", true);
            DownloadItem ExCookieCutter = new DownloadItem("", "", "The Cookie-Cutter Interchanges", "8", "7 MB", "ExCookieCutter", "", false);
            DownloadItem ExTexasStadiumImplosion = new DownloadItem("", "", "Texas Stadium Implosion, April 10, 2010", "6", "5 MB", "ExTexasStadiumImplosion", "", false);
            DownloadItem ExTelecomCorridor = new DownloadItem("", "", "Central Expressway, Technology and the Telecom Corridor", "15", "6 MB", "ExTelecomCorridor", "", false);
            DownloadItem ExStemmonsJFKFreeway = new DownloadItem("", "", "JFK Assassination and Stemmons Freeway: the Freeway Photos", "7", "2 MB", "ExStemmonsJFKFreeway", "", false);
            DownloadItem ExStemmonsJFKSigns = new DownloadItem("", "", "JFK Assassination and Stemmons Freeway: the Freeway Signs in Dealey Plaza", "19", "9 MB", "ExStemmonsJFKSigns", "", true);
            DownloadItem ExStemmonsJFKZapruder = new DownloadItem("", "", "JFK Assassination and Stemmons Freeway: the Stemmons Freeway Sign and the Zapruder Film", "4", "3 MB", "ExStemmonsJFKZapruder", "", false);
            DownloadItem[] excerpts = { ExStemmonsFreeway, ExTrinityParkway, ExWoodallRodgers, ExLBJ, Ex30EThornton, ExDNT, ExBush, Ex175, ExTelecomCorridor, ExTexasStadiumImplosion,
                                      ExCookieCutter, ExStemmonsJFKFreeway, ExStemmonsJFKSigns, ExStemmonsJFKZapruder};

            ExcerptsDallas = new List<DownloadItem>(excerpts);
            Excerpts.Add(new KeyValuePair<string, List<DownloadItem>>("Dallas", ExcerptsDallas));

        }


        private void InitializeExcerptsRegional()
        {
            //Build the list of Excerpts
            DownloadItem ExControversy = new DownloadItem("", "", "Controversy, includes a ranking of top controversies", "6", "1 MB", "ExControversy", "", false);
            DownloadItem ExCancelations = new DownloadItem("", "", "Canceled Freeways", "6", "1 MB", "ExCancelations", "",  false);
            DownloadItem[] excerpts = { ExCancelations, ExControversy };
            ExcerptsRegional = new List<DownloadItem>(excerpts);
            Excerpts.Add(new KeyValuePair<string, List<DownloadItem>>("Regional", ExcerptsRegional));
        }


        private void InitializeExcerptsMidCities()
        {
            //Build the list of Excerpts
            DownloadItem ExDFWTurnpike = new DownloadItem("", "", "The Dallas-Fort Worth Turnpike, 1957-1977", "14", "10 MB", "ExDFWTurnpike", "",  false);
            DownloadItem ExSH183 = new DownloadItem("", "", "SH 183 Airport Freeway", "12", "8 MB", "ExSH183", "",  false);
            DownloadItem ExSH114 = new DownloadItem("", "", "SH 114 Carpenter Freeway and Las Colinas", "8", "5 MB", "ExSH114", "",  true);
            DownloadItem ExDelta191 = new DownloadItem("", "", "SH 114 and the Delta 191 Crash, August 2, 1985", "8", "5 MB", "ExDelta191", "",  false);
            DownloadItem ExInternationalParkway = new DownloadItem("", "", "International Parkway and the Concorde at DFW Airport", "5", "3 MB", "ExInternationalParkway", "",  true);
            DownloadItem ExArlingtonStadiums = new DownloadItem("", "", "Tom Landry Highway: the Stadiums of Arlington", "5", "5 MB", "ExArlingtonStadiums", "",  false);
            DownloadItem ExSixFlags = new DownloadItem("", "", "Tom Landry Highway: Six Flags Over Texas", "5", "4 MB", "ExSixFlags", "", true);

            DownloadItem[] excerpts = { ExDFWTurnpike, ExSH183, ExSH114, ExDelta191, ExInternationalParkway, ExArlingtonStadiums, ExSixFlags };

            ExcerptsMidCities = new List<DownloadItem>(excerpts);
            Excerpts.Add(new KeyValuePair<string, List<DownloadItem>>("Mid-Cities", ExcerptsMidCities));

        }


        private void InitializeExcerptsFortWorth()
        {
            //Build the list of Excerpts
            DownloadItem ExFWMixmaster = new DownloadItem("", "", "Fort Worth Mixmaster", "2", "2 MB", "ExFWMixmaster", "",  false);
            DownloadItem ExFWLancaster = new DownloadItem("", "", "Fort Worth Lancaster Elevated Controversy", "12", "9 MB", "ExFWLancaster", "",  true);
            DownloadItem ExFW30 = new DownloadItem("", "", "Fort Worth Interstate 30, the West Freeway", "7", "5 MB", "ExFW30", "",  false);
            DownloadItem ExFW820 = new DownloadItem("", "", "Fort Worth Interstate 20 and Loop 820", "8", "5 MB", "ExFW820", "",  true);
            DownloadItem ExFW35WS = new DownloadItem("", "", "Fort Worth Interstate 35W South, the South Freeway", "7", "4 MB", "ExFW35WS", "",  true);
            DownloadItem ExFWDowntownLoop = new DownloadItem("", "", "Fort Worth, the Life and Death of the Downtown Freeway Loop", "6", "2 MB", "ExFWDowntownLoop", "", true);

            DownloadItem[] excerpts = { ExFWMixmaster, ExFWLancaster, ExFW30, ExFW820, ExFW35WS, ExFWDowntownLoop };

            ExcerptsFortWorth = new List<DownloadItem>(excerpts);
            Excerpts.Add(new KeyValuePair<string, List<DownloadItem>>("FortWorth", ExcerptsFortWorth));

        }

        private void InitializeLinks()
        {
            //Links = new List<KeyValuePair<string, List<Link>>>();

            //KeyValuePair<string, List<Link>> kvp = new KeyValuePair<string, List<Link>>(
            //    "Dallas",
            //    new List<Link>{
            //        new Link("I-20", "LBJ Freeway","i20-dallas"),
            //        new Link("I-30", "R.L. Thornton Freeway East","i30-east"),
            //        new Link("I-35E", "Stemmons Freeway","i35e-north"),
            //        new Link("I-45", "Schepps Freeway","i45"),
            //        new Link("I-345", "Downtown","i345"),
            //        new Link("I-635", "LBJ Freeway","i635"),
            //        });

            //Links.Add(kvp);

            Links = new List<KeyValuePair<string, List<Link>>> {
                new KeyValuePair<string, List<Link>> ("Dallas", 
                new List<Link>{
                    new Link("I-20", "LBJ Freeway","i20-dallas"),
                    new Link("I-30", "R.L. Thornton Freeway East","i30-dallas"),
                    new Link("I-35E North", "Stemmons Freeway","i35e-north"),
                    new Link("I-35E South", "R.L. Thornton Freeway South","i35e-south"),
                    new Link("I-45", "Schepps Freeway","i45"),
                    new Link("I-345", "Downtown","i345"),
                    new Link("I-635", "LBJ Freeway","i635"),
                    new Link("US 67", "Marvin Love Freeway","us67"),
                    new Link("US 75", "Central Expressway","us75"),
                    new Link("US 80", "","us80"),
                    new Link("US 175", "CF Hawn, SM Wright Freeways","us175"),
                    new Link("SH 114", "Carpenter Freeway","sh114"),
                    new Link("SH 183", "Carpenter Freeway, Airport Freeway","sh183"),
                    new Link("Bush Turnpike", "SH 190 and SH 161","bush"),
                    new Link("Dallas North Tollway", "","dnt"),
                    new Link("SH 121", "including Sam Rayburn Turnpike","sh121"),
                    new Link("Loop 12", "Walton Walker Blvd","loop12"),
                    new Link("Spur 366", "Woodall Rodgers Freeway","spur366"),
                    new Link("Spur 408", "Patriot Freeway","spur408"),
                    new Link("Collin County Outer Loop", "","ccol")

                    }),

                new KeyValuePair<string, List<Link>> ("Fort Worth", 
                new List<Link>{
                    new Link("I-20", "","i20-fort-worth"),
                    new Link("I-30", "Tom Landry Highway","i30-landry"),
                    new Link("I-30", "West Freeway","i30-west"),
                    new Link("I-35W north", "North Freeway","i35w-north"),
                    new Link("I-35W south", "South Freeway","i35w-north"),
                    new Link("I-820", "Jim Wright Freeway","i820"),
                    new Link("US 287 south", "M.L. King Freeway","us287-south"),
                    new Link("US 287 north", "","us287-north"),
                    new Link("SH 121", "Airport Freeway","sh121-fort-worth"),
                    new Link("SH 170", "Toll Road","sh170"),
                    new Link("SH 199", "","sh199"),
                    new Link("Chisholm Trail Parkway", "Toll Road","us67"),
                    }),
                new KeyValuePair<string, List<Link>> ("Mid-Cities", 
                new List<Link>{
                    new Link("I-20", "Reagan Freeway","i20-dallas"),
                    new Link("I-30", "Tom Landry Highway","i30-landry"),
                    new Link("SH 360", "Angus Wynne Freeway","sh360"),
                    new Link("SH 183/SH 121", "Airport Freeway","sh183"),
                    new Link("SH 114", "Carpenter Freeway","sh114"),
                    new Link("Bush Turnpike", "SH 161","bush-turnpike"),
                    }),
                new KeyValuePair<string, List<Link>> ("Non-Highway", 
                new List<Link>{
                    new Link("Chihuly at Dallas Arboretum", "2012","chihuly"),
                    new Link("Killers concert", "2014 at Reunion","killers")
                    }),
                };
            

        }
    }

    //public class QuickViewPage
    //{
    //    public string Title;
    //    public string PdfPath;
    //    public string PdfSize;
    //    public string PdfFile;
    //    public string ImagePath;
    //    public List<QuickViewItem> Pages;

    //}




    public class DownloadItem
    {
        public string PdfFile;
        public string ChapterNumber;
        public string Title;
        public string PageCount;
        public string PdfSizeMB;
        public string QuickViewFolder;
        public string Description;
        public bool StartOdd;//true if the first page of the chapter is an odd (right-side) page

        public DownloadItem(
            string pdfFile,
            string chapterNumber,
            string title,
            string pageCount,
            string pdfSizeMB,
            string quickViewFolder,
            string description,
            bool startOdd
        )
        {
            PdfFile = pdfFile;
            ChapterNumber = chapterNumber;
            Title = title;
            PageCount = pageCount;
            PdfSizeMB = pdfSizeMB;
            QuickViewFolder = quickViewFolder;
            Description = description;
            StartOdd = startOdd;
        }
    }

    //public class QuickViewItem
    //{
    //    public string FilePath;
    //    public bool odd;
    //}

    public class Link
    {
        public string DisplayText { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public Link(string displayText, string description, string url)
        {
            DisplayText = displayText;
            Description = description;
            Url = url;
        }
    }
}