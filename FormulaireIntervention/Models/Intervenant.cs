using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormulaireIntervention.Models;

namespace FormulaireIntervention.Models
{
    public class Intervenant
    {
        private string firstName;
        private string lastName;
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public List<string> SelectAllInDB()
        {
            List<string> listIntervenant = new List<string>();
            DBConnection DB = new DBConnection();
            DB.
            

            return listIntervenant;
        }

    }
    

}