
namespace Dog_Race_Assignment
{
    partial class Form1
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
            this.cat3 = new System.Windows.Forms.PictureBox();
            this.cat2 = new System.Windows.Forms.PictureBox();
            this.cat1 = new System.Windows.Forms.PictureBox();
            this.cat4 = new System.Windows.Forms.PictureBox();
            this.Endgame = new System.Windows.Forms.Button();
            this.Race = new System.Windows.Forms.Button();
            this.Placebet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Minimunbet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDowncat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownbet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.radioButtonBob = new System.Windows.Forms.RadioButton();
            this.radioButtonjoe = new System.Windows.Forms.RadioButton();
            this.Raceground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownbet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raceground)).BeginInit();
            this.SuspendLayout();
            // 
            // cat3
            // 
            this.cat3.Image = global::Cat_Race_Assignment.Resource1.d3;
            this.cat3.Location = new System.Drawing.Point(62, 228);
            this.cat3.Margin = new System.Windows.Forms.Padding(4);
            this.cat3.Name = "cat3";
            this.cat3.Size = new System.Drawing.Size(149, 95);
            this.cat3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat3.TabIndex = 11;
            this.cat3.TabStop = false;
            this.cat3.Click += new System.EventHandler(this.dog3_Click);
            // 
            // cat2
            // 
            this.cat2.Image = global::Cat_Race_Assignment.Resource1.d4;
            this.cat2.Location = new System.Drawing.Point(62, 133);
            this.cat2.Margin = new System.Windows.Forms.Padding(4);
            this.cat2.Name = "cat2";
            this.cat2.Size = new System.Drawing.Size(149, 87);
            this.cat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat2.TabIndex = 10;
            this.cat2.TabStop = false;
            this.cat2.Click += new System.EventHandler(this.dog2_Click);
            // 
            // cat1
            // 
            this.cat1.Image = global::Cat_Race_Assignment.Resource1.d2;
            this.cat1.Location = new System.Drawing.Point(62, 34);
            this.cat1.Margin = new System.Windows.Forms.Padding(4);
            this.cat1.Name = "cat1";
            this.cat1.Size = new System.Drawing.Size(149, 91);
            this.cat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat1.TabIndex = 9;
            this.cat1.TabStop = false;
            this.cat1.Click += new System.EventHandler(this.dog1_Click);
            // 
            // cat4
            // 
            this.cat4.Image = global::Cat_Race_Assignment.Resource1.d1;
            this.cat4.Location = new System.Drawing.Point(62, 328);
            this.cat4.Margin = new System.Windows.Forms.Padding(4);
            this.cat4.Name = "cat4";
            this.cat4.Size = new System.Drawing.Size(149, 96);
            this.cat4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat4.TabIndex = 12;
            this.cat4.TabStop = false;
            this.cat4.Click += new System.EventHandler(this.dog4_Click);
            // 
            // Endgame
            // 
            this.Endgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Endgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endgame.ForeColor = System.Drawing.Color.Red;
            this.Endgame.Location = new System.Drawing.Point(1192, 331);
            this.Endgame.Margin = new System.Windows.Forms.Padding(4);
            this.Endgame.Name = "Endgame";
            this.Endgame.Size = new System.Drawing.Size(145, 96);
            this.Endgame.TabIndex = 16;
            this.Endgame.Text = "Leave Game";
            this.Endgame.UseVisualStyleBackColor = false;
            this.Endgame.Click += new System.EventHandler(this.Endgame_Click);
            // 
            // Race
            // 
            this.Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race.ForeColor = System.Drawing.Color.Red;
            this.Race.Location = new System.Drawing.Point(1192, 34);
            this.Race.Margin = new System.Windows.Forms.Padding(4);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(145, 95);
            this.Race.TabIndex = 15;
            this.Race.Text = "Let\'s Go";
            this.Race.UseVisualStyleBackColor = false;
            this.Race.Click += new System.EventHandler(this.Race_Click);
            // 
            // Placebet
            // 
            this.Placebet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Placebet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placebet.ForeColor = System.Drawing.Color.Red;
            this.Placebet.Location = new System.Drawing.Point(1005, 467);
            this.Placebet.Margin = new System.Windows.Forms.Padding(4);
            this.Placebet.Name = "Placebet";
            this.Placebet.Size = new System.Drawing.Size(130, 92);
            this.Placebet.TabIndex = 14;
            this.Placebet.Text = " Bet In";
            this.Placebet.UseVisualStyleBackColor = false;
            this.Placebet.Click += new System.EventHandler(this.Placebet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.Minimunbet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDowncat);
            this.groupBox1.Controls.Add(this.numericUpDownbet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonAl);
            this.groupBox1.Controls.Add(this.radioButtonBob);
            this.groupBox1.Controls.Add(this.radioButtonjoe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 439);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(938, 156);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Menu";
            // 
            // Minimunbet
            // 
            this.Minimunbet.AutoSize = true;
            this.Minimunbet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Minimunbet.Location = new System.Drawing.Point(209, 38);
            this.Minimunbet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Minimunbet.Name = "Minimunbet";
            this.Minimunbet.Size = new System.Drawing.Size(82, 34);
            this.Minimunbet.TabIndex = 10;
            this.Minimunbet.Text = "Above Bet\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(624, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jot has not bet yet\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(624, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Anmol has not bet yet\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(624, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Avi has not bet yet\r\n";
            // 
            // numericUpDowncat
            // 
            this.numericUpDowncat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.numericUpDowncat.Location = new System.Drawing.Point(405, 94);
            this.numericUpDowncat.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDowncat.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDowncat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDowncat.Name = "numericUpDowncat";
            this.numericUpDowncat.Size = new System.Drawing.Size(57, 23);
            this.numericUpDowncat.TabIndex = 6;
            this.numericUpDowncat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownbet
            // 
            this.numericUpDownbet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.numericUpDownbet.Location = new System.Drawing.Point(405, 36);
            this.numericUpDownbet.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownbet.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownbet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownbet.Name = "numericUpDownbet";
            this.numericUpDownbet.Size = new System.Drawing.Size(57, 23);
            this.numericUpDownbet.TabIndex = 5;
            this.numericUpDownbet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(402, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Money ";
            // 
            // radioButtonAl
            // 
            this.radioButtonAl.AutoSize = true;
            this.radioButtonAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.radioButtonAl.Location = new System.Drawing.Point(14, 80);
            this.radioButtonAl.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAl.Name = "radioButtonAl";
            this.radioButtonAl.Size = new System.Drawing.Size(51, 21);
            this.radioButtonAl.TabIndex = 2;
            this.radioButtonAl.TabStop = true;
            this.radioButtonAl.Text = "Jot";
            this.radioButtonAl.UseVisualStyleBackColor = false;
            // 
            // radioButtonBob
            // 
            this.radioButtonBob.AutoSize = true;
            this.radioButtonBob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.radioButtonBob.Location = new System.Drawing.Point(14, 51);
            this.radioButtonBob.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonBob.Name = "radioButtonBob";
            this.radioButtonBob.Size = new System.Drawing.Size(73, 21);
            this.radioButtonBob.TabIndex = 1;
            this.radioButtonBob.TabStop = true;
            this.radioButtonBob.Text = "Anmol";
            this.radioButtonBob.UseVisualStyleBackColor = false;
            // 
            // radioButtonjoe
            // 
            this.radioButtonjoe.AutoSize = true;
            this.radioButtonjoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.radioButtonjoe.Location = new System.Drawing.Point(14, 23);
            this.radioButtonjoe.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonjoe.Name = "radioButtonjoe";
            this.radioButtonjoe.Size = new System.Drawing.Size(51, 21);
            this.radioButtonjoe.TabIndex = 0;
            this.radioButtonjoe.TabStop = true;
            this.radioButtonjoe.Text = "Avi";
            this.radioButtonjoe.UseVisualStyleBackColor = false;
            // 
            // Raceground
            // 
            this.Raceground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Raceground.BackgroundImage = global::Cat_Race_Assignment.Resource1.three_lane_autosport_racing_track_motorsport_background_vector_flat_illustration_start_finish_line_three_lane_autosport_race_132771488;
            this.Raceground.Location = new System.Drawing.Point(46, 9);
            this.Raceground.Margin = new System.Windows.Forms.Padding(4);
            this.Raceground.Name = "Raceground";
            this.Raceground.Size = new System.Drawing.Size(1089, 418);
            this.Raceground.TabIndex = 17;
            this.Raceground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1411, 629);
            this.Controls.Add(this.Endgame);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.Placebet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cat4);
            this.Controls.Add(this.cat3);
            this.Controls.Add(this.cat2);
            this.Controls.Add(this.cat1);
            this.Controls.Add(this.Raceground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownbet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raceground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cat3;
        private System.Windows.Forms.PictureBox cat2;
        private System.Windows.Forms.PictureBox cat1;
        private System.Windows.Forms.PictureBox cat4;
        private System.Windows.Forms.Button Endgame;
        private System.Windows.Forms.Button Race;
        private System.Windows.Forms.Button Placebet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Minimunbet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDowncat;
        private System.Windows.Forms.NumericUpDown numericUpDownbet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAl;
        private System.Windows.Forms.RadioButton radioButtonBob;
        private System.Windows.Forms.RadioButton radioButtonjoe;
        private System.Windows.Forms.PictureBox Raceground;
    }
}

