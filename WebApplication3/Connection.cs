using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Connection
    {
        public string connstring = "data source=DCODETECH\\SQLEXPRESS;database=crudapp;integrated security=SSPI";
        public string connect()
        {
            return connstring;
        }
    }
}