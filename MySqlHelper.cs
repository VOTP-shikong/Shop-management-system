using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Shop_management_system
{
    public class MySqlHelper
    {
        public static string connectStr = "server=localhost;user id=root;password=13823860223a;database=shop;";
        // 定义静态字符串connectStr，用于保存数据库连接字符串

        public static int ExecuteNonQuery(string sqlStr, params MySqlParameter[] para)
        {
            // 定义静态的ExecuteNonQuery方法，用于执行非查询SQL语句，并返回受影响的行数
            // 方法参数包括一个sqlStr字符串用于存储SQL查询语句，一个参数数组para用于存储SQL参数

            using (MySqlConnection con = new MySqlConnection(connectStr))
            {
                // 使用关键字using创建MySqlConnection对象con，并将connectStr作为构造函数的参数进行初始化
                // using关键字可自动释放资源，确保连接被正确关闭

                con.Open();
                // 打开数据库连接

                using (MySqlCommand cmd = new MySqlCommand(sqlStr, con))
                {
                    // 使用关键字using创建MySqlCommand对象cmd，并将sqlStr和con作为构造函数的参数进行初始化
                    // using关键字可自动释放资源，确保命令对象被正确释放

                    try
                    {
                        if (para != null)
                        {
                            // 判断参数数组是否为null

                            foreach (MySqlParameter p in para)
                            {
                                // 遍历参数数组中的每个参数

                                cmd.Parameters.AddWithValue(p.ParameterName, p.Value);
                                // 将参数名和参数值添加到命令对象中
                            }
                        }

                        return cmd.ExecuteNonQuery();
                        // 执行SQL语句并返回受影响的行数
                    }
                    catch (Exception ex)
                    {
                        // 捕获异常并抛出
                        throw ex;
                    }
                }
            }
        }

        public static DataSet ExecuteQuery(string sqlStr, params MySqlParameter[] para)
        {
            // 定义静态的ExecuteQuery方法，用于执行查询SQL语句，并返回结果DataSet
            // 方法参数包括一个sqlStr字符串用于存储SQL查询语句，一个参数数组para用于存储SQL参数

            using (MySqlConnection con = new MySqlConnection(connectStr))
            {
                // 使用关键字using创建MySqlConnection对象con，并将connectStr作为构造函数的参数进行初始化
                // using关键字可自动释放资源，确保连接被正确关闭

                con.Open();
                // 打开数据库连接

                using (MySqlCommand cmd = new MySqlCommand(sqlStr, con))
                {
                    // 使用关键字using创建MySqlCommand对象cmd，并将sqlStr和con作为构造函数的参数进行初始化
                    // using关键字可自动释放资源，确保命令对象被正确释放

                    try
                    {
                        if (para != null)
                        {
                            // 判断参数数组是否为null

                            foreach (MySqlParameter p in para)
                            {
                                // 遍历参数数组中的每个参数

                                cmd.Parameters.AddWithValue(p.ParameterName, p.Value);
                                // 将参数名和参数值添加到命令对象中
                            }
                        }

                        DataSet ds = new DataSet();
                        // 创建一个DataSet对象用于存储查询结果

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        // 创建一个MySqlDataAdapter对象，用于执行查询命令

                        da.Fill(ds);
                        // 使用DataAdapter的Fill方法将查询结果填充到DataSet对象中

                        return ds;
                        // 返回填充后的DataSet对象
                    }
                    catch (Exception ex)
                    {
                        // 捕获异常并抛出
                        throw ex;
                    }
                }
            }
        }
        public static int ExecuteScalar(string sqlStr, params MySqlParameter[] para)
        {
            using (MySqlConnection con = new MySqlConnection(connectStr))
            {
                // 使用关键字using创建MySqlConnection对象con，并将connectStr作为构造函数的参数进行初始化
                // using关键字可自动释放资源，确保连接被正确关闭

                con.Open();
                // 打开数据库连接

                using (MySqlCommand cmd = new MySqlCommand(sqlStr, con))
                {
                    // 使用关键字using创建MySqlCommand对象cmd，并将sqlStr和con作为构造函数的参数进行初始化
                    // using关键字可自动释放资源，确保命令对象被正确释放

                    try
                    {
                        if (para != null)
                        {
                            // 判断参数数组是否为null

                            foreach (MySqlParameter p in para)
                            {
                                // 遍历参数数组中的每个参数

                                cmd.Parameters.AddWithValue(p.ParameterName, p.Value);
                                // 将参数名和参数值添加到命令对象中
                            }
                        }
                        if(cmd.ExecuteScalar() == null)
                        {
                            return 0;
                        }
                        else
                        {
                            int result = Convert.ToInt32(cmd.ExecuteScalar());
                            return result;
                        }
                        //cmd.ExecuteScalar();
                        //Console.WriteLine("ExecuteScalar returned {0:c}", amount);
                        //return result;
                        // 执行SQL语句并返回受影响的行数
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return 0;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
        public static string getposition(string sqlStr, params MySqlParameter[] para)
        {
            using (MySqlConnection con = new MySqlConnection(connectStr))
            {
                // 使用关键字using创建MySqlConnection对象con，并将connectStr作为构造函数的参数进行初始化
                // using关键字可自动释放资源，确保连接被正确关闭

                con.Open();
                // 打开数据库连接

                using (MySqlCommand cmd = new MySqlCommand(sqlStr, con))
                {
                    // 使用关键字using创建MySqlCommand对象cmd，并将sqlStr和con作为构造函数的参数进行初始化
                    // using关键字可自动释放资源，确保命令对象被正确释放
                    foreach (MySqlParameter p in para)
                    {
                        // 遍历参数数组中的每个参数

                        cmd.Parameters.AddWithValue(p.ParameterName, p.Value);
                        // 将参数名和参数值添加到命令对象中
                    }
                    string position = Convert.ToString(cmd.ExecuteScalar());
                    return position;
                }
            }
        }
        public static string getsomething(string sqlStr, params MySqlParameter[] para)//查询返回单个结果
        {
            using (MySqlConnection con = new MySqlConnection(connectStr))
            {
                // 使用关键字using创建MySqlConnection对象con，并将connectStr作为构造函数的参数进行初始化
                // using关键字可自动释放资源，确保连接被正确关闭

                con.Open();
                // 打开数据库连接

                
                using (MySqlCommand cmd = new MySqlCommand(sqlStr, con))
                {
                    if (para != null)
                    {
                        // 使用关键字using创建MySqlCommand对象cmd，并将sqlStr和con作为构造函数的参数进行初始化
                        // using关键字可自动释放资源，确保命令对象被正确释放
                        foreach (MySqlParameter p in para)
                        {
                            // 遍历参数数组中的每个参数

                            cmd.Parameters.AddWithValue(p.ParameterName, p.Value);
                            // 将参数名和参数值添加到命令对象中
                        }
                    }
                    string s = Convert.ToString(cmd.ExecuteScalar());
                    return s;
                }
            }
        }
    }
}
