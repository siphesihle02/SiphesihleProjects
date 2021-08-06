﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Fruits_SA_Devloper_Test.Models
{
    public class product
    {
        [Key]
     public int id { get; set; }
      [Required(ErrorMessage = "Please correct product code")]
      [DisplayName("Product Code")]
     public string productCode { get; set; }
     [Required(ErrorMessage = "Please enter  a product name")]
     [DisplayName("Product Name")]
     public string productName { get; set; }
     [DisplayName("Description")]
    public string description { get; set; }
     [Required(ErrorMessage = "Please choose a product category")]
     [DisplayName("Category Name")]
      public string categoryName { get; set; }
        [Required(ErrorMessage = "Please enter price")]
        [DisplayName("Price")]
        public  double price { get; set; }
        [DisplayName(" Product Image")]
        public byte image { get; set; }
        public virtual category Category { get; set; }
    }
}