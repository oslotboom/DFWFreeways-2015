using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DFWFreeways.Models;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> us287_south_freeway_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_083.JPG","20090928_ft_worth_083-1050.jpg", "20090928_ft_worth_083-2560.jpg", "aerial", 
                    "US 287 MLK Freeway",
                    "US 287 MLK Freeway looking northwest",
                    "US 287 MLK Freeway",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_085.JPG","20090928_ft_worth_085-1050.jpg", "20090928_ft_worth_085-2560.jpg", "aerial", 
                    "US 287 MLK Freeway",
                    "US 287 MLK Freeway looking northwest",
                    "US 287 MLK Freeway",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_089.JPG","20090928_ft_worth_089-1050.jpg", "20090928_ft_worth_089-2560.jpg", "aerial", 
                    "US 287 MLK Freeway",
                    "US 287 MLK Freeway looking northwest",
                    "US 287 MLK Freeway",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_092.JPG","20090928_ft_worth_092-700.jpg", "20090928_ft_worth_092-1700.jpg", "aerial", 
                    "US 287 MLK Freeway",
                    "US 287 MLK Freeway looking northwest",
                    "US 287 MLK Freeway",
                    "Looking northwest."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_096.JPG","20090928_ft_worth_096-1050.jpg", "20090928_ft_worth_096-2560.jpg", "aerial", 
                    "US 287 MLK Freeway",
                    "US 287 MLK Freeway looking southeast",
                    "US 287 MLK Freeway",
                    "Looking southeast."),
                new AerialGalleryItem(new DateTime(2009,9,28),"20090928_ft_worth_080.JPG","20090928_ft_worth_080-1050.jpg", "20090928_ft_worth_080-2560.jpg", "aerial", 
                    "Lake Arlington",
                    "Lake Arlington looking southeast",
                    "Lake Arlington",
                    "Nearby Lake Arlington looking southeast, with I-820 in the lower part of the photo.")
            
            };
        }
    }
}