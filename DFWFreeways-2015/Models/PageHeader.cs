using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace DFWFreeways.Models
{
    [DataContract(Name = "pageHeader")]
    public class PageHeader
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "subTitle")]
        public string Subtitle { get; set; }
        public string Shield { get; set; }
        public string UrlParent { get; set; }
        [DataMember(Name = "urlParentText")]
        public string UrlParentText { get; set; }
        [DataMember(Name = "lastUpdated")]
        public string LastUpdated { get; set; }

        public PageHeader(
            string title,
            string subTitle,
            string shield,
            string urlParent,
            string urlParentText,
            string lastUpdated)
        {
            Title = title;
            Subtitle = subTitle;
            Shield = shield;
            UrlParent = urlParent;
            UrlParentText = urlParentText;
            LastUpdated = lastUpdated;
        }
    }
}