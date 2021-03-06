﻿using CodedUI.jQueryExtensions.Test.Core;
using Nancy;

namespace CodedUI.jQueryExtensions.WebSite
{
    public class WebsiteModule : NancyModule
    {
        public WebsiteModule()
        {
            Get["/"] = _ => { return View["viewWebsiteRoot", new {}]; };

            Get[Constants.SelectorTestPath] = _ => { return View["viewSelectorTests", new {}]; };

            Get[Constants.ExistTestPath] = _ => { return View["viewExistsTests", new {}]; };

            Get[Constants.WaitForExistsTestPath] = _ => { return View["viewWaitForExistsTests", new {}]; };

            Get[Constants.ExistsInjectTests] = _ => { return View["viewJQueryExistsInjectTests", new { }]; };

            Get[Constants.NotExistsInjectTests] = _ => { return View["viewJQueryNotExistsInjectTests", new { }]; };

            Get[Constants.WaitForNotExistsTests] = _ => { return View["viewWaitForNotExistsTests", new { }]; };

            Get[Constants.MethodsPage] = _ => { return View["viewMethodsTests", new { }]; };
        }
    }
}