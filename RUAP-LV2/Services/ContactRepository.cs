﻿using RUAP_LV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RUAP_LV2.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
            {
            new Contact
            {
                Id = 1,
                Name = "Glenn Block"
            },
            new Contact
            {
                Id = 2,
                Name = "Dan Roth"
            }
            };
        }
    }
}