using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PicShare.Areas.Identity.Data
{
    public class PhotoGraphy
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Category { get; set; }
        [StringLength(255)]
        public string Path { get; set; }
        public int? NoOfViews { get; set; }

        [NotMappedAttribute]
        [Required(ErrorMessage = "Photo is required.")]
        public List<IFormFile> filePhoto { get; set; }
        public string ApplicationUserId { get; internal set; }
    }
}
