using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

namespace StudIsu
{
    class Adapter
    {
        static string checkId = "select max Id from IsuStudents.Students.id";
        public static void Add(Student stud) 
        {
            string query = " Insert into IsuStudents.Students (Id, Name, FName,Group, Mark;) values ( {stud.Id}," + stud.Name + "," + stud.FName + "," + stud.Group + "," + Convert.ToString(stud.Mark) + ")";
            string connstring = "Data Source=(LocalDb)\v12.0;Initial Catalog=IsuStudents;Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = checkId;
            conn.Open();
            int id = command.ExecuteNonQuery();
            id++;
            query.Replace("{stud.Id}", Convert.ToString(id));
            command.CommandText = query;
            command.CommandType=System.Data.CommandType.Text;
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static void Read(Student stud)
        {
            string query = " Select * from IsuStudents.Students where id = " + Convert.ToString(stud.Id);
            string connstring = "Data Source=(LocalDb)\v12.0;Initial Catalog=IsuStudens;Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand command = conn.CreateCommand();
            command.CommandText = checkId;
            conn.Open();
            Student student = new Student();
            command.CommandText = query;
            command.CommandType = System.Data.CommandType.Text;
            
            conn.Close();
        }
    }
}
