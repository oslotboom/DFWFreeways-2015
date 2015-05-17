using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {


        public static List<AerialGalleryItem> dnt_plano_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"","", "", "aerial", 
                    "Dallas North Tollway in Plano",
                    "Dallas North Tollway in Plano, looking ",
                    "Dallas North Tollway in Plano",
                    "Looking ."),
                new AerialGalleryItem(new DateTime(2011,4,16),"","", "", "aerial", 
                    "Dallas North Tollway in Plano",
                    "Dallas North Tollway in Plano, looking ",
                    "Dallas North Tollway in Plano",
                    "Looking ."),
                new AerialGalleryItem(new DateTime(2011,4,16),"","", "", "aerial", 
                    "Dallas North Tollway in Plano",
                    "Dallas North Tollway in Plano, looking ",
                    "Dallas North Tollway in Plano",
                    "Looking ."),
                new AerialGalleryItem(new DateTime(2011,4,16),"","", "", "aerial", 
                    "Dallas North Tollway in Plano",
                    "Dallas North Tollway in Plano, looking ",
                    "Dallas North Tollway in Plano",
                    "Looking ."),
                new AerialGalleryItem(new DateTime(2011,4,16),"","", "", "aerial", 
                    "Dallas North Tollway in Plano",
                    "Dallas North Tollway in Plano, looking ",
                    "Dallas North Tollway in Plano",
                    "Looking .")
            
            };
        }
    }
}