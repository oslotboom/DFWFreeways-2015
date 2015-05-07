using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public class QuickViewPage
    {
        public string Title;
        public string PdfPath;
        public string PdfSize;
        public string PdfFile;
        public string ImagePath;
        public string ImageString; //This is a comma-separated string with the paths to all the images to be displayed
        public List<QuickViewItem> Pages;

        public static List<KeyValuePair<string, string>> InitializeDescriptions () {
            return new List<KeyValuePair<string, string>> {
                
new KeyValuePair<string, string>("Dallas-Fort-Worth-Freeways-Book", "Dallas-Fort Worth Freeways, the Complete Book"),
new KeyValuePair<string, string>("ChCoverContents", "Cover, Contents and Foreword"),
new KeyValuePair<string, string>("ChEvents", "Chapter 1: Putting North Texas Style into Freeway Openings and Celebrations"),
new KeyValuePair<string, string>("ChPlanning", "Chapter 2: Planning, Controversy and Cancellations"),
new KeyValuePair<string, string>("ChTexasStadium", "Chapter 8: Texas Stadium Freeways"),
new KeyValuePair<string, string>("ChTomLandryHighway", "Chapter 9: Tom Landry Highway"),
new KeyValuePair<string, string>("ChStemmonsJFK", "Chapter 5: Stemmons Freeway and the John F. Kennedy Assassination"),
new KeyValuePair<string, string>("ChCentralOriginal", "Chapter 3: Central Expressway, the Original"),
new KeyValuePair<string, string>("ChCentralModern", "Chapter 4: Central Expressway"),
new KeyValuePair<string, string>("ChDallasFreeways", "Chapter 6: Dallas Freeways"),
new KeyValuePair<string, string>("ChDallasFreewayAdventures", "Chapter 7: Freeway Adventures in Dallas"),
new KeyValuePair<string, string>("ChMidCitiesFreeways", "Chapter 10: Mid Cities Freeways"),
new KeyValuePair<string, string>("ChFortWorthFreeways", "Chapter 11: Fort Worth Freeways"),
new KeyValuePair<string, string>("ChIndexAuthor", "Index and About the Author"),
new KeyValuePair<string, string>("ExIllustrations", "Excerpt: Illustrations and Cartoons"),
new KeyValuePair<string, string>("ExDelta191", "Chapter 10 Excerpt: SH 114 and the Delta 191 Crash"),
new KeyValuePair<string, string>("ExTexasStadiumImplosion", "Chapter 8 Excerpt: Texas Stadium Implosion"),
new KeyValuePair<string, string>("ExWoodallRodgers", "Chapter 6 Excerpt: Woodall Rodgers Freeway"),
new KeyValuePair<string, string>("ExArlingtonStadiums", "Chapter 9 Excerpt: Tom Landry Highway and the Stadiums of Arlington"),
new KeyValuePair<string, string>("ExSixFlags", "Chapter 9 Excerpt: Tom Landry Highway and Six Flags Over Texas"),
new KeyValuePair<string, string>("ExTelecomCorridor", "Excerpt from Chapters 3 and 4: The Telecom Corridor (Central Expressway in Richardson)"),
new KeyValuePair<string, string>("ExStemmonsFreeway", "Chapter 6 Excerpt: Interstate 35E North Stemmons Freeway"),
new KeyValuePair<string, string>("ExStemmonsJFKFreeway", "Chapter 5 Excerpt: JFK Assassination Stemmons Freeway Photos"),
new KeyValuePair<string, string>("ExStemmonsJFKSigns", "Chapter 5 Excerpt: JFK Assassination Dealey Plaza Freeway Signs"),
new KeyValuePair<string, string>("ExStemmonsJFKZapruder", "Chapter 5 Excerpt: JFK Assassination Zapruder Film and the Stemmons Freeway Sign"),
new KeyValuePair<string, string>("ExLBJ", "Chapter 6 Excerpt: Interstate 635 LBJ Freeway"),
new KeyValuePair<string, string>("Ex30EThornton", "Chapter 6 Excerpt: Interstate 30 East R.L. Thornton Freeway"),
new KeyValuePair<string, string>("Ex175", "Chapter 6 Excerpt: US 175, S.M. Wright and C.F. Hawn Freeways"),
new KeyValuePair<string, string>("ExDNT", "Chapter 6 Excerpt: Dallas North Tollway"),
new KeyValuePair<string, string>("ExBush", "Chapter 6 Excerpt: Bush Turnpike, SH 190 and SH 161"),
new KeyValuePair<string, string>("ExTrinityParkway", "Chapter 6 Excerpt: The Trinity Parkway"),
new KeyValuePair<string, string>("Ex35ESThornton", "Chapter 6 Excerpt: Interstate 35E South R.L. Thornton Freeway"),
new KeyValuePair<string, string>("ExSH114", "Chapter 10 Excerpt: SH 114 Carpenter Freeway and Las Colinas"),
new KeyValuePair<string, string>("ExInternationalParkway", "Chapter 10 Excerpt: International Parkway and the Concorde at DFW"),
new KeyValuePair<string, string>("ExDFWTurnpike", "Chapter 9 Excerpt: The Dallas-Fort Worth Turnpike"),
new KeyValuePair<string, string>("ExEventsPoliticians", "Chapter 1 Excerpt: Politicians and Freeway Events"),
new KeyValuePair<string, string>("ExSH183", "Chapter 10 Excerpt: SH 183 including the Greater Southwest International Airport"),
new KeyValuePair<string, string>("ExFWLancaster", "Chapter 11 Excerpt: The Fort Worth Lancaster Elevated Controversy"),
new KeyValuePair<string, string>("ExFWMixmaster", "Chapter 11 Excerpt: The Fort Worth Mixmaster"),
new KeyValuePair<string, string>("ExFWDowntownLoop", "Chapter 11 Excerpt: The Life and Death of the Fort Worth Downtown Freeway Loop"),
new KeyValuePair<string, string>("ExFW30", "Chapter 11 Excerpt: Interstate 30, the West Freeway"),
new KeyValuePair<string, string>("ExFW35WS", "Chapter 11 Excerpt: Interstate 35W South, the South Freeway"),
new KeyValuePair<string, string>("ExFW820", "Chapter 11 Excerpt: Interstate 820"),
new KeyValuePair<string, string>("ExCookieCutter", "Chapter 6 Excerpt: The Cookie Cutter Interchanges"),
new KeyValuePair<string, string>("ExPlanning", "Chapter 2 Excerpt: Freeway Planning"),
new KeyValuePair<string, string>("ExControversy", "Chapter 2 Excerpt: Freeway Controversy"),
new KeyValuePair<string, string>("ExCancelations", "Chapter 2 Excerpt: Canceled Freeways")
            };
        }
    }

    public class QuickViewItem
    {
        public string FilePath;
        public bool odd;
    }

    
}