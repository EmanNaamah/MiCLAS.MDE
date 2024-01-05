using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MiCLAS.MDE.Base
{
    public static class ExtensionUtil
    {
        #region DataReader Extension

        public static bool IsDateNull(this IDataReader reader, string colName)
        {
            return (reader.IsDbNull(colName));
        }


        public static double GetDoubleValue(this IDataReader reader, string colName)
        {
            return (double)GetValue(reader, colName, 0.0);
        }

        public static string GetStringValue(this IDataReader reader, string colName)
        {
            return (string)GetValue(reader, colName, "");
        }

        public static DateTime GetDateValue(this IDataReader reader, string colName)
        {
            return (DateTime)GetValue(reader, colName, DateTime.MinValue);
        }

        public static bool GetBoolValue(this IDataReader row, string colName)
        {
            return (bool)GetValue(row, colName, false);
        }

        public static int GetIntValue(this IDataReader reader, string colName)
        {
            return (int)GetValue(reader, colName, -1);
        }

        public static object GetValue(this IDataReader reader, string colName, object nullValue)
        {
            object value = GetValue(reader, colName);

            if (value == null)
                value = nullValue;

            return value;
        }



        public static object GetValue(this IDataReader reader, string colName)
        {
            object value = null;

            if (reader != null && !reader.IsClosed && !string.IsNullOrEmpty(colName))
            {
                value = reader.GetValue(reader.GetOrdinal(colName));
                if (value is DBNull)
                    value = null;
            }

            return value;
        }



        public static bool IsDbNull(this IDataReader reader, string colName)
        {
            bool result = false;

            if (reader != null && !reader.IsClosed && !string.IsNullOrEmpty(colName))
            {
                object value = reader.GetValue(reader.GetOrdinal(colName));
                if (value is DBNull)
                    result = true;
            }

            return result;

        }


        #endregion DataReader Extension

        #region DataRows Extension     

        public static double GetDoubleValue(this DataRow row, string colName)
        {
            return (double)GetValue(row, colName, 0.0);
        }

        public static string GetStringValue(this DataRow row, string colName)
        {
            return (string)GetValue(row, colName, "");
        }

        public static DateTime GetDateValue(this DataRow row, string colName)
        {
            return (DateTime)GetValue(row, colName, DateTime.MinValue);
        }

       

        public static int GetIntValue(this DataRow row, string colName)
        {
            return (int)GetValue(row, colName, -1);
        }

        public static bool GetBoolValue(this DataRow row, string colName)
        {
            return (bool)GetValue(row, colName, false);
        }

        public static object GetValueDb(this DataRow row, string colName)
        {
            return GetValue(row, colName, DBNull.Value);
        }

        public static object GetValue(this DataRow row, string colName, object nullValue = null)
        {
            object value = nullValue;

            if (row != null && !string.IsNullOrEmpty(colName))
            {
                if (row.Table == null || row.Table.Columns.Contains(colName))
                {
                    try
                    {
                        if (!Convert.IsDBNull(row[colName]))
                            value = row[colName];
                    }
                    catch (Exception ex)
                    {
                        string message = "GetValue(): " + (row.Table != null ? "Table " + row.Table.TableName : "") + " Column: " + colName;
                        throw new Exception(message, ex);
                    }
                }
            }

            return value;
        }

        public static bool IsRowValid(this DataRow row, string pkName = "", object pkValue = null)
        {
            bool result = (row != null && row.RowState != DataRowState.Deleted);

            if (result && !string.IsNullOrEmpty(pkName) && pkValue != null)
            {
                result = (row.Table != null && row.Table.Columns.Contains(pkName));
                if (result)
                    result = (row.GetValue(pkName) == pkValue);
            }
            return result;
        }

        public static bool IsRowAccesible(this DataRow row)
        {
            return (row != null && row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached);
        }

        /// <summary>
        /// prüft, ob row aktuell ist
        /// </summary>
        /// <param name="row"></param>
        /// <param name="pkName"></param>
        /// <param name="pkValue"></param>
        /// <returns></returns>
        public static bool IsRowCurrent(this DataRow row, string pkName = "", object pkValue = null)
        {
            bool result = (row != null && row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached);
            if (result && !string.IsNullOrEmpty(pkName) && pkValue != null)
            {
                result = (row.Table != null && row.Table.Columns.Contains(pkName));
                if (result)
                    result = (row.GetValue(pkName).Equals((object)pkValue));
            }
            return result;
        }

        public static bool IsDbNull(this DataRow row, string colName)
        {
            bool result = false;

            if (row != null && !string.IsNullOrEmpty(colName))
            {
                if (row.Table == null || row.Table.Columns.Contains(colName))
                {
                    result = Convert.IsDBNull(row[colName]);
                }
            }

            return result;

        }
        /// <summary>
        /// check if date is valid
        /// </summary>
        /// <param name="row">DataRow instance</param>
        /// <param name="colName">Column name</param>
        /// <returns></returns>
        public static bool IsDateNull(this DataRow row, string colName)
        {
            return (row.IsDbNull(colName));
        }

        public static bool IsColumnChanged(this DataRow row, string colName)
        {
            bool changed = false;

            if (row != null && row.Table != null && row.Table.Columns.Contains(colName))
            {
                DataColumn col = row.Table.Columns[colName];

                if (!row.HasVersion(DataRowVersion.Original))
                    changed = (Convert.IsDBNull(col.DefaultValue) || !row[col.ColumnName].Equals(col.DefaultValue));
                else if (row.HasVersion(DataRowVersion.Proposed))
                {
                    DataRowVersion version = (row.HasVersion(DataRowVersion.Original)) ? DataRowVersion.Original : DataRowVersion.Default;
                    changed = (!row[col, version].Equals(row[col, DataRowVersion.Proposed]));
                }
                else if (row.HasVersion(DataRowVersion.Current))
                    changed = (!row[col, DataRowVersion.Original].Equals(row[col, DataRowVersion.Current]));
            }

            return changed;
        }

        public static bool IsRowOfTable(this DataRow row, string tableName)
        {
            return (row != null && row.Table != null && row.Table.TableName == tableName);
        }

        public static bool IsRowNew(this DataRow row)
        {
            return (row != null && (row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached));
        }
        

        #endregion DataRows Extension
    }
}
