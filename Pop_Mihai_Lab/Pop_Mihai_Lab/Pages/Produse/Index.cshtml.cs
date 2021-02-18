using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Mihai_Lab.Data;
using Pop_Mihai_Lab.Models;

namespace Pop_Mihai_Lab.Pages.Produse
{
    public class IndexModel : PageModel
    {
        private readonly Pop_Mihai_Lab.Data.Pop_Mihai_LabContext _context;

        public IndexModel(Pop_Mihai_Lab.Data.Pop_Mihai_LabContext context)
        {
            _context = context;
        }

        public IList<Produs> Produs { get;set; }

        public async Task OnGetAsync()
        {
            Produs = await _context.Produs.ToListAsync();
        }
    }
}
