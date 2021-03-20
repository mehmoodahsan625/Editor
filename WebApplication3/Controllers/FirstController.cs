using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Editor.Models;

namespace Editor.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet]
        public IActionResult Editor()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Editor(string editor)
        {
            pdf modeldata = new pdf();
                modeldata.body = editor;
                return new ViewAsPdf("_pdfPartial", modeldata)
                {
                    FileName = "MyPdfFile.pdf"
                };
            
        }
    }
}
