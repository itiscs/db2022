using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsForDB
{
    public partial class Task1cmd : Form
    {
        public Task1cmd()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.myBaseConnectionString);
            // создаем объект связь с бд, строку соединения берём из   
            // свойств проекта, можно задать самим строкой
            con.Open();
            // подключаемся к бд
            var str = "SELECT Products.name, Orders.orderdate, Orders.count,  " +
                " Products.price, Orders.amount FROM Orders INNER JOIN  Products ON" +
                " Orders.id_prod = Products.id WHERE Orders.count > " + txtCount.Text;
            // задаем текст запроса, добавляем текст из txtCount

            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            // создали команду и выполнили метод ExecuteReader

            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            // при помощи ридера заполнили таблицу и закрыли      
            // соединение с бд	
            
            dataGridView1.DataSource = dt;
            //отобразили таблицу на форме
        }
    }
}

