using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CxCE_Demo
{
class PasswordExample
{
    public static string GetPassword()
    {
        return ConfigurationManager.AppSettings["password"];
    }
}

    class Constants
    {
        public static string DB_PASSWORD = PasswordExample.GetPassword();
    }
}
