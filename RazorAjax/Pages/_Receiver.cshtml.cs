using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAjax.Pages
{
    public class _ReceiverModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty]
        public string foo { get; set; }
        [BindProperty]
        public string cmd { get; set; }
        public IActionResult OnPost()
        {
            return Content("Received " + foo + " with the command " + cmd);

        }


    }
}