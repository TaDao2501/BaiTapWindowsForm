namespace Bai4
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmess = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoblack = new System.Windows.Forms.RadioButton();
            this.rdoblue = new System.Windows.Forms.RadioButton();
            this.rdogreen = new System.Windows.Forms.RadioButton();
            this.rdored = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblmess = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmess);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtmess
            // 
            this.txtmess.Location = new System.Drawing.Point(82, 59);
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(252, 20);
            this.txtmess.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(82, 27);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 20);
            this.txtname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoblack);
            this.groupBox2.Controls.Add(this.rdoblue);
            this.groupBox2.Controls.Add(this.rdogreen);
            this.groupBox2.Controls.Add(this.rdored);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // rdoblack
            // 
            this.rdoblack.AutoSize = true;
            this.rdoblack.Location = new System.Drawing.Point(28, 106);
            this.rdoblack.Name = "rdoblack";
            this.rdoblack.Size = new System.Drawing.Size(52, 17);
            this.rdoblack.TabIndex = 6;
            this.rdoblack.TabStop = true;
            this.rdoblack.Text = "Black";
            this.rdoblack.UseVisualStyleBackColor = true;
            this.rdoblack.CheckedChanged += new System.EventHandler(this.rdoblack_CheckedChanged);
            // 
            // rdoblue
            // 
            this.rdoblue.AutoSize = true;
            this.rdoblue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdoblue.Location = new System.Drawing.Point(28, 82);
            this.rdoblue.Name = "rdoblue";
            this.rdoblue.Size = new System.Drawing.Size(46, 17);
            this.rdoblue.TabIndex = 5;
            this.rdoblue.TabStop = true;
            this.rdoblue.Text = "Blue";
            this.rdoblue.UseVisualStyleBackColor = true;
            this.rdoblue.CheckedChanged += new System.EventHandler(this.rdoblue_CheckedChanged);
            // 
            // rdogreen
            // 
            this.rdogreen.AutoSize = true;
            this.rdogreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdogreen.Location = new System.Drawing.Point(28, 58);
            this.rdogreen.Name = "rdogreen";
            this.rdogreen.Size = new System.Drawing.Size(54, 17);
            this.rdogreen.TabIndex = 4;
            this.rdogreen.TabStop = true;
            this.rdogreen.Text = "Green";
            this.rdogreen.UseVisualStyleBackColor = true;
            this.rdogreen.CheckedChanged += new System.EventHandler(this.rdogreen_CheckedChanged);
            // 
            // rdored
            // 
            this.rdored.AutoSize = true;
            this.rdored.ForeColor = System.Drawing.Color.Red;
            this.rdored.Location = new System.Drawing.Point(28, 34);
            this.rdored.Name = "rdored";
            this.rdored.Size = new System.Drawing.Size(45, 17);
            this.rdored.TabIndex = 3;
            this.rdored.TabStop = true;
            this.rdored.Text = "Red";
            this.rdored.UseVisualStyleBackColor = true;
            this.rdored.CheckedChanged += new System.EventHandler(this.rdored_CheckedChanged);
            this.rdored.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(161, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(181, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 144);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Style";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(54, 103);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Underline";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox2.Location = new System.Drawing.Point(54, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Italic";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(54, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Bold";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // lblmess
            // 
            this.lblmess.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblmess.Location = new System.Drawing.Point(115, 302);
            this.lblmess.Name = "lblmess";
            this.lblmess.Size = new System.Drawing.Size(102, 100);
            this.lblmess.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "&Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(254, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "&Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::Bai4.Properties.Resources.pic2;
            this.pic2.Location = new System.Drawing.Point(14, 302);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(95, 100);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 9;
            this.pic2.TabStop = false;
            this.toolTip1.SetToolTip(this.pic2, "Click me please");
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // pic1
            // 
            this.pic1.Image = global::Bai4.Properties.Resources.original;
            this.pic1.Location = new System.Drawing.Point(14, 302);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(95, 100);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            this.toolTip1.SetToolTip(this.pic1, "Click me please");
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(365, 432);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.lblmess);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Formatter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmess;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoblack;
        private System.Windows.Forms.RadioButton rdoblue;
        private System.Windows.Forms.RadioButton rdogreen;
        private System.Windows.Forms.RadioButton rdored;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblmess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pic2;
    }
}

