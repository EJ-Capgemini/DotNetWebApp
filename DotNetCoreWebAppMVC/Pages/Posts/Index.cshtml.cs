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
    public class IndexModel : PageModel
    {
        private readonly DotNetCoreWebAppMVC.Data.ApplicationDbContext _context;

        public IndexModel(DotNetCoreWebAppMVC.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Post.ToListAsync();
        }
    }
}
