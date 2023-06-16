using Bloggie2.Data;
using Bloggie2.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Bloggie2.Pages.Admin.Blogs
{
    public class ListModel : PageModel
    {
        private readonly BloggieDbContext bloggieDbContext;
        public List<BlogPost> BlogPosts { get; set; }
        public ListModel(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }
        public async Task OnGet()
        {
            BlogPosts = await bloggieDbContext.BlogPosts.ToListAsync();
        }
    }
}
