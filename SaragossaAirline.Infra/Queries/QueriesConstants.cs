using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaragossaAirline.Infra.Queries {
    internal class QueriesConstants {
        public const string SelectAllfromAirline="SELECT * FROM dbo.airline";
        public const string SelectAllFromAirplane="SELECT * FROM dbo.airplane";
        public const string SelectAllFromPassenger="SELECT * FROM dbo.passenger";
        public const string SelectAllFromInvoicing="SELECT * FROM dbo.invoicing";

        public const string SelectAllByIdFromAirline="SELECT * FROM dbo.airline WHERE id={0}";
        public const string SelectAllByIdfromAircraft="SELECT * FROM dbo.aircraft WHERE id={0}";
        public const string SelectAllByIdfromPassenger="SELECT * FROM dbo.passenger WHERE id={0}";
        public const string SelectAllByIdfromInvoicing="SELECT * FROM dbo.invoicing WHERE id={0}";
    }
}
