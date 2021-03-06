﻿/*
 * Created by SharpDevelop.
 * User: copygirl
 * Date: 30.08.2012
 * Time: 13:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace INVedit
{
	partial class EditForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.boxText1 = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.labelPage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxTitle = new System.Windows.Forms.TextBox();
            this.boxSigned = new System.Windows.Forms.CheckBox();
            this.boxAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.tmrRnd = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnStrike = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.PictureBox();
            this.btnYellow = new System.Windows.Forms.PictureBox();
            this.btnPink = new System.Windows.Forms.PictureBox();
            this.btnRed = new System.Windows.Forms.PictureBox();
            this.btnAqua = new System.Windows.Forms.PictureBox();
            this.btnBrightGreen = new System.Windows.Forms.PictureBox();
            this.btnIndigo = new System.Windows.Forms.PictureBox();
            this.btnDarkGray = new System.Windows.Forms.PictureBox();
            this.btnGray = new System.Windows.Forms.PictureBox();
            this.btnGold = new System.Windows.Forms.PictureBox();
            this.btnPurple = new System.Windows.Forms.PictureBox();
            this.btnDarkRed = new System.Windows.Forms.PictureBox();
            this.btnDarkAqua = new System.Windows.Forms.PictureBox();
            this.btnDarkGreen = new System.Windows.Forms.PictureBox();
            this.btnDarkBlue = new System.Windows.Forms.PictureBox();
            this.btnBlack = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrightGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIndigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDarkGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDarkRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDarkAqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDarkGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDarkBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlack)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxText1
            // 
            this.boxText1.Enabled = false;
            this.boxText1.Location = new System.Drawing.Point(16, 263);
            this.boxText1.MaxLength = 255;
            this.boxText1.Multiline = true;
            this.boxText1.Name = "boxText1";
            this.boxText1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxText1.Size = new System.Drawing.Size(310, 134);
            this.boxText1.TabIndex = 6;
            this.boxText1.TextChanged += new System.EventHandler(this.BoxTextTextChanged);
            this.boxText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxText_KeyPress);
            this.boxText1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.boxText_KeyUp);
            this.boxText1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxText_MouseUp);
            this.boxText1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.boxText_PreviewKeyDown);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(9, 204);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 22);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPreviousClick);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(279, 204);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 22);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNextClick);
            // 
            // labelPage
            // 
            this.labelPage.Location = new System.Drawing.Point(55, 204);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(218, 22);
            this.labelPage.TabIndex = 8;
            this.labelPage.Text = "Page 0 of 0";
            this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boxTitle
            // 
            this.boxTitle.Enabled = false;
            this.boxTitle.Location = new System.Drawing.Point(60, 7);
            this.boxTitle.Name = "boxTitle";
            this.boxTitle.Size = new System.Drawing.Size(259, 20);
            this.boxTitle.TabIndex = 1;
            this.boxTitle.TextChanged += new System.EventHandler(this.BoxTitleTextChanged);
            this.boxTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxTitle_MouseUp);
            // 
            // boxSigned
            // 
            this.boxSigned.Appearance = System.Windows.Forms.Appearance.Button;
            this.boxSigned.Enabled = false;
            this.boxSigned.Location = new System.Drawing.Point(265, 31);
            this.boxSigned.Name = "boxSigned";
            this.boxSigned.Size = new System.Drawing.Size(54, 24);
            this.boxSigned.TabIndex = 5;
            this.boxSigned.Text = "Signed";
            this.boxSigned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boxSigned.UseVisualStyleBackColor = true;
            this.boxSigned.CheckedChanged += new System.EventHandler(this.BoxSignedCheckedChanged);
            // 
            // boxAuthor
            // 
            this.boxAuthor.Enabled = false;
            this.boxAuthor.Location = new System.Drawing.Point(60, 33);
            this.boxAuthor.Name = "boxAuthor";
            this.boxAuthor.Size = new System.Drawing.Size(199, 20);
            this.boxAuthor.TabIndex = 4;
            this.boxAuthor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxAuthor_MouseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(334, 204);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(63, 22);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // tmrRnd
            // 
            this.tmrRnd.Enabled = true;
            this.tmrRnd.Interval = 50;
            this.tmrRnd.Tick += new System.EventHandler(this.tmrRnd_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(334, 142);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 21);
            this.btnReset.TabIndex = 48;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Enabled = false;
            this.btnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.Location = new System.Drawing.Point(334, 115);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(63, 21);
            this.btnItalic.TabIndex = 47;
            this.btnItalic.Text = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Enabled = false;
            this.btnUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.Location = new System.Drawing.Point(334, 88);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(63, 21);
            this.btnUnderline.TabIndex = 46;
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnStrike
            // 
            this.btnStrike.Enabled = false;
            this.btnStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrike.Location = new System.Drawing.Point(334, 61);
            this.btnStrike.Name = "btnStrike";
            this.btnStrike.Size = new System.Drawing.Size(63, 21);
            this.btnStrike.TabIndex = 45;
            this.btnStrike.Text = "Strike";
            this.btnStrike.UseVisualStyleBackColor = true;
            this.btnStrike.Click += new System.EventHandler(this.btnStrike_Click);
            // 
            // btnBold
            // 
            this.btnBold.Enabled = false;
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.Location = new System.Drawing.Point(334, 34);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(63, 21);
            this.btnBold.TabIndex = 44;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Enabled = false;
            this.btnRandom.Location = new System.Drawing.Point(334, 7);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(63, 21);
            this.btnRandom.TabIndex = 43;
            this.btnRandom.Text = "Rnd Text";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnWhite.Enabled = false;
            this.btnWhite.Location = new System.Drawing.Point(446, 204);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(23, 22);
            this.btnWhite.TabIndex = 64;
            this.btnWhite.TabStop = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.btnYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnYellow.Enabled = false;
            this.btnYellow.Location = new System.Drawing.Point(446, 176);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(23, 22);
            this.btnYellow.TabIndex = 63;
            this.btnYellow.TabStop = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnPink
            // 
            this.btnPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnPink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnPink.Enabled = false;
            this.btnPink.Location = new System.Drawing.Point(446, 148);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(23, 22);
            this.btnPink.TabIndex = 62;
            this.btnPink.TabStop = false;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnRed.Enabled = false;
            this.btnRed.Location = new System.Drawing.Point(446, 120);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(23, 22);
            this.btnRed.TabIndex = 61;
            this.btnRed.TabStop = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnAqua
            // 
            this.btnAqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAqua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAqua.Enabled = false;
            this.btnAqua.Location = new System.Drawing.Point(446, 92);
            this.btnAqua.Name = "btnAqua";
            this.btnAqua.Size = new System.Drawing.Size(23, 22);
            this.btnAqua.TabIndex = 60;
            this.btnAqua.TabStop = false;
            this.btnAqua.Click += new System.EventHandler(this.btnAqua_Click);
            // 
            // btnBrightGreen
            // 
            this.btnBrightGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.btnBrightGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBrightGreen.Enabled = false;
            this.btnBrightGreen.Location = new System.Drawing.Point(446, 64);
            this.btnBrightGreen.Name = "btnBrightGreen";
            this.btnBrightGreen.Size = new System.Drawing.Size(23, 22);
            this.btnBrightGreen.TabIndex = 59;
            this.btnBrightGreen.TabStop = false;
            this.btnBrightGreen.Click += new System.EventHandler(this.btnBrightGreen_Click);
            // 
            // btnIndigo
            // 
            this.btnIndigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnIndigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnIndigo.Enabled = false;
            this.btnIndigo.Location = new System.Drawing.Point(446, 36);
            this.btnIndigo.Name = "btnIndigo";
            this.btnIndigo.Size = new System.Drawing.Size(23, 22);
            this.btnIndigo.TabIndex = 58;
            this.btnIndigo.TabStop = false;
            this.btnIndigo.Click += new System.EventHandler(this.btnIndigo_Click);
            // 
            // btnDarkGray
            // 
            this.btnDarkGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDarkGray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDarkGray.Enabled = false;
            this.btnDarkGray.Location = new System.Drawing.Point(446, 8);
            this.btnDarkGray.Name = "btnDarkGray";
            this.btnDarkGray.Size = new System.Drawing.Size(23, 22);
            this.btnDarkGray.TabIndex = 57;
            this.btnDarkGray.TabStop = false;
            this.btnDarkGray.Click += new System.EventHandler(this.btnDarkGray_Click);
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnGray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnGray.Enabled = false;
            this.btnGray.Location = new System.Drawing.Point(417, 204);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(23, 22);
            this.btnGray.TabIndex = 56;
            this.btnGray.TabStop = false;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnGold
            // 
            this.btnGold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnGold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnGold.Enabled = false;
            this.btnGold.Location = new System.Drawing.Point(417, 176);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(23, 22);
            this.btnGold.TabIndex = 55;
            this.btnGold.TabStop = false;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.btnPurple.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnPurple.Enabled = false;
            this.btnPurple.Location = new System.Drawing.Point(417, 148);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(23, 22);
            this.btnPurple.TabIndex = 54;
            this.btnPurple.TabStop = false;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnDarkRed
            // 
            this.btnDarkRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDarkRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDarkRed.Enabled = false;
            this.btnDarkRed.Location = new System.Drawing.Point(417, 120);
            this.btnDarkRed.Name = "btnDarkRed";
            this.btnDarkRed.Size = new System.Drawing.Size(23, 22);
            this.btnDarkRed.TabIndex = 53;
            this.btnDarkRed.TabStop = false;
            this.btnDarkRed.Click += new System.EventHandler(this.btnDarkRed_Click);
            // 
            // btnDarkAqua
            // 
            this.btnDarkAqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnDarkAqua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDarkAqua.Enabled = false;
            this.btnDarkAqua.Location = new System.Drawing.Point(417, 92);
            this.btnDarkAqua.Name = "btnDarkAqua";
            this.btnDarkAqua.Size = new System.Drawing.Size(23, 22);
            this.btnDarkAqua.TabIndex = 52;
            this.btnDarkAqua.TabStop = false;
            this.btnDarkAqua.Click += new System.EventHandler(this.btnDarkAqua_Click);
            // 
            // btnDarkGreen
            // 
            this.btnDarkGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnDarkGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDarkGreen.Enabled = false;
            this.btnDarkGreen.Location = new System.Drawing.Point(417, 64);
            this.btnDarkGreen.Name = "btnDarkGreen";
            this.btnDarkGreen.Size = new System.Drawing.Size(23, 22);
            this.btnDarkGreen.TabIndex = 51;
            this.btnDarkGreen.TabStop = false;
            this.btnDarkGreen.Click += new System.EventHandler(this.btnDarkGreen_Click);
            // 
            // btnDarkBlue
            // 
            this.btnDarkBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.btnDarkBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDarkBlue.Enabled = false;
            this.btnDarkBlue.Location = new System.Drawing.Point(417, 36);
            this.btnDarkBlue.Name = "btnDarkBlue";
            this.btnDarkBlue.Size = new System.Drawing.Size(23, 22);
            this.btnDarkBlue.TabIndex = 50;
            this.btnDarkBlue.TabStop = false;
            this.btnDarkBlue.Click += new System.EventHandler(this.btnDarkBlue_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBlack.Enabled = false;
            this.btnBlack.Location = new System.Drawing.Point(417, 8);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(23, 22);
            this.btnBlack.TabIndex = 49;
            this.btnBlack.TabStop = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCharCount,
            this.lblLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 244);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(478, 22);
            this.statusStrip1.TabIndex = 65;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCharCount
            // 
            this.lblCharCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblCharCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(86, 17);
            this.lblCharCount.Text = "Chars Left: 256";
            // 
            // lblLine
            // 
            this.lblLine.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblLine.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(102, 17);
            this.lblLine.Text = "Current Line: 0 /13";
            // 
            // boxText
            // 
            this.boxText.Enabled = false;
            this.boxText.Location = new System.Drawing.Point(10, 62);
            this.boxText.MaxLength = 256;
            this.boxText.Name = "boxText";
            this.boxText.RightMargin = 116;
            this.boxText.Size = new System.Drawing.Size(309, 134);
            this.boxText.TabIndex = 66;
            this.boxText.Text = "";
            this.boxText.TextChanged += new System.EventHandler(this.BoxTextTextChanged);
            this.boxText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.boxText_KeyDown);
            this.boxText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxText_KeyPress);
            this.boxText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.boxText_KeyUp);
            this.boxText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxText_MouseDown);
            this.boxText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxText_MouseUp);
            this.boxText.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.boxText_PreviewKeyDown);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 266);
            this.Controls.Add(this.boxText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnPink);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnAqua);
            this.Controls.Add(this.btnBrightGreen);
            this.Controls.Add(this.btnIndigo);
            this.Controls.Add(this.btnDarkGray);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnGold);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnDarkRed);
            this.Controls.Add(this.btnDarkAqua);
            this.Controls.Add(this.btnDarkGreen);
            this.Controls.Add(this.btnDarkBlue);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnStrike);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.boxSigned);
            this.Controls.Add(this.boxAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.boxText1);
            this.Controls.Add(this.boxTitle);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Editor";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrightGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIndigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDarkGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDarkRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDarkAqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDarkGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDarkBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlack)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.TextBox boxTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelPage;
		private System.Windows.Forms.CheckBox boxSigned;
		private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.TextBox boxText1;
		private System.Windows.Forms.TextBox boxAuthor;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Timer tmrRnd;
        private System.Windows.Forms.PictureBox btnWhite;
        private System.Windows.Forms.PictureBox btnYellow;
        private System.Windows.Forms.PictureBox btnPink;
        private System.Windows.Forms.PictureBox btnRed;
        private System.Windows.Forms.PictureBox btnAqua;
        private System.Windows.Forms.PictureBox btnBrightGreen;
        private System.Windows.Forms.PictureBox btnIndigo;
        private System.Windows.Forms.PictureBox btnDarkGray;
        private System.Windows.Forms.PictureBox btnGray;
        private System.Windows.Forms.PictureBox btnGold;
        private System.Windows.Forms.PictureBox btnPurple;
        private System.Windows.Forms.PictureBox btnDarkRed;
        private System.Windows.Forms.PictureBox btnDarkAqua;
        private System.Windows.Forms.PictureBox btnDarkGreen;
        private System.Windows.Forms.PictureBox btnDarkBlue;
        private System.Windows.Forms.PictureBox btnBlack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnStrike;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCharCount;
        private System.Windows.Forms.RichTextBox boxText;
        private System.Windows.Forms.ToolStripStatusLabel lblLine;
	}
}
