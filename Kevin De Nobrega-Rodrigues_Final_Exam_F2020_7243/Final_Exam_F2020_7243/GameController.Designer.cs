﻿namespace Final_Exam_F2020_7243
{
    partial class GameController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameController));
            this.picture_energy = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_Energy = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label_Direction = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.label_Destroyer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Lives = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_energy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_energy
            // 
            this.picture_energy.BackColor = System.Drawing.Color.Transparent;
            this.picture_energy.Image = ((System.Drawing.Image)(resources.GetObject("picture_energy.Image")));
            this.picture_energy.Location = new System.Drawing.Point(186, 3);
            this.picture_energy.Margin = new System.Windows.Forms.Padding(2);
            this.picture_energy.Name = "picture_energy";
            this.picture_energy.Size = new System.Drawing.Size(21, 38);
            this.picture_energy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_energy.TabIndex = 27;
            this.picture_energy.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(82, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // label_Energy
            // 
            this.label_Energy.AutoSize = true;
            this.label_Energy.BackColor = System.Drawing.Color.Transparent;
            this.label_Energy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Energy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Energy.Location = new System.Drawing.Point(224, 15);
            this.label_Energy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Energy.Name = "label_Energy";
            this.label_Energy.Size = new System.Drawing.Size(25, 26);
            this.label_Energy.TabIndex = 25;
            this.label_Energy.Text = "0";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(537, 3);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // label_Direction
            // 
            this.label_Direction.AutoSize = true;
            this.label_Direction.BackColor = System.Drawing.Color.Transparent;
            this.label_Direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Direction.ForeColor = System.Drawing.Color.Gold;
            this.label_Direction.Location = new System.Drawing.Point(580, 15);
            this.label_Direction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Direction.Name = "label_Direction";
            this.label_Direction.Size = new System.Drawing.Size(80, 26);
            this.label_Direction.TabIndex = 23;
            this.label_Direction.Text = "NONE";
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_State.ForeColor = System.Drawing.Color.Gold;
            this.label_State.Location = new System.Drawing.Point(402, 15);
            this.label_State.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(73, 26);
            this.label_State.TabIndex = 21;
            this.label_State.Text = "Small";
            // 
            // label_Destroyer
            // 
            this.label_Destroyer.AutoSize = true;
            this.label_Destroyer.BackColor = System.Drawing.Color.Transparent;
            this.label_Destroyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Destroyer.ForeColor = System.Drawing.Color.Gold;
            this.label_Destroyer.Location = new System.Drawing.Point(134, 15);
            this.label_Destroyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Destroyer.Name = "label_Destroyer";
            this.label_Destroyer.Size = new System.Drawing.Size(25, 26);
            this.label_Destroyer.TabIndex = 20;
            this.label_Destroyer.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label_Lives
            // 
            this.label_Lives.AutoSize = true;
            this.label_Lives.BackColor = System.Drawing.Color.Transparent;
            this.label_Lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lives.ForeColor = System.Drawing.Color.Red;
            this.label_Lives.Location = new System.Drawing.Point(44, 15);
            this.label_Lives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Lives.Name = "label_Lives";
            this.label_Lives.Size = new System.Drawing.Size(25, 26);
            this.label_Lives.TabIndex = 18;
            this.label_Lives.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 534);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(311, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "State = ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(678, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picture_energy);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label_Energy);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label_Direction);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.label_Destroyer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_Lives);
            this.Name = "GameController";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameController_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture_energy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_energy;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_Energy;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label_Direction;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Label label_Destroyer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Lives;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

