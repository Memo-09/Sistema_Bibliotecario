
namespace Proyecto_Version2_Biblioteca
{
    partial class Historial_Prestamos
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.dtPrestamos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(513, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 46);
            this.button3.TabIndex = 140;
            this.button3.Text = "DEVOLVER LIBRO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 139;
            this.label1.Text = "Clave del Cliente";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(104, 36);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 138;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.DarkCyan;
            this.Label10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(12, 8);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(646, 23);
            this.Label10.TabIndex = 137;
            this.Label10.Text = "HISTORIAL DE PRESTAMOS PENDIENTES";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtPrestamos
            // 
            this.dtPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPrestamos.Location = new System.Drawing.Point(12, 60);
            this.dtPrestamos.Name = "dtPrestamos";
            this.dtPrestamos.Size = new System.Drawing.Size(646, 136);
            this.dtPrestamos.TabIndex = 136;
            // 
            // Historial_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 263);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.dtPrestamos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historial_Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial_Prestamos";
            this.Load += new System.EventHandler(this.Historial_Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.DataGridView dtPrestamos;
    }
}