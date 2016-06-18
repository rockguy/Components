using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using System.Data;

namespace StudIsu
{
    public class Adapter
    {
        static string checkId = "SELECT max(id)  FROM [IsuStudents].[dbo].[Students]";
        static string connstring = "Data Source=ALJONA;Initial Catalog=IsuStudents;Integrated Security=SSPI";

        public static void Add(Student stud) 
        {
            string query = " Insert into [IsuStudents].[dbo].[Students] (Id, Name, FName,[Group], Mark) values ( {stud.Id},'" + stud.Name + "','" + stud.FName + "','" + stud.Group + "'," + Convert.ToString(stud.Mark) + ")";
            
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = checkId;
            conn.Open();
            int id;
            if (stud.Id == 0)
            {
                try
                {
                    id = Convert.ToInt32(command.ExecuteScalar());
                    command.Dispose();
                }
                catch
                {
                    id = 1;
                    command.Dispose();
                }
                id++;
            }
            else id = stud.Id;
            
            query=query.Replace("{stud.Id}", Convert.ToString(id));
            command.CommandText = query;
            command.CommandType=System.Data.CommandType.Text;
            command.ExecuteNonQuery();
            command.Dispose();
            conn.Close();
        }
        

        public static DataTable ReadAll()
        {
         
            string query = " Select * from [IsuStudents].[dbo].[Students]";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            
            command.CommandText = query;
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            command.Dispose();
            conn.Close();
            return dt;
        }

        public static Student Read(int id)
        {
            string query = " Select * from [IsuStudents].[dbo].[Students] where id="+id;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            Student student = new Student();
            command.CommandText = query;
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            try
            {
                var x = dt.Rows[0].ItemArray; 
            }
            catch
            {
                ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException();
                throw ex;
            }
            
            student.Id = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            student.Name = dt.Rows[0].ItemArray[1].ToString();
            student.FName = dt.Rows[0].ItemArray[2].ToString();
            student.Group = dt.Rows[0].ItemArray[3].ToString();
            student.Mark = Convert.ToDouble(dt.Rows[0].ItemArray[4]);

            command.Dispose();
            conn.Close();
            return student;
        }

        public static void Edit(Student stud)
        {
            string query = " Update [IsuStudents].[dbo].[Students] set Name = '" + stud.Name + "', FName= '" + stud.FName + "', [Group] = '" + stud.Group + "', Mark=" + Convert.ToString(stud.Mark) + " where Id="+stud.Id ;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = query;
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
            command.Dispose();
            conn.Close();
        }

        public static void Delete(int Id) 
        {
            string query = " Delete From [IsuStudents].[dbo].[Students] Where Id = " + Id;
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = query;
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
            command.Dispose();
            conn.Close();
        }
    }
}
