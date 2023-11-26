namespace G16_Juegos
{
    partial class FrmDatos
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatos));
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            dgvDatos = new DataGridView();
            erpError = new ErrorProvider(components);
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            panel1 = new Panel();
            Salir = new Button();
            button3 = new Button();
            tlsGuardar = new Button();
            panel2 = new Panel();
            tslRegistrar = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(198, 90);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre :";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(286, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 4;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = Color.Black;
            dgvDatos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.Location = new Point(187, 184);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(333, 172);
            dgvDatos.TabIndex = 8;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.FromArgb(0, 192, 0);
            radioButton1.Location = new Point(286, 132);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 20);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ganado";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.Red;
            radioButton2.Location = new Point(385, 132);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 20);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perdido";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(390, 380);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 13;
            label1.Text = "G16_Valor_Total";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 0, 20);
            panel1.Controls.Add(Salir);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(tlsGuardar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tslRegistrar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 424);
            panel1.TabIndex = 14;
            // 
            // Salir
            // 
            Salir.FlatAppearance.BorderSize = 0;
            Salir.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            Salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            Salir.FlatStyle = FlatStyle.Flat;
            Salir.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Salir.ForeColor = SystemColors.ButtonHighlight;
            Salir.Location = new Point(0, 311);
            Salir.Name = "Salir";
            Salir.Size = new Size(121, 45);
            Salir.TabIndex = 5;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(0, 239);
            button3.Name = "button3";
            button3.Size = new Size(121, 45);
            button3.TabIndex = 4;
            button3.Text = "Ayuda";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tlsGuardar
            // 
            tlsGuardar.FlatAppearance.BorderSize = 0;
            tlsGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            tlsGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            tlsGuardar.FlatStyle = FlatStyle.Flat;
            tlsGuardar.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tlsGuardar.ForeColor = SystemColors.ButtonHighlight;
            tlsGuardar.Location = new Point(0, 186);
            tlsGuardar.Name = "tlsGuardar";
            tlsGuardar.Size = new Size(121, 45);
            tlsGuardar.TabIndex = 3;
            tlsGuardar.Text = "Guardar";
            tlsGuardar.UseVisualStyleBackColor = true;
            tlsGuardar.Click += tlsGuardar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(124, 131);
            panel2.TabIndex = 2;
            // 
            // tslRegistrar
            // 
            tslRegistrar.FlatAppearance.BorderSize = 0;
            tslRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            tslRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            tslRegistrar.FlatStyle = FlatStyle.Flat;
            tslRegistrar.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tslRegistrar.ForeColor = SystemColors.ButtonHighlight;
            tslRegistrar.Location = new Point(0, 137);
            tslRegistrar.Name = "tslRegistrar";
            tslRegistrar.Size = new Size(121, 45);
            tslRegistrar.TabIndex = 0;
            tslRegistrar.Text = "Registrar";
            tslRegistrar.UseVisualStyleBackColor = true;
            tslRegistrar.Click += tslRegistrar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(171, 129);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 15;
            label4.Text = "Resultado :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(176, 24);
            label5.Name = "label5";
            label5.Size = new Size(303, 35);
            label5.TabIndex = 16;
            label5.Text = "Registro De Juegos";
            // 
            // FrmDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(550, 423);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dgvDatos);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmDatos";
            Text = "Registro de Puntaje de Juegos";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private DataGridView dgvDatos;
        private ErrorProvider erpError;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button tslRegistrar;
        private Button Salir;
        private Button button3;
        private Button tlsGuardar;
        private Label label5;
        private Label label4;
    }
}