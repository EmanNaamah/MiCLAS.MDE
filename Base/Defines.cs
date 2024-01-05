using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCLAS.MDE
{
    public enum MDEModus
    {
        Artikelnummer = 1,
        EAN =2,
        Barcode = 3,
        EDI = 4
    }


    public struct DataConnection
    {
        public string ConnectionString;
    }    

    public sealed class PublicAttributes
    {
        public static DataConnection DataConnection;
        
        public PublicAttributes()
        {
            DataConnection = new DataConnection();
            DataConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MDEInventur.mdb;User ID=admin";

        }
    }
}
