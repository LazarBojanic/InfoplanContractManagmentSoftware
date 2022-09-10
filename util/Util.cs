using System;
using System.Data.OleDb;

namespace CSharp_SQL_App.util {
    public static class Util {
        public static OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
        public static DateTime dateTimeWithoutMilliseconds(DateTime date) {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
        }
    }
}