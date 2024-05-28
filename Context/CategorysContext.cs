using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;
using ПР42_Осокин.Classes;
using ПР42_Осокин.Modell;

namespace ПР42_Осокин.Context
{
    public class CategorysContext : Categorys
    {
        public static ObservableCollection<CategorysContext> AllCategorys()
        {
            ObservableCollection<CategorysContext> allCategorys = new ObservableCollection<CategorysContext>();
            SqlConnection connection;
            SqlDataReader dataCategorys = Classes.Connection.Query("SELECT * FROM Categorys", out connection);
            while (dataCategorys.Read())
            {
                allCategorys.Add(new CategorysContext()
                {
                    Id = dataCategorys.GetInt32(0),
                    Name = dataCategorys.GetString(1)
                });
            }
            Classes.Connection.CloseConnection(connection);
            return allCategorys;
        }
    }
}
