using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int userID { get; set; }
        public static string userPosition { get; set; }
        public static string userName { get; set; }
        public static string userLastName { get; set; }
        public static int userBornYear { get; set; }
        public static string userAccessLevel { get; set; }


    }
}
