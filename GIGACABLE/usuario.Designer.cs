namespace GIGACABLE
{
    partial class usuario
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
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.textBox5 = new System.Windows.Forms.TextBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.label6 = new System.Windows.Forms.Label();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.comboBox2 = new System.Windows.Forms.ComboBox();
        	this.fechaLabel = new System.Windows.Forms.Label();
        	this.comboBox3 = new System.Windows.Forms.ComboBox();
        	this.comboBox4 = new System.Windows.Forms.ComboBox();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(115, 82);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(68, 15);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "No. Cliente";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(115, 126);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(49, 15);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "Tecnico";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(115, 202);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(42, 15);
        	this.label4.TabIndex = 3;
        	this.label4.Text = "Status";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.Location = new System.Drawing.Point(115, 240);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(73, 15);
        	this.label5.TabIndex = 4;
        	this.label5.Text = "Descripcion";
        	// 
        	// textBox5
        	// 
        	this.textBox5.Location = new System.Drawing.Point(220, 240);
        	this.textBox5.Multiline = true;
        	this.textBox5.Name = "textBox5";
        	this.textBox5.Size = new System.Drawing.Size(236, 62);
        	this.textBox5.TabIndex = 9;
        	// 
        	// button1
        	// 
        	this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button1.Location = new System.Drawing.Point(250, 321);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(75, 23);
        	this.button1.TabIndex = 10;
        	this.button1.Text = "Generar";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1_Click);
        	// 
        	// button2
        	// 
        	this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button2.Location = new System.Drawing.Point(250, 373);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(75, 23);
        	this.button2.TabIndex = 11;
        	this.button2.Text = "Buscar";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.Button2_Click);
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.Location = new System.Drawing.Point(136, 28);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(254, 27);
        	this.label6.TabIndex = 12;
        	this.label6.Text = "Generacion de Reporte";
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Items.AddRange(new object[] {
			"Reportado",
			"En progreso",
			"Finalizado"});
        	this.comboBox1.Location = new System.Drawing.Point(220, 200);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(121, 21);
        	this.comboBox1.TabIndex = 13;
        	// 
        	// label7
        	// 
        	this.label7.Location = new System.Drawing.Point(12, 9);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(100, 23);
        	this.label7.TabIndex = 14;
        	this.label7.Text = "Usuario ";
        	this.label7.Click += new System.EventHandler(this.Label7Click);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(115, 164);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(90, 15);
        	this.label2.TabIndex = 15;
        	this.label2.Text = "Tipo de reporte";
        	this.label2.Click += new System.EventHandler(this.Label2Click);
        	// 
        	// comboBox2
        	// 
        	this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox2.FormattingEnabled = true;
        	this.comboBox2.Items.AddRange(new object[] {
			"Asistencia remota",
			"Asistencia especializada a domicilio",
			"Mantenimiento general",
			"Mantenimiento en exteriores",
			"Otro"});
        	this.comboBox2.Location = new System.Drawing.Point(220, 164);
        	this.comboBox2.Name = "comboBox2";
        	this.comboBox2.Size = new System.Drawing.Size(121, 21);
        	this.comboBox2.TabIndex = 16;
        	// 
        	// fechaLabel
        	// 
        	this.fechaLabel.Location = new System.Drawing.Point(454, 9);
        	this.fechaLabel.Name = "fechaLabel";
        	this.fechaLabel.Size = new System.Drawing.Size(100, 23);
        	this.fechaLabel.TabIndex = 17;
        	this.fechaLabel.Text = "Fecha aaaa-mm-dd";
        	// 
        	// comboBox3
        	// 
        	this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox3.FormattingEnabled = true;
        	this.comboBox3.Items.AddRange(new object[] {
			"1",
			"2"});
        	this.comboBox3.Location = new System.Drawing.Point(220, 120);
        	this.comboBox3.Name = "comboBox3";
        	this.comboBox3.Size = new System.Drawing.Size(121, 21);
        	this.comboBox3.TabIndex = 18;
        	// 
        	// comboBox4
        	// 
        	this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox4.FormattingEnabled = true;
        	this.comboBox4.Items.AddRange(new object[] {
			"1",
			"2"});
        	this.comboBox4.Location = new System.Drawing.Point(220, 76);
        	this.comboBox4.Name = "comboBox4";
        	this.comboBox4.Size = new System.Drawing.Size(121, 21);
        	this.comboBox4.TabIndex = 19;
        	// 
        	// usuario
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(566, 450);
        	this.Controls.Add(this.comboBox4);
        	this.Controls.Add(this.comboBox3);
        	this.Controls.Add(this.fechaLabel);
        	this.Controls.Add(this.comboBox2);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.comboBox1);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.textBox5);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label1);
        	this.Name = "usuario";
        	this.Text = "Usuario";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}