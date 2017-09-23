using Engine;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ToDo
{
    public partial class Form1 : Form
    {
        private Logic _logic;
        private edit ed;
        private SQLiteConnection m_dbConnection;

        public Form1()
        {
            InitializeComponent();
            _logic = new Logic();

            if (!File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");
                createDB();
            }
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");

            _logic.Table.Columns.Add("Tytuł");
            _logic.Table.Columns.Add("Opis");
            _logic.Table.Columns.Add("del");
            _logic.Table.Columns.Add("id");
            _logic.Table = GetData("select title, description, del, id from messages where del = 0");

            dataGridView1.DataSource = _logic.Table;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Location= (new Point(Screen.PrimaryScreen.Bounds.Width -300 ,10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit newMessage = new edit(this);
            newMessage.ShowDialog();
        }

        public void updateDT(string tytul, string opis)
        {

            _logic.Table.Rows.Add(tytul, opis);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string val = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["id"].Value.ToString();
            DataRow[] res = _logic.Table.Select(String.Format("id = {0}", val));
            textBox1.Text = res[0][1].ToString();
        }

        private DataTable GetData(string sqlCommand) {
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(sqlCommand, m_dbConnection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            m_dbConnection.Close();
            return table;
    }

        private void createDB()
        {
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            string sql = "CREATE TABLE messages (id INTEGER PRIMARY KEY, title VARCHAR(25), description VARCHAR(200), del INT)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
            m_dbConnection.Dispose();
        }


        public void updateDB(string sql)
        {
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
            _logic.Table.Clear();
            _logic.Table = GetData("select title, description, del, id from messages where del = 0");
            dataGridView1.DataSource = _logic.Table;

        }

        private void zapisz_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string val = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["id"].Value.ToString();
                DataRow[] res = _logic.Table.Select(String.Format("id = {0}", val));

                string title = res[0][0].ToString();  //_logic.Table.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>(0);
                string desc = res[0][1].ToString(); //_logic.Table.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>(1);
                Int64 id = int.Parse(res[0][3].ToString());// _logic.Table.Rows[dataGridView1.CurrentCell.RowIndex].Field<Int64>(3);
                ed = new edit(this,title,desc,id);
                ed.ShowDialog();
            }
        }

        private void usun_btn_Click(object sender, EventArgs e)
        {
            string val = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["id"].Value.ToString();
            DataRow[] res = _logic.Table.Select(String.Format("id = {0}", val));
            Int64 id = int.Parse(res[0][3].ToString());

            updateDB(String.Format("UPDATE messages set del = 1 where id = {0}", id ));
            _logic.Table.Clear();
            _logic.Table = GetData("select title, description, del, id from messages where del = 0");
            dataGridView1.DataSource = _logic.Table;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_onTop.Checked){
                Console.WriteLine("checked");
                this.TopMost = true;
            }
            else
            {
                Console.WriteLine("NOT");
                this.TopMost = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Mariusz.");

        }
    }
}
