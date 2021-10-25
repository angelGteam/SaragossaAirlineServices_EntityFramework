using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System {
    public class Envoltorio {
        public enum Database {
            ZaragozaAirline_Test,
            ZaragozaAirline
        }

        public static string Getconnectionstring(Database dBName) {
            string ret;
            switch(dBName) {
                case Database.ZaragozaAirline:
                ret = @"Data Source=(localdb)\AirLines;Initial Catalog=ZaragozaAirlines;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                break;
                case Database.ZaragozaAirline_Test:
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
