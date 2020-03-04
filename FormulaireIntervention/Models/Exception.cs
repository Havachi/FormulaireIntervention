using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaireIntervention.Models
{
    public class InvalidDBCommand : Exception
    {
        public InvalidDBCommand (string message) : base(message)
        {

        }
    }
    public class UnknownClient : Exception
    {
        public UnknownClient (string message) : base(message)
        {

        }
    }
    public class MultipleUserWithSameName : Exception
    {
        public MultipleUserWithSameName (string message) : base(message)
        {

        }
    }
}