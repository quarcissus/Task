using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuxoftTaskGerardoAcostaOlvera
{

    /// <summary>
    /// Public Class that will storage the currency Codes that will be used in the application
    /// </summary>
    public partial class CURRENCYCODES
    {
        public const string US = "US";
        public const string MXN = "MXN";
    }

    /// <summary>
    /// Public Class that will storage the country denomination that will be used in the application
    /// </summary>
    public partial class CURRENCYDENOMINATIONS
    {
        public static readonly decimal[] US = { 0.01m, 0.05m, 0.10m, 0.25m, 0.50m, 1.00m, 2.00m, 5.00m, 10.00m, 20.00m, 50.00m, 100.00m };
        public static readonly decimal[] MXN = { 0.05m, 0.10m, 0.20m, 0.50m, 1.00m, 2.00m, 5.00m, 10.00m, 20.00m, 50.00m, 100.00m };
    }

    /// <summary
    /// /// Class that will storage the global variables that will be used in the application
    /// </summary>
    public partial class COUNTRYGLOBALDATA
    {
        /// <summary>Currency code of the country we want to use</summary>
        public const string CURRENCYCODE = CURRENCYCODES.US;

        /// <summary>Denomination of the country we want to use</summary>
        public static readonly decimal[] DENOMINATION = CURRENCYDENOMINATIONS.US;
    }
   

}
