namespace PonyMemo
{
    partial class Form1
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
            this.btnSelaa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rekNroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emäDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isäDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ponitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poniTiedot = new PonyMemo.PoniTiedot();
            this.label1 = new System.Windows.Forms.Label();
            this.paneeli = new System.Windows.Forms.Panel();
            this.txtEmä = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIsä = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReknro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.kuvalaatikko = new System.Windows.Forms.PictureBox();
            this.txtEtsi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUusi = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.ponitTableAdapter = new PonyMemo.PoniTiedotTableAdapters.PonitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniTiedot)).BeginInit();
            this.paneeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kuvalaatikko)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelaa
            // 
            this.btnSelaa.Location = new System.Drawing.Point(415, 141);
            this.btnSelaa.Name = "btnSelaa";
            this.btnSelaa.Size = new System.Drawing.Size(75, 23);
            this.btnSelaa.TabIndex = 0;
            this.btnSelaa.Text = "Selaa";
            this.btnSelaa.UseVisualStyleBackColor = true;
            this.btnSelaa.Click += new System.EventHandler(this.btnSelaa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn,
            this.rekNroDataGridViewTextBoxColumn,
            this.emäDataGridViewTextBoxColumn,
            this.isäDataGridViewTextBoxColumn,
            this.kuvaDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.ponitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 172);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "Nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "Nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // rekNroDataGridViewTextBoxColumn
            // 
            this.rekNroDataGridViewTextBoxColumn.DataPropertyName = "RekNro";
            this.rekNroDataGridViewTextBoxColumn.HeaderText = "RekNro";
            this.rekNroDataGridViewTextBoxColumn.Name = "rekNroDataGridViewTextBoxColumn";
            // 
            // emäDataGridViewTextBoxColumn
            // 
            this.emäDataGridViewTextBoxColumn.DataPropertyName = "Emä";
            this.emäDataGridViewTextBoxColumn.HeaderText = "Emä";
            this.emäDataGridViewTextBoxColumn.Name = "emäDataGridViewTextBoxColumn";
            // 
            // isäDataGridViewTextBoxColumn
            // 
            this.isäDataGridViewTextBoxColumn.DataPropertyName = "Isä";
            this.isäDataGridViewTextBoxColumn.HeaderText = "Isä";
            this.isäDataGridViewTextBoxColumn.Name = "isäDataGridViewTextBoxColumn";
            // 
            // kuvaDataGridViewImageColumn
            // 
            this.kuvaDataGridViewImageColumn.DataPropertyName = "Kuva";
            this.kuvaDataGridViewImageColumn.HeaderText = "Kuva";
            this.kuvaDataGridViewImageColumn.Name = "kuvaDataGridViewImageColumn";
            // 
            // ponitBindingSource
            // 
            this.ponitBindingSource.DataMember = "Ponit";
            this.ponitBindingSource.DataSource = this.poniTiedot;
            // 
            // poniTiedot
            // 
            this.poniTiedot.DataSetName = "PoniTiedot";
            this.poniTiedot.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nimi:";
            // 
            // paneeli
            // 
            this.paneeli.Controls.Add(this.txtEmä);
            this.paneeli.Controls.Add(this.label4);
            this.paneeli.Controls.Add(this.txtIsä);
            this.paneeli.Controls.Add(this.label3);
            this.paneeli.Controls.Add(this.txtReknro);
            this.paneeli.Controls.Add(this.label2);
            this.paneeli.Controls.Add(this.txtNimi);
            this.paneeli.Controls.Add(this.label1);
            this.paneeli.Controls.Add(this.kuvalaatikko);
            this.paneeli.Controls.Add(this.btnSelaa);
            this.paneeli.Location = new System.Drawing.Point(12, 12);
            this.paneeli.Name = "paneeli";
            this.paneeli.Size = new System.Drawing.Size(542, 185);
            this.paneeli.TabIndex = 0;
            // 
            // txtEmä
            // 
            this.txtEmä.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ponitBindingSource, "Emä", true));
            this.txtEmä.Location = new System.Drawing.Point(104, 124);
            this.txtEmä.Name = "txtEmä";
            this.txtEmä.Size = new System.Drawing.Size(220, 20);
            this.txtEmä.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Emä:";
            // 
            // txtIsä
            // 
            this.txtIsä.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ponitBindingSource, "Isä", true));
            this.txtIsä.Location = new System.Drawing.Point(104, 83);
            this.txtIsä.Name = "txtIsä";
            this.txtIsä.Size = new System.Drawing.Size(220, 20);
            this.txtIsä.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Isä:";
            // 
            // txtReknro
            // 
            this.txtReknro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ponitBindingSource, "RekNro", true));
            this.txtReknro.Location = new System.Drawing.Point(104, 51);
            this.txtReknro.Name = "txtReknro";
            this.txtReknro.Size = new System.Drawing.Size(117, 20);
            this.txtReknro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rekisterinumero:";
            // 
            // txtNimi
            // 
            this.txtNimi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ponitBindingSource, "Nimi", true));
            this.txtNimi.Location = new System.Drawing.Point(104, 13);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(220, 20);
            this.txtNimi.TabIndex = 1;
            // 
            // kuvalaatikko
            // 
            this.kuvalaatikko.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kuvalaatikko.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.ponitBindingSource, "Kuva", true));
            this.kuvalaatikko.Location = new System.Drawing.Point(376, 3);
            this.kuvalaatikko.Name = "kuvalaatikko";
            this.kuvalaatikko.Size = new System.Drawing.Size(152, 132);
            this.kuvalaatikko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kuvalaatikko.TabIndex = 0;
            this.kuvalaatikko.TabStop = false;
            // 
            // txtEtsi
            // 
            this.txtEtsi.Location = new System.Drawing.Point(116, 203);
            this.txtEtsi.Name = "txtEtsi";
            this.txtEtsi.Size = new System.Drawing.Size(435, 20);
            this.txtEtsi.TabIndex = 4;
            this.txtEtsi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEtsi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Etsi:";
            // 
            // btnUusi
            // 
            this.btnUusi.Location = new System.Drawing.Point(206, 416);
            this.btnUusi.Name = "btnUusi";
            this.btnUusi.Size = new System.Drawing.Size(75, 23);
            this.btnUusi.TabIndex = 6;
            this.btnUusi.Text = "Uusi";
            this.btnUusi.UseVisualStyleBackColor = true;
            this.btnUusi.Click += new System.EventHandler(this.btnUusi_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(296, 416);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 7;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(388, 416);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(75, 23);
            this.btnPeruuta.TabIndex = 8;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(479, 416);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(75, 23);
            this.btnTallenna.TabIndex = 9;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // ponitTableAdapter
            // 
            this.ponitTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 452);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.btnPeruuta);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnUusi);
            this.Controls.Add(this.txtEtsi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paneeli);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PonyMemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniTiedot)).EndInit();
            this.paneeli.ResumeLayout(false);
            this.paneeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kuvalaatikko)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelaa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paneeli;
        private System.Windows.Forms.TextBox txtEmä;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIsä;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReknro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.PictureBox kuvalaatikko;
        private System.Windows.Forms.TextBox txtEtsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUusi;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnTallenna;
        private PoniTiedot poniTiedot;
        private System.Windows.Forms.BindingSource ponitBindingSource;
        private PoniTiedotTableAdapters.PonitTableAdapter ponitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rekNroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emäDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isäDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn kuvaDataGridViewImageColumn;
    }
}

