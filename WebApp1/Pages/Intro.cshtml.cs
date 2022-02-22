using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1.Pages
{
    public class IntroModel : PageModel
    {
        public int Number1 { get; set; } = 0;
        public int Number2 { get; set; } = 0;

        public void OnGet()
        {
        }
    }
}
