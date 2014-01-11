using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace DurandalNancy
{
    public class DurandalNancyModule : NancyModule
    {
        public DurandalNancyModule()
        {
            Get["/"] = p => View["index"];

            Get["/api/list"] = p => Response.AsJson(new
            {
                Title = "Durandal & Nancy",
                Message = "Super-Duper-Happy SPA Done Right!"
            });
        }
    }
}