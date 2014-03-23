﻿using System;
using System.Text;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

namespace FunnelWeb.Web.Application.Mvc.ActionResults
{
    public class XmlActionResult : ActionResult
    {
        public XDocument Xml { get; protected set; }
        public string ContentType { get; set; }
        public Encoding Encoding { get; set; }

        public XmlActionResult(XDocument xml)
        {
            if (xml == null)
                throw new ArgumentNullException("xml", "XML must be provided for this feed to use");
            
            Xml = xml;
            ContentType = "text/xml";
            Encoding = Encoding.UTF8;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            response.ContentType = this.ContentType;
            response.HeaderEncoding = this.Encoding;
            
            var writer = new XmlTextWriter(response.OutputStream, this.Encoding);
            Xml.WriteTo(writer);
            writer.Close();
        }
    }
}