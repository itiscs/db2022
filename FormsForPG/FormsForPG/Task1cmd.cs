using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;

namespace FormsForPG
{
    public partial class Task1cmd : Form
    {
        public Task1cmd()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = "Host=localhost;Username=postgres;Password=1;Persist Security Info=True;Database=myBase";
            // создаем объект связь с бд, строку соединения берём из   
            // свойств проекта, можно задать самим строкой

            con.Open();
            // подключаемся к бд
            var str = "SELECT products.name, orders.date_order, orders.\"count\", " +
                " products.price, orders.amount FROM  orders INNER JOIN products  " +
                "  ON orders.id_prod = products.id_prod WHERE Orders.\"count\" > " + txtCount.Text;
            // задаем текст запроса, добавляем текст из txtCount

            NpgsqlCommand cmd = new NpgsqlCommand(str, con);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            // создали команду и выполнили метод ExecuteReader

            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            // при помощи ридера заполнили таблицу и закрыли      
            // соединение с бд	

            dataGridView1.DataSource = dt;

        }
    }
}
