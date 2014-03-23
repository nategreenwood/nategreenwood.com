﻿using System.IO;
using System.Web;

namespace FunnelWeb.Web.Application.Mvc
{
    public class FileUpload
    {
        private readonly HttpPostedFileBase postedFile;

        public FileUpload(HttpPostedFileBase postedFile)
        {
            this.postedFile = postedFile;
        }

        public string FileName
        {
            get { return Path.GetFileName(postedFile.FileName); }
        }

        public void SaveTo(string fullPath)
        {
            postedFile.SaveAs(fullPath);
        }

        public Stream Stream { get { return postedFile.InputStream; } }
    }
}
