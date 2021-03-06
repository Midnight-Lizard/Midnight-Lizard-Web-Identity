﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidnightLizard.Web.Identity.Models.ManageViewModels
{
    public class IndexViewModel
    {
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name = "Display name")]
        public string DisplayName { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
