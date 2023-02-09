using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace Core_Project.Models.ViewModel
{
    public class CustomerVM
    {
        public CustomerVM()
        {
            this.ProductList = new List<int>();
        }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        public int Phone { get; set; }
        public string Picture { get; set; }
        public IFormFile PictureFile { get; set; }
        public bool MaritialStatus { get; set; }
        //nav
        public virtual List<int> ProductList { get; set; }
    }
}
