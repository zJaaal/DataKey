using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Cache
{
    //* You'll use this cache data for register form, when you search using the ID you can modify every TextBox and selection for Access Level, then there will be an update button that will send the new information to the Data Base*//
    //* Don't forget about the delete button*//
    public static class RegisterCache
    {
        public static int userID { get; set; }
        public static string userPosition { get; set; }
        public static string userName { get; set; }
        public static string userLastName { get; set; }
        public static int userBornYear { get; set; }
        public static string userAccessLevel { get; set; }
        public static string userKeyPass { get; set; }
    }
}
