using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Mihai_Lab.Data;
using Pop_Mihai_Lab.Models;

namespace Pop_Mihai_Lab.Pages.Clienti
{
    public class DetailsModel : PageModel
    {
        private readonly Pop_Mihai_Lab.Data.Pop_Mihai_LabContext _context;

        public DetailsModel(Pop_Mihai_Lab.Data.Pop_Mihai_LabContext context)
        {
            _context = context;
        }

        public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FirstOrDefaultAsync(m => m.ID == id);

            if (Client == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
