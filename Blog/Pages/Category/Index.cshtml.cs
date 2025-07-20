using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Blog.Pages.Category
{
    public class IndexModel(AppDBContext db) : PageModel
    {
        private readonly AppDBContext _db = db;

        public IEnumerable<Categories> Categories { get; set; }

        public async Task OnGetAsync()
        {
            Categories = await _db.Categories.ToListAsync();
        }
    }
}
