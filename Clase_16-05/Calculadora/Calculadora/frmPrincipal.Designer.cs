namespace Calculadora
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultado = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            suma = new Button();
            resta = new Button();
            multiplicacion = new Button();
            button13 = new Button();
            igual = new Button();
            division = new Button();
            SuspendLayout();
            // 
            // resultado
            // 
            resultado.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            resultado.Location = new Point(324, 80);
            resultado.Name = "resultado";
            resultado.RightToLeft = RightToLeft.Yes;
            resultado.Size = new Size(458, 61);
            resultado.TabIndex = 0;
            resultado.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(324, 159);
            button1.Name = "button1";
            button1.Size = new Size(109, 105);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(443, 159);
            button2.Name = "button2";
            button2.Size = new Size(109, 105);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(558, 159);
            button3.Name = "button3";
            button3.Size = new Size(109, 105);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(324, 270);
            button4.Name = "button4";
            button4.Size = new Size(109, 105);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(443, 270);
            button5.Name = "button5";
            button5.Size = new Size(109, 105);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(558, 270);
            button6.Name = "button6";
            button6.Size = new Size(109, 105);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(324, 381);
            button7.Name = "button7";
            button7.Size = new Size(109, 105);
            button7.TabIndex = 7;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(443, 381);
            button8.Name = "button8";
            button8.Size = new Size(109, 105);
            button8.TabIndex = 8;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(558, 381);
            button9.Name = "button9";
            button9.Size = new Size(109, 105);
            button9.TabIndex = 9;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // suma
            // 
            suma.BackColor = Color.DarkOrange;
            suma.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            suma.ForeColor = Color.White;
            suma.Location = new Point(673, 159);
            suma.Name = "suma";
            suma.Size = new Size(109, 105);
            suma.TabIndex = 10;
            suma.Text = "+";
            suma.UseVisualStyleBackColor = false;
            suma.Click += suma_Click;
            // 
            // resta
            // 
            resta.BackColor = Color.DarkOrange;
            resta.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            resta.ForeColor = Color.White;
            resta.Location = new Point(673, 270);
            resta.Name = "resta";
            resta.Size = new Size(109, 105);
            resta.TabIndex = 11;
            resta.Text = "-";
            resta.UseVisualStyleBackColor = false;
            resta.Click += resta_Click;
            // 
            // multiplicacion
            // 
            multiplicacion.BackColor = Color.DarkOrange;
            multiplicacion.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            multiplicacion.ForeColor = Color.White;
            multiplicacion.Location = new Point(673, 381);
            multiplicacion.Name = "multiplicacion";
            multiplicacion.Size = new Size(109, 105);
            multiplicacion.TabIndex = 12;
            multiplicacion.Text = "*";
            multiplicacion.UseVisualStyleBackColor = false;
            multiplicacion.Click += multiplicacion_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(324, 492);
            button13.Name = "button13";
            button13.Size = new Size(109, 105);
            button13.TabIndex = 13;
            button13.Text = "0";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // igual
            // 
            igual.BackColor = SystemColors.Highlight;
            igual.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            igual.ForeColor = Color.White;
            igual.Location = new Point(443, 492);
            igual.Name = "igual";
            igual.Size = new Size(224, 105);
            igual.TabIndex = 14;
            igual.Text = "=";
            igual.UseVisualStyleBackColor = false;
            igual.Click += igual_Click;
            // 
            // division
            // 
            division.BackColor = Color.DarkOrange;
            division.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            division.ForeColor = Color.White;
            division.Location = new Point(673, 492);
            division.Name = "division";
            division.Size = new Size(109, 105);
            division.TabIndex = 15;
            division.Text = "/";
            division.UseVisualStyleBackColor = false;
            division.Click += division_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1086, 699);
            Controls.Add(division);
            Controls.Add(igual);
            Controls.Add(button13);
            Controls.Add(multiplicacion);
            Controls.Add(resta);
            Controls.Add(suma);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(resultado);
            Name = "frmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox resultado;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button suma;
        private Button resta;
        private Button multiplicacion;
        private Button button13;
        private Button igual;
        private Button division;
    }
}