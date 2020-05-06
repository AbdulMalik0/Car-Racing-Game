using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_racing_game
{
    public partial class main_Form1 : Form
    {
        public main_Form1()
        {
            InitializeComponent();
            this.game_over_label.Visible = false;
            this.try_again_but.Visible = false;
        }

        private void road_timer1_Tick(object sender, EventArgs e)
        {
            racing(output_speed);
            enemy(output_speed);
            gameover();
        }

        public void racing(int speedvalue)
        {
            if (this.road_mark_pictureBox1.Top >= 500)
                this.road_mark_pictureBox1.Top = 0;
            else
                this.road_mark_pictureBox1.Top += speedvalue;

            if (this.road_mark_pictureBox2.Top >= 500)
                this.road_mark_pictureBox2.Top = 0;
            else
                this.road_mark_pictureBox2.Top += speedvalue;

            if (this.road_mark_pictureBox3.Top >= 500)
                this.road_mark_pictureBox3.Top = 0;
            else
                this.road_mark_pictureBox3.Top += speedvalue;

            if (this.road_mark_pictureBox4.Top >= 500)
                this.road_mark_pictureBox4.Top = 0;
            else
                this.road_mark_pictureBox4.Top += speedvalue;

            if (this.road_mark_pictureBox5.Top >= 500)
                this.road_mark_pictureBox5.Top = 0;
            else
                this.road_mark_pictureBox5.Top += speedvalue;
        }
        int output_speed = 5;
        private void main_Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                if (game_over_label.Visible != true)
                {
                    if (this.car_pictureBox3.Left >= 8)
                        this.car_pictureBox3.Left -= 10;
                }
            if (e.KeyCode == Keys.Right)
                if (game_over_label.Visible != true)
                {
                    if (this.car_pictureBox3.Right <= 380)
                        this.car_pictureBox3.Left += 10;
                }
            if (e.KeyCode == Keys.Up)
                if (game_over_label.Visible != true)
                {
                    racing(output_speed++);
                }
            if (e.KeyCode == Keys.Down)
                if (game_over_label.Visible != true)
                    if (output_speed > 0)
                    {
                        racing(output_speed--);
                    }
            
            
        }
        Random enemylocation = new Random();
        int s, p, q;

        private void main_Form1_Load(object sender, EventArgs e)
        {
            try_again_but.BackColor = Color.FromArgb(5, 200, 90, 34);
            game_over_label.BackColor = Color.FromArgb(100, 230, 160, 8);
            
        }

        void use()
        {
            road_timer1.Stop();
            game_over_label.Visible = true;
            this.try_again_but.Visible = true;
        }

        private void try_again_but_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        void gameover()
        {
            if (car_pictureBox3.Bounds.IntersectsWith(enemy1.Bounds))
            {
                use();
            }
            if (car_pictureBox3.Bounds.IntersectsWith(enemy2.Bounds))
            {
                use();
            }
            if (car_pictureBox3.Bounds.IntersectsWith(enemy3.Bounds))
            {
                use();
            }
            if (car_pictureBox3.Bounds.IntersectsWith(enemy4.Bounds))
            {
                use();
            }
        }


        void enemy(int outp)
        {
            s = enemylocation.Next(7, 138);
            p = enemylocation.Next(197, 336);

            if (enemy1.Top > 500)
                enemy1.Location = new Point(s, 0);
            else
                enemy1.Top += outp;
            if (enemy2.Top > 500)
            {
                enemy2.Location = new Point(p, 0);
            }
            else
                enemy2.Top += outp;
            if (enemy3.Top > 500)
            {
                enemy3.Location = new Point(p, 0);
            }
            else
                enemy3.Top += outp;

            if (enemy4.Top > 500)
                enemy4.Location = new Point(s, 0);
            else
                enemy4.Top += outp;
        }

        
    }
}
