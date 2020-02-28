using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaireIntervention.Models
{
    public abstract class Client
    {
        protected int id;
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
        protected Client(int id, string FirstName, string LastName, string PhoneNumber, string Address)
        {
            this.id = id;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.phoneNumber = PhoneNumber;
            this.address = Address;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}