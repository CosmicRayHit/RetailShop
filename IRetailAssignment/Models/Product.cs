using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IRetailAssignment.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Column("productId")]
        public int ProductId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("price")]
        public int Price { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
    }
}