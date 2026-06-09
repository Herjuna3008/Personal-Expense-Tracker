using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using MockupVisProg.Models;

namespace MockupVisProg.Database
{
    public static class DbHelper
    {
        private const string ConnectionString =
            @"Server=.\SQLEXPRESS;Database=ExpenseTracker;Integrated Security=True;";

        // ── Helpers ─────────────────────────────────────────────────

        private static string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder(64);
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        // ── Auth ─────────────────────────────────────────────────────

        public static bool RegisterUser(string username, string email, string password)
        {
            try
            {
                const string sql = @"
                    INSERT INTO Users (Username, Email, Password)
                    VALUES (@Username, @Email, @Password)";

                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd  = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email",    email);
                    cmd.Parameters.AddWithValue("@Password", HashPassword(password));

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("RegisterUser error: " + ex.Message);
                return false;
            }
        }

        public static User LoginUser(string email, string password)
        {
            try
            {
                const string sql = @"
                    SELECT UserID, Username, Email, Password, CreatedAt
                    FROM Users
                    WHERE Email = @Email AND Password = @Password";

                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd  = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email",    email);
                    cmd.Parameters.AddWithValue("@Password", HashPassword(password));

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID    = reader.GetInt32(0),
                                Username  = reader.GetString(1),
                                Email     = reader.GetString(2),
                                Password  = reader.GetString(3),
                                CreatedAt = reader.GetDateTime(4)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("LoginUser error: " + ex.Message);
            }
            return null;
        }

        // ── Categories ───────────────────────────────────────────────

        public static List<Category> GetCategories()
        {
            var list = new List<Category>();
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd  = new SqlCommand("SELECT CategoryID, Name FROM Categories ORDER BY Name", conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Category
                            {
                                CategoryID = reader.GetInt32(0),
                                Name       = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("GetCategories error: " + ex.Message);
            }
            return list;
        }

        // ── Expenses ─────────────────────────────────────────────────

        public static List<Expense> GetAllExpenses()
        {
            var list = new List<Expense>();
            try
            {
                const string sql = @"
                    SELECT e.ExpenseID, e.Date, e.Description, e.CategoryID,
                           c.Name AS CategoryName, e.Amount
                    FROM Expenses e
                    INNER JOIN Categories c ON e.CategoryID = c.CategoryID
                    WHERE e.UserID = @UserID
                    ORDER BY e.Date DESC";

                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd  = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", Session.CurrentUser.UserID);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Expense
                            {
                                ExpenseID    = reader.GetInt32(0),
                                Date         = reader.GetDateTime(1),
                                Description  = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                CategoryID   = reader.GetInt32(3),
                                CategoryName = reader.GetString(4),
                                Amount       = reader.GetDecimal(5)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("GetAllExpenses error: " + ex.Message);
            }
            return list;
        }

        public static bool AddExpense(Expense e)
        {
            try
            {
                const string sql = @"
                    INSERT INTO Expenses (Date, Description, CategoryID, Amount, UserID)
                    VALUES (@Date, @Description, @CategoryID, @Amount, @UserID)";

                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd  = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Date",        e.Date);
                    cmd.Parameters.AddWithValue("@Description", (object)e.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CategoryID",  e.CategoryID);
                    cmd.Parameters.AddWithValue("@Amount",      e.Amount);
                    cmd.Parameters.AddWithValue("@UserID",      Session.CurrentUser.UserID);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("AddExpense error: " + ex.Message);
                return false;
            }
        }

        public static DataTable GetExpensesByMonth(int month, int year, int userID)
        {
            var dt = new DataTable();
            try
            {
                const string sql = @"
                    SELECT e.Date,
                           e.Description,
                           c.Name AS Kategori,
                           e.Amount
                    FROM Expenses e
                    INNER JOIN Categories c ON e.CategoryID = c.CategoryID
                    WHERE MONTH(e.Date) = @Month
                      AND YEAR(e.Date)  = @Year
                      AND e.UserID      = @UserID
                    ORDER BY e.Date ASC";

                using (var conn    = new SqlConnection(ConnectionString))
                using (var adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Month",  month);
                    adapter.SelectCommand.Parameters.AddWithValue("@Year",   year);
                    adapter.SelectCommand.Parameters.AddWithValue("@UserID", userID);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("GetExpensesByMonth error: " + ex.Message);
            }
            return dt;
        }

        public static decimal GetTotalByMonth(int month, int year, int userID)
        {
            try
            {
                const string sql = @"
                    SELECT ISNULL(SUM(Amount), 0)
                    FROM Expenses
                    WHERE MONTH(Date) = @Month
                      AND YEAR(Date)  = @Year
                      AND UserID      = @UserID";

                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd  = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Month",  month);
                    cmd.Parameters.AddWithValue("@Year",   year);
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    conn.Open();
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("GetTotalByMonth error: " + ex.Message);
                return 0;
            }
        }

        public static bool DeleteExpense(int id)
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd  = new SqlCommand("DELETE FROM Expenses WHERE ExpenseID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("DeleteExpense error: " + ex.Message);
                return false;
            }
        }

        public static DataTable GetExpensesAsDataTable()
        {
            var dt = new DataTable();
            try
            {
                const string sql = @"
                    SELECT e.ExpenseID, e.Date, e.Description,
                           c.Name AS Kategori, e.Amount
                    FROM Expenses e
                    INNER JOIN Categories c ON e.CategoryID = c.CategoryID
                    WHERE e.UserID = @UserID
                    ORDER BY e.Date DESC";

                using (var conn    = new SqlConnection(ConnectionString))
                using (var adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@UserID", Session.CurrentUser.UserID);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("GetExpensesAsDataTable error: " + ex.Message);
            }
            return dt;
        }
    }
}
