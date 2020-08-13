using DataAccess;
using System;

namespace Domain
{
    public class KeyPassGenerator
    {
        public string NewKeyPass { get; set; }

        KeyPassComparator _KPG = new KeyPassComparator();
        Random RND = new Random();

        string Characters = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUWXYZ0123456789.@*!";
        char Letter;
        public string GenKeyPass()
        {
        TryAgain:;
            for (int i = 0; i < 6; i++)
            {
                Letter = Characters[RND.Next(Characters.Length)];
                NewKeyPass += Letter.ToString();
            }
            var Verification = _KPG.KPSearch(NewKeyPass);
            if (Verification == true)
            {
                goto TryAgain;
            }
            else
                return NewKeyPass;
        }
    }
}
