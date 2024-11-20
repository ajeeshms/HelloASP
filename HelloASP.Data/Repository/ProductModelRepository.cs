﻿using HelloASP.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloASP.Data.Repository {
    public class ProductModelRepository {
        public IEnumerable<ProductModel> Get(int page, int size) {

            using (var connection = new SqlConnection(Settings.ConnectionString)) {

                using (var command = connection.CreateCommand()) {

                    command.CommandText = "select productmodelid, name from SalesLT.productmodel order by productmodelid offset @skip rows fetch next @fetch rows only";
                    command.Parameters.AddWithValue("@skip", (page - 1) * size);
                    command.Parameters.AddWithValue("@fetch", size);

                    connection.Open();

                    using (var reader = command.ExecuteReader()) {

                        while (reader.Read()) {

                            yield return new ProductModel {
                                Id = Convert.ToInt32(reader["productmodelid"]),
                                Name = reader["name"].ToString()
                            };
                        }
                    }
                }
            }
        }
    }
}
