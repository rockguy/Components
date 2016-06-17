using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudIsu;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

namespace StudIsu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = NNameBox.Text;
            student.Group = NGroup.Text;
            student.FName = NFNameBox.Text;
            student.Mark = Convert.ToDouble(NMarkBox.Text);
            Adapter.Add(student);
        }

       
    }
}
