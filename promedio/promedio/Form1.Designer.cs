namespace promedio
{
    partial class Form1
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
            txtAlumno = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblNombre = new Label();
            lblControl = new Label();
            lblGuia = new Label();
            lblParcial = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(126, 51);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new Size(289, 23);
            txtAlumno.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(148, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 23);
            textBox4.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(7, 54);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "NOMBRE ALUMNO:";
            // 
            // lblControl
            // 
            lblControl.AutoSize = true;
            lblControl.Location = new Point(7, 195);
            lblControl.Name = "lblControl";
            lblControl.Size = new Size(135, 15);
            lblControl.TabIndex = 5;
            lblControl.Text = "CONTROL DE LECTURA:";
            // 
            // lblGuia
            // 
            lblGuia.AutoSize = true;
            lblGuia.Location = new Point(83, 153);
            lblGuia.Name = "lblGuia";
            lblGuia.Size = new Size(37, 15);
            lblGuia.TabIndex = 6;
            lblGuia.Text = "GUIA:";
            // 
            // lblParcial
            // 
            lblParcial.AutoSize = true;
            lblParcial.Location = new Point(64, 103);
            lblParcial.Name = "lblParcial";
            lblParcial.Size = new Size(56, 15);
            lblParcial.TabIndex = 7;
            lblParcial.Text = "PARCIAL:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 69);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 8;
            label5.Text = " PORCENTAJES:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(524, 103);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 9;
            label6.Text = "60%";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(496, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(496, 195);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(169, 261);
            button1.Name = "button1";
            button1.Size = new Size(181, 41);
            button1.TabIndex = 12;
            button1.Text = "CALCULAR PROMEDIO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(483, 235);
            button2.Name = "button2";
            button2.Size = new Size(144, 30);
            button2.TabIndex = 13;
            button2.Text = "CONTACTO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(186, 305);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 343);
            Controls.Add(lblResultado);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblParcial);
            Controls.Add(lblGuia);
            Controls.Add(lblControl);
            Controls.Add(lblNombre);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtAlumno);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAlumno;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblNombre;
        private Label lblControl;
        private Label lblGuia;
        private Label lblParcial;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Label lblResultado;
    }
}
