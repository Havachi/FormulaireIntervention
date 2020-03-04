using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulaireIntervention.Models
{
    public class Verification
    {
        public List<string> VerifyClientData(int clientID,List<string> listOfAllInfo)
        {

            var clientFirstName = listOfAllInfo[0];
            var clientLastName = listOfAllInfo[1];
            var clientAddress = listOfAllInfo[2];
            var clientPhoneNumber = listOfAllInfo[3];

            var DB = new DBConnection();
            var clientInfoInDB = DB.SelectOneClientInDB(clientID);

            if(clientInfoInDB[0] != listOfAllInfo[0])
            {
                listOfAllInfo[0] = clientInfoInDB[0];
            }
            if (clientInfoInDB[1] != listOfAllInfo[1])
            {
                listOfAllInfo[1] = clientInfoInDB[1];
            }
            if (clientInfoInDB[2] != listOfAllInfo[2])
            {
                listOfAllInfo[2] = clientInfoInDB[2];
            }
            if (clientInfoInDB[3] != listOfAllInfo[3])
            {
                listOfAllInfo[3] = clientInfoInDB[3];
            }
            return listOfAllInfo;
        }
    }
}