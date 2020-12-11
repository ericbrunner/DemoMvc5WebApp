using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        [Required]
        public string ContactName
        {
            get;
            set;
        }

        public string CustomerID
        {
            get;
            set;
        }

        [Required]
        public string Country
        {
            get;
            set;
        }

        [DataType(DataType.Date)]
        public DateTime BirthDay
        {
            get;
            set;
        }
    }

}