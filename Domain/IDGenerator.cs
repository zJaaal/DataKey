using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace Domain
{
    public class IDGenerator
    {
        public string NewID { get; set; }
        Random _ran = new Random();
        public string GenID()
        {
            TryAgain:
            NewID = _ran.Next(0, 999999).ToString();
            IDComparator _IDC = new IDComparator();
            _IDC.IDSearch(NewID);
            var Verification = _IDC.IDSearch(NewID);
            if (Verification == true)
            {
                goto TryAgain;
            }
            else
            {
                return NewID;
            }
        }
    }
}
