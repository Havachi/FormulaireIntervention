using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaireIntervention.Models
{
    public class Intervenant
    {
        private string firstName;
        private string lastName;
        public Intervenant(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
    }
}