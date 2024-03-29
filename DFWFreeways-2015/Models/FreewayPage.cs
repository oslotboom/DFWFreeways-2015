﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DFWFreeways.Models
{
    [DataContract]
    public class FreewayHome
    {
        [DataMember(Name = "pageHeader")]
        public PageHeader PageHeader { get; set; }
        [DataMember(Name = "Title")]
        public string Title { get; set; }
        [DataMember(Name = "Map")]
        public string Map { get; set; }
        [DataMember(Name = "Photo")]
        public HomePagePhoto Photo { get; set; }
        [DataMember(Name = "Text")]
        public string Text { get; set; }
        public string HighwayRouting { get; set; }
        [DataMember(Name = "Features")]
        public List<Feature> Features { get; set; }
        public string FolderPath { get; set; } 
    }

    [DataContract(Name = "photo")]
    public class HomePagePhoto
    {
        [DataMember(Name = "File")]
        public string File { get; set; }
        [DataMember(Name = "Caption")]
        public string Caption { get; set; }
        [DataMember(Name = "Date")]
        public string Date { get; set; }
    }

    [DataContract(Name = "feature")]
    public class Feature
    {
        [DataMember(Name = "FeatureType")]
        public string FeatureType { get; set; }
        public string IconText { get; set; }
        [DataMember(Name = "FeatureProperties")]
        public List<FeatureProperty> FeatureProperties { get; set; }
    }

    [DataContract(Name = "featureproperties")]
    public class FeatureProperty
    {
        [DataMember(Name = "AnchorText")]
        public string AnchorText { get; set; }
        [DataMember(Name = "AnchorUrl")]
        public string AnchorUrl { get; set; }
        [DataMember(Name = "BookText")]
        public string BookText { get; set; }
        [DataMember(Name = "Quickview")]
        public string QuickView { get; set; }
        [DataMember(Name = "Pdf")]
        public string Pdf { get; set; }
        [DataMember(Name = "video")]
        public string Video { get; set; }
        [DataMember(Name = "videoLinkSmall")]
        public string VideoLinkSmall { get; set; }
        [DataMember(Name = "videoLinkMedium")]
        public string VideoLinkMedium { get; set; }

        [DataMember(Name = "videoLinkLarge")]
        public string VideoLinkLarge { get; set; }
        [DataMember(Name = "videoLinkSmallText")]
        public string VideoLinkSmallText { get; set; }
        [DataMember(Name = "videoLinkMediumText")]
        public string VideoLinkMediumText { get; set; }
        [DataMember(Name = "videoLinkLargeText")]
        public string VideoLinkLargeText { get; set; }
    }
}