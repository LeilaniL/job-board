using System.Collections.Generic;

namespace JobBoard.Models
{
    public class JobOpening
    {
        private string _title;
        private string _description;
        private Contacts _contactObject = new Contacts(name, phone);
        public JobOpening(string title, string description, Contacts contactObject)
        {
            _title = title;
            _description = description;
            _contactObject = contactObject;


        }
        public string GetTitle()
        {
            return _title;
        }
    }
    public class Contacts
    {
        private string _name;
        private string _phone;
        public Contacts(string name, string phone)
        {
            _name = name;
            _phone = phone;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetPhone()
        {
            return _phone;
        }
    }

}