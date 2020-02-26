using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaireIntervention.Models
{
    public class Signature
    {
        public string SignatureDataUrl { get; set; }
        public void OnPost()
        {
            if (string.IsNullOrWhiteSpace(SignatureDataUrl))
            {
                return;
            }

            var base64Signature = SignatureDataUrl.Split(',')[1];
            var binarySignature = Convert.FromBase64String(base64Signature);

            System.IO.File.WriteAllBytes("Signature.png", binarySignature); 
        }
    }
}