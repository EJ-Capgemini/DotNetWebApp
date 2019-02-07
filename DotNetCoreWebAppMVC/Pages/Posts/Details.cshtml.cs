using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetCoreWebAppMVC.Data;
using DotNetCoreWebAppMVC.Models;

namespace DotNetCoreWebAppMVC.Pages.Posts
{
    public class DetailsModel : PageModel
    {
        private readonly DotNetCoreWebAppMVC.Data.ApplicationDbContext _context;

        public DetailsModel(DotNetCoreWebAppMVC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Post Post { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Post = await _context.Post.FirstOrDefaultAsync(m => m.ID == id);

            if (Post == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
