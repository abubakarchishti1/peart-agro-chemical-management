using System;
using System.Data;
using MySql.Data.MySqlClient;
using PeartAgroChemicalsManagementSystem.DAL;

namespace PeartAgroChemicalsManagementSystem.BLL
{
    public class StockBLL
    {
        public DataTable GetAllPesticides()
        {
            string query = @"SELECT p.PesticideID, p.ProductName, 
                            c.CategoryName, p.Company, p.FormType,
                            p.UnitPrice, p.StockQty, p.MinStockLevel,
                            p.ExpiryDate, p.RegistrationNo
                            FROM Pesticides p
                            LEFT JOIN Categories c 
                            ON p.CategoryID = c.CategoryID
                            ORDER BY p.ProductName";
            return DBHelper.ExecuteQuery(query);
        }

        public DataTable GetLowStock()
        {
            string query = @"SELECT p.ProductName, c.CategoryName,
                            p.StockQty, p.MinStockLevel, p.Company
                            FROM Pesticides p
                            LEFT JOIN Categories c 
                            ON p.CategoryID = c.CategoryID
                            WHERE p.StockQty <= p.MinStockLevel
                            ORDER BY p.StockQty ASC";
            return DBHelper.ExecuteQuery(query);
        }

        public DataTable GetExpiredStock()
        {
            string query = @"SELECT p.ProductName, c.CategoryName,
                            p.StockQty, p.ExpiryDate, p.Company
                            FROM Pesticides p
                            LEFT JOIN Categories c 
                            ON p.CategoryID = c.CategoryID
                            WHERE p.ExpiryDate < CURDATE()
                            ORDER BY p.ExpiryDate ASC";
            return DBHelper.ExecuteQuery(query);
        }

        public bool AddStockIn(int pesticideID, int supplierID,
                               int quantity, decimal unitCost, string remarks)
        {
            decimal totalCost = quantity * unitCost;

            MySqlParameter[] prms = {
                new MySqlParameter("@pid",  pesticideID),
                new MySqlParameter("@sid",  supplierID),
                new MySqlParameter("@qty",  quantity),
                new MySqlParameter("@cost", unitCost),
                new MySqlParameter("@tot",  totalCost),
                new MySqlParameter("@rem",  remarks ?? "")
            };

            string query = @"INSERT INTO StockIn 
                (PesticideID, SupplierID, Quantity, 
                 UnitCost, TotalCost, Remarks)
                VALUES 
                (@pid, @sid, @qty, @cost, @tot, @rem)";

            int rows = DBHelper.ExecuteNonQuery(query, prms);

            if (rows > 0)
            {
                string update = @"UPDATE Pesticides 
                                 SET StockQty = StockQty + @qty
                                 WHERE PesticideID = @pid";
                MySqlParameter[] up = {
                    new MySqlParameter("@qty", quantity),
                    new MySqlParameter("@pid", pesticideID)
                };
                DBHelper.ExecuteNonQuery(update, up);
                return true;
            }
            return false;
        }

        public bool AddStockOut(int pesticideID, int quantity,
                                decimal unitPrice, string customerName, string remarks)
        {
            string checkQty = "SELECT StockQty FROM Pesticides WHERE PesticideID = @pid";
            MySqlParameter[] chk = {
                new MySqlParameter("@pid", pesticideID)
            };
            int available = Convert.ToInt32(DBHelper.ExecuteScalar(checkQty, chk));

            if (available < quantity)
                throw new Exception("Stock available nahi! Available: " + available);

            decimal totalAmount = quantity * unitPrice;

            MySqlParameter[] prms = {
                new MySqlParameter("@pid",  pesticideID),
                new MySqlParameter("@qty",  quantity),
                new MySqlParameter("@up",   unitPrice),
                new MySqlParameter("@tot",  totalAmount),
                new MySqlParameter("@cust", customerName ?? ""),
                new MySqlParameter("@rem",  remarks ?? "")
            };

            string query = @"INSERT INTO StockOut
                (PesticideID, Quantity, UnitPrice,
                 TotalAmount, CustomerName, Remarks)
                VALUES
                (@pid, @qty, @up, @tot, @cust, @rem)";

            int rows = DBHelper.ExecuteNonQuery(query, prms);

            if (rows > 0)
            {
                string update = @"UPDATE Pesticides 
                                 SET StockQty = StockQty - @qty
                                 WHERE PesticideID = @pid";
                MySqlParameter[] up = {
                    new MySqlParameter("@qty", quantity),
                    new MySqlParameter("@pid", pesticideID)
                };
                DBHelper.ExecuteNonQuery(update, up);
                return true;
            }
            return false;
        }

        public DataTable GetStockInHistory()
        {
            string query = @"SELECT si.StockInID, p.ProductName,
                            s.SupplierName, si.Quantity,
                            si.UnitCost, si.TotalCost, si.StockInDate
                            FROM StockIn si
                            JOIN Pesticides p ON si.PesticideID = p.PesticideID
                            JOIN Suppliers s  ON si.SupplierID  = s.SupplierID
                            ORDER BY si.StockInDate DESC";
            return DBHelper.ExecuteQuery(query);
        }

        public DataTable GetStockOutHistory()
        {
            string query = @"SELECT so.StockOutID, p.ProductName,
                            so.CustomerName, so.Quantity,
                            so.UnitPrice, so.TotalAmount, so.StockOutDate
                            FROM StockOut so
                            JOIN Pesticides p ON so.PesticideID = p.PesticideID
                            ORDER BY so.StockOutDate DESC";
            return DBHelper.ExecuteQuery(query);
        }

        public int GetTotalProducts()
        {
            string q = "SELECT COUNT(*) FROM Pesticides";
            return Convert.ToInt32(DBHelper.ExecuteScalar(q));
        }

        public int GetLowStockCount()
        {
            string q = "SELECT COUNT(*) FROM Pesticides WHERE StockQty <= MinStockLevel";
            return Convert.ToInt32(DBHelper.ExecuteScalar(q));
        }

        public int GetExpiredCount()
        {
            string q = "SELECT COUNT(*) FROM Pesticides WHERE ExpiryDate < CURDATE()";
            return Convert.ToInt32(DBHelper.ExecuteScalar(q));
        }
    }
}