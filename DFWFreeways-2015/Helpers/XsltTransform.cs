using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Xsl;
using System.IO;

namespace DFWFreeways.Helpers
{
    public static class HtmlHelperXmlExtensions
    {
        /// <summary>
        /// Applies an XSL transformation to an XML document.
        /// </summary>
        public static HtmlString RenderXml(this HtmlHelper helper, string xmlPath, string xsltPath, string imagePath)
        {
            XsltArgumentList args = new XsltArgumentList();
            args.AddParam("imagePath", "", imagePath);

            XslCompiledTransform t = new XslCompiledTransform();
            t.Load(xsltPath);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationType = ValidationType.DTD;

            using (XmlReader reader = XmlReader.Create(xmlPath, settings))
            {
                StringWriter writer = new StringWriter();
                t.Transform(reader, args, writer);
                return new HtmlString(writer.ToString());
            }

        }

    }
}

