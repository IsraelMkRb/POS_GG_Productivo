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
            this.Nombre_label = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Display_label = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.TextBox();
            this.Precio_Label = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            this.FixPrice = new System.Windows.Forms.CheckBox();
            this.Contenedor_Central.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor_Central
            // 
            this.Contenedor_Central.Controls.Add(this.FixPrice);
            this.Contenedor_Central.Controls.Add(this.Precio);
            this.Contenedor_Central.Controls.Add(this.Precio_Label);
            this.Contenedor_Central.Controls.Add(this.Display);
            this.Contenedor_Central.Controls.Add(this.Display_label);
            this.Contenedor_Central.Controls.Add(this.Nombre);
            this.Contenedor_Central.Controls.Add(this.Nombre_label);
            this.Contenedor_Central.Location = new System.Drawing.Point(46, 24);
            this.Contenedor_Central.Name = "Contenedor_Central";
            this.Contenedor_Central.Size = new System.Drawing.Size(703, 377);
            this.Contenedor_Central.TabIndex = 0;
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.Location = new System.Drawing.Point(76, 95);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(63, 17);
            this.Nombre_label.TabIndex = 0;
            this.Nombre_label.Text = "Nombre*";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(145, 92);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(327, 22);
            this.Nombre.TabIndex = 1;
            // 
            // Display_label
            // 
            this.Display_label.AutoSize = true;
            this.Display_label.Location = new System.Drawing.Point(80, 129);
            this.Display_label.Name = "Display_label";
            this.Display_label.Size = new System.Drawing.Size(59, 17);
            this.Display_label.TabIndex = 2;
            this.Display_label.Text = "Display*";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(145, 126);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(327, 22);
            this.Display.TabIndex = 3;
            // 
            // Precio_Label
            // 
            this.Precio_Label.AutoSize = true;
            this.Precio_Label.Location = new System.Drawing.Point(80, 165);
            this.Precio_Label.Name = "Precio_Label";
            this.Precio_Label.Size = new System.Drawing.Size(53, 17);
            this.Precio_Label.TabIndex = 4;
            this.Precio_Label.Text = "Precio*";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(145, 162);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(327, 22);
            this.Precio.TabIndex = 5;
            // 
            // FixPrice
            // 
            this.FixPrice.AutoSize = true;
            this.FixPrice.Location = new System.Drawing.Point(145, 209);
            this.FixPrice.Name = "FixPrice";
            this.FixPrice.Size = new System.Drawing.Size(145, 21);
            this.FixPrice.TabIndex = 7;
            this.FixPrice.Text = "Precio Modificable";
            this.FixPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FixPrice.UseVisualStyleBackColor = true;
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contenedor_Central);
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.Contenedor_Central.ResumeLayout(false);
            this.Contenedor_Central.PerformLayout();
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
    }
}