namespace sem2_exercises {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.fraction_box = new System.Windows.Forms.GroupBox();
            this.decimal_box = new System.Windows.Forms.TextBox();
            this.dec_btn = new System.Windows.Forms.RadioButton();
            this.frac6 = new System.Windows.Forms.TextBox();
            this.frac5 = new System.Windows.Forms.TextBox();
            this.operator_label2 = new System.Windows.Forms.Label();
            this.fraction_submit = new System.Windows.Forms.Button();
            this.frac4 = new System.Windows.Forms.TextBox();
            this.frac3 = new System.Windows.Forms.TextBox();
            this.operator_label1 = new System.Windows.Forms.Label();
            this.frac2 = new System.Windows.Forms.TextBox();
            this.frac1 = new System.Windows.Forms.TextBox();
            this.simplify_btn = new System.Windows.Forms.RadioButton();
            this.multiply_btn = new System.Windows.Forms.RadioButton();
            this.add_btn = new System.Windows.Forms.RadioButton();
            this.gcd_box = new System.Windows.Forms.GroupBox();
            this.gcd_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gcd_is = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gcd2 = new System.Windows.Forms.TextBox();
            this.gcd1 = new System.Windows.Forms.TextBox();
            this.gcd_btn = new System.Windows.Forms.RadioButton();
            this.fraction_btn = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fraction_box.SuspendLayout();
            this.gcd_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "How May I Help You?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Powered By: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(572, 300);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LundyTech";
            // 
            // fraction_box
            // 
            this.fraction_box.Controls.Add(this.decimal_box);
            this.fraction_box.Controls.Add(this.dec_btn);
            this.fraction_box.Controls.Add(this.frac6);
            this.fraction_box.Controls.Add(this.frac5);
            this.fraction_box.Controls.Add(this.operator_label2);
            this.fraction_box.Controls.Add(this.fraction_submit);
            this.fraction_box.Controls.Add(this.frac4);
            this.fraction_box.Controls.Add(this.frac3);
            this.fraction_box.Controls.Add(this.operator_label1);
            this.fraction_box.Controls.Add(this.frac2);
            this.fraction_box.Controls.Add(this.frac1);
            this.fraction_box.Controls.Add(this.simplify_btn);
            this.fraction_box.Controls.Add(this.multiply_btn);
            this.fraction_box.Controls.Add(this.add_btn);
            this.fraction_box.Enabled = false;
            this.fraction_box.Location = new System.Drawing.Point(337, 134);
            this.fraction_box.Name = "fraction_box";
            this.fraction_box.Size = new System.Drawing.Size(299, 141);
            this.fraction_box.TabIndex = 5;
            this.fraction_box.TabStop = false;
            this.fraction_box.Text = "Fraction Converter";
            // 
            // decimal_box
            // 
            this.decimal_box.Location = new System.Drawing.Point(154, 36);
            this.decimal_box.Name = "decimal_box";
            this.decimal_box.Size = new System.Drawing.Size(40, 20);
            this.decimal_box.TabIndex = 13;
            this.decimal_box.WordWrap = false;
            // 
            // dec_btn
            // 
            this.dec_btn.AutoSize = true;
            this.dec_btn.Location = new System.Drawing.Point(16, 85);
            this.dec_btn.Name = "dec_btn";
            this.dec_btn.Size = new System.Drawing.Size(63, 17);
            this.dec_btn.TabIndex = 12;
            this.dec_btn.TabStop = true;
            this.dec_btn.Text = "Decimal";
            this.dec_btn.UseVisualStyleBackColor = true;
            this.dec_btn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // frac6
            // 
            this.frac6.Location = new System.Drawing.Point(219, 46);
            this.frac6.Name = "frac6";
            this.frac6.Size = new System.Drawing.Size(40, 20);
            this.frac6.TabIndex = 11;
            this.frac6.WordWrap = false;
            // 
            // frac5
            // 
            this.frac5.Location = new System.Drawing.Point(219, 20);
            this.frac5.Name = "frac5";
            this.frac5.Size = new System.Drawing.Size(40, 20);
            this.frac5.TabIndex = 10;
            this.frac5.WordWrap = false;
            // 
            // operator_label2
            // 
            this.operator_label2.AutoSize = true;
            this.operator_label2.Location = new System.Drawing.Point(200, 39);
            this.operator_label2.Name = "operator_label2";
            this.operator_label2.Size = new System.Drawing.Size(13, 13);
            this.operator_label2.TabIndex = 9;
            this.operator_label2.Text = "=";
            this.operator_label2.Visible = false;
            // 
            // fraction_submit
            // 
            this.fraction_submit.Location = new System.Drawing.Point(106, 85);
            this.fraction_submit.Name = "fraction_submit";
            this.fraction_submit.Size = new System.Drawing.Size(85, 23);
            this.fraction_submit.TabIndex = 8;
            this.fraction_submit.Text = "Submit";
            this.fraction_submit.UseVisualStyleBackColor = true;
            this.fraction_submit.Click += new System.EventHandler(this.fraction_submit_Click);
            // 
            // frac4
            // 
            this.frac4.Location = new System.Drawing.Point(154, 46);
            this.frac4.Name = "frac4";
            this.frac4.Size = new System.Drawing.Size(40, 20);
            this.frac4.TabIndex = 7;
            // 
            // frac3
            // 
            this.frac3.Location = new System.Drawing.Point(154, 20);
            this.frac3.Name = "frac3";
            this.frac3.Size = new System.Drawing.Size(40, 20);
            this.frac3.TabIndex = 6;
            this.frac3.WordWrap = false;
            // 
            // operator_label1
            // 
            this.operator_label1.AutoSize = true;
            this.operator_label1.Location = new System.Drawing.Point(135, 38);
            this.operator_label1.Name = "operator_label1";
            this.operator_label1.Size = new System.Drawing.Size(13, 13);
            this.operator_label1.TabIndex = 5;
            this.operator_label1.Text = "?";
            this.operator_label1.Visible = false;
            // 
            // frac2
            // 
            this.frac2.Location = new System.Drawing.Point(89, 46);
            this.frac2.Name = "frac2";
            this.frac2.Size = new System.Drawing.Size(40, 20);
            this.frac2.TabIndex = 4;
            // 
            // frac1
            // 
            this.frac1.Location = new System.Drawing.Point(89, 20);
            this.frac1.Name = "frac1";
            this.frac1.Size = new System.Drawing.Size(40, 20);
            this.frac1.TabIndex = 3;
            // 
            // simplify_btn
            // 
            this.simplify_btn.AutoSize = true;
            this.simplify_btn.Location = new System.Drawing.Point(16, 19);
            this.simplify_btn.Name = "simplify_btn";
            this.simplify_btn.Size = new System.Drawing.Size(60, 17);
            this.simplify_btn.TabIndex = 2;
            this.simplify_btn.TabStop = true;
            this.simplify_btn.Text = "Simplify";
            this.simplify_btn.UseVisualStyleBackColor = true;
            this.simplify_btn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // multiply_btn
            // 
            this.multiply_btn.AutoSize = true;
            this.multiply_btn.Location = new System.Drawing.Point(16, 60);
            this.multiply_btn.Name = "multiply_btn";
            this.multiply_btn.Size = new System.Drawing.Size(60, 17);
            this.multiply_btn.TabIndex = 1;
            this.multiply_btn.TabStop = true;
            this.multiply_btn.Text = "Multiply";
            this.multiply_btn.UseVisualStyleBackColor = true;
            this.multiply_btn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // add_btn
            // 
            this.add_btn.AutoSize = true;
            this.add_btn.Location = new System.Drawing.Point(16, 38);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(44, 17);
            this.add_btn.TabIndex = 0;
            this.add_btn.TabStop = true;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // gcd_box
            // 
            this.gcd_box.Controls.Add(this.gcd_label);
            this.gcd_box.Controls.Add(this.button1);
            this.gcd_box.Controls.Add(this.gcd_is);
            this.gcd_box.Controls.Add(this.label5);
            this.gcd_box.Controls.Add(this.label4);
            this.gcd_box.Controls.Add(this.label3);
            this.gcd_box.Controls.Add(this.gcd2);
            this.gcd_box.Controls.Add(this.gcd1);
            this.gcd_box.Location = new System.Drawing.Point(19, 134);
            this.gcd_box.Name = "gcd_box";
            this.gcd_box.Size = new System.Drawing.Size(297, 114);
            this.gcd_box.TabIndex = 6;
            this.gcd_box.TabStop = false;
            this.gcd_box.Text = "Find GCD";
            // 
            // gcd_label
            // 
            this.gcd_label.AutoSize = true;
            this.gcd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcd_label.ForeColor = System.Drawing.Color.Maroon;
            this.gcd_label.Location = new System.Drawing.Point(144, 78);
            this.gcd_label.Name = "gcd_label";
            this.gcd_label.Size = new System.Drawing.Size(21, 20);
            this.gcd_label.TabIndex = 7;
            this.gcd_label.Text = "X";
            this.gcd_label.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gcd_is
            // 
            this.gcd_is.AutoSize = true;
            this.gcd_is.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcd_is.ForeColor = System.Drawing.Color.Black;
            this.gcd_is.Location = new System.Drawing.Point(64, 78);
            this.gcd_is.Name = "gcd_is";
            this.gcd_is.Size = new System.Drawing.Size(85, 20);
            this.gcd_is.TabIndex = 5;
            this.gcd_is.Text = "** GCD IS:";
            this.gcd_is.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = ")";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = ",";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "GCD (";
            // 
            // gcd2
            // 
            this.gcd2.Location = new System.Drawing.Point(119, 34);
            this.gcd2.Name = "gcd2";
            this.gcd2.Size = new System.Drawing.Size(42, 20);
            this.gcd2.TabIndex = 1;
            this.gcd2.Text = "1469";
            // 
            // gcd1
            // 
            this.gcd1.Location = new System.Drawing.Point(54, 35);
            this.gcd1.Name = "gcd1";
            this.gcd1.Size = new System.Drawing.Size(42, 20);
            this.gcd1.TabIndex = 0;
            this.gcd1.Text = "87801";
            // 
            // gcd_btn
            // 
            this.gcd_btn.AutoSize = true;
            this.gcd_btn.Location = new System.Drawing.Point(67, 111);
            this.gcd_btn.Name = "gcd_btn";
            this.gcd_btn.Size = new System.Drawing.Size(144, 17);
            this.gcd_btn.TabIndex = 1;
            this.gcd_btn.TabStop = true;
            this.gcd_btn.Text = "Greatest Common Divisor";
            this.gcd_btn.UseVisualStyleBackColor = true;
            this.gcd_btn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fraction_btn
            // 
            this.fraction_btn.AutoSize = true;
            this.fraction_btn.Location = new System.Drawing.Point(426, 111);
            this.fraction_btn.Name = "fraction_btn";
            this.fraction_btn.Size = new System.Drawing.Size(112, 17);
            this.fraction_btn.TabIndex = 8;
            this.fraction_btn.TabStop = true;
            this.fraction_btn.Text = "Fraction Converter";
            this.fraction_btn.UseVisualStyleBackColor = true;
            this.fraction_btn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sem2_exercises.Properties.Resources.fraction;
            this.pictureBox3.Location = new System.Drawing.Point(559, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sem2_exercises.Properties.Resources.purp;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(647, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sem2_exercises.Properties.Resources.purp;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(641, 343);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fraction_btn);
            this.Controls.Add(this.gcd_btn);
            this.Controls.Add(this.gcd_box);
            this.Controls.Add(this.fraction_box);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sem2_EX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fraction_box.ResumeLayout(false);
            this.fraction_box.PerformLayout();
            this.gcd_box.ResumeLayout(false);
            this.gcd_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox fraction_box;
        private System.Windows.Forms.GroupBox gcd_box;
        private System.Windows.Forms.RadioButton gcd_btn;
        private System.Windows.Forms.RadioButton fraction_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gcd2;
        private System.Windows.Forms.TextBox gcd1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label gcd_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label gcd_is;
        private System.Windows.Forms.RadioButton simplify_btn;
        private System.Windows.Forms.RadioButton multiply_btn;
        private System.Windows.Forms.RadioButton add_btn;
        private System.Windows.Forms.TextBox frac3;
        private System.Windows.Forms.Label operator_label1;
        private System.Windows.Forms.TextBox frac2;
        private System.Windows.Forms.TextBox frac1;
        private System.Windows.Forms.Label operator_label2;
        private System.Windows.Forms.Button fraction_submit;
        private System.Windows.Forms.TextBox frac4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox frac6;
        private System.Windows.Forms.TextBox frac5;
        private System.Windows.Forms.RadioButton dec_btn;
        private System.Windows.Forms.TextBox decimal_box;
    }
}

