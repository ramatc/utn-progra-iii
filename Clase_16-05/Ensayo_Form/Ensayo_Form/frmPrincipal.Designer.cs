namespace Ensayo_Form
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
            label1 = new Label();
            numReserva = new TextBox();
            duracion = new TextBox();
            label3 = new Label();
            inicio = new TextBox();
            label2 = new Label();
            banda = new TextBox();
            label4 = new Label();
            costo = new TextBox();
            label6 = new Label();
            descuento = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            mayor = new RichTextBox();
            montoTotal = new RichTextBox();
            costoFinal = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(29, 202);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(407, 50);
            label1.TabIndex = 0;
            label1.Text = "Número de reserva (0 para terminar):";
            // 
            // numReserva
            // 
            numReserva.Location = new Point(29, 246);
            numReserva.Margin = new Padding(6);
            numReserva.Name = "numReserva";
            numReserva.Size = new Size(249, 35);
            numReserva.TabIndex = 3;
            // 
            // duracion
            // 
            duracion.Location = new Point(29, 449);
            duracion.Margin = new Padding(6);
            duracion.Name = "duracion";
            duracion.Size = new Size(249, 35);
            duracion.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(29, 412);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(279, 50);
            label3.TabIndex = 2;
            label3.Text = "Duración:";
            // 
            // inicio
            // 
            inicio.Location = new Point(29, 350);
            inicio.Margin = new Padding(6);
            inicio.Name = "inicio";
            inicio.Size = new Size(249, 35);
            inicio.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(29, 307);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(279, 50);
            label2.TabIndex = 4;
            label2.Text = "Inicio de la reserva:";
            // 
            // banda
            // 
            banda.Location = new Point(29, 554);
            banda.Margin = new Padding(6);
            banda.Name = "banda";
            banda.Size = new Size(249, 35);
            banda.TabIndex = 6;
            // 
            // label4
            // 
            label4.Location = new Point(29, 517);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(279, 50);
            label4.TabIndex = 6;
            label4.Text = "Banda:";
            // 
            // costo
            // 
            costo.Location = new Point(29, 62);
            costo.Margin = new Padding(6);
            costo.Name = "costo";
            costo.Size = new Size(249, 35);
            costo.TabIndex = 1;
            // 
            // label6
            // 
            label6.Location = new Point(29, 26);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(249, 50);
            label6.TabIndex = 8;
            label6.Text = "Costo por hora:";
            // 
            // descuento
            // 
            descuento.Location = new Point(320, 62);
            descuento.Margin = new Padding(6);
            descuento.Name = "descuento";
            descuento.Size = new Size(249, 35);
            descuento.TabIndex = 2;
            // 
            // label5
            // 
            label5.Location = new Point(320, 26);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(249, 50);
            label5.TabIndex = 10;
            label5.Text = "Descuento:";
            // 
            // button1
            // 
            button1.Location = new Point(631, 26);
            button1.Name = "button1";
            button1.Size = new Size(287, 99);
            button1.TabIndex = 11;
            button1.Text = "Fijar costo y descuento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Location = new Point(320, 269);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(279, 50);
            label7.TabIndex = 13;
            label7.Text = "Mayor monto:";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.Location = new Point(320, 570);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(279, 50);
            label8.TabIndex = 15;
            label8.Text = "Monto total:";
            label8.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(29, 656);
            button2.Name = "button2";
            button2.Size = new Size(287, 99);
            button2.TabIndex = 16;
            button2.Text = "Enviar reserva";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // mayor
            // 
            mayor.Location = new Point(320, 322);
            mayor.Name = "mayor";
            mayor.ReadOnly = true;
            mayor.Size = new Size(494, 218);
            mayor.TabIndex = 17;
            mayor.Text = "";
            mayor.Visible = false;
            // 
            // montoTotal
            // 
            montoTotal.Location = new Point(320, 622);
            montoTotal.Name = "montoTotal";
            montoTotal.ReadOnly = true;
            montoTotal.Size = new Size(494, 218);
            montoTotal.TabIndex = 18;
            montoTotal.Text = "";
            montoTotal.Visible = false;
            // 
            // costoFinal
            // 
            costoFinal.Location = new Point(37, 827);
            costoFinal.Margin = new Padding(6);
            costoFinal.Name = "costoFinal";
            costoFinal.ReadOnly = true;
            costoFinal.Size = new Size(249, 35);
            costoFinal.TabIndex = 19;
            // 
            // label9
            // 
            label9.Location = new Point(37, 790);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(279, 50);
            label9.TabIndex = 20;
            label9.Text = "Costo:";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1317, 900);
            Controls.Add(costoFinal);
            Controls.Add(label9);
            Controls.Add(montoTotal);
            Controls.Add(mayor);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(descuento);
            Controls.Add(label5);
            Controls.Add(costo);
            Controls.Add(label6);
            Controls.Add(banda);
            Controls.Add(label4);
            Controls.Add(inicio);
            Controls.Add(label2);
            Controls.Add(duracion);
            Controls.Add(label3);
            Controls.Add(numReserva);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "frmPrincipal";
            Text = "Form1";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numReserva;
        private TextBox duracion;
        private Label label3;
        private TextBox inicio;
        private Label label2;
        private TextBox banda;
        private Label label4;
        private TextBox costo;
        private Label label6;
        private TextBox descuento;
        private Label label5;
        private Button button1;
        private Label label7;
        private Label label8;
        private Button button2;
        private RichTextBox mayor;
        private RichTextBox montoTotal;
        private TextBox costoFinal;
        private Label label9;
    }
}