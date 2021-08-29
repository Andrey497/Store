using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.Sql;
using Microsoft.SqlServer.Server;

namespace CLRFunction1
{
    public class Class1
    {
        [SqlFunctionAttribute()]
        public static SqlString StringFormat(SqlString inputString)
        {
            String str = inputString.ToString();
            str = str.Trim();
            String OutputSting = "";
            OutputSting +=char.ToUpper(str[0])+(str.Substring(1)).ToLower();
            return new SqlString(OutputSting);
        }
       
    }
}
