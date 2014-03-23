﻿using System.Web.Mvc;
using Autofac;
using FunnelWeb.Model;
using FunnelWeb.Model.Strings;

namespace FunnelWeb.Web.Application.Mvc.Binders
{
    public class BindersModule : Module
    {
        private readonly ModelBinderDictionary binders;

        public BindersModule(ModelBinderDictionary binders)
        {
            this.binders = binders;
        }

        protected override void Load(ContainerBuilder builder)
        {
            binders.Add(typeof(PageName), new ImplicitAssignmentBinder());
            binders.Add(typeof(int[]), new ArrayBinder());
            binders.Add(typeof(FileUpload), new UploadBinder());
            binders.Add(typeof (EntryRevision), new EntryRevisionBinder());
        }
    }
}
