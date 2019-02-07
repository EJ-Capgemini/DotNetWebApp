using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DotNetCoreWebAppMVC.Data;
using DotNetCoreWebAppMVC.Models;

namespace DotNetCoreWebAppMVC.Pages.Posts
{
    public class CreateModel : PageModel
    {
        private readonly DotNetCoreWebAppMVC.Data.ApplicationDbContext _context;

        public CreateModel(DotNetCoreWebAppMVC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Post Post { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Post.Add(Post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}