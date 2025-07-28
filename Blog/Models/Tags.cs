using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Blog.Models
{
    public class Tags
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
