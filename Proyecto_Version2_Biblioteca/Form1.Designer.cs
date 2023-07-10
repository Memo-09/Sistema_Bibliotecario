
namespace Proyecto_Version2_Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRCHIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIBROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lIBROSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aUTORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gENEROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITORIALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEVOLUCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSIDENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroLibros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLector = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnlector = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label10 = new System.Windows.Forms.Label();
            this.dtLibros = new System.Windows.Forms.DataGridView();
            this.txtFecEntrega = new System.Windows.Forms.TextBox();
            this.dtDevolucion = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOToolStripMenuItem,
            this.rEGISTROToolStripMenuItem,
            this.dEVOLUCIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 77;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            this.aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lIBROSToolStripMenuItem,
            this.cLIENTESToolStripMenuItem,
            this.pROVEEDORESToolStripMenuItem});
            this.aRCHIVOToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            this.aRCHIVOToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aRCHIVOToolStripMenuItem.Text = "ARCHIVO";
            // 
            // lIBROSToolStripMenuItem
            // 
            this.lIBROSToolStripMenuItem.Name = "lIBROSToolStripMenuItem";
            this.lIBROSToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.lIBROSToolStripMenuItem.Text = "LIBROS";
            this.lIBROSToolStripMenuItem.Click += new System.EventHandler(this.lIBROSToolStripMenuItem_Click);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // pROVEEDORESToolStripMenuItem
            // 
            this.pROVEEDORESToolStripMenuItem.Name = "pROVEEDORESToolStripMenuItem";
            this.pROVEEDORESToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pROVEEDORESToolStripMenuItem.Text = "PROVEEDORES";
            this.pROVEEDORESToolStripMenuItem.Click += new System.EventHandler(this.pROVEEDORESToolStripMenuItem_Click);
            // 
            // rEGISTROToolStripMenuItem
            // 
            this.rEGISTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem1,
            this.lIBROSToolStripMenuItem1,
            this.pROVEEDORESToolStripMenuItem1,
            this.aUTORESToolStripMenuItem,
            this.gENEROToolStripMenuItem,
            this.eDITORIALESToolStripMenuItem});
            this.rEGISTROToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEGISTROToolStripMenuItem.Name = "rEGISTROToolStripMenuItem";
            this.rEGISTROToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.rEGISTROToolStripMenuItem.Text = "REGISTRO";
            // 
            // cLIENTESToolStripMenuItem1
            // 
            this.cLIENTESToolStripMenuItem1.Name = "cLIENTESToolStripMenuItem1";
            this.cLIENTESToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cLIENTESToolStripMenuItem1.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem1.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem1_Click);
            // 
            // lIBROSToolStripMenuItem1
            // 
            this.lIBROSToolStripMenuItem1.Name = "lIBROSToolStripMenuItem1";
            this.lIBROSToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lIBROSToolStripMenuItem1.Text = "LIBROS";
            this.lIBROSToolStripMenuItem1.Click += new System.EventHandler(this.lIBROSToolStripMenuItem1_Click);
            // 
            // pROVEEDORESToolStripMenuItem1
            // 
            this.pROVEEDORESToolStripMenuItem1.Name = "pROVEEDORESToolStripMenuItem1";
            this.pROVEEDORESToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pROVEEDORESToolStripMenuItem1.Text = "PROVEEDORES";
            this.pROVEEDORESToolStripMenuItem1.Click += new System.EventHandler(this.pROVEEDORESToolStripMenuItem1_Click);
            // 
            // aUTORESToolStripMenuItem
            // 
            this.aUTORESToolStripMenuItem.Name = "aUTORESToolStripMenuItem";
            this.aUTORESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aUTORESToolStripMenuItem.Text = "AUTORES";
            this.aUTORESToolStripMenuItem.Click += new System.EventHandler(this.aUTORESToolStripMenuItem_Click);
            // 
            // gENEROToolStripMenuItem
            // 
            this.gENEROToolStripMenuItem.Name = "gENEROToolStripMenuItem";
            this.gENEROToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gENEROToolStripMenuItem.Text = "GENERO";
            this.gENEROToolStripMenuItem.Click += new System.EventHandler(this.gENEROToolStripMenuItem_Click);
            // 
            // eDITORIALESToolStripMenuItem
            // 
            this.eDITORIALESToolStripMenuItem.Name = "eDITORIALESToolStripMenuItem";
            this.eDITORIALESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eDITORIALESToolStripMenuItem.Text = "EDITORIALES";
            this.eDITORIALESToolStripMenuItem.Click += new System.EventHandler(this.eDITORIALESToolStripMenuItem_Click);
            // 
            // dEVOLUCIONESToolStripMenuItem
            // 
            this.dEVOLUCIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSIDENTESToolStripMenuItem});
            this.dEVOLUCIONESToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dEVOLUCIONESToolStripMenuItem.Name = "dEVOLUCIONESToolStripMenuItem";
            this.dEVOLUCIONESToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.dEVOLUCIONESToolStripMenuItem.Text = "DEVOLUCIONES";
            // 
            // iNSIDENTESToolStripMenuItem
            // 
            this.iNSIDENTESToolStripMenuItem.Name = "iNSIDENTESToolStripMenuItem";
            this.iNSIDENTESToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.iNSIDENTESToolStripMenuItem.Text = "INSIDENTES";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(431, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 22);
            this.button3.TabIndex = 153;
            this.button3.Text = "HISTORIAL DE PRETAMOS DE LIBROS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(498, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 70);
            this.button1.TabIndex = 152;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(594, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 70);
            this.button2.TabIndex = 151;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(320, 93);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(236, 20);
            this.txtBuscar.TabIndex = 150;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.label2.Location = new System.Drawing.Point(246, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 149;
            this.label2.Text = "Buscar Libro:";
            // 
            // txtNumeroLibros
            // 
            this.txtNumeroLibros.Enabled = false;
            this.txtNumeroLibros.Location = new System.Drawing.Point(109, 308);
            this.txtNumeroLibros.Name = "txtNumeroLibros";
            this.txtNumeroLibros.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroLibros.TabIndex = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 147;
            this.label1.Text = "Numero de Libros";
            // 
            // txtLector
            // 
            this.txtLector.Location = new System.Drawing.Point(135, 67);
            this.txtLector.Name = "txtLector";
            this.txtLector.Size = new System.Drawing.Size(206, 20);
            this.txtLector.TabIndex = 146;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(405, 67);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 145;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.Label9.Location = new System.Drawing.Point(25, 126);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(104, 16);
            this.Label9.TabIndex = 144;
            this.Label9.Text = "Fecha de Devolución:";
            // 
            // btnlector
            // 
            this.btnlector.BackColor = System.Drawing.Color.DarkCyan;
            this.btnlector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlector.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlector.ForeColor = System.Drawing.Color.White;
            this.btnlector.Location = new System.Drawing.Point(520, 66);
            this.btnlector.Name = "btnlector";
            this.btnlector.Size = new System.Drawing.Size(36, 22);
            this.btnlector.TabIndex = 143;
            this.btnlector.Text = "•••";
            this.btnlector.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlector.UseVisualStyleBackColor = false;
            this.btnlector.Click += new System.EventHandler(this.btnlector_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.Label7.Location = new System.Drawing.Point(25, 98);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(87, 16);
            this.Label7.TabIndex = 142;
            this.Label7.Text = "Fecha de Entrega:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.Label6.Location = new System.Drawing.Point(25, 66);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(38, 16);
            this.Label6.TabIndex = 141;
            this.Label6.Text = "Lector:";
            // 
            // Label3
            // 
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Location = new System.Drawing.Point(12, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(661, 106);
            this.Label3.TabIndex = 140;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isb,
            this.clave,
            this.descripcion,
            this.editorial});
            this.dataGridView1.Location = new System.Drawing.Point(15, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 130);
            this.dataGridView1.TabIndex = 139;
            // 
            // isb
            // 
            this.isb.HeaderText = "ISB";
            this.isb.Name = "isb";
            // 
            // clave
            // 
            this.clave.HeaderText = "CLAVE";
            this.clave.Name = "clave";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "NOMBRE";
            this.descripcion.Name = "descripcion";
            // 
            // editorial
            // 
            this.editorial.HeaderText = "EDITORIAL";
            this.editorial.Name = "editorial";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.DarkCyan;
            this.Label10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(12, 31);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(661, 23);
            this.Label10.TabIndex = 138;
            this.Label10.Text = "DATOS DE REGISTRO";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtLibros
            // 
            this.dtLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLibros.Location = new System.Drawing.Point(12, 166);
            this.dtLibros.Name = "dtLibros";
            this.dtLibros.Size = new System.Drawing.Size(661, 130);
            this.dtLibros.TabIndex = 137;
            this.dtLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLibros_CellContentClick);
            this.dtLibros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLibros_CellContentDoubleClick);
            this.dtLibros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLibros_CellDoubleClick);
            // 
            // txtFecEntrega
            // 
            this.txtFecEntrega.Enabled = false;
            this.txtFecEntrega.Location = new System.Drawing.Point(135, 94);
            this.txtFecEntrega.Name = "txtFecEntrega";
            this.txtFecEntrega.Size = new System.Drawing.Size(105, 20);
            this.txtFecEntrega.TabIndex = 155;
            // 
            // dtDevolucion
            // 
            this.dtDevolucion.CustomFormat = "yyyy/MM/dd";
            this.dtDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDevolucion.Location = new System.Drawing.Point(135, 126);
            this.dtDevolucion.Name = "dtDevolucion";
            this.dtDevolucion.Size = new System.Drawing.Size(105, 20);
            this.dtDevolucion.TabIndex = 156;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(626, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 22);
            this.button4.TabIndex = 157;
            this.button4.Text = "•••";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.label4.Location = new System.Drawing.Point(347, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 158;
            this.label4.Text = "Clave:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 547);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtDevolucion);
            this.Controls.Add(this.txtFecEntrega);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroLibros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLector);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.btnlector);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.dtLibros);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIBROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lIBROSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dEVOLUCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSIDENTESToolStripMenuItem;
        internal System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroLibros;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtLector;
        public System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button btnlector;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
        internal System.Windows.Forms.Label Label10;
        public System.Windows.Forms.DataGridView dtLibros;
        private System.Windows.Forms.TextBox txtFecEntrega;
        private System.Windows.Forms.DateTimePicker dtDevolucion;
        private System.Windows.Forms.ToolStripMenuItem aUTORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gENEROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITORIALESToolStripMenuItem;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Label label4;
    }
}

