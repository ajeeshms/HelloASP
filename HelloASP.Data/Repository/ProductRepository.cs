﻿using HelloASP.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HelloASP.Data.Repository {
    public class ProductRepository {
        public IEnumerable<Product> Get(int page, int size) {

            using (var connection = new SqlConnection(Settings.ConnectionString)) {

                using (var command = connection.CreateCommand()) {

                    command.CommandText = "select productid, name, productnumber, listprice from SalesLT.Product order by productid offset @skip rows fetch next @fetch rows only";
                    command.Parameters.AddWithValue("@skip", (page - 1) * size);
                    command.Parameters.AddWithValue("@fetch", size);

                    connection.Open();

                    using (var reader = command.ExecuteReader()) {

                        while (reader.Read()) {

                            yield return new Product {
                                Id = Convert.ToInt32(reader["productid"]),
                                Name = reader["name"].ToString(),
                                ProductNumber = reader["listprice"].ToString(),
                                ListPrice = Convert.ToDecimal(reader["listprice"])
                            };
                        }
                    }
                }
            }
        }

        public bool Update(Product product) {
            using (var connection = new SqlConnection(Settings.ConnectionString)) {

                using (var command = connection.CreateCommand()) {

                    command.CommandText = "update SalesLT.Product set name = @name, @listprice = @listPrice where productid = @prodId";
                    command.Parameters.AddWithValue("@prodId", product.Id);
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@listPrice", product.ListPrice);

                    connection.Open();

                    try {
                        return command.ExecuteNonQuery() == 1;
                    }
                    catch {
                        return false;
                    }
                }
            }
        }
    }
}

