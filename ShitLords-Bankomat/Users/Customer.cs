﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Shitlords_Bankomat
{
    public class Customer : User
    {
        public List<Account> accounts;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public override string UserType { get; set; } = "Customer";

        public bool IsBlocked { get; set; }


        public Customer(string id, string passWord, string firstName, string lastName, string userType) : base(id, passWord)
        {
            accounts = new List<Account>();
            FirstName = firstName;
            LastName = lastName;
            UserType = userType;
            IsBlocked = false;
        }
    }
}