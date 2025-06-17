using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebMVCApp.Data
{
    public class Customer
    {
        public int CustId {  get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}