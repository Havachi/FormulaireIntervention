using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaireIntervention.Models
{
    public class InterventionType
    {
        private string interventionType;
        public InterventionType (string interventionType)
        {
            this.interventionType = interventionType;
        }
        public string Type
        {
            get { return interventionType; }
            set { interventionType = value; }
        }
    }
}