using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public partial class AerialGalleryList
    {
        public static List<AerialGalleryItem> loop12_all_images()
        {
            List<AerialGalleryItem> itemList = new List<AerialGalleryItem>(AerialGalleryList.loop12_diamond_images());
            itemList.AddRange(AerialGalleryList.loop12_trinity_images());
            itemList.AddRange(AerialGalleryList.loop12_davis_images());
            itemList.AddRange(AerialGalleryList.loop12_i30_images());
            return itemList;
        }

        public static List<AerialGalleryItem> loop12_trinity_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2011,4,16),"20110416_aerial_0331.JPG","20110416_aerial_0331-1050.jpg", "20110416_aerial_0331-2560.jpg", "aerial", 
                    "Loop 12 at the Trinity River",
                    "Loop 12 at the Trinity River, looking south",
                    "Loop 12 at the Trinity River",
                    "Looking south."),

                new AerialGalleryItem(new DateTime(2005,4,11),"","4_loop_12_looking_n_at_trinity_2006-05-30_ADJ_900.jpg", "4_loop_12_looking_n_at_trinity_2006-05-30_ADJ_2548x1761.png", "aerial", 
                    "Loop 12 at the Trinity River",
                    "Loop 12 at the Trinity River, looking north",
                    "Loop 12 at the Trinity River",
                    "Looking north.")

            
            };
        }

        public static List<AerialGalleryItem> loop12_davis_images()
        {

            return new List<AerialGalleryItem>() {
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0411.JPG","20110416_aerial_0411-1050.jpg", "20110416_aerial_0411-2560.jpg", "aerial", 
                    "Loop 12 at Davis/Jefferson",
                    "Loop 12 at Davis/Jefferson, looking north",
                    "Loop 12 at Davis/Jefferson",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0414.JPG","20110416_aerial_0414-1050.jpg", "20110416_aerial_0414-2560.jpg", "aerial", 
                    "Loop 12 at Davis/Jefferson",
                    "Loop 12 at Davis/Jefferson, looking north",
                    "Loop 12 at Davis/Jefferson",
                    "Looking north."),
                new AerialGalleryItem(new DateTime(2005,4,11),"20110416_aerial_0416.JPG","20110416_aerial_0416-1050.jpg", "20110416_aerial_0416-2560.jpg", "aerial", 
                    "Loop 12 at Davis/Jefferson",
                    "Loop 12 at Davis/Jefferson, looking north",
                    "Loop 12 at Davis/Jefferson",
                    "Looking north.")
            
            };
        }
    }
}