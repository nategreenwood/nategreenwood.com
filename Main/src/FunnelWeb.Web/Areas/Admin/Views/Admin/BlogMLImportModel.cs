﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FunnelWeb.Web.Application;
using FunnelWeb.Web.Application.Mvc;

namespace FunnelWeb.Web.Areas.Admin.Views.Admin
{
    public class BlogMLImportModel
    {
        [DisplayName("File")]
        [Required]
        [Description("Select the BlogML file you wish to upload.")]
        public FileUpload File { get; set; }
    }
}