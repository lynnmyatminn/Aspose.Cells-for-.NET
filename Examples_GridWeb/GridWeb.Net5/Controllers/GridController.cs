﻿using Aspose.Cells.GridWeb.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GridWeb.Demo.NET5._0.Controllers
{
    [Route("grid")]
    public class GridController : Controller
    {
        [HttpGet("versionp/{type}/{id}")]
        public IActionResult GetV1(string type, string id)
        {
            return new OkObjectResult("Version One home " + type + " " + id);
        }

        [HttpGet("acw/{type}/{id}")]
        [HttpPost("acw/{type}/{id}")]
        public IActionResult Operation(string type, string id)
        {
            return Aspose.Cells.GridWeb.AcwController.DoAcwAction(this, type, id);
        }

        [HttpGet("index1")]
        public IActionResult Index1()
        {
            //set a session store path
            Aspose.Cells.GridWeb.GridWeb.SessionStorePath = @"E:\storage\tmp\gridweb\filecache\";
            Aspose.Cells.GridWeb.GridWeb mw = new Aspose.Cells.GridWeb.GridWeb();
            mw.ID = "gid";
            mw.SetSession(HttpContext.Session);
            //set acw_client path
            mw.ResourceFilePath = "/js/acw_client/";
			 //set the picture cache ,you need to create this directory
            mw.PictureCachePath = @"E:\storage\tmp\gridweb\piccache";
            mw.EnableAsync = true;
            //load workbook
            String file = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\wb\test.xlsx");
            mw.ImportExcelFile(file);

            //set width height
            mw.Width = Unit.Pixel(800);
            mw.Height = Unit.Pixel(500);
            return View(mw);

        }
    }
}
