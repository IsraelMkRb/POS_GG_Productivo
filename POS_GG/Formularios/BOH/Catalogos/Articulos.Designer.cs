using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulos));
            this.Indice = new System.Windows.Forms.DataGridView();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormularioArticulos = new System.Windows.Forms.TabControl();
            this.General_pag = new System.Windows.Forms.TabPage();
            this.ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PrecioModificable = new System.Windows.Forms.CheckBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Mod_pag = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.Modificador5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Modificador4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Modificador3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Modificador2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Modificador1 = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.documentViewerBarManager1 = new DevExpress.XtraPrinting.Preview.DocumentViewerBarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.documentViewerRibbonController1 = new DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Indice)).BeginInit();
            this.FormularioArticulos.SuspendLayout();
            this.General_pag.SuspendLayout();
            this.Mod_pag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerRibbonController1)).BeginInit();
            this.SuspendLayout();
            // 
            // Indice
            // 
            this.Indice.AllowUserToAddRows = false;
            this.Indice.AllowUserToDeleteRows = false;
            this.Indice.AllowUserToResizeRows = false;
            this.Indice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Indice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Indice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Indice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Column,
            this.Name_Column});
            this.Indice.Location = new System.Drawing.Point(12, 10);
            this.Indice.Name = "Indice";
            this.Indice.RowTemplate.Height = 24;
            this.Indice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Indice.Size = new System.Drawing.Size(250, 371);
            this.Indice.TabIndex = 10;
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
            // FormularioArticulos
            // 
            this.FormularioArticulos.Controls.Add(this.General_pag);
            this.FormularioArticulos.Controls.Add(this.Mod_pag);
            this.FormularioArticulos.Controls.Add(this.tabPage1);
            this.FormularioArticulos.Location = new System.Drawing.Point(277, 10);
            this.FormularioArticulos.Multiline = true;
            this.FormularioArticulos.Name = "FormularioArticulos";
            this.FormularioArticulos.SelectedIndex = 0;
            this.FormularioArticulos.Size = new System.Drawing.Size(511, 377);
            this.FormularioArticulos.TabIndex = 0;
            // 
            // General_pag
            // 
            this.General_pag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.General_pag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.General_pag.Controls.Add(this.ID);
            this.General_pag.Controls.Add(this.label12);
            this.General_pag.Controls.Add(this.PrecioModificable);
            this.General_pag.Controls.Add(this.precio);
            this.General_pag.Controls.Add(this.label4);
            this.General_pag.Controls.Add(this.display);
            this.General_pag.Controls.Add(this.label3);
            this.General_pag.Controls.Add(this.nombre);
            this.General_pag.Controls.Add(this.label2);
            this.General_pag.Controls.Add(this.label1);
            this.General_pag.Controls.Add(this.label5);
            this.General_pag.Location = new System.Drawing.Point(4, 25);
            this.General_pag.Name = "General_pag";
            this.General_pag.Padding = new System.Windows.Forms.Padding(3);
            this.General_pag.Size = new System.Drawing.Size(503, 348);
            this.General_pag.TabIndex = 0;
            this.General_pag.Text = "General";
            this.General_pag.Paint += new System.Windows.Forms.PaintEventHandler(this.General_pag_Paint);
            // 
            // ID
            // 
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.Location = new System.Drawing.Point(13, 91);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(366, 22);
            this.ID.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(10, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "ID(*)";
            // 
            // PrecioModificable
            // 
            this.PrecioModificable.AutoSize = true;
            this.PrecioModificable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrecioModificable.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PrecioModificable.FlatAppearance.BorderSize = 9;
            this.PrecioModificable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PrecioModificable.Location = new System.Drawing.Point(13, 269);
            this.PrecioModificable.Name = "PrecioModificable";
            this.PrecioModificable.Size = new System.Drawing.Size(148, 22);
            this.PrecioModificable.TabIndex = 6;
            this.PrecioModificable.Text = "Precio Modificable";
            this.PrecioModificable.UseVisualStyleBackColor = true;
            // 
            // precio
            // 
            this.precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precio.Location = new System.Drawing.Point(11, 241);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(366, 22);
            this.precio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(9, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio(*)";
            // 
            // display
            // 
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Location = new System.Drawing.Point(11, 186);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(366, 22);
            this.display.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(8, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display(*)";
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.Location = new System.Drawing.Point(11, 138);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(366, 22);
            this.nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "General";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "___________";
            // 
            // Mod_pag
            // 
            this.Mod_pag.BackColor = System.Drawing.Color.White;
            this.Mod_pag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Mod_pag.Controls.Add(this.label11);
            this.Mod_pag.Controls.Add(this.Modificador5);
            this.Mod_pag.Controls.Add(this.label10);
            this.Mod_pag.Controls.Add(this.Modificador4);
            this.Mod_pag.Controls.Add(this.label9);
            this.Mod_pag.Controls.Add(this.Modificador3);
            this.Mod_pag.Controls.Add(this.label8);
            this.Mod_pag.Controls.Add(this.Modificador2);
            this.Mod_pag.Controls.Add(this.label7);
            this.Mod_pag.Controls.Add(this.label6);
            this.Mod_pag.Controls.Add(this.Modificador1);
            this.Mod_pag.Location = new System.Drawing.Point(4, 25);
            this.Mod_pag.Name = "Mod_pag";
            this.Mod_pag.Padding = new System.Windows.Forms.Padding(3);
            this.Mod_pag.Size = new System.Drawing.Size(503, 348);
            this.Mod_pag.TabIndex = 1;
            this.Mod_pag.Text = "Modificadores";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Modificador 5";
            // 
            // Modificador5
            // 
            this.Modificador5.FormattingEnabled = true;
            this.Modificador5.Location = new System.Drawing.Point(17, 314);
            this.Modificador5.Name = "Modificador5";
            this.Modificador5.Size = new System.Drawing.Size(216, 24);
            this.Modificador5.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Modificador 4";
            // 
            // Modificador4
            // 
            this.Modificador4.FormattingEnabled = true;
            this.Modificador4.Location = new System.Drawing.Point(15, 255);
            this.Modificador4.Name = "Modificador4";
            this.Modificador4.Size = new System.Drawing.Size(216, 24);
            this.Modificador4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Modificador 3";
            // 
            // Modificador3
            // 
            this.Modificador3.FormattingEnabled = true;
            this.Modificador3.Location = new System.Drawing.Point(13, 195);
            this.Modificador3.Name = "Modificador3";
            this.Modificador3.Size = new System.Drawing.Size(216, 24);
            this.Modificador3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Modificador 2";
            // 
            // Modificador2
            // 
            this.Modificador2.FormattingEnabled = true;
            this.Modificador2.Location = new System.Drawing.Point(11, 136);
            this.Modificador2.Name = "Modificador2";
            this.Modificador2.Size = new System.Drawing.Size(216, 24);
            this.Modificador2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Modificador 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Modificadores";
            // 
            // Modificador1
            // 
            this.Modificador1.FormattingEnabled = true;
            this.Modificador1.Location = new System.Drawing.Point(11, 77);
            this.Modificador1.Name = "Modificador1";
            this.Modificador1.Size = new System.Drawing.Size(216, 24);
            this.Modificador1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(503, 348);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Receta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // documentViewerBarManager1
            // 
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlTop);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlBottom);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlLeft);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlRight);
            this.documentViewerBarManager1.Form = this;
            this.documentViewerBarManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("documentViewerBarManager1.ImageStream")));
            this.documentViewerBarManager1.MaxItemId = 59;
            this.documentViewerBarManager1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.documentViewerBarManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.documentViewerBarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.documentViewerBarManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.documentViewerBarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 450);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormularioArticulos);
            this.Controls.Add(this.Indice);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Articulos_Paint);
            this.Resize += new System.EventHandler(this.Articulos_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Indice)).EndInit();
            this.FormularioArticulos.ResumeLayout(false);
            this.General_pag.ResumeLayout(false);
            this.General_pag.PerformLayout();
            this.Mod_pag.ResumeLayout(false);
            this.Mod_pag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerRibbonController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        #region Comportamiento Formulario

        private void Articulos_Resize(object sender, EventArgs e)
        {
            //Ajustamos tamaño del indice donde aparecen todos los articulos
            Indice.Height = this.Height - (Indice.Location.Y - this.Location.Y) * 2;
            //Ajustamos el tamaño del formulario
            FormularioArticulos.Location = new Point(Indice.Width + 30, FormularioArticulos.Location.Y);
            FormularioArticulos.Height = this.Height - (FormularioArticulos.Location.Y - this.Location.Y) * 2;
            FormularioArticulos.Width = this.Width - Indice.Width - 50;
            //Ajustamos general
            foreach (Control control in FormularioArticulos.SelectedTab.Controls)
            {

            }
        }

        private void General_pag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Indice_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Articulos_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle,
                                                                                        Color.White, Color.Gray, 90);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
        #endregion
        private System.Windows.Forms.DataGridView Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Column;
        private System.Windows.Forms.TabControl FormularioArticulos;
        private System.Windows.Forms.TabPage General_pag;
        private System.Windows.Forms.TabPage Mod_pag;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraPrinting.Preview.DocumentViewerBarManager documentViewerBarManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController documentViewerRibbonController1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.CheckBox PrecioModificable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Modificador5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Modificador4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Modificador3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Modificador2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Modificador1;
        private TextBox ID;
        private Label label12;
    }
}