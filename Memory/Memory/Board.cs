using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace Memory
{
    public class Board : Form 
    {
        private System.ComponentModel.IContainer components = null;
        //int counter = 10;
        // boolean to determine part of turn player is in
        bool turn = true;
        String board = "b1";
        // strings that determines the picture each card gets
        String p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18;
        // this music is played when board is complete
        SoundPlayer winMusic = new SoundPlayer(Memory.Properties.Resources.Win_Music);
        // this is the sound played when a card is flipped
        SoundPlayer cardFlip = new SoundPlayer(Memory.Properties.Resources.Miss_Swing3);
        // pictureboxes for each card
        private PictureBox pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8,
            pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16,
            pictureBox17, pictureBox18;
        //menustrip declarations
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem, newGameToolStripMenuItem, optionsToolStripMenuItem, 
            board1ToolStripMenuItem, board2ToolStripMenuItem, quitToolStripMenuItem;
        
        /*
         * This is the constructor for the Board class
         */
        public Board()
        {
            InitializeComponent();
            InitializeCards();
        }

        /*
         * This method initializes the form components
         */
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.board1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.board2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox1.Location = new System.Drawing.Point(11, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox2.Location = new System.Drawing.Point(132, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox3.Location = new System.Drawing.Point(253, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox4.Location = new System.Drawing.Point(374, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox5.Location = new System.Drawing.Point(495, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(115, 150);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox6.Location = new System.Drawing.Point(616, 27);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(115, 150);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox7.Location = new System.Drawing.Point(11, 183);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(115, 150);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox8.Location = new System.Drawing.Point(132, 183);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(115, 150);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox9.Location = new System.Drawing.Point(253, 183);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(115, 150);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox10.Location = new System.Drawing.Point(374, 183);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(115, 150);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox11.Location = new System.Drawing.Point(495, 183);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(115, 150);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox12.Location = new System.Drawing.Point(616, 183);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(115, 150);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox13.Location = new System.Drawing.Point(11, 339);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(115, 150);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox14.Location = new System.Drawing.Point(132, 339);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(115, 150);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox15.Location = new System.Drawing.Point(253, 339);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(115, 150);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox16.Location = new System.Drawing.Point(374, 339);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(115, 150);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 15;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Click += new System.EventHandler(this.pictureBox16_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox17.Location = new System.Drawing.Point(495, 339);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(115, 150);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 16;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Memory.Properties.Resources.Ore_Regional;
            this.pictureBox18.Location = new System.Drawing.Point(616, 339);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(115, 150);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 17;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Click += new System.EventHandler(this.pictureBox18_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.board1ToolStripMenuItem,
            this.board2ToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // board1ToolStripMenuItem
            // 
            this.board1ToolStripMenuItem.Name = "board1ToolStripMenuItem";
            this.board1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.board1ToolStripMenuItem.Text = "Board1";
            this.board1ToolStripMenuItem.Click += new System.EventHandler(this.board1ToolStripMenuItem_Click);
            // 
            // board2ToolStripMenuItem
            // 
            this.board2ToolStripMenuItem.Name = "board2ToolStripMenuItem";
            this.board2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.board2ToolStripMenuItem.Text = "Board2";
            this.board2ToolStripMenuItem.Click += new System.EventHandler(this.board2ToolStripMenuItem_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Board";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /*
         * This method initialzes all the cards creating a random layout each time
         */
        #region Random picture generator
        public void InitializeCards()
        {
            List<String> pictureList = new List<String>();
            String s1 = "picture1", s2 = "picture2", s3 = "picture3", s4 = "picture4", s5 = "picture5",
            s6 = "picture6", s7 = "picture7", s8 = "picture8", s9 = "picture9";
            Random random = new Random();
            int r;

            pictureList.Add(s1); pictureList.Add(s1); pictureList.Add(s2); pictureList.Add(s2);
            pictureList.Add(s3); pictureList.Add(s3); pictureList.Add(s4); pictureList.Add(s4);
            pictureList.Add(s5); pictureList.Add(s5); pictureList.Add(s6); pictureList.Add(s6);
            pictureList.Add(s7); pictureList.Add(s7); pictureList.Add(s8); pictureList.Add(s8);
            pictureList.Add(s9); pictureList.Add(s9);
            
            r = random.Next(17); this.p1 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(16); this.p2 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(15); this.p3 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(14); this.p4 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(13); this.p5 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(12); this.p6 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(11); this.p7 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(10); this.p8 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(9); this.p9 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(8); this.p10 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(7); this.p11 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(6); this.p12 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(5); this.p13 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(4); this.p14 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(3); this.p15 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(2); this.p16 = pictureList[r]; pictureList.RemoveAt(r);
            r = random.Next(1); this.p17 = pictureList[r]; pictureList.RemoveAt(r);
            this.p18 = pictureList[0];

            //make each card active
            Bitmap picture = global::Memory.Properties.Resources.Ore_Regional;
            pictureBox1.Enabled = true; pictureBox1.Image = picture; pictureBox2.Enabled = true; pictureBox2.Image = picture;
            pictureBox3.Enabled = true; pictureBox3.Image = picture; pictureBox4.Enabled = true; pictureBox4.Image = picture;
            pictureBox5.Enabled = true; pictureBox5.Image = picture; pictureBox6.Enabled = true; pictureBox6.Image = picture;
            pictureBox7.Enabled = true; pictureBox7.Image = picture; pictureBox8.Enabled = true; pictureBox8.Image = picture;
            pictureBox9.Enabled = true; pictureBox9.Image = picture; pictureBox10.Enabled = true; pictureBox10.Image = picture;
            pictureBox11.Enabled = true; pictureBox11.Image = picture; pictureBox12.Enabled = true; pictureBox12.Image = picture;
            pictureBox13.Enabled = true; pictureBox13.Image = picture; pictureBox14.Enabled = true; pictureBox14.Image = picture;
            pictureBox15.Enabled = true; pictureBox15.Image = picture; pictureBox16.Enabled = true; pictureBox16.Image = picture;
            pictureBox17.Enabled = true; pictureBox17.Image = picture; pictureBox18.Enabled = true; pictureBox18.Image = picture;

            //background colors for selected board
            if (board.Equals("b1"))
            {
                this.BackColor = Color.DarkSlateGray;
            }
            else if (board.Equals("b2"))
            {
                this.BackColor = Color.CornflowerBlue;
            }
        }
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /*
         * this method checks for a match of the cards flipped
         */
        private void MatchCheck()
        {
            //change turn state
            if (turn == true)
            {
                turn = false;
            }
            else
            {
                turn = true;
            }

            //check for match
            if (turn == true)
            {
                if (this.pictureBox1.Enabled == false && this.pictureBox2.Enabled == false && p1.Equals(p2) ||
                    this.pictureBox1.Enabled == false && this.pictureBox3.Enabled == false && p1.Equals(p3) ||
                    this.pictureBox1.Enabled == false && this.pictureBox4.Enabled == false && p1.Equals(p4) ||
                    this.pictureBox1.Enabled == false && this.pictureBox5.Enabled == false && p1.Equals(p5) ||
                    this.pictureBox1.Enabled == false && this.pictureBox6.Enabled == false && p1.Equals(p6) ||
                    this.pictureBox1.Enabled == false && this.pictureBox7.Enabled == false && p1.Equals(p7) ||
                    this.pictureBox1.Enabled == false && this.pictureBox8.Enabled == false && p1.Equals(p8) ||
                    this.pictureBox1.Enabled == false && this.pictureBox9.Enabled == false && p1.Equals(p9) ||
                    this.pictureBox1.Enabled == false && this.pictureBox10.Enabled == false && p1.Equals(p10) ||
                    this.pictureBox1.Enabled == false && this.pictureBox11.Enabled == false && p1.Equals(p11) ||
                    this.pictureBox1.Enabled == false && this.pictureBox12.Enabled == false && p1.Equals(p12) ||
                    this.pictureBox1.Enabled == false && this.pictureBox13.Enabled == false && p1.Equals(p13) ||
                    this.pictureBox1.Enabled == false && this.pictureBox14.Enabled == false && p1.Equals(p14) ||
                    this.pictureBox1.Enabled == false && this.pictureBox15.Enabled == false && p1.Equals(p15) ||
                    this.pictureBox1.Enabled == false && this.pictureBox16.Enabled == false && p1.Equals(p16) ||
                    this.pictureBox1.Enabled == false && this.pictureBox17.Enabled == false && p1.Equals(p17) ||
                    this.pictureBox1.Enabled == false && this.pictureBox18.Enabled == false && p1.Equals(p18))
                {
                    this.pictureBox1.Enabled = false;
                }
                else
                {
                    this.pictureBox1.Enabled = true;
                }
                if (this.pictureBox2.Enabled == false && this.pictureBox1.Enabled == false && p2.Equals(p1) ||
                    this.pictureBox2.Enabled == false && this.pictureBox3.Enabled == false && p2.Equals(p3) ||
                    this.pictureBox2.Enabled == false && this.pictureBox4.Enabled == false && p2.Equals(p4) ||
                    this.pictureBox2.Enabled == false && this.pictureBox5.Enabled == false && p2.Equals(p5) ||
                    this.pictureBox2.Enabled == false && this.pictureBox6.Enabled == false && p2.Equals(p6) ||
                    this.pictureBox2.Enabled == false && this.pictureBox7.Enabled == false && p2.Equals(p7) ||
                    this.pictureBox2.Enabled == false && this.pictureBox8.Enabled == false && p2.Equals(p8) ||
                    this.pictureBox2.Enabled == false && this.pictureBox9.Enabled == false && p2.Equals(p9) ||
                    this.pictureBox2.Enabled == false && this.pictureBox10.Enabled == false && p2.Equals(p10) ||
                    this.pictureBox2.Enabled == false && this.pictureBox11.Enabled == false && p2.Equals(p11) ||
                    this.pictureBox2.Enabled == false && this.pictureBox12.Enabled == false && p2.Equals(p12) ||
                    this.pictureBox2.Enabled == false && this.pictureBox13.Enabled == false && p2.Equals(p13) ||
                    this.pictureBox2.Enabled == false && this.pictureBox14.Enabled == false && p2.Equals(p14) ||
                    this.pictureBox2.Enabled == false && this.pictureBox15.Enabled == false && p2.Equals(p15) ||
                    this.pictureBox2.Enabled == false && this.pictureBox16.Enabled == false && p2.Equals(p16) ||
                    this.pictureBox2.Enabled == false && this.pictureBox17.Enabled == false && p2.Equals(p17) ||
                    this.pictureBox2.Enabled == false && this.pictureBox18.Enabled == false && p2.Equals(p18))
                {
                    this.pictureBox2.Enabled = false;
                }
                else
                {
                    this.pictureBox2.Enabled = true;
                }
                if (this.pictureBox3.Enabled == false && this.pictureBox2.Enabled == false && p3.Equals(p2) ||
                    this.pictureBox3.Enabled == false && this.pictureBox1.Enabled == false && p3.Equals(p1) ||
                    this.pictureBox3.Enabled == false && this.pictureBox4.Enabled == false && p3.Equals(p4) ||
                    this.pictureBox3.Enabled == false && this.pictureBox5.Enabled == false && p3.Equals(p5) ||
                    this.pictureBox3.Enabled == false && this.pictureBox6.Enabled == false && p3.Equals(p6) ||
                    this.pictureBox3.Enabled == false && this.pictureBox7.Enabled == false && p3.Equals(p7) ||
                    this.pictureBox3.Enabled == false && this.pictureBox8.Enabled == false && p3.Equals(p8) ||
                    this.pictureBox3.Enabled == false && this.pictureBox9.Enabled == false && p3.Equals(p9) ||
                    this.pictureBox3.Enabled == false && this.pictureBox10.Enabled == false && p3.Equals(p10) ||
                    this.pictureBox3.Enabled == false && this.pictureBox11.Enabled == false && p3.Equals(p11) ||
                    this.pictureBox3.Enabled == false && this.pictureBox12.Enabled == false && p3.Equals(p12) ||
                    this.pictureBox3.Enabled == false && this.pictureBox13.Enabled == false && p3.Equals(p13) ||
                    this.pictureBox3.Enabled == false && this.pictureBox14.Enabled == false && p3.Equals(p14) ||
                    this.pictureBox3.Enabled == false && this.pictureBox15.Enabled == false && p3.Equals(p15) ||
                    this.pictureBox3.Enabled == false && this.pictureBox16.Enabled == false && p3.Equals(p16) ||
                    this.pictureBox3.Enabled == false && this.pictureBox17.Enabled == false && p3.Equals(p17) ||
                    this.pictureBox3.Enabled == false && this.pictureBox18.Enabled == false && p3.Equals(p18))
                {
                    this.pictureBox3.Enabled = false;
                }
                else
                {
                    this.pictureBox3.Enabled = true;
                }
                if (this.pictureBox4.Enabled == false && this.pictureBox2.Enabled == false && p4.Equals(p2) ||
                    this.pictureBox4.Enabled == false && this.pictureBox3.Enabled == false && p4.Equals(p3) ||
                    this.pictureBox4.Enabled == false && this.pictureBox1.Enabled == false && p4.Equals(p1) ||
                    this.pictureBox4.Enabled == false && this.pictureBox5.Enabled == false && p4.Equals(p5) ||
                    this.pictureBox4.Enabled == false && this.pictureBox6.Enabled == false && p4.Equals(p6) ||
                    this.pictureBox4.Enabled == false && this.pictureBox7.Enabled == false && p4.Equals(p7) ||
                    this.pictureBox4.Enabled == false && this.pictureBox8.Enabled == false && p4.Equals(p8) ||
                    this.pictureBox4.Enabled == false && this.pictureBox9.Enabled == false && p4.Equals(p9) ||
                    this.pictureBox4.Enabled == false && this.pictureBox10.Enabled == false && p4.Equals(p10) ||
                    this.pictureBox4.Enabled == false && this.pictureBox11.Enabled == false && p4.Equals(p11) ||
                    this.pictureBox4.Enabled == false && this.pictureBox12.Enabled == false && p4.Equals(p12) ||
                    this.pictureBox4.Enabled == false && this.pictureBox13.Enabled == false && p4.Equals(p13) ||
                    this.pictureBox4.Enabled == false && this.pictureBox14.Enabled == false && p4.Equals(p14) ||
                    this.pictureBox4.Enabled == false && this.pictureBox15.Enabled == false && p4.Equals(p15) ||
                    this.pictureBox4.Enabled == false && this.pictureBox16.Enabled == false && p4.Equals(p16) ||
                    this.pictureBox4.Enabled == false && this.pictureBox17.Enabled == false && p4.Equals(p17) ||
                    this.pictureBox4.Enabled == false && this.pictureBox18.Enabled == false && p4.Equals(p18))
                {
                    this.pictureBox4.Enabled = false;
                }
                else
                {
                    this.pictureBox4.Enabled = true;
                }
                if (this.pictureBox5.Enabled == false && this.pictureBox2.Enabled == false && p5.Equals(p2) ||
                    this.pictureBox5.Enabled == false && this.pictureBox3.Enabled == false && p5.Equals(p3) ||
                    this.pictureBox5.Enabled == false && this.pictureBox4.Enabled == false && p5.Equals(p4) ||
                    this.pictureBox5.Enabled == false && this.pictureBox1.Enabled == false && p5.Equals(p1) ||
                    this.pictureBox5.Enabled == false && this.pictureBox6.Enabled == false && p5.Equals(p6) ||
                    this.pictureBox5.Enabled == false && this.pictureBox7.Enabled == false && p5.Equals(p7) ||
                    this.pictureBox5.Enabled == false && this.pictureBox8.Enabled == false && p5.Equals(p8) ||
                    this.pictureBox5.Enabled == false && this.pictureBox9.Enabled == false && p5.Equals(p9) ||
                    this.pictureBox5.Enabled == false && this.pictureBox10.Enabled == false && p5.Equals(p10) ||
                    this.pictureBox5.Enabled == false && this.pictureBox11.Enabled == false && p5.Equals(p11) ||
                    this.pictureBox5.Enabled == false && this.pictureBox12.Enabled == false && p5.Equals(p12) ||
                    this.pictureBox5.Enabled == false && this.pictureBox13.Enabled == false && p5.Equals(p13) ||
                    this.pictureBox5.Enabled == false && this.pictureBox14.Enabled == false && p5.Equals(p14) ||
                    this.pictureBox5.Enabled == false && this.pictureBox15.Enabled == false && p5.Equals(p15) ||
                    this.pictureBox5.Enabled == false && this.pictureBox16.Enabled == false && p5.Equals(p16) ||
                    this.pictureBox5.Enabled == false && this.pictureBox17.Enabled == false && p5.Equals(p17) ||
                    this.pictureBox5.Enabled == false && this.pictureBox18.Enabled == false && p5.Equals(p18))
                {
                    this.pictureBox5.Enabled = false;
                }
                else
                {
                    this.pictureBox5.Enabled = true;
                }
                if (this.pictureBox6.Enabled == false && this.pictureBox2.Enabled == false && p6.Equals(p2) ||
                    this.pictureBox6.Enabled == false && this.pictureBox3.Enabled == false && p6.Equals(p3) ||
                    this.pictureBox6.Enabled == false && this.pictureBox4.Enabled == false && p6.Equals(p4) ||
                    this.pictureBox6.Enabled == false && this.pictureBox5.Enabled == false && p6.Equals(p5) ||
                    this.pictureBox6.Enabled == false && this.pictureBox1.Enabled == false && p6.Equals(p1) ||
                    this.pictureBox6.Enabled == false && this.pictureBox7.Enabled == false && p6.Equals(p7) ||
                    this.pictureBox6.Enabled == false && this.pictureBox8.Enabled == false && p6.Equals(p8) ||
                    this.pictureBox6.Enabled == false && this.pictureBox9.Enabled == false && p6.Equals(p9) ||
                    this.pictureBox6.Enabled == false && this.pictureBox10.Enabled == false && p6.Equals(p10) ||
                    this.pictureBox6.Enabled == false && this.pictureBox11.Enabled == false && p6.Equals(p11) ||
                    this.pictureBox6.Enabled == false && this.pictureBox12.Enabled == false && p6.Equals(p12) ||
                    this.pictureBox6.Enabled == false && this.pictureBox13.Enabled == false && p6.Equals(p13) ||
                    this.pictureBox6.Enabled == false && this.pictureBox14.Enabled == false && p6.Equals(p14) ||
                    this.pictureBox6.Enabled == false && this.pictureBox15.Enabled == false && p6.Equals(p15) ||
                    this.pictureBox6.Enabled == false && this.pictureBox16.Enabled == false && p6.Equals(p16) ||
                    this.pictureBox6.Enabled == false && this.pictureBox17.Enabled == false && p6.Equals(p17) ||
                    this.pictureBox6.Enabled == false && this.pictureBox18.Enabled == false && p6.Equals(p18))
                {
                    this.pictureBox6.Enabled = false;
                }
                else
                {
                    this.pictureBox6.Enabled = true;
                }
                if (this.pictureBox7.Enabled == false && this.pictureBox2.Enabled == false && p7.Equals(p2) ||
                    this.pictureBox7.Enabled == false && this.pictureBox3.Enabled == false && p7.Equals(p3) ||
                    this.pictureBox7.Enabled == false && this.pictureBox4.Enabled == false && p7.Equals(p4) ||
                    this.pictureBox7.Enabled == false && this.pictureBox5.Enabled == false && p7.Equals(p5) ||
                    this.pictureBox7.Enabled == false && this.pictureBox6.Enabled == false && p7.Equals(p6) ||
                    this.pictureBox7.Enabled == false && this.pictureBox1.Enabled == false && p7.Equals(p1) ||
                    this.pictureBox7.Enabled == false && this.pictureBox8.Enabled == false && p7.Equals(p8) ||
                    this.pictureBox7.Enabled == false && this.pictureBox9.Enabled == false && p7.Equals(p9) ||
                    this.pictureBox7.Enabled == false && this.pictureBox10.Enabled == false && p7.Equals(p10) ||
                    this.pictureBox7.Enabled == false && this.pictureBox11.Enabled == false && p7.Equals(p11) ||
                    this.pictureBox7.Enabled == false && this.pictureBox12.Enabled == false && p7.Equals(p12) ||
                    this.pictureBox7.Enabled == false && this.pictureBox13.Enabled == false && p7.Equals(p13) ||
                    this.pictureBox7.Enabled == false && this.pictureBox14.Enabled == false && p7.Equals(p14) ||
                    this.pictureBox7.Enabled == false && this.pictureBox15.Enabled == false && p7.Equals(p15) ||
                    this.pictureBox7.Enabled == false && this.pictureBox16.Enabled == false && p7.Equals(p16) ||
                    this.pictureBox7.Enabled == false && this.pictureBox17.Enabled == false && p7.Equals(p17) ||
                    this.pictureBox7.Enabled == false && this.pictureBox18.Enabled == false && p7.Equals(p18))
                {
                    this.pictureBox7.Enabled = false;
                }
                else
                {
                    this.pictureBox7.Enabled = true;
                }
                if (this.pictureBox8.Enabled == false && this.pictureBox2.Enabled == false && p8.Equals(p2) ||
                    this.pictureBox8.Enabled == false && this.pictureBox3.Enabled == false && p8.Equals(p3) ||
                    this.pictureBox8.Enabled == false && this.pictureBox4.Enabled == false && p8.Equals(p4) ||
                    this.pictureBox8.Enabled == false && this.pictureBox5.Enabled == false && p8.Equals(p5) ||
                    this.pictureBox8.Enabled == false && this.pictureBox6.Enabled == false && p8.Equals(p6) ||
                    this.pictureBox8.Enabled == false && this.pictureBox7.Enabled == false && p8.Equals(p7) ||
                    this.pictureBox8.Enabled == false && this.pictureBox1.Enabled == false && p8.Equals(p1) ||
                    this.pictureBox8.Enabled == false && this.pictureBox9.Enabled == false && p8.Equals(p9) ||
                    this.pictureBox8.Enabled == false && this.pictureBox10.Enabled == false && p8.Equals(p10) ||
                    this.pictureBox8.Enabled == false && this.pictureBox11.Enabled == false && p8.Equals(p11) ||
                    this.pictureBox8.Enabled == false && this.pictureBox12.Enabled == false && p8.Equals(p12) ||
                    this.pictureBox8.Enabled == false && this.pictureBox13.Enabled == false && p8.Equals(p13) ||
                    this.pictureBox8.Enabled == false && this.pictureBox14.Enabled == false && p8.Equals(p14) ||
                    this.pictureBox8.Enabled == false && this.pictureBox15.Enabled == false && p8.Equals(p15) ||
                    this.pictureBox8.Enabled == false && this.pictureBox16.Enabled == false && p8.Equals(p16) ||
                    this.pictureBox8.Enabled == false && this.pictureBox17.Enabled == false && p8.Equals(p17) ||
                    this.pictureBox8.Enabled == false && this.pictureBox18.Enabled == false && p8.Equals(p18))
                {
                    this.pictureBox8.Enabled = false;
                }
                else
                {
                    this.pictureBox8.Enabled = true;
                }
                if (this.pictureBox9.Enabled == false && this.pictureBox2.Enabled == false && p9.Equals(p2) ||
                    this.pictureBox9.Enabled == false && this.pictureBox3.Enabled == false && p9.Equals(p3) ||
                    this.pictureBox9.Enabled == false && this.pictureBox4.Enabled == false && p9.Equals(p4) ||
                    this.pictureBox9.Enabled == false && this.pictureBox5.Enabled == false && p9.Equals(p5) ||
                    this.pictureBox9.Enabled == false && this.pictureBox6.Enabled == false && p9.Equals(p6) ||
                    this.pictureBox9.Enabled == false && this.pictureBox7.Enabled == false && p9.Equals(p7) ||
                    this.pictureBox9.Enabled == false && this.pictureBox8.Enabled == false && p9.Equals(p8) ||
                    this.pictureBox9.Enabled == false && this.pictureBox1.Enabled == false && p9.Equals(p1) ||
                    this.pictureBox9.Enabled == false && this.pictureBox10.Enabled == false && p9.Equals(p10) ||
                    this.pictureBox9.Enabled == false && this.pictureBox11.Enabled == false && p9.Equals(p11) ||
                    this.pictureBox9.Enabled == false && this.pictureBox12.Enabled == false && p9.Equals(p12) ||
                    this.pictureBox9.Enabled == false && this.pictureBox13.Enabled == false && p9.Equals(p13) ||
                    this.pictureBox9.Enabled == false && this.pictureBox14.Enabled == false && p9.Equals(p14) ||
                    this.pictureBox9.Enabled == false && this.pictureBox15.Enabled == false && p9.Equals(p15) ||
                    this.pictureBox9.Enabled == false && this.pictureBox16.Enabled == false && p9.Equals(p16) ||
                    this.pictureBox9.Enabled == false && this.pictureBox17.Enabled == false && p9.Equals(p17) ||
                    this.pictureBox9.Enabled == false && this.pictureBox18.Enabled == false && p9.Equals(p18))
                {
                    this.pictureBox9.Enabled = false;
                }
                else
                {
                    this.pictureBox9.Enabled = true;
                }
                if (this.pictureBox10.Enabled == false && this.pictureBox2.Enabled == false && p10.Equals(p2) ||
                    this.pictureBox10.Enabled == false && this.pictureBox3.Enabled == false && p10.Equals(p3) ||
                    this.pictureBox10.Enabled == false && this.pictureBox4.Enabled == false && p10.Equals(p4) ||
                    this.pictureBox10.Enabled == false && this.pictureBox5.Enabled == false && p10.Equals(p5) ||
                    this.pictureBox10.Enabled == false && this.pictureBox6.Enabled == false && p10.Equals(p6) ||
                    this.pictureBox10.Enabled == false && this.pictureBox7.Enabled == false && p10.Equals(p7) ||
                    this.pictureBox10.Enabled == false && this.pictureBox8.Enabled == false && p10.Equals(p8) ||
                    this.pictureBox10.Enabled == false && this.pictureBox9.Enabled == false && p10.Equals(p9) ||
                    this.pictureBox10.Enabled == false && this.pictureBox1.Enabled == false && p10.Equals(p1) ||
                    this.pictureBox10.Enabled == false && this.pictureBox11.Enabled == false && p10.Equals(p11) ||
                    this.pictureBox10.Enabled == false && this.pictureBox12.Enabled == false && p10.Equals(p12) ||
                    this.pictureBox10.Enabled == false && this.pictureBox13.Enabled == false && p10.Equals(p13) ||
                    this.pictureBox10.Enabled == false && this.pictureBox14.Enabled == false && p10.Equals(p14) ||
                    this.pictureBox10.Enabled == false && this.pictureBox15.Enabled == false && p10.Equals(p15) ||
                    this.pictureBox10.Enabled == false && this.pictureBox16.Enabled == false && p10.Equals(p16) ||
                    this.pictureBox10.Enabled == false && this.pictureBox17.Enabled == false && p10.Equals(p17) ||
                    this.pictureBox10.Enabled == false && this.pictureBox18.Enabled == false && p10.Equals(p18))
                {
                    this.pictureBox10.Enabled = false;
                }
                else
                {
                    this.pictureBox10.Enabled = true;
                }
                if (this.pictureBox11.Enabled == false && this.pictureBox2.Enabled == false && p11.Equals(p2) ||
                    this.pictureBox11.Enabled == false && this.pictureBox3.Enabled == false && p11.Equals(p3) ||
                    this.pictureBox11.Enabled == false && this.pictureBox4.Enabled == false && p11.Equals(p4) ||
                    this.pictureBox11.Enabled == false && this.pictureBox5.Enabled == false && p11.Equals(p5) ||
                    this.pictureBox11.Enabled == false && this.pictureBox6.Enabled == false && p11.Equals(p6) ||
                    this.pictureBox11.Enabled == false && this.pictureBox7.Enabled == false && p11.Equals(p7) ||
                    this.pictureBox11.Enabled == false && this.pictureBox8.Enabled == false && p11.Equals(p8) ||
                    this.pictureBox11.Enabled == false && this.pictureBox9.Enabled == false && p11.Equals(p9) ||
                    this.pictureBox11.Enabled == false && this.pictureBox10.Enabled == false && p11.Equals(p10) ||
                    this.pictureBox11.Enabled == false && this.pictureBox1.Enabled == false && p11.Equals(p1) ||
                    this.pictureBox11.Enabled == false && this.pictureBox12.Enabled == false && p11.Equals(p12) ||
                    this.pictureBox11.Enabled == false && this.pictureBox13.Enabled == false && p11.Equals(p13) ||
                    this.pictureBox11.Enabled == false && this.pictureBox14.Enabled == false && p11.Equals(p14) ||
                    this.pictureBox11.Enabled == false && this.pictureBox15.Enabled == false && p11.Equals(p15) ||
                    this.pictureBox11.Enabled == false && this.pictureBox16.Enabled == false && p11.Equals(p16) ||
                    this.pictureBox11.Enabled == false && this.pictureBox17.Enabled == false && p11.Equals(p17) ||
                    this.pictureBox11.Enabled == false && this.pictureBox18.Enabled == false && p11.Equals(p18))
                {
                    this.pictureBox11.Enabled = false;
                }
                else
                {
                    this.pictureBox11.Enabled = true;
                }
                if (this.pictureBox12.Enabled == false && this.pictureBox2.Enabled == false && p12.Equals(p2) ||
                    this.pictureBox12.Enabled == false && this.pictureBox3.Enabled == false && p12.Equals(p3) ||
                    this.pictureBox12.Enabled == false && this.pictureBox4.Enabled == false && p12.Equals(p4) ||
                    this.pictureBox12.Enabled == false && this.pictureBox5.Enabled == false && p12.Equals(p5) ||
                    this.pictureBox12.Enabled == false && this.pictureBox6.Enabled == false && p12.Equals(p6) ||
                    this.pictureBox12.Enabled == false && this.pictureBox7.Enabled == false && p12.Equals(p7) ||
                    this.pictureBox12.Enabled == false && this.pictureBox8.Enabled == false && p12.Equals(p8) ||
                    this.pictureBox12.Enabled == false && this.pictureBox9.Enabled == false && p12.Equals(p9) ||
                    this.pictureBox12.Enabled == false && this.pictureBox10.Enabled == false && p12.Equals(p10) ||
                    this.pictureBox12.Enabled == false && this.pictureBox11.Enabled == false && p12.Equals(p11) ||
                    this.pictureBox12.Enabled == false && this.pictureBox1.Enabled == false && p12.Equals(p1) ||
                    this.pictureBox12.Enabled == false && this.pictureBox13.Enabled == false && p12.Equals(p13) ||
                    this.pictureBox12.Enabled == false && this.pictureBox14.Enabled == false && p12.Equals(p14) ||
                    this.pictureBox12.Enabled == false && this.pictureBox15.Enabled == false && p12.Equals(p15) ||
                    this.pictureBox12.Enabled == false && this.pictureBox16.Enabled == false && p12.Equals(p16) ||
                    this.pictureBox12.Enabled == false && this.pictureBox17.Enabled == false && p12.Equals(p17) ||
                    this.pictureBox12.Enabled == false && this.pictureBox18.Enabled == false && p12.Equals(p18))
                {
                    this.pictureBox12.Enabled = false;
                }
                else
                {
                    this.pictureBox12.Enabled = true;
                }
                if (this.pictureBox13.Enabled == false && this.pictureBox2.Enabled == false && p13.Equals(p2) ||
                    this.pictureBox13.Enabled == false && this.pictureBox3.Enabled == false && p13.Equals(p3) ||
                    this.pictureBox13.Enabled == false && this.pictureBox4.Enabled == false && p13.Equals(p4) ||
                    this.pictureBox13.Enabled == false && this.pictureBox5.Enabled == false && p13.Equals(p5) ||
                    this.pictureBox13.Enabled == false && this.pictureBox6.Enabled == false && p13.Equals(p6) ||
                    this.pictureBox13.Enabled == false && this.pictureBox7.Enabled == false && p13.Equals(p7) ||
                    this.pictureBox13.Enabled == false && this.pictureBox8.Enabled == false && p13.Equals(p8) ||
                    this.pictureBox13.Enabled == false && this.pictureBox9.Enabled == false && p13.Equals(p9) ||
                    this.pictureBox13.Enabled == false && this.pictureBox10.Enabled == false && p13.Equals(p10) ||
                    this.pictureBox13.Enabled == false && this.pictureBox11.Enabled == false && p13.Equals(p11) ||
                    this.pictureBox13.Enabled == false && this.pictureBox12.Enabled == false && p13.Equals(p12) ||
                    this.pictureBox13.Enabled == false && this.pictureBox1.Enabled == false && p13.Equals(p1) ||
                    this.pictureBox13.Enabled == false && this.pictureBox14.Enabled == false && p13.Equals(p14) ||
                    this.pictureBox13.Enabled == false && this.pictureBox15.Enabled == false && p13.Equals(p15) ||
                    this.pictureBox13.Enabled == false && this.pictureBox16.Enabled == false && p13.Equals(p16) ||
                    this.pictureBox13.Enabled == false && this.pictureBox17.Enabled == false && p13.Equals(p17) ||
                    this.pictureBox13.Enabled == false && this.pictureBox18.Enabled == false && p13.Equals(p18))
                {
                    this.pictureBox13.Enabled = false;
                }
                else
                {
                    this.pictureBox13.Enabled = true;
                }
                if (this.pictureBox14.Enabled == false && this.pictureBox2.Enabled == false && p14.Equals(p2) ||
                    this.pictureBox14.Enabled == false && this.pictureBox3.Enabled == false && p14.Equals(p3) ||
                    this.pictureBox14.Enabled == false && this.pictureBox4.Enabled == false && p14.Equals(p4) ||
                    this.pictureBox14.Enabled == false && this.pictureBox5.Enabled == false && p14.Equals(p5) ||
                    this.pictureBox14.Enabled == false && this.pictureBox6.Enabled == false && p14.Equals(p6) ||
                    this.pictureBox14.Enabled == false && this.pictureBox7.Enabled == false && p14.Equals(p7) ||
                    this.pictureBox14.Enabled == false && this.pictureBox8.Enabled == false && p14.Equals(p8) ||
                    this.pictureBox14.Enabled == false && this.pictureBox9.Enabled == false && p14.Equals(p9) ||
                    this.pictureBox14.Enabled == false && this.pictureBox10.Enabled == false && p14.Equals(p10) ||
                    this.pictureBox14.Enabled == false && this.pictureBox11.Enabled == false && p14.Equals(p11) ||
                    this.pictureBox14.Enabled == false && this.pictureBox12.Enabled == false && p14.Equals(p12) ||
                    this.pictureBox14.Enabled == false && this.pictureBox13.Enabled == false && p14.Equals(p13) ||
                    this.pictureBox14.Enabled == false && this.pictureBox1.Enabled == false && p14.Equals(p1) ||
                    this.pictureBox14.Enabled == false && this.pictureBox15.Enabled == false && p14.Equals(p15) ||
                    this.pictureBox14.Enabled == false && this.pictureBox16.Enabled == false && p14.Equals(p16) ||
                    this.pictureBox14.Enabled == false && this.pictureBox17.Enabled == false && p14.Equals(p17) ||
                    this.pictureBox14.Enabled == false && this.pictureBox18.Enabled == false && p14.Equals(p18))
                {
                    this.pictureBox14.Enabled = false;
                }
                else
                {
                    this.pictureBox14.Enabled = true;
                }
                if (this.pictureBox15.Enabled == false && this.pictureBox2.Enabled == false && p15.Equals(p2) ||
                    this.pictureBox15.Enabled == false && this.pictureBox3.Enabled == false && p15.Equals(p3) ||
                    this.pictureBox15.Enabled == false && this.pictureBox4.Enabled == false && p15.Equals(p4) ||
                    this.pictureBox15.Enabled == false && this.pictureBox5.Enabled == false && p15.Equals(p5) ||
                    this.pictureBox15.Enabled == false && this.pictureBox6.Enabled == false && p15.Equals(p6) ||
                    this.pictureBox15.Enabled == false && this.pictureBox7.Enabled == false && p15.Equals(p7) ||
                    this.pictureBox15.Enabled == false && this.pictureBox8.Enabled == false && p15.Equals(p8) ||
                    this.pictureBox15.Enabled == false && this.pictureBox9.Enabled == false && p15.Equals(p9) ||
                    this.pictureBox15.Enabled == false && this.pictureBox10.Enabled == false && p15.Equals(p10) ||
                    this.pictureBox15.Enabled == false && this.pictureBox11.Enabled == false && p15.Equals(p11) ||
                    this.pictureBox15.Enabled == false && this.pictureBox12.Enabled == false && p15.Equals(p12) ||
                    this.pictureBox15.Enabled == false && this.pictureBox13.Enabled == false && p15.Equals(p13) ||
                    this.pictureBox15.Enabled == false && this.pictureBox14.Enabled == false && p15.Equals(p14) ||
                    this.pictureBox15.Enabled == false && this.pictureBox1.Enabled == false && p15.Equals(p1) ||
                    this.pictureBox15.Enabled == false && this.pictureBox16.Enabled == false && p15.Equals(p16) ||
                    this.pictureBox15.Enabled == false && this.pictureBox17.Enabled == false && p15.Equals(p17) ||
                    this.pictureBox15.Enabled == false && this.pictureBox18.Enabled == false && p15.Equals(p18))
                {
                    this.pictureBox15.Enabled = false;
                }
                else
                {
                    this.pictureBox15.Enabled = true;
                }
                if (this.pictureBox16.Enabled == false && this.pictureBox2.Enabled == false && p16.Equals(p2) ||
                    this.pictureBox16.Enabled == false && this.pictureBox3.Enabled == false && p16.Equals(p3) ||
                    this.pictureBox16.Enabled == false && this.pictureBox4.Enabled == false && p16.Equals(p4) ||
                    this.pictureBox16.Enabled == false && this.pictureBox5.Enabled == false && p16.Equals(p5) ||
                    this.pictureBox16.Enabled == false && this.pictureBox6.Enabled == false && p16.Equals(p6) ||
                    this.pictureBox16.Enabled == false && this.pictureBox7.Enabled == false && p16.Equals(p7) ||
                    this.pictureBox16.Enabled == false && this.pictureBox8.Enabled == false && p16.Equals(p8) ||
                    this.pictureBox16.Enabled == false && this.pictureBox9.Enabled == false && p16.Equals(p9) ||
                    this.pictureBox16.Enabled == false && this.pictureBox10.Enabled == false && p16.Equals(p10) ||
                    this.pictureBox16.Enabled == false && this.pictureBox11.Enabled == false && p16.Equals(p11) ||
                    this.pictureBox16.Enabled == false && this.pictureBox12.Enabled == false && p16.Equals(p12) ||
                    this.pictureBox16.Enabled == false && this.pictureBox13.Enabled == false && p16.Equals(p13) ||
                    this.pictureBox16.Enabled == false && this.pictureBox14.Enabled == false && p16.Equals(p14) ||
                    this.pictureBox16.Enabled == false && this.pictureBox15.Enabled == false && p16.Equals(p15) ||
                    this.pictureBox16.Enabled == false && this.pictureBox1.Enabled == false && p16.Equals(p1) ||
                    this.pictureBox16.Enabled == false && this.pictureBox17.Enabled == false && p16.Equals(p17) ||
                    this.pictureBox16.Enabled == false && this.pictureBox18.Enabled == false && p16.Equals(p18))
                {
                    this.pictureBox16.Enabled = false;
                }
                else
                {
                    this.pictureBox16.Enabled = true;
                }
                if (this.pictureBox17.Enabled == false && this.pictureBox2.Enabled == false && p17.Equals(p2) ||
                    this.pictureBox17.Enabled == false && this.pictureBox3.Enabled == false && p17.Equals(p3) ||
                    this.pictureBox17.Enabled == false && this.pictureBox4.Enabled == false && p17.Equals(p4) ||
                    this.pictureBox17.Enabled == false && this.pictureBox5.Enabled == false && p17.Equals(p5) ||
                    this.pictureBox17.Enabled == false && this.pictureBox6.Enabled == false && p17.Equals(p6) ||
                    this.pictureBox17.Enabled == false && this.pictureBox7.Enabled == false && p17.Equals(p7) ||
                    this.pictureBox17.Enabled == false && this.pictureBox8.Enabled == false && p17.Equals(p8) ||
                    this.pictureBox17.Enabled == false && this.pictureBox9.Enabled == false && p17.Equals(p9) ||
                    this.pictureBox17.Enabled == false && this.pictureBox10.Enabled == false && p17.Equals(p10) ||
                    this.pictureBox17.Enabled == false && this.pictureBox11.Enabled == false && p17.Equals(p11) ||
                    this.pictureBox17.Enabled == false && this.pictureBox12.Enabled == false && p17.Equals(p12) ||
                    this.pictureBox17.Enabled == false && this.pictureBox13.Enabled == false && p17.Equals(p13) ||
                    this.pictureBox17.Enabled == false && this.pictureBox14.Enabled == false && p17.Equals(p14) ||
                    this.pictureBox17.Enabled == false && this.pictureBox15.Enabled == false && p17.Equals(p15) ||
                    this.pictureBox17.Enabled == false && this.pictureBox16.Enabled == false && p17.Equals(p16) ||
                    this.pictureBox17.Enabled == false && this.pictureBox1.Enabled == false && p17.Equals(p1) ||
                    this.pictureBox17.Enabled == false && this.pictureBox18.Enabled == false && p17.Equals(p18))
                {
                    this.pictureBox17.Enabled = false;
                }
                else
                {
                    this.pictureBox17.Enabled = true;
                }
                if (this.pictureBox18.Enabled == false && this.pictureBox2.Enabled == false && p18.Equals(p2) ||
                    this.pictureBox18.Enabled == false && this.pictureBox3.Enabled == false && p18.Equals(p3) ||
                    this.pictureBox18.Enabled == false && this.pictureBox4.Enabled == false && p18.Equals(p4) ||
                    this.pictureBox18.Enabled == false && this.pictureBox5.Enabled == false && p18.Equals(p5) ||
                    this.pictureBox18.Enabled == false && this.pictureBox6.Enabled == false && p18.Equals(p6) ||
                    this.pictureBox18.Enabled == false && this.pictureBox7.Enabled == false && p18.Equals(p7) ||
                    this.pictureBox18.Enabled == false && this.pictureBox8.Enabled == false && p18.Equals(p8) ||
                    this.pictureBox18.Enabled == false && this.pictureBox9.Enabled == false && p18.Equals(p9) ||
                    this.pictureBox18.Enabled == false && this.pictureBox10.Enabled == false && p18.Equals(p10) ||
                    this.pictureBox18.Enabled == false && this.pictureBox11.Enabled == false && p18.Equals(p11) ||
                    this.pictureBox18.Enabled == false && this.pictureBox12.Enabled == false && p18.Equals(p12) ||
                    this.pictureBox18.Enabled == false && this.pictureBox13.Enabled == false && p18.Equals(p13) ||
                    this.pictureBox18.Enabled == false && this.pictureBox14.Enabled == false && p18.Equals(p14) ||
                    this.pictureBox18.Enabled == false && this.pictureBox15.Enabled == false && p18.Equals(p15) ||
                    this.pictureBox18.Enabled == false && this.pictureBox16.Enabled == false && p18.Equals(p16) ||
                    this.pictureBox18.Enabled == false && this.pictureBox17.Enabled == false && p18.Equals(p17) ||
                    this.pictureBox18.Enabled == false && this.pictureBox1.Enabled == false && p18.Equals(p1))
                {
                    this.pictureBox18.Enabled = false;
                }
                else
                {
                    this.pictureBox18.Enabled = true;
                }

            }

            if (this.pictureBox1.Enabled == false && this.pictureBox2.Enabled == false && this.pictureBox3.Enabled == false && 
                this.pictureBox4.Enabled == false && this.pictureBox5.Enabled == false && this.pictureBox6.Enabled == false && 
                this.pictureBox7.Enabled == false && this.pictureBox8.Enabled == false && this.pictureBox9.Enabled == false && 
                this.pictureBox10.Enabled == false && this.pictureBox11.Enabled == false && this.pictureBox12.Enabled == false && 
                this.pictureBox13.Enabled == false && this.pictureBox14.Enabled == false && this.pictureBox15.Enabled == false && 
                this.pictureBox16.Enabled == false && this.pictureBox17.Enabled == false && this.pictureBox18.Enabled == false)
            {
                winMusic.Play();
                System.Threading.Thread.Sleep(5500);
                InitializeCards();
            }
        }

        /*
         * this method flips all unmatched cards back over
         */
        private void TurnEnd()
        {
            Bitmap picture = global::Memory.Properties.Resources.Ore_Regional;
                if (this.pictureBox1.Enabled == true)
                {
                    this.pictureBox1.Image = picture;
                }
                if (this.pictureBox2.Enabled == true)
                {
                    this.pictureBox2.Image = picture;
                }
                if (this.pictureBox3.Enabled == true)
                {       
                    this.pictureBox3.Image = picture;
                }
                if (this.pictureBox4.Enabled == true)
                {
                    this.pictureBox4.Image = picture;
                }
                if (this.pictureBox5.Enabled == true)
                {
                    this.pictureBox5.Image = picture;
                }
                if (this.pictureBox6.Enabled == true)
                {
                    this.pictureBox6.Image = picture;
                }
                if (this.pictureBox7.Enabled == true)
                {
                    this.pictureBox7.Image = picture;
                }
                if (this.pictureBox8.Enabled == true)
                {
                    this.pictureBox8.Image = picture;
                }
                if (this.pictureBox9.Enabled == true)
                {
                    this.pictureBox9.Image = picture;
                }
                if (this.pictureBox10.Enabled == true)
                {
                    this.pictureBox10.Image = picture;
                }
                if (this.pictureBox11.Enabled == true)
                {
                    this.pictureBox11.Image = picture;
                }
                if (this.pictureBox12.Enabled == true)
                {
                    this.pictureBox12.Image = picture;
                }
                if (this.pictureBox13.Enabled == true)
                {
                    this.pictureBox13.Image = picture;
                }
                if (this.pictureBox14.Enabled == true)
                {
                    this.pictureBox14.Image = picture;
                }
                if (this.pictureBox15.Enabled == true)
                {
                    this.pictureBox15.Image = picture;
                }
                if (this.pictureBox16.Enabled == true)
                {
                    this.pictureBox16.Image = picture;
                }
                if (this.pictureBox17.Enabled == true)
                {
                    this.pictureBox17.Image = picture;
                }
                if (this.pictureBox18.Enabled == true)
                {
                    this.pictureBox18.Image = picture;
                }

                cardFlip.Play();
        }

        #region card event handlers
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox1;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p1);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p1);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox2;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p2);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p2);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox3;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p3);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p3);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox4;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p4);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p4);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox5;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p5);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p5);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox6;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p6);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p6);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox7;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p7);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p7);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox8;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p8);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p8);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox9;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p9);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p9);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox10;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p10);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p10);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox11;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p11);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p11);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox12;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p12);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p12);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox13;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p13);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p13);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox14;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p14);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p14);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox15;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p15);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p15);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox16;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p16);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p16);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox17;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p17);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p17);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            TurnEnd();
            PictureBox p = this.pictureBox18;
            if (board.Equals("b1"))
            {
                OreCard card = new OreCard(p18);
                p.Image = card.picture;
            }
            else if (board.Equals("b2"))
            {
                IceCard card = new IceCard(p18);
                p.Image = card.picture;
            }
            p.Enabled = false;
            
            MatchCheck();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeCards();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void board1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.board = "b1";
            InitializeCards();
        }

        private void board2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.board = "b2";
            InitializeCards();
            
        }

    }
        #endregion
}
