using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pop_Mihai_Lab.Data;
using Pop_Mihai_Lab.Models;

namespace Pop_Mihai_Lab.Pages.Comenzi
{
    public class CreateModel : PageModel
    {
        private readonly Pop_Mihai_Lab.Data.Pop_Mihai_LabContext _context;

        public CreateModel(Pop_Mihai_Lab.Data.Pop_Mihai_LabContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClientID"] = new SelectList(_context.Client, "ID", "ID");
        ViewData["ProdusID"] = new SelectList(_context.Produs, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Comanda Comanda { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Comanda.Add(Comanda);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
