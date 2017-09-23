using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class edit : Form
    {
        private Form1 _masterForm;
        private Int64 _id;

        public edit(Form1 masterForm, string title = "", string desc="",Int64 id = -1)
        {
            InitializeComponent();
            _masterForm = masterForm;
            _id = id;
            Location = (new Point(Screen.PrimaryScreen.Bounds.Width - 630, 10));

            if (id > -1)
            {
                textBox1.Text = title;
                textBox2.Text = desc;

                //label1.Text = id.ToString();
            }
        }

     




        private void button1_Click(object sender, EventArgs e)
        {
            if (_id > -1)
            {
                _masterForm.updateDB(String.Format("UPDATE messages set title = '{1}', description = '{2}' where id = {0}",_id, textBox1.Text.ToString().Replace("'","''"), textBox2.Text.ToString().Replace("'","''")));
            }
            else
            {
                _masterForm.updateDB(String.Format("insert into messages (title, description, del) values ('{0}', '{1}',0)", textBox1.Text.ToString().Replace("'","''"), textBox2.Text.ToString().Replace("'","''")));
            }

            this.Close();
        }
    }
}
