using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloASP.Data {
    public class Settings {
        private static string connectionString;
        public static string ConnectionString {
            get => connectionString; set {
                if (string.IsNullOrEmpty(connectionString))
                    connectionString = value;
            }
        }
    }
}
