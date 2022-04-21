namespace Compilador
{
    partial class Compilador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compilador));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCompilar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsoleEdit = new System.Windows.Forms.TextBox();
            this.rbtnArchivo = new System.Windows.Forms.RadioButton();
            this.rbtnConsola = new System.Windows.Forms.RadioButton();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicionInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicionFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(38, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 815);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnCompilar);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.lbConsole);
            this.tabPage1.Controls.Add(this.btnCargar);
            this.tabPage1.Controls.Add(this.txtArchivo);
            this.tabPage1.Controls.Add(this.btnProcesar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtConsoleEdit);
            this.tabPage1.Controls.Add(this.rbtnArchivo);
            this.tabPage1.Controls.Add(this.rbtnConsola);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 787);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Programa fuente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificador,
            this.numeroLinea,
            this.posicionInicial,
            this.posicionFinal,
            this.categoria,
            this.lexema});
            this.dataGridView1.Location = new System.Drawing.Point(6, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(780, 331);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCompilar
            // 
            this.btnCompilar.BackColor = System.Drawing.Color.Gray;
            this.btnCompilar.Location = new System.Drawing.Point(342, 358);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(102, 37);
            this.btnCompilar.TabIndex = 10;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = false;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(687, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 37);
            this.btnClear.TabIndex = 9;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbConsole
            // 
            this.lbConsole.Enabled = false;
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.ItemHeight = 15;
            this.lbConsole.Location = new System.Drawing.Point(6, 258);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(780, 94);
            this.lbConsole.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargar.BackgroundImage")));
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Location = new System.Drawing.Point(733, 104);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(53, 37);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(6, 112);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(721, 23);
            this.txtArchivo.TabIndex = 6;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.Gray;
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProcesar.Location = new System.Drawing.Point(342, 188);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(102, 32);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consola:";
            // 
            // txtConsoleEdit
            // 
            this.txtConsoleEdit.Location = new System.Drawing.Point(6, 68);
            this.txtConsoleEdit.Multiline = true;
            this.txtConsoleEdit.Name = "txtConsoleEdit";
            this.txtConsoleEdit.Size = new System.Drawing.Size(780, 114);
            this.txtConsoleEdit.TabIndex = 2;
            this.txtConsoleEdit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbtnArchivo
            // 
            this.rbtnArchivo.AutoSize = true;
            this.rbtnArchivo.Location = new System.Drawing.Point(418, 23);
            this.rbtnArchivo.Name = "rbtnArchivo";
            this.rbtnArchivo.Size = new System.Drawing.Size(68, 19);
            this.rbtnArchivo.TabIndex = 1;
            this.rbtnArchivo.TabStop = true;
            this.rbtnArchivo.Text = "Archivo";
            this.rbtnArchivo.UseVisualStyleBackColor = true;
            this.rbtnArchivo.CheckedChanged += new System.EventHandler(this.rbtnArchivo_CheckedChanged);
            // 
            // rbtnConsola
            // 
            this.rbtnConsola.AutoSize = true;
            this.rbtnConsola.Location = new System.Drawing.Point(303, 23);
            this.rbtnConsola.Name = "rbtnConsola";
            this.rbtnConsola.Size = new System.Drawing.Size(67, 19);
            this.rbtnConsola.TabIndex = 0;
            this.rbtnConsola.TabStop = true;
            this.rbtnConsola.Text = "Consola";
            this.rbtnConsola.UseVisualStyleBackColor = true;
            this.rbtnConsola.CheckedChanged += new System.EventHandler(this.rbtnConsola_CheckedChanged);
            // 
            // identificador
            // 
            this.identificador.HeaderText = "Identificador";
            this.identificador.Name = "identificador";
            // 
            // numeroLinea
            // 
            this.numeroLinea.HeaderText = "Número Linea";
            this.numeroLinea.Name = "numeroLinea";
            // 
            // posicionInicial
            // 
            this.posicionInicial.HeaderText = "Posición Inicial";
            this.posicionInicial.Name = "posicionInicial";
            // 
            // posicionFinal
            // 
            this.posicionFinal.HeaderText = "Posicion Final";
            this.posicionFinal.Name = "posicionFinal";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // lexema
            // 
            this.lexema.HeaderText = "Lexema";
            this.lexema.Name = "lexema";
            // 
            // Compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(888, 870);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Compilador";
            this.Text = "Compilador";
            this.Load += new System.EventHandler(this.Compilador_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private RadioButton rbtnArchivo;
        private RadioButton rbtnConsola;
        private TextBox txtConsoleEdit;
        private Button btnProcesar;
        private Label label1;
        private Button btnCargar;
        private TextBox txtArchivo;
        private ListBox lbConsole;
        private Button btnClear;
        private Button btnCompilar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn identificador;
        private DataGridViewTextBoxColumn numeroLinea;
        private DataGridViewTextBoxColumn posicionInicial;
        private DataGridViewTextBoxColumn posicionFinal;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn lexema;
    }
}