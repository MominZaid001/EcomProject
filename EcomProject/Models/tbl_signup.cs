//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcomProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_signup
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Need User Name")]
        public string userName { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        public string email { get; set; }

        [StringLength(10, ErrorMessage = "The Mobile must contains 10 characters", MinimumLength = 10)]
        public decimal phoneNum { get; set; }

        [DataType(DataType.Password)]
        public string userPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("userPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string C_userPassword { get; set; }
    
        public virtual tbl_login tbl_login { get; set; }
    }
}