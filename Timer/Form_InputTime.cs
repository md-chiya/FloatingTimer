using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Timer
{
    public partial class Form_InputTimer : Form
    {
        private TextBox tb_time;
        private Button btn_ok;
        string str_time;
        public string Str_time
        {
            get
            {
                return str_time;
            }
            set
            {
                this.str_time = value;
            }
        }
        public bool bool_goodhhmmss = false;

        public Form_InputTimer()
        {
            InitializeComponent();

            this.Text = "時刻を入力してね";
            this.Size = new Size(300, 150);
            this.TopMost = true;

            tb_time = new TextBox();
            tb_time.Location = new Point(this.Width/2 - tb_time.Width/2, 30);
            this.Controls.Add(tb_time);

            btn_ok = new Button();
            btn_ok.Text = "決定！";
            btn_ok.Location = new Point(this.Width / 2 - btn_ok.Width / 2, tb_time.Location.Y + 40);
            btn_ok.FlatStyle = FlatStyle.Standard;
            btn_ok.ForeColor = Color.GhostWhite;
            btn_ok.BackColor = Color.Chocolate;
            btn_ok.Click += delegate (object sender, EventArgs e)
            {
                if (Regex.IsMatch(tb_time.Text, "[0-9]{2}:[0-5][0-9]:[0-5][0-9]"))
                {
                    str_time = tb_time.Text;
                    bool_goodhhmmss = true;
                    this.Close();
                }
            };
            this.Controls.Add(btn_ok);

        }
    }
}
