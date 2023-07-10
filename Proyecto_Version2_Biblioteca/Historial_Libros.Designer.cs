
namespace Proyecto_Version2_Biblioteca
{
    partial class Historial_Libros
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
            this.dtLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.DarkCyan;
            this.Label10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(12, 8);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(646, 23);
            this.Label10.TabIndex = 92;
            this.Label10.Text = "HISTORIAL DE LIBROS";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtLibros
            // 
            this.dtLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLibros.Location = new System.Drawing.Point(12, 34);
            this.dtLibros.Name = "dtLibros";
            this.dtLibros.Size = new System.Drawing.Size(646, 340);
            this.dtLibros.TabIndex = 91;
            // 
            // Historial_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 391);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.dtLibros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historial_Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial_Libros";
            this.Load += new System.EventHandler(this.Historial_Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.DataGridView dtLibros;
    }
}