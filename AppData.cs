using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLITHUVIENSQL1
{
    internal class AppData
    {
        public const int Role_User = 2;
        public const int Role_Admin = 1;

        public static bool isLogin = false;
        public static string username;
        public static string fullname;
        public static int role;

    }
}
