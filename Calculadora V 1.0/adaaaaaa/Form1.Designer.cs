﻿namespace Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Resultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Resultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Resultado.Location = new System.Drawing.Point(7, 9);
            this.Resultado.MaximumSize = new System.Drawing.Size(260, 110);
            this.Resultado.MinimumSize = new System.Drawing.Size(265, 110);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(265, 110);
            this.Resultado.TabIndex = 0;
            this.Resultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.somar);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Cose);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Seno);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(115, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "Tg";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Tange);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(217, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "√";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Raiz);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(166, 232);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.subtrair);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(217, 232);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "x^y";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Pot);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(166, 283);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "*";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.multiplicar);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(166, 336);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 9;
            this.button9.Text = "/";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.dividir);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(217, 183);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(45, 45);
            this.button10.TabIndex = 10;
            this.button10.Text = "%";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Porce);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.button11.Location = new System.Drawing.Point(217, 283);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(45, 45);
            this.button11.TabIndex = 11;
            this.button11.Text = "Resto";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.resto);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(217, 336);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(45, 96);
            this.button12.TabIndex = 12;
            this.button12.Text = "=";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.calcular);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 336);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(147, 45);
            this.button13.TabIndex = 13;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.digito);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(115, 183);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(45, 45);
            this.button15.TabIndex = 15;
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.digito);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(63, 183);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(45, 45);
            this.button16.TabIndex = 16;
            this.button16.Text = "8";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.digito);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(12, 183);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(45, 45);
            this.button17.TabIndex = 17;
            this.button17.Text = "7";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.digito);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(115, 234);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(45, 45);
            this.button18.TabIndex = 18;
            this.button18.Text = "6";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.digito);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(64, 234);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(45, 45);
            this.button19.TabIndex = 19;
            this.button19.Text = "5";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.digito);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(13, 234);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(45, 45);
            this.button20.TabIndex = 20;
            this.button20.Text = "4";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.digito);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(115, 285);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(45, 45);
            this.button21.TabIndex = 21;
            this.button21.Text = "3";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.digito);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(64, 285);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(45, 45);
            this.button22.TabIndex = 22;
            this.button22.Text = "2";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.digito);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(13, 285);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(45, 45);
            this.button23.TabIndex = 23;
            this.button23.Text = "1";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.digito);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(115, 132);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(45, 45);
            this.button25.TabIndex = 25;
            this.button25.Text = "C";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.Limpar);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(166, 387);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(45, 45);
            this.button14.TabIndex = 26;
            this.button14.Text = ",";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.digito);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(64, 132);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(45, 45);
            this.button24.TabIndex = 27;
            this.button24.Text = "CE";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.limparParcialmente);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(13, 132);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(45, 45);
            this.button26.TabIndex = 28;
            this.button26.Text = "← ";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.LimparSeta);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.button27.Location = new System.Drawing.Point(166, 132);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(45, 45);
            this.button27.TabIndex = 29;
            this.button27.Text = "||||||||||";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.easteregg);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 444);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Daniel C e Thaís - 2003";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;

    }
}
