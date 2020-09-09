using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IRetailAssignment.Models
{
    [Table("order")]
    public class Order
    {
        [Key]
        [Column("orderId")]
        public int OrderId { get; set; }

        [Column("customerId")]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [Column("productId")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("orderNo")]
        public int OrderNo { get; set; }
        
        [Column("description")]
        public string Description { get; set; }

        [Column("status")]
        public bool Status { get; set; }
    }
}