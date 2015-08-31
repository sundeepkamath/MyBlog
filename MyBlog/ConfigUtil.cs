using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MyBlog
{
    public class ConfigUtil
    {
        public static int ReadFromConfig(string key)
        {
            int value;
            if (int.TryParse(WebConfigurationManager.AppSettings[key], out value))
                return value;
            else
                //TODO add logging support
                //TODO add error logging here
                return 0;
        }
    }
}