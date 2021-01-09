using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moldovan_Maria_AplicatieWeb.Data;
using Moldovan_Maria_AplicatieWeb.Models;

namespace Moldovan_Maria_AplicatieWeb.Pages.Retetele
{
    public class CreateModel : PageModel
    {
        private readonly Moldovan_Maria_AplicatieWeb.Data.Moldovan_Maria_AplicatieWebContext _context;

        public CreateModel(Moldovan_Maria_AplicatieWeb.Data.Moldovan_Maria_AplicatieWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Retete Retete { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Retete.Add(Retete);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
