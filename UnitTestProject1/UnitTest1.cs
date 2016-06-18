using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudIsu;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public Student student = new Student() { Id = 1, Name = "abcdefg", FName = "абвгдеёж", Group = "777", Mark = 100 };
        [TestMethod]
        public void DbTest()
        {
            string connstring = "Data Source=ALJONA;Initial Catalog=IsuStudents;Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            conn.Close();
        }

        [TestMethod]
        public void AddReadTest()
        {            
            Adapter.Add(student);
           Assert.IsTrue(SameStudent(Adapter.Read(student.Id), student));
           Adapter.Delete(student.Id);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(ArgumentOutOfRangeException))]
        public void DeleteTest() {
            Adapter.Add(student);
            Adapter.Delete(student.Id);
            Adapter.Read(student.Id);
        }

        [TestMethod]
        public void Edit()
        {
            Adapter.Add(student);
            Student student2 = new Student() { Id = student.Id, Name = "Жёедгвба",FName=student.FName,Group=student.Group,Mark=student.Mark };
            Adapter.Edit(student2);
            Assert.IsFalse(SameStudent(Adapter.Read(student.Id), student));
            Adapter.Delete(student.Id);
        }

        public bool SameStudent(Student stud1, Student stud2)
        {
            return (stud1.Id == stud2.Id)&&(stud1.Name==stud2.Name)&&(stud1.FName==stud2.FName)&&(stud1.Group==stud2.Group)&&(stud1.Mark==stud2.Mark);
        
        }
    }
}
