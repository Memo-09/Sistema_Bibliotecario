
namespace Proyecto_Version2_Biblioteca
{
    partial class Lista_Clientes
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
            this.dtClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
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
            this.Label10.TabIndex = 90;
            this.Label10.Text = "LISTA DE CLIENTES REGISTRADOS";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtClientes
            // 
            this.dtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClientes.Location = new System.Drawing.Point(12, 35);
            this.dtClientes.Name = "dtClientes";
            this.dtClientes.Size = new System.Drawing.Size(646, 340);
            this.dtClientes.TabIndex = 89;
            this.dtClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtClientes_CellDoubleClick);
            this.dtClientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtClientes_CellMouseDoubleClick);
            // 
            // Lista_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 396);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.dtClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Clientes";
            this.Load += new System.EventHandler(this.Lista_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.DataGridView dtClientes;
    }
}