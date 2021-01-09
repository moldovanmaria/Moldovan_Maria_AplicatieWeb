using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Maria_AplicatieWeb.Data;
using Moldovan_Maria_AplicatieWeb.Models;

namespace Moldovan_Maria_AplicatieWeb.Pages.Retetele
{
    public class DeleteModel : PageModel
    {
        private readonly Moldovan_Maria_AplicatieWeb.Data.Moldovan_Maria_AplicatieWebContext _context;

        public DeleteModel(Moldovan_Maria_AplicatieWeb.Data.Moldovan_Maria_AplicatieWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Retete Retete { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Retete = await _context.Retete.FirstOrDefaultAsync(m => m.ID == id);

            if (Retete == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Retete = await _context.Retete.FindAsync(id);

            if (Retete != null)
            {
                _context.Retete.Remove(Retete);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
