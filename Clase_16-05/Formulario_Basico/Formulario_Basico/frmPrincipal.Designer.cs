namespace Formulario_Basico
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            salidaFinal = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnPromedio = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(41, 26);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(185, 23);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(290, 26);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(185, 23);
            txtNum2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Número 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 9);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Número 2:";
            // 
            // salidaFinal
            // 
            salidaFinal.BorderStyle = BorderStyle.FixedSingle;
            salidaFinal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            salidaFinal.Location = new Point(29, 271);
            salidaFinal.Name = "salidaFinal";
            salidaFinal.Size = new Size(446, 47);
            salidaFinal.TabIndex = 4;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(50, 92);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(104, 50);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "Sumar";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(190, 92);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(104, 50);
            btnResta.TabIndex = 6;
            btnResta.Text = "Restar";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(338, 92);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(104, 50);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(115, 166);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(104, 50);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(260, 166);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(104, 50);
            btnPromedio.TabIndex = 9;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(514, 362);
            Controls.Add(btnPromedio);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(salidaFinal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "frmPrincipal";
            Text = "Form1";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label label1;
        private Label label2;
        private Label salidaFinal;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnPromedio;
    }
}