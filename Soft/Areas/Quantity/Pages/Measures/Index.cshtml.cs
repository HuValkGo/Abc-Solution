using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Abc.Facade.Quantity;
using Abc.Soft.Data;

namespace Abc.Soft
{
    public class IndexModel : PageModel
    {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Abc.Soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<MeasureView> MeasureView { get;set; }

        public async Task OnGetAsync()
        {
            MeasureView = await _context.Measures.ToListAsync();
        }
    }
}
