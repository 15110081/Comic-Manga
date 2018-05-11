using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DataProvider
    {
        //public static string Server= "169.254.107.107";
        public string server;
        public string userId;
        public string Pass;
        public string database;
        //Phương thức dùng để mở kết nối đến csdl  DESKTOP-RTBB5RM\SQLEXPRESS
       string connectionSTR = @"Data Source=MINH-PC\SQLEXPRESS;Initial Catalog=truyentranh;Integrated Security=True";

        //server + database + userId + Pass + ";Integrated Security = true"
        //public static string connectionSTR = string.Format("{0} {1} {2} {3} ; Integrated Security=true",new object[] { });
        private static volatile DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }
        public bool checkconnect()
        {
            bool f = true;
            using (SqlConnection conn = new SqlConnection(server + userId + Pass + ";Integrated Security = true"))
            {
                try
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();
                }
                catch (Exception)
                {
                    f = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return f;
        }
        public static SqlConnection KetNoi()
        {
            string sChuoiKetNoi = string.Format(@"Data Source=MINH-PC\SQLEXPRESS;Initial Catalog=truyentranh;Integrated Security=True");
            SqlConnection conn = new SqlConnection(sChuoiKetNoi);
            conn.Open();
            return conn;
        }
        //Phương thức ngắt kết nối

        public static void NgatKetNoi(SqlConnection conn)
        {
            conn.Close();
        }
        //Phương thức truy vấn đến cơ sở dữ liệu trả về kết quả là datatable ("thường ứng với câu lệnh select")
        public DataTable TruyVanDataTable(string sChuoiTruyVan)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sChuoiTruyVan, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    connection.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }

            }
        }
        //Phương thức truy vấn đến cơ sở dữ liệu trả về kết quả là datatable ("thường ứng với câu lệnh select")
        public DataTable TruyVanDataReader(string sChuoiTruyVan)
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sChuoiTruyVan, connection);
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    connection.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        public SqlDataReader TruyVanExecuteReader(string sChuoiTruyVan)
        {
            SqlDataReader rd;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sChuoiTruyVan, connection);
                rd = cmd.ExecuteReader();
            }
            return rd;
        }
        public static SqlCommand TaoCommand(string sChuoiTruyVan)
        {
            SqlConnection conn = KetNoi();
            try
            {
                SqlCommand cmd = new SqlCommand(sChuoiTruyVan, conn);
                return cmd;
            }
            catch (Exception ex)
            {
                NgatKetNoi(conn);
                return null;
            }
        }
        //Phương thức thực hiện các câu lệnh truy vấn như insert, update, delete
        public bool TruyVanExecuteNonQuery(string sChuoiTruyVan)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(sChuoiTruyVan, connection);
                    int iCMD = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (iCMD > 0)
                    {
                        return true; //Truy vấn thành công
                    }
                    else
                    {
                        return false; //Thất bại
                    }
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return false;
                }
            }
        }
        //Phương thức trả về 1 giá trị 
        public DataSet TruyVanDataSet(string query, object[] parameter = null)
        {
            DataSet data = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
        public SqlDataReader SelectExecuteReader(string query, object[] parameter = null)
        {
            SqlDataReader rd;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }//CommandBehavior.CloseConnection
                rd = command.ExecuteReader();
                connection.Close();
            }
            return rd;
        }
        public bool SelectExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                             if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();
                    connection.Close();
                }
                
            }
            catch (Exception ex)
            {
                throw;
                return false;
            }
            if (data > 0)
            {
                return true; //Truy vấn thành công
            }
            else
            {
                return false; //Thất bại
            }
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

    }
}
