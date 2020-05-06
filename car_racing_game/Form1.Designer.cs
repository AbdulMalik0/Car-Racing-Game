﻿namespace car_racing_game
{
    partial class main_Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_Form1));
            this.road_timer1 = new System.Windows.Forms.Timer(this.components);
            this.game_over_label = new System.Windows.Forms.Label();
            this.try_again_but = new System.Windows.Forms.Button();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.car_pictureBox3 = new System.Windows.Forms.PictureBox();
            this.road_mark_pictureBox5 = new System.Windows.Forms.PictureBox();
            this.road_mark_pictureBox4 = new System.Windows.Forms.PictureBox();
            this.road_mark_pictureBox3 = new System.Windows.Forms.PictureBox();
            this.road_mark_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.road_mark_pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road_mark_pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road_mark_pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road_mark_pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road_mark_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road_mark_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // road_timer1
            // 
            this.road_timer1.Enabled = true;
            this.road_timer1.Interval = 20;
            this.road_timer1.Tick += new System.EventHandler(this.road_timer1_Tick);
            // 
            // game_over_label
            // 
            this.game_over_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.game_over_label.AutoSize = true;
            this.game_over_label.BackColor = System.Drawing.Color.Gold;
            this.game_over_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_over_label.ForeColor = System.Drawing.Color.Red;
            this.game_over_label.Location = new System.Drawing.Point(99, 154);
            this.game_over_label.Name = "game_over_label";
            this.game_over_label.Size = new System.Drawing.Size(197, 39);
            this.game_over_label.TabIndex = 12;
            this.game_over_label.Text = "Game Over";
            // 
            // try_again_but
            // 
            this.try_again_but.BackColor = System.Drawing.Color.DarkGray;
            this.try_again_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.try_again_but.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.try_again_but.FlatAppearance.BorderSize = 0;
            this.try_again_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.try_again_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.try_again_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.try_again_but.Font = new System.Drawing.Font("Georgia Pro Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.try_again_but.ForeColor = System.Drawing.Color.MidnightBlue;
            this.try_again_but.Image = global::car_racing_game.Properties.Resources.undo;
            this.try_again_but.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.try_again_but.Location = new System.Drawing.Point(146, 193);
            this.try_again_but.Name = "try_again_but";
            this.try_again_but.Size = new System.Drawing.Size(87, 23);
            this.try_again_but.TabIndex = 13;
            this.try_again_but.Text = "Try Again";
            this.try_again_but.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.try_again_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.try_again_but.UseVisualStyleBackColor = false;
            this.try_again_but.Click += new System.EventHandler(this.try_again_but_Click);
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.Color.Transparent;
            this.enemy4.BackgroundImage = global::car_racing_game.Properties.Resources.car;
            this.enemy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemy4.Image = ((System.Drawing.Image)(resources.GetObject("enemy4.Image")));
            this.enemy4.Location = new System.Drawing.Point(80, 12);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(42, 58);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 11;
            this.enemy4.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.BackgroundImage = global::car_racing_game.Properties.Resources.car;
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(242, 337);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(42, 58);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 10;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.BackgroundImage = global::car_racing_game.Properties.Resources.car;
            this.enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(285, 135);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(42, 58);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 9;
            this.enemy3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.BackgroundImage = global::car_racing_game.Properties.Resources.car;
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(30, 246);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(42, 58);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 8;
            this.enemy1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(379, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(6, 471);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(6, 471);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // car_pictureBox3
            // 
            this.car_pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.car_pictureBox3.BackgroundImage = global::car_racing_game.Properties.Resources.car;
            this.car_pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car_pictureBox3.Location = new System.Drawing.Point(135, 400);
            this.car_pictureBox3.Name = "car_pictureBox3";
            this.car_pictureBox3.Size = new System.Drawing.Size(38, 58);
            this.car_pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car_pictureBox3.TabIndex = 7;
            this.car_pictureBox3.TabStop = false;
            // 
            // road_mark_pictureBox5
            // 
            this.road_mark_pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.road_mark_pictureBox5.Location = new System.Drawing.Point(189, 380);
            this.road_mark_pictureBox5.Name = "road_mark_pictureBox5";
            this.road_mark_pictureBox5.Size = new System.Drawing.Size(7, 78);
            this.road_mark_pictureBox5.TabIndex = 4;
            this.road_mark_pictureBox5.TabStop = false;
            // 
            // road_mark_pictureBox4
            // 
            this.road_mark_pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.road_mark_pictureBox4.Location = new System.Drawing.Point(189, 285);
            this.road_mark_pictureBox4.Name = "road_mark_pictureBox4";
            this.road_mark_pictureBox4.Size = new System.Drawing.Size(7, 78);
            this.road_mark_pictureBox4.TabIndex = 3;
            this.road_mark_pictureBox4.TabStop = false;
            // 
            // road_mark_pictureBox3
            // 
            this.road_mark_pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.road_mark_pictureBox3.Location = new System.Drawing.Point(189, 190);
            this.road_mark_pictureBox3.Name = "road_mark_pictureBox3";
            this.road_mark_pictureBox3.Size = new System.Drawing.Size(7, 78);
            this.road_mark_pictureBox3.TabIndex = 2;
            this.road_mark_pictureBox3.TabStop = false;
            // 
            // road_mark_pictureBox2
            // 
            this.road_mark_pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.road_mark_pictureBox2.Location = new System.Drawing.Point(189, 95);
            this.road_mark_pictureBox2.Name = "road_mark_pictureBox2";
            this.road_mark_pictureBox2.Size = new System.Drawing.Size(7, 78);
            this.road_mark_pictureBox2.TabIndex = 1;
            this.road_mark_pictureBox2.TabStop = false;
            // 
            // road_mark_pictureBox1
            // 
            this.road_mark_pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.road_mark_pictureBox1.Location = new System.Drawing.Point(189, 0);
            this.road_mark_pictureBox1.Name = "road_mark_pictureBox1";
            this.road_mark_pictureBox1.Size = new System.Drawing.Size(7, 78);
            this.road_mark_pictureBox1.TabIndex = 0;
            this.road_mark_pictureBox1.TabStop = false;
            // 
            // main_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.try_again_but);
            this.Controls.Add(this.game_over_label);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.car_pictureBox3);
            this.Controls.Add(this.road_mark_pictureBox5);
            this.Controls.Add(this.road_mark_pictureBox4);
            this.Controls.Add(this.road_mark_pictureBox3);
            this.Controls.Add(this.road_mark_pictureBox2);
            this.Controls.Add(this.road_mark_pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main_Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing";
            this.Load += new System.EventHandler(this.main_Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road_mark_pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road_mark_pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road_mark_pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road_mark_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road_mark_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox road_mark_pictureBox1;
        private System.Windows.Forms.PictureBox road_mark_pictureBox2;
        private System.Windows.Forms.PictureBox road_mark_pictureBox3;
        private System.Windows.Forms.PictureBox road_mark_pictureBox4;
        private System.Windows.Forms.PictureBox road_mark_pictureBox5;
        private System.Windows.Forms.Timer road_timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox car_pictureBox3;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.Label game_over_label;
        private System.Windows.Forms.Button try_again_but;
    }
}

