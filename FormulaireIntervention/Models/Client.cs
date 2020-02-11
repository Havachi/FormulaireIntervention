using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaireIntervention.Models
{
    public abstract class Client
    {
        protected string firstName;
        protected string lastName;
        protected string phoneNumber;
        protected string address;

        protected Client()
        {

        }

        protected Client(string FirstName, string LastName, string PhoneNumber, string Address)
        {

            this.firstName = FirstName;
            this.lastName = LastName;
            this.phoneNumber = PhoneNumber;
            this.address = Address;
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
        public string Address
        {
            get { return address; }
        }
    }
}