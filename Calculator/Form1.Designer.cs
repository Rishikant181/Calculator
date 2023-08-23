namespace Calculator
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
            this.erase = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.bsp = new System.Windows.Forms.Button();
            this.rt = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.divi = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dfltclr = new System.Windows.Forms.Button();
            this.frclr = new System.Windows.Forms.Button();
            this.bckclr = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // erase
            // 
            this.erase.BackColor = System.Drawing.SystemColors.GrayText;
            this.erase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.erase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.erase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erase.Location = new System.Drawing.Point(119, 284);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(45, 45);
            this.erase.TabIndex = 45;
            this.erase.Text = "C";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.GrayText;
            this.point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(16, 284);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(45, 45);
            this.point.TabIndex = 44;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // bsp
            // 
            this.bsp.BackColor = System.Drawing.SystemColors.GrayText;
            this.bsp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsp.Location = new System.Drawing.Point(239, 25);
            this.bsp.Name = "bsp";
            this.bsp.Size = new System.Drawing.Size(56, 24);
            this.bsp.TabIndex = 43;
            this.bsp.Text = "<<";
            this.bsp.UseVisualStyleBackColor = true;
            this.bsp.Click += new System.EventHandler(this.bsp_Click);
            // 
            // rt
            // 
            this.rt.BackColor = System.Drawing.SystemColors.GrayText;
            this.rt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt.Location = new System.Drawing.Point(250, 233);
            this.rt.Name = "rt";
            this.rt.Size = new System.Drawing.Size(45, 45);
            this.rt.TabIndex = 42;
            this.rt.Text = "|";
            this.rt.UseVisualStyleBackColor = true;
            this.rt.Click += new System.EventHandler(this.rt_Click);
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.SystemColors.GrayText;
            this.power.Cursor = System.Windows.Forms.Cursors.Hand;
            this.power.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(199, 233);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(45, 45);
            this.power.TabIndex = 41;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // divi
            // 
            this.divi.BackColor = System.Drawing.SystemColors.GrayText;
            this.divi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.divi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divi.Location = new System.Drawing.Point(250, 182);
            this.divi.Name = "divi";
            this.divi.Size = new System.Drawing.Size(45, 45);
            this.divi.TabIndex = 40;
            this.divi.Text = "/";
            this.divi.UseVisualStyleBackColor = true;
            this.divi.Click += new System.EventHandler(this.divi_Click);
            // 
            // multi
            // 
            this.multi.BackColor = System.Drawing.SystemColors.GrayText;
            this.multi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.Location = new System.Drawing.Point(199, 182);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(45, 45);
            this.multi.TabIndex = 39;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.GrayText;
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(199, 128);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(45, 45);
            this.plus.TabIndex = 38;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.GrayText;
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(250, 128);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(45, 45);
            this.minus.TabIndex = 37;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.GrayText;
            this.num0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(67, 284);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(45, 45);
            this.num0.TabIndex = 36;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.GrayText;
            this.num9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(118, 128);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(45, 45);
            this.num9.TabIndex = 35;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.GrayText;
            this.num8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(67, 128);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(45, 45);
            this.num8.TabIndex = 34;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.GrayText;
            this.num7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(16, 128);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(45, 45);
            this.num7.TabIndex = 33;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.GrayText;
            this.num6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(118, 182);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(45, 45);
            this.num6.TabIndex = 32;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.GrayText;
            this.num5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(67, 182);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(45, 45);
            this.num5.TabIndex = 31;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.GrayText;
            this.num4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(16, 182);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(45, 45);
            this.num4.TabIndex = 30;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.GrayText;
            this.num3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(119, 233);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(45, 45);
            this.num3.TabIndex = 29;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.GrayText;
            this.num2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(67, 233);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(45, 45);
            this.num2.TabIndex = 28;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.GrayText;
            this.num1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(16, 233);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(45, 45);
            this.num1.TabIndex = 27;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(15, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 29);
            this.textBox2.TabIndex = 26;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 24);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dfltclr);
            this.groupBox1.Controls.Add(this.frclr);
            this.groupBox1.Controls.Add(this.bckclr);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(316, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 304);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options >>";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(31, 195);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(92, 28);
            this.save.TabIndex = 5;
            this.save.Text = "Save Config";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rishikant Sahu\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programmer :";
            // 
            // dfltclr
            // 
            this.dfltclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfltclr.ForeColor = System.Drawing.Color.Black;
            this.dfltclr.Location = new System.Drawing.Point(12, 134);
            this.dfltclr.Name = "dfltclr";
            this.dfltclr.Size = new System.Drawing.Size(132, 27);
            this.dfltclr.TabIndex = 2;
            this.dfltclr.Text = "Default";
            this.dfltclr.UseVisualStyleBackColor = true;
            this.dfltclr.Click += new System.EventHandler(this.dfltclr_Click);
            // 
            // frclr
            // 
            this.frclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frclr.ForeColor = System.Drawing.Color.Black;
            this.frclr.Location = new System.Drawing.Point(12, 94);
            this.frclr.Name = "frclr";
            this.frclr.Size = new System.Drawing.Size(132, 34);
            this.frclr.TabIndex = 1;
            this.frclr.Text = "Foreground Color";
            this.frclr.UseVisualStyleBackColor = true;
            this.frclr.Click += new System.EventHandler(this.frclr_Click);
            // 
            // bckclr
            // 
            this.bckclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckclr.ForeColor = System.Drawing.Color.Black;
            this.bckclr.Location = new System.Drawing.Point(12, 49);
            this.bckclr.Name = "bckclr";
            this.bckclr.Size = new System.Drawing.Size(132, 39);
            this.bckclr.TabIndex = 0;
            this.bckclr.Text = "Background Color";
            this.bckclr.UseVisualStyleBackColor = true;
            this.bckclr.Click += new System.EventHandler(this.bckclr_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton = this.bsp;
            this.ClientSize = new System.Drawing.Size(494, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.point);
            this.Controls.Add(this.bsp);
            this.Controls.Add(this.rt);
            this.Controls.Add(this.power);
            this.Controls.Add(this.divi);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 393);
            this.MinimumSize = new System.Drawing.Size(500, 393);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button bsp;
        private System.Windows.Forms.Button rt;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button divi;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dfltclr;
        private System.Windows.Forms.Button frclr;
        private System.Windows.Forms.Button bckclr;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

