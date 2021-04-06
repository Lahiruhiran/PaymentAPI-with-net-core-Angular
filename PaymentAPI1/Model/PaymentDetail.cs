using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI1.Model
{
    public class PaymentDetail
    {
        [Key]
        public int CardId { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public String CardHName { get; set; }
        [Column(TypeName = "nvarchar(16)")]
        public String cardNo { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        public String expireDate { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public String Securitycode { get; set; }



    }
}
