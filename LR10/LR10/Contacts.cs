using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10
{
    public class Contacts
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }
    }
    public class PersonalContacts: Contacts
    {
        public string Birthday { get; set; }
        public string Adress {  get; set; }
    }
    public class BusinessContacts: Contacts
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
    }
}
