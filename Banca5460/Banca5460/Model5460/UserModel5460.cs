using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Banca5460.Model5460
{
    public class UserModel5460
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string FLastName { get; set; }
        public string MLastName { get; set; }
        public ObservableCollection <Phone> PhoneNumber { get; set; }
        public ObservableCollection <Accounts> Accounts { get; set; }
    }

    public class Phone
    {
        public string id { get; set; }
        public string Number { get; set; }
    }

    public class Accounts
    {
        public string id { get; set; }
        public string Name { get; set; }
    } 
}
