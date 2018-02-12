﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RenocanWeb.Models
{
   
    public class RegistrationCompany
    {
        public int Company_ID { get; set; }
        public string CompanyName { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Owner_First_Name { get; set; }
        public string Owner_Last_Name { get; set; }
        public Nullable<bool> IsAggrement { get; set; }
        public Nullable<bool> Is_Paid { get; set; }
        public string Website_Add { get; set; }
        public string Bussiness_Description { get; set; }
        public string Profile_Information { get; set; }
        public string Products { get; set; }
        public string Services { get; set; }
        public string Brands { get; set; }
        public string Specialities { get; set; }
        public string Year_Established { get; set; }
        public string Return_Policy_URL { get; set; }
        public string Payment_Method_URL { get; set; }
        public string Licences_URL { get; set; }
        public string Insurance_URL { get; set; }
        public string Certificates_URL { get; set; }
        public string Pricing { get; set; }
        public string Contract_Based { get; set; }
        public string Warranty { get; set; }

        public int BusinessCategoryId { get; set; }
        public IEnumerable<SelectListItem> BusinessCategoryList { get; set; }

    }

}