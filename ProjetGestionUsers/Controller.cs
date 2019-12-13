using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class Controller
    {
        public static bool DateController(string date)
        {
            bool FormatDateIsTrue = false;

            //Si l'utilisateur n'as pas entré une date, le format va être juste, parce que la date est pas obligatoire 
            if (date == "")
            {
                return true;
            }
            //Si 'utilisateur a entré une date
            else
            {
                //Le format demande yyyy.mm.dd
                string motif = @"^\(?([0-9]{4})\)?[.]?([0-9]{2})[.]?([0-9]{2})$";
                bool returnin = Regex.IsMatch(date, motif);
                FormatDateIsTrue = Regex.IsMatch(date, motif);

                if(FormatDateIsTrue == false)
                {
                    throw new ExceptionDate("Vous n'avez pas entré le bon format pour la date, exemple: 2019.01.30");
                }

                return FormatDateIsTrue;
            }

        }

        public static void ChekValuesNotVide(string value1 = "NotInfor", string value2 = "NotInfor", string value3 = "NotInfor", string value4 = "NotInfor")
        {
            if(value1 =="" || value2 == "" || value3 =="" || value4 == "")
            {
                throw new ExceptionValue("Vous n'avez pas entré les informations obligatoires");
            }
        }
    }
}
