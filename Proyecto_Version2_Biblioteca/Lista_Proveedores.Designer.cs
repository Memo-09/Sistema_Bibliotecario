
namespace Proyecto_Version2_Biblioteca
{
    partial class Lista_Proveedores
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
            this.Label10 = new System.Windows.Forms.Label();
            this.dtProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.DarkCyan;
            this.Label10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(12, 9);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(646, 23);
            this.Label10.TabIndex = 92;
            this.Label10.Text = "LISTA DE CLIENTES REGISTRADOS";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtProveedores
            // 
            this.dtProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProveedores.Location = new System.Drawing.Point(12, 35);
            this.dtProveedores.Name = "dtProveedores";
            this.dtProveedores.Size = new System.Drawing.Size(646, 340);
            this.dtProveedores.TabIndex = 91;
            // 
            // Lista_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 388);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.dtProveedores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Proveedores";
            this.Load += new System.EventHandler(this.Lista_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.DataGridView dtProveedores;
    }
}