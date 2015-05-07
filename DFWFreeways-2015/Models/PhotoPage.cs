using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DFWFreeways.Models
{
    [DataContract]
    public class PhotoPage
    {
        [DataMember(Name = "pageHeader")]
        public PageHeader PageHeader { get; set; }
        [DataMember(Name = "folderPath")]
        public string FolderPath { get; set; }
        //[DataMember(Name = "title")]
        //public string Title { get; set; }
        public string Shield { get; set; }
        //[DataMember(Name = "displayNumber")]
        //public string DisplayNumber { get; set; }
        //public string Parent { get; set; }
        [DataMember(Name = "map")]
        public string Map { get; set; }
        //[DataMember(Name = "lastUpdated")]
        //public string LastUpdated { get; set; }
        [DataMember(Name = "text")]
        public string Text { get; set; }
        [DataMember(Name = "hasThumbnailImages")]
        public bool HasThumbnails=false;
        [DataMember(Name = "images")]
        public List<Image> Images { get; set; }
    }

    [DataContract(Name = "image")]
    public class Image
    {
        [DataMember(Name = "file")]
        public string File { get; set; }
        [DataMember(Name = "highResolution")]
        public string HighResolution { get; set; }
        [DataMember(Name = "caption")]
        public string Caption { get; set; }
        [DataMember(Name = "imageDate")]
        public string ImageDate { get; set; }
        [DataMember(Name = "imageStatus")]
        public ImageStatus Status { get; set; }
    } 
    [DataContract(Name = "imageStatus")]
    public class ImageStatus
    {
        [DataMember(Name = "statusDate")]
        public string StatusDate { get; set; }
        [DataMember(Name = "status")]
        public string Status { get; set; }
        [DataMember(Name = "note")]
        public string Note { get; set; }
    }

}