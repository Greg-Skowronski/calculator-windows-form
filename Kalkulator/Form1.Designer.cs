﻿namespace Kalkulator
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
            this.zero = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zero.Location = new System.Drawing.Point(12, 203);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(96, 45);
            this.zero.TabIndex = 0;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.four.Location = new System.Drawing.Point(12, 101);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(45, 45);
            this.four.TabIndex = 1;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dec.Location = new System.Drawing.Point(114, 203);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(45, 45);
            this.dec.TabIndex = 2;
            this.dec.Text = ",";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.button_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Location = new System.Drawing.Point(165, 203);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(45, 45);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operator_click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equal.Location = new System.Drawing.Point(216, 152);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(45, 96);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.button5_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.one.Location = new System.Drawing.Point(12, 152);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(45, 45);
            this.one.TabIndex = 5;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.two.Location = new System.Drawing.Point(63, 152);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(45, 45);
            this.two.TabIndex = 6;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.three.Location = new System.Drawing.Point(114, 152);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(45, 45);
            this.three.TabIndex = 7;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sub.Location = new System.Drawing.Point(165, 152);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(45, 45);
            this.sub.TabIndex = 8;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.operator_click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.five.Location = new System.Drawing.Point(63, 101);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(45, 45);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.six.Location = new System.Drawing.Point(114, 101);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(45, 45);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // times
            // 
            this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.times.Location = new System.Drawing.Point(165, 101);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(45, 45);
            this.times.TabIndex = 11;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.operator_click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(216, 101);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(45, 45);
            this.button13.TabIndex = 12;
            this.button13.Text = "C";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.Location = new System.Drawing.Point(216, 50);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(46, 45);
            this.button14.TabIndex = 13;
            this.button14.Text = "CE";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.div.Location = new System.Drawing.Point(165, 50);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(45, 45);
            this.div.TabIndex = 14;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.operator_click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nine.Location = new System.Drawing.Point(114, 50);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(45, 45);
            this.nine.TabIndex = 15;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eight.Location = new System.Drawing.Point(63, 50);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(45, 45);
            this.eight.TabIndex = 16;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seven.Location = new System.Drawing.Point(12, 50);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(45, 45);
            this.seven.TabIndex = 17;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Result.Location = new System.Drawing.Point(12, 13);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(249, 31);
            this.Result.TabIndex = 18;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.equation.Location = new System.Drawing.Point(17, 14);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 20);
            this.equation.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(274, 262);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.div);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.times);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.four);
            this.Controls.Add(this.zero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 300);
            this.MinimumSize = new System.Drawing.Size(290, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label equation;
    }
}

