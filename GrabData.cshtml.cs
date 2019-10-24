using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyCaneLane1._1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CandyCaneLane1._1.Pages
{
    public class GrabDataModel : PageModel
    {
        public ApplicationDbContext _db { get; set; }

        public IList<Candies> Candies { get; set; }

        public GrabDataModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task OnGetAsync()
        {
            Candies = await _db.Candies.ToListAsync();
        }
    }
}