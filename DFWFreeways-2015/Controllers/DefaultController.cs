using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DFWFreeways.Models;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Configuration;
//using DFWFreeways.Models;
using System.Xml.Xsl;


namespace DFWFreeways.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            HomePage homePage = new HomePage();
            return View(homePage);
        }


        // GET: Freeway
        //public ActionResult Aerial()
        //{
        //    AerialGalleryList list = AerialGalleryList.Initialize_i635_us75();
        //    return View(list);
        //}
        // GET: Freeway
        public ActionResult Aerial(string location)
        {
            string id = (string)this.ControllerContext.RouteData.Values["id"];
            string detail = (string)this.ControllerContext.RouteData.Values["detail"];

            //AerialList aerialList = new AerialList();
            //AerialGalleryList aerialGalleryList = new AerialGalleryList(ConfigurationManager.AppSettings["AzureFileStorage"], "aerial");
            //aerialGalleryList.ItemList = (List<AerialGalleryItem>)aerialGalleryList.GetType().GetMethod(id.Replace('-', '_') + "_" + detail.Replace('-', '_')).Invoke(null, null);
            string identifier = id.Replace('-', '_') + "_" + detail.Replace('-', '_');
            string[] info = AerialGalleryList.Descriptions(identifier);
            AerialGalleryList aerialGalleryList = 

                new AerialGalleryList(ConfigurationManager.AppSettings["AzureFileStorage"], "aerial",
                    new PageHeader(info[0], info[1], GetShieldPath(id.Split('-').FirstOrDefault()), id, info[2], info[3])
                );
            if (!string.IsNullOrEmpty(AerialGalleryList.PageText(identifier)))
                aerialGalleryList.Text = AerialGalleryList.PageText(identifier);

            //AerialGalleryList aerialGalleryList = (AerialGalleryList)instance.GetType().GetMethod(id.Replace('-', '_') + "_" + detail.Replace('-', '_')).Invoke(null, new string[] { ConfigurationManager.AppSettings["AzureFileStorage"], "aerial" });
            aerialGalleryList.ItemList = (List<AerialGalleryItem>)aerialGalleryList.GetType().GetMethod(identifier + "_images").Invoke(null, null);

            //AerialGalleryList list = AerialGalleryList.i635_us75();
            return View(aerialGalleryList);
        }

        // GET: Freeway
        public ActionResult Freeway()
        {

            string id = (string)this.ControllerContext.RouteData.Values["id"];
            string detail = (string)this.ControllerContext.RouteData.Values["detail"];

            //The view depends on the path. A path with a freeway only is a freeway home page. Paths with additional items are photo pages.
            if (String.IsNullOrEmpty(detail)) { 
                FreewayHome freewayHome = new FreewayHome();

                if (id == null)
                    id = "i35e-north";
                //id = "i35w";

                byte[] bytes = System.IO.File.ReadAllBytes(Request.PhysicalApplicationPath + "App_Data\\" + id + ".json");
                //strip off first three elements, which is the BOM byte sequence
                bytes = bytes.Skip(3).ToArray();
                freewayHome = Deserialize<FreewayHome>(bytes);
                freewayHome.PageHeader.Shield = GetShieldPath(id);
                freewayHome.HighwayRouting = id;
                freewayHome.FolderPath = ConfigurationManager.AppSettings["GoogleDrive"] + id + "/";
                foreach (Feature feature in freewayHome.Features)
                {
                    feature.IconText = IconText(feature.FeatureType);
                    foreach (FeatureProperty property in feature.FeatureProperties) {
                        if (!String.IsNullOrEmpty(property.Pdf))
                            property.Pdf = ConfigurationManager.AppSettings["PdfServer"] + property.Pdf;
                        }
                }
                //var imagePage = Deserialize<ImagePage>(bytes);

                return View(freewayHome);
            }
            else
            {
                PhotoPage photoPage = new PhotoPage();
                string folderPath = ConfigurationManager.AppSettings["GoogleDrive"] + id + "/" + detail.Split('-').First() +"/";
                byte[] bytes = System.IO.File.ReadAllBytes(Request.PhysicalApplicationPath + "App_Data\\" + id + "-" + detail + ".json");
                //strip off first three elements, which is the BOM byte sequence
                bytes = bytes.Skip(3).ToArray();
                photoPage = Deserialize<PhotoPage>(bytes);
                photoPage.FolderPath = folderPath;

                photoPage.PageHeader.Shield = GetShieldPath(id); // "~/images/shields/shield-" + id.Split('-').First() + ".png";
                photoPage.PageHeader.UrlParent = id;

                //var imagePage = Deserialize<ImagePage>(bytes);

                return View("Images", photoPage);

            }
        }


        // GET: Book
        public ActionResult Book(bool startOdd, string pdfSize, string pdfFile)
        {
            string viewItem = RouteData.Values["id"].ToString();

            List<KeyValuePair<string, string>> QuickViewHeadings = QuickViewPage.InitializeDescriptions();


            //String targetDirectory = Server.MapPath("/images/book_QuickView/" + viewItem);

            String targetDirectory = Request.PhysicalApplicationPath + "images\\book\\" + viewItem;

            QuickViewPage quickViewPage = new QuickViewPage();


            ////if (viewItem == "Dallas-Fort-Worth-Freeways-Book")
            ////{
            ////    quickViewPage.Title = "Dallas-Fort Worth Freeways, the Complete Book";
            ////    ViewBag.Title = quickViewPage.Title;
            ////}
            ////else
            ////{
            ////    string title =    QuickViewHeadings.Where(r => r.Key==viewItem).FirstOrDefault().Value; 
            ////    //Get the chapter or excerpt name info for this id code
            ////    using (DFWFreewaysDBEntities db = new DFWFreewaysDBEntities())
            ////    {
            ////        RatingItem ratingItem = db.RatingItems.Where(i => i.itemCode == viewItem).FirstOrDefault();

            ////        if (ratingItem == null)
            ////        {
            ////            if (viewItem == "ChCoverContents")
            ////                quickViewPage.Title = "Cover, Contents and Foreword";
            ////            else if (viewItem == "ChIndexAuthor")
            ////                quickViewPage.Title = "Index and About the Author";
            ////        }
            ////        else
            ////            quickViewPage.Title = ratingItem.descriptionShort;
            ////    }
            ////    ViewBag.Title = "Dallas-Fort Worth Freeways " + quickViewPage.Title;
            ////}


            quickViewPage.PdfPath = System.Web.Configuration.WebConfigurationManager.AppSettings["PdfServer"].ToString();
            quickViewPage.PdfFile = pdfFile;
            quickViewPage.PdfSize = pdfSize;
            quickViewPage.Title = QuickViewHeadings.Where(r => r.Key == viewItem).FirstOrDefault().Value;
            ViewBag.Title = "Dallas-Fort Worth Freeways " + quickViewPage.Title;

            List<QuickViewItem> quickViewPages = new List<QuickViewItem>();
            string imageString = "";

            try
            {
                DirectoryInfo dir = new DirectoryInfo(targetDirectory);
                FileSystemInfo[] infos = dir.GetFileSystemInfos();

                if (infos.Length == 0)
                {

                }
                else
                {

                    int i = 1;
                    quickViewPage.ImagePath = "images/book/" + viewItem + "/";
                    foreach (FileSystemInfo fileSystemInfo in infos)
                    {
                        QuickViewItem quickViewItem = new QuickViewItem();
                        quickViewItem.FilePath = fileSystemInfo.Name;
                        quickViewItem.odd = false;
                        if (startOdd && (i % 2 == 1) || !startOdd && (i % 2 == 0))
                            quickViewItem.odd = true;

                        imageString += "'" + Url.Content("~/" + quickViewPage.ImagePath + quickViewItem.FilePath) + "',";
                        quickViewPages.Add(quickViewItem);
                        i++;
                    }

                }
            }
            catch (Exception ex)
            {
            }
            //ImageString is a list of all the images to be displayed, to be used by the recursive client-side image loader
            quickViewPage.ImageString = imageString.Substring(0, imageString.Length - 1);
            quickViewPage.Pages = quickViewPages;
            return View(quickViewPage);

        }

        // GET: Book
        public ActionResult Maps()
        {
            string xmlFile = Server.MapPath("~/App_Data/oldRoadMaps.xml");
            string xsltFile = Server.MapPath("~/App_Data/oldRoadMaps.xsl");

            string imagePath = ConfigurationManager.AppSettings["GoogleDrive"] + "old-highway-maps/";

            Maps model = new Maps("Old Highway Maps of Texas ", xmlFile, xsltFile, imagePath,
                new PageHeader("Old Highway Maps of Texas","1917-1973",string.Empty,string.Empty,string.Empty, "June 1, 2015 (add 1957 Fort Worth)")
            );

            return View(model);
        }


        public ActionResult PageNotFound()
        {
            return View();
        }

        private T Deserialize<T>(byte[] bytes)
        {
            T obj = Activator.CreateInstance<T>();
            MemoryStream ms = new MemoryStream(bytes);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(ms);
            ms.Close();
            return obj;
        }



        private string GetShieldPath(string id)
        {
            return "~/images/shields/shield-" + id.Split('-').First() + ".png";
        }

        private string GetServerPath(string id, string detail)
        {
            return "test";
        }

        private string IconText(string featureType)
        {
            switch (featureType)
            {
                case "Roadside":
                    return "Roadside Views";
                    break;
                case "DriversViews":
                    return "Driver's Views";
                    break;
                case "Book":
                    return "Book";
                    break;
                case "Construction":
                    return "Construction";
                    break;
                case "Aerial":
                    return "Aerial Views";
                    break;
                case "Historical":
                    return "Historical";
                    break;
                case "Video":
                    return "Video";
                    break;
                default:
                    return"";
                    break;
            }
        }
    }
}