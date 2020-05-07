using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            this.game_speed_level_timer.Enabled = true;

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
        int s, p;
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


        private void main_Form1_Load(object sender, EventArgs e)
        {
            try_again_but.BackColor = Color.FromArgb(5, 200, 90, 34);
            game_over_label.BackColor = Color.FromArgb(100, 230, 160, 8);

            game_speed_level_timer.Enabled = true;

            
        }
        //void game_speed(int speed)
        //{

        //    enemy1.Top += speed;
        //    enemy2.Top += speed;
        //    enemy3.Top += speed;
        //    enemy4.Top += speed;
        //    road_mark_pictureBox1.Top += speed;
        //    road_mark_pictureBox2.Top += speed;
        //    road_mark_pictureBox3.Top += speed;
        //    road_mark_pictureBox4.Top += speed;
        //    road_mark_pictureBox5.Top += speed;

        //}
        void game_speed_implement()
        {
            if (minutes_label.Text == "015")
            {
                output_speed = 10;
                //game_speed(10);
                level_label2.Text = "02";
            }
            if (minutes_label.Text == "025")
            {
                output_speed = 15;
                //game_speed(15);
                level_label2.Text = "03";
            }
            if (minutes_label.Text == "035")
            {
                output_speed = 20;
               // game_speed(20);
                level_label2.Text = "04";
            }

            if (minutes_label.Text == "045")
            {
                output_speed = 25;
                //game_speed(25);
                level_label2.Text = "05";
            }
            if (minutes_label.Text == "055")
            {
                //game_speed(30);
                level_label2.Text = "06";
            }
            if (minutes_label.Text == "065")
            {
                //game_speed(35);
                level_label2.Text = "07";
            }
        }
        void use()
        {
            game_speed_level_timer.Stop();
            road_timer1.Stop();
            game_over_label.Visible = true;
            this.try_again_but.Visible = true;


            reset_labeltime();
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


       
        int x_seconds, y_minutus;
        private void game_speed_level_timer_Tick(object sender, EventArgs e)
        {
            increasedseconds();
            showtime();

            game_speed_implement();
        }

        //private void start_button1_Click(object sender, EventArgs e)
        //{
            
        //}

        private void reset_labeltime()
        {
            x_seconds = 0;
            y_minutus = 0;

            showtime();
        }

        void showtime()
        {
            seconds_label.Text = x_seconds.ToString("00");
            minutes_label.Text = y_minutus.ToString("000");
        }
        void increasedseconds()
        {
            if (x_seconds == 59)
            {
                x_seconds = 0;
                increasedminutes();
            }

            else
                x_seconds++;
        }
        void increasedminutes() 
        {
                y_minutus++;
        }
    }
}
