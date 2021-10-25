using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System {
    public class Envoltorio {
        public enum DatabaseType {
            ZaragozaAirline_Test,
            ZaragozaAirline
        }

        public static string Getconnectionstring(DatabaseType dBName) {
            string ret;
            switch(dBName) {
                case DatabaseType.ZaragozaAirline:
                ret = @"Data Source=(localdb)\AirLines;Initial Catalog=ZaragozaAirlines;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                break;
                case DatabaseType.ZaragozaAirline_Test:
                ret = @"Data Source=(localdb)\AirLines;Initial Catalog=ZaragozaAirlines_Tests;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                break;
                default:
                ret = @"Data Source=(localdb)\AirLines;Initial Catalog=ZaragozaAirlines;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                break;
            }
            return ret;
        }
    }
}
