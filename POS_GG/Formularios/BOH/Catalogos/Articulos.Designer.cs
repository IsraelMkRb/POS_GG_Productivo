namespace POS_GG.Formularios.BOH.Catalogos
{
    partial class Articulos
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
            this.Contenedor_Central = new System.Windows.Forms.Panel();
            this.FixPrice = new System.Windows.Forms.CheckBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Precio_Label = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.TextBox();
            this.Display_label = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Nombre_label = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.Indice = new System.Windows.Forms.DataGridView();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contenedor_Central.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Indice)).BeginInit();
            this.SuspendLayout();
            // 
            // Contenedor_Central
            // 
            this.Contenedor_Central.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Contenedor_Central.Controls.Add(this.Indice);
            this.Contenedor_Central.Controls.Add(this.Titulo);
            this.Contenedor_Central.Controls.Add(this.FixPrice);
            this.Contenedor_Central.Controls.Add(this.Precio);
            this.Contenedor_Central.Controls.Add(this.Precio_Label);
            this.Contenedor_Central.Controls.Add(this.Display);
            this.Contenedor_Central.Controls.Add(this.Display_label);
            this.Contenedor_Central.Controls.Add(this.Nombre);
            this.Contenedor_Central.Controls.Add(this.Nombre_label);
            this.Contenedor_Central.Location = new System.Drawing.Point(37, 24);
            this.Contenedor_Central.Name = "Contenedor_Central";
            this.Contenedor_Central.Size = new System.Drawing.Size(712, 377);
            this.Contenedor_Central.TabIndex = 0;
            // 
            // FixPrice
            // 
            this.FixPrice.AutoSize = true;
            this.FixPrice.Location = new System.Drawing.Point(343, 181);
            this.FixPrice.Name = "FixPrice";
            this.FixPrice.Size = new System.Drawing.Size(145, 21);
            this.FixPrice.TabIndex = 7;
            this.FixPrice.Text = "Precio Modificable";
            this.FixPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FixPrice.UseVisualStyleBackColor = true;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(343, 138);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(327, 22);
            this.Precio.TabIndex = 5;
            // 
            // Precio_Label
            // 
            this.Precio_Label.AutoSize = true;
            this.Precio_Label.Location = new System.Drawing.Point(278, 141);
            this.Precio_Label.Name = "Precio_Label";
            this.Precio_Label.Size = new System.Drawing.Size(53, 17);
            this.Precio_Label.TabIndex = 4;
            this.Precio_Label.Text = "Precio*";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(343, 102);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(327, 22);
            this.Display.TabIndex = 3;
            // 
            // Display_label
            // 
            this.Display_label.AutoSize = true;
            this.Display_label.Location = new System.Drawing.Point(278, 105);
            this.Display_label.Name = "Display_label";
            this.Display_label.Size = new System.Drawing.Size(59, 17);
            this.Display_label.TabIndex = 2;
            this.Display_label.Text = "Display*";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(343, 68);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(327, 22);
            this.Nombre.TabIndex = 1;
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.Location = new System.Drawing.Point(274, 71);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(63, 17);
            this.Nombre_label.TabIndex = 0;
            this.Nombre_label.Text = "Nombre*";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(380, 13);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(178, 25);
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "Registra articulos";
            // 
            // Indice
            // 
            this.Indice.AllowUserToAddRows = false;
            this.Indice.AllowUserToDeleteRows = false;
            this.Indice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Indice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Indice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Column,
            this.Name_Column});
            this.Indice.Location = new System.Drawing.Point(3, 3);
            this.Indice.Name = "Indice";
            this.Indice.RowTemplate.Height = 24;
            this.Indice.Size = new System.Drawing.Size(250, 371);
            this.Indice.TabIndex = 9;
            // 
            // ID_Column
            // 
            this.ID_Column.HeaderText = "ID";
            this.ID_Column.Name = "ID_Column";
            // 
            // Name_Column
            // 
            this.Name_Column.HeaderText = "Name";
            this.Name_Column.Name = "Name_Column";
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contenedor_Central);
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.Resize += new System.EventHandler(this.Articulos_Resize);
            this.Contenedor_Central.ResumeLayout(false);
            this.Contenedor_Central.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Indice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Contenedor_Central;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Label Display_label;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label Nombre_label;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.Label Precio_Label;
        private System.Windows.Forms.CheckBox FixPrice;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridView Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Column;
    }
}