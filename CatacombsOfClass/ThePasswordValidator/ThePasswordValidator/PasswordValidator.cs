﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePasswordValidator
{
    internal class PasswordValidator
    {
        MessageOutput MO = new();
        string _password;
        public PasswordValidator(string password)
        {
            _password = password;
        }

        public void ValidatePasswordLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 13)
            {
                CheckForDisallowedCharacters(password);
            } else
            {
                MO.DisplayMessage("That password is not the correct length, the password has to be between 6 & 13 characters long");
            }
        }

        private void CheckForDisallowedCharacters(string password)
        {
            if (password.Contains('T') || (password.Contains('&')))
            {
                MO.DisplayMessage("The password contains invalid characters T or &, please re-enter the password");
            } else
            {
                ValidateIndividualCharacters(password);
            }
        }

        private void ValidateIndividualCharacters(string password)
        {
            int upperCaseCount = 0;
            int lowerCaseCount = 0;
            int numberCount = 0;
                foreach (char letter in password)
                {
                    if (char.IsUpper(letter))
                    {
                        upperCaseCount++;
                    } else if (char.IsLower(letter))
                    {
                        lowerCaseCount++;
                    } else if (char.IsDigit(letter))
                    {
                        numberCount++;
                    }
                }

            if (upperCaseCount > 0 && lowerCaseCount > 0 && numberCount > 0)
            {
                ValidatePassword();
            } else
            {
                MO.DisplayMessage("That is an invalid password, the password needs to have alteast 1 capital letter, 1 lowercase letter & 1 numerical digit!");
            }
        }

        private void ValidatePassword()
        {
            MO.DisplayMessage("That password is valid!");
        }

    }
}
