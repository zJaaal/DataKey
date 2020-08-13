using DataAccess;
using System;

namespace Domain
{
    public class IDGenerator
    {
        public string NewID { get; set; }
        Random _ran = new Random();
        IDComparator _IDC = new IDComparator();
        public string GenID()
        {
        TryAgain:

            NewID = _ran.Next(0, 999999).ToString();

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
