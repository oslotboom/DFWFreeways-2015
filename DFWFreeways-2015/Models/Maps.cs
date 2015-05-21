using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFWFreeways.Models
{
    public class Maps
    {
        public string Title { get; set; }
        public PageHeader PageHeader { get; set; }
        public string XmlFile { get; set; }
        public string XsltFile { get; set; }
        public string ImagePath { get; set; }

        public Maps(string title, string xmlFile, string xsltFile, string imagePath, PageHeader pageHeader )
        {
            Title = title;
            XmlFile = xmlFile;
            XsltFile = xsltFile;
            ImagePath = imagePath;
            PageHeader = pageHeader;
        }
    }




}