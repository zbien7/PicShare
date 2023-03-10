using PicShare.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PicShare.Models
{
    public class PhotographyViewModel
    {
        public PhotoGraphy photoGraphy { get; set; }
        public List<PhotoGraphy> photoGraphyList { get; set; }
    }
}
