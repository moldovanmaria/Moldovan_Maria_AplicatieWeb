using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Moldovan_Maria_AplicatieWeb.Data;
using Moldovan_Maria_AplicatieWeb.Models;

namespace Moldovan_Maria_AplicatieWeb.Pages.Retetele
{
    public class EditModel : PageModel
    {
        private readonly Moldovan_Maria_AplicatieWeb.Data.Moldovan_Maria_AplicatieWebContext _context;

        public EditModel(Moldovan_Maria_AplicatieWeb.Data.Moldovan_Maria_AplicatieWebContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Retete).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReteteExists(Retete.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ReteteExists(int id)
        {
            return _context.Retete.Any(e => e.ID == id);
        }
    }
}
