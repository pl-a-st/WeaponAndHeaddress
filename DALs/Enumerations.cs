using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public enum TableType
    {
        Weapon,
        Headdress
    }

    public static class TableName
    {
        public static string GetTableNameByTableType(TableType tableType)
        {
            switch (tableType)
            {
                case TableType.Headdress:
                    return "Headdress";
                case TableType.Weapon:
                    return "Weapon";
                default:
                    return string.Empty;
            }
        }         
    }
}
