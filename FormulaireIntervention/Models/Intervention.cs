using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaireIntervention.Models
{
    public class Intervention
    {
        private Client client;
        private Intervenant intervenant;
        private InterventionType interventionType;
        public Intervention()
        {

        }
        public Intervention(Client client, Intervenant intervenant, InterventionType interventionType)
        {
            this.client = client;
            this.intervenant = intervenant;          
            this.interventionType = interventionType;
        }

        public Client Client
        {
            get { return client; }
        }
        public Intervenant Intervenant
        {
            get { return intervenant; }
        }
        public InterventionType InterventionType
        {
            get { return interventionType; }
        }
        public int CalculateDuration(int intervStart, int intervStop)
        {
            return intervStop - intervStart;
        }
    }
}