namespace Bai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdosun = new System.Windows.Forms.RadioButton();
            this.rdosnow = new System.Windows.Forms.RadioButton();
            this.rdorain = new System.Windows.Forms.RadioButton();
            this.rdocloud = new System.Windows.Forms.RadioButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.picsun = new System.Windows.Forms.PictureBox();
            this.picsnow = new System.Windows.Forms.PictureBox();
            this.picrain = new System.Windows.Forms.PictureBox();
            this.piccloud = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picsun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccloud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name here";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(165, 33);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(201, 20);
            this.txtname.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdosun);
            this.groupBox1.Controls.Add(this.rdosnow);
            this.groupBox1.Controls.Add(this.rdorain);
            this.groupBox1.Controls.Add(this.rdocloud);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 171);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // rdosun
            // 
            this.rdosun.AutoSize = true;
            this.rdosun.Location = new System.Drawing.Point(32, 133);
            this.rdosun.Name = "rdosun";
            this.rdosun.Size = new System.Drawing.Size(55, 17);
            this.rdosun.TabIndex = 3;
            this.rdosun.TabStop = true;
            this.rdosun.Text = "&Sunny";
            this.rdosun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdosun.UseVisualStyleBackColor = true;
            // 
            // rdosnow
            // 
            this.rdosnow.AutoSize = true;
            this.rdosnow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdosnow.Location = new System.Drawing.Point(32, 96);
            this.rdosnow.Name = "rdosnow";
            this.rdosnow.Size = new System.Drawing.Size(57, 17);
            this.rdosnow.TabIndex = 2;
            this.rdosnow.TabStop = true;
            this.rdosnow.Text = "&Snowy";
            this.rdosnow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdosnow.UseVisualStyleBackColor = true;
            // 
            // rdorain
            // 
            this.rdorain.AutoSize = true;
            this.rdorain.ForeColor = System.Drawing.Color.Fuchsia;
            this.rdorain.Location = new System.Drawing.Point(32, 63);
            this.rdorain.Name = "rdorain";
            this.rdorain.Size = new System.Drawing.Size(52, 17);
            this.rdorain.TabIndex = 1;
            this.rdorain.TabStop = true;
            this.rdorain.Text = "&Rainy";
            this.rdorain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdorain.UseVisualStyleBackColor = true;
            // 
            // rdocloud
            // 
            this.rdocloud.AutoSize = true;
            this.rdocloud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdocloud.Location = new System.Drawing.Point(32, 30);
            this.rdocloud.Name = "rdocloud";
            this.rdocloud.Size = new System.Drawing.Size(57, 17);
            this.rdocloud.TabIndex = 0;
            this.rdocloud.TabStop = true;
            this.rdocloud.Text = "&Cloudy";
            this.rdocloud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdocloud.UseVisualStyleBackColor = true;
            this.rdocloud.CheckedChanged += new System.EventHandler(this.rdocloud_CheckedChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDisplay.Location = new System.Drawing.Point(13, 263);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(235, 122);
            this.lblDisplay.TabIndex = 3;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(273, 281);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(77, 34);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "&Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(273, 327);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(77, 34);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // picsun
            // 
            this.picsun.Image = global::Bai3.Properties.Resources.original___Copy___Copy___Copy___Copy;
            this.picsun.Location = new System.Drawing.Point(273, 180);
            this.picsun.Name = "picsun";
            this.picsun.Size = new System.Drawing.Size(69, 67);
            this.picsun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picsun.TabIndex = 9;
            this.picsun.TabStop = false;
            // 
            // picsnow
            // 
            this.picsnow.Image = global::Bai3.Properties.Resources.original___Copy___Copy___Copy;
            this.picsnow.Location = new System.Drawing.Point(179, 180);
            this.picsnow.Name = "picsnow";
            this.picsnow.Size = new System.Drawing.Size(69, 67);
            this.picsnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picsnow.TabIndex = 8;
            this.picsnow.TabStop = false;
            // 
            // picrain
            // 
            this.picrain.Image = global::Bai3.Properties.Resources.original___Copy___Copy;
            this.picrain.Location = new System.Drawing.Point(273, 89);
            this.picrain.Name = "picrain";
            this.picrain.Size = new System.Drawing.Size(69, 67);
            this.picrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picrain.TabIndex = 7;
            this.picrain.TabStop = false;
            // 
            // piccloud
            // 
            this.piccloud.Image = global::Bai3.Properties.Resources.original___Copy;
            this.piccloud.Location = new System.Drawing.Point(179, 89);
            this.piccloud.Name = "piccloud";
            this.piccloud.Size = new System.Drawing.Size(69, 67);
            this.piccloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.piccloud.TabIndex = 6;
            this.piccloud.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 394);
            this.Controls.Add(this.picsun);
            this.Controls.Add(this.picsnow);
            this.Controls.Add(this.picrain);
            this.Controls.Add(this.piccloud);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picsun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccloud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdosun;
        private System.Windows.Forms.RadioButton rdosnow;
        private System.Windows.Forms.RadioButton rdorain;
        private System.Windows.Forms.RadioButton rdocloud;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox piccloud;
        private System.Windows.Forms.PictureBox picrain;
        private System.Windows.Forms.PictureBox picsnow;
        private System.Windows.Forms.PictureBox picsun;
    }
}

