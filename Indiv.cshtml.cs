using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyCaneLane1._1.Pages
{
    public class IndivModel : PageModel
    {
        public void OnGet(int? id)
        {
            System.Diagnostics.Debug.WriteLine(id);
        }
    }
}