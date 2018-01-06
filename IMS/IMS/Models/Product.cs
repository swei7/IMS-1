using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class Item
    {
        public string Name { get; set;}
        public int Id { get; set; }
        public string PicturePath { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public double Cost { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
    }
}