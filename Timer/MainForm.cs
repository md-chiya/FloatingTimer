using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class TimerWindow : Form
    {
        private Boolean movable;
        private int rest_hh, rest_mm, rest_ss;
        Form_InputTimer fi;

        public TimerWindow()
        {
            InitializeComponent();

            /*ウィンドウサイズ変更*/
            this.Size = new Size(350, 100);

            btn_Timer.Location = new Point(0, 0);
            btn_Timer.Size = new Size(this.Width, this.Height);
            btn_Timer.Text = "00:00:00";

            opacityToolStripMenuItem.Text = "不透明度(" + this.Opacity * 100 + "%)";

            movable = false;

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fi = new Form_InputTimer();
            fi.Closed += new EventHandler(this.OnCloseSubWindow);
            fi.Show();
            this.Enabled = false;
        }

        private void OnCloseSubWindow(object sender, EventArgs e)
        {
            this.Enabled = true;
            if (fi.bool_goodhhmmss)
            {
                btn_Timer.Text = fi.Str_time;
            }

        }

        private void MoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (movable)
            {
                moveToolStripMenuItem.Text = "移動させる";
                movable = false;
            } else
            {
                moveToolStripMenuItem.Text = "固定させる";
                movable = true;
            }
        }


        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (movable)
            {
                this.Left = Cursor.Position.X - this.Width/2;
                this.Top = Cursor.Position.Y - this.Height/2;
            }
            
        }

        private void changeOpacity(object sender, EventArgs e)
        {
            String[] str = sender.ToString().Split('%');

            this.Opacity = Convert.ToDouble(str[0]) / 100.0;
            opacityToolStripMenuItem.Text = "不透明度(" + this.Opacity * 100 +"%)";

        }

        private void onClikck_btn(object sender, EventArgs e)
        {
            if (timer_increment.Enabled)
            {
                timer_increment.Enabled = false;
            } else
            {
                timer_increment.Enabled = true;
                String[] str = btn_Timer.Text.Split(':');
                rest_hh = Convert.ToInt32(str[0]);
                rest_mm = Convert.ToInt32(str[1]);
                rest_ss = Convert.ToInt32(str[2]);

            }
        }

        private void Timer_increment_Tick(object sender, EventArgs e)
        {
            
            if (rest_hh + rest_mm + rest_ss <= 0)
            {
                timer_increment.Enabled = false;
                MessageBox.Show("時間切れ", "終わり", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            rest_ss--;
            if (rest_ss < 0) {
                rest_mm--;
                rest_ss = 59;
                if (rest_mm < 0)
                {
                    rest_hh--;
                    rest_mm = 59;
                }
            }
            btn_Timer.Text = Convert.ToString(rest_hh.ToString("D2") + ":" + rest_mm.ToString("D2") + ":" + rest_ss.ToString("D2"));

        }
    }
}
