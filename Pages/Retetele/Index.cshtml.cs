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
    public class IndexModel : PageModel
    {
        private readonly Moldovan_Maria_AplicatieWeb.Data.Moldovan_Maria_AplicatieWebContext _context;

        public IndexModel(Moldovan_Maria_AplicatieWeb.Data.Moldovan_Maria_AplicatieWebContext context)
        {
            _context = context;
        }

        public IList<Retete> Retete { get;set; }

        public async Task OnGetAsync()
        {
            Retete = await _context.Retete.ToListAsync();
        }
    }
}
