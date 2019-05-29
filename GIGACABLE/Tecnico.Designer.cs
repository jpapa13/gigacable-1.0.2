namespace GIGACABLE
{
    partial class Tecnico
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
        	this.button1 = new System.Windows.Forms.Button();
        	this.label9 = new System.Windows.Forms.Label();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.actualizarButton = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(27, 324);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(75, 23);
        	this.button1.TabIndex = 41;
        	this.button1.Text = "Detalle";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1_Click);
        	// 
        	// label9
        	// 
        	this.label9.AutoSize = true;
        	this.label9.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label9.Location = new System.Drawing.Point(27, 9);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(197, 27);
        	this.label9.TabIndex = 42;
        	this.label9.Text = "Lista de Reportes";
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.AllowUserToAddRows = false;
        	this.dataGridView1.AllowUserToDeleteRows = false;
        	this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        	this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Location = new System.Drawing.Point(27, 109);
        	this.dataGridView1.MultiSelect = false;
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.ReadOnly = true;
        	this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        	this.dataGridView1.Size = new System.Drawing.Size(848, 238);
        	this.dataGridView1.TabIndex = 43;
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Items.AddRange(new object[] {
			"Reportado",
			"En progreso",
			"Finalizado"});
        	this.comboBox1.Location = new System.Drawing.Point(27, 57);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(121, 21);
        	this.comboBox1.TabIndex = 44;
        	this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
        	// 
        	// actualizarButton
        	// 
        	this.actualizarButton.Location = new System.Drawing.Point(197, 55);
        	this.actualizarButton.Name = "actualizarButton";
        	this.actualizarButton.Size = new System.Drawing.Size(75, 23);
        	this.actualizarButton.TabIndex = 45;
        	this.actualizarButton.Text = "Actualizar";
        	this.actualizarButton.UseVisualStyleBackColor = true;
        	this.actualizarButton.Click += new System.EventHandler(this.ActualizarButtonClick);
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(331, 16);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(224, 20);
        	this.label1.TabIndex = 46;
        	this.label1.Text = "Bienvenido técnico:";
        	this.label1.Click += new System.EventHandler(this.Label1Click);
        	// 
        	// Tecnico
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(887, 363);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.actualizarButton);
        	this.Controls.Add(this.comboBox1);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.label9);
        	this.Controls.Add(this.button1);
        	this.Name = "Tecnico";
        	this.Text = "Lista de Reportes";
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.Label label1;
    }
}