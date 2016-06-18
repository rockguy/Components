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
          dataGridView1.DataSource = Adapter.ReadAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = NNameBox.Text;
            student.Group = NGroupBox.Text;
            student.FName = NFNameBox.Text;
            student.Mark = Convert.ToDouble(NMarkBox.Text);
            Adapter.Add(student);
            update(); ;//надо сиправить потом
        }

       

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            NNameBox.Text=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            IdBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            NFNameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            NGroupBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            NMarkBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = Convert.ToInt32(IdBox.Text);
            student.Name = NNameBox.Text;
            student.Group = NGroupBox.Text;
            student.FName = NFNameBox.Text;
            student.Mark = Convert.ToDouble(NMarkBox.Text);
            Adapter.Edit(student);
            update();//надо сиправить потом
        }

        private void update()
        {
            dataGridView1.DataSource = Adapter.ReadAll();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(IdBox.Text);
            Adapter.Delete(Id);
            update();
        }

        private void GroupBox_DropDown(object sender, EventArgs e)
        {
            
        }
       
    }
}
