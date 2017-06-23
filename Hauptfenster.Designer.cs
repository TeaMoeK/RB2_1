namespace RB21
{
  partial class Hauptfenster
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.groupNamen = new System.Windows.Forms.GroupBox();
      this.dgvNamen = new System.Windows.Forms.DataGridView();
      this.btnNamenSave = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.dgvErgebnisse = new System.Windows.Forms.DataGridView();
      this.btnMaterialSave = new System.Windows.Forms.Button();
      this.databaseDataSet = new RB21.DatabaseDataSet();
      this.personenBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.personenTableAdapter = new RB21.DatabaseDataSetTableAdapters.PersonenTableAdapter();
      this.tableAdapterManager = new RB21.DatabaseDataSetTableAdapters.TableAdapterManager();
      this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.adressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.zweitnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.geburtstagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.geschlechtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.darfKKDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.darfLGDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.kleinkaliberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.luftgewehrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.handschuhIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.jackeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pistoleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.istKoenigDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.istVizeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.istArchiviertDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.groupNamen.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvNamen)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvErgebnisse)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // groupNamen
      // 
      this.groupNamen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.groupNamen.Controls.Add(this.btnNamenSave);
      this.groupNamen.Controls.Add(this.dgvNamen);
      this.groupNamen.Location = new System.Drawing.Point(12, 12);
      this.groupNamen.Name = "groupNamen";
      this.groupNamen.Size = new System.Drawing.Size(570, 337);
      this.groupNamen.TabIndex = 0;
      this.groupNamen.TabStop = false;
      this.groupNamen.Text = "Namen";
      // 
      // dgvNamen
      // 
      this.dgvNamen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvNamen.AutoGenerateColumns = false;
      this.dgvNamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvNamen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.adressIDDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.zweitnameDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.geburtstagDataGridViewTextBoxColumn,
            this.geschlechtDataGridViewTextBoxColumn,
            this.darfKKDataGridViewCheckBoxColumn,
            this.darfLGDataGridViewCheckBoxColumn,
            this.kleinkaliberIDDataGridViewTextBoxColumn,
            this.luftgewehrIDDataGridViewTextBoxColumn,
            this.handschuhIDDataGridViewTextBoxColumn,
            this.jackeIDDataGridViewTextBoxColumn,
            this.pistoleIDDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.istKoenigDataGridViewCheckBoxColumn,
            this.istVizeDataGridViewCheckBoxColumn,
            this.istArchiviertDataGridViewCheckBoxColumn});
      this.dgvNamen.DataSource = this.personenBindingSource;
      this.dgvNamen.Location = new System.Drawing.Point(6, 19);
      this.dgvNamen.Name = "dgvNamen";
      this.dgvNamen.Size = new System.Drawing.Size(558, 284);
      this.dgvNamen.TabIndex = 0;
      // 
      // btnNamenSave
      // 
      this.btnNamenSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnNamenSave.Location = new System.Drawing.Point(6, 309);
      this.btnNamenSave.Name = "btnNamenSave";
      this.btnNamenSave.Size = new System.Drawing.Size(75, 23);
      this.btnNamenSave.TabIndex = 1;
      this.btnNamenSave.Text = "Save";
      this.btnNamenSave.UseVisualStyleBackColor = true;
      this.btnNamenSave.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.btnMaterialSave);
      this.groupBox1.Location = new System.Drawing.Point(588, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(184, 332);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Material";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.groupBox2.Controls.Add(this.dgvErgebnisse);
      this.groupBox2.Location = new System.Drawing.Point(18, 355);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(564, 203);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Ergebnisse";
      // 
      // dgvErgebnisse
      // 
      this.dgvErgebnisse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvErgebnisse.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvErgebnisse.Location = new System.Drawing.Point(3, 16);
      this.dgvErgebnisse.Name = "dgvErgebnisse";
      this.dgvErgebnisse.Size = new System.Drawing.Size(558, 184);
      this.dgvErgebnisse.TabIndex = 0;
      // 
      // btnMaterialSave
      // 
      this.btnMaterialSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnMaterialSave.Location = new System.Drawing.Point(7, 303);
      this.btnMaterialSave.Name = "btnMaterialSave";
      this.btnMaterialSave.Size = new System.Drawing.Size(75, 23);
      this.btnMaterialSave.TabIndex = 1;
      this.btnMaterialSave.Text = "Save";
      this.btnMaterialSave.UseVisualStyleBackColor = true;
      // 
      // databaseDataSet
      // 
      this.databaseDataSet.DataSetName = "DatabaseDataSet";
      this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // personenBindingSource
      // 
      this.personenBindingSource.DataMember = "Personen";
      this.personenBindingSource.DataSource = this.databaseDataSet;
      // 
      // personenTableAdapter
      // 
      this.personenTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.PersonenTableAdapter = this.personenTableAdapter;
      this.tableAdapterManager.UpdateOrder = RB21.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // iDDataGridViewTextBoxColumn
      // 
      this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
      this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
      this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
      this.iDDataGridViewTextBoxColumn.ReadOnly = true;
      this.iDDataGridViewTextBoxColumn.Visible = false;
      // 
      // adressIDDataGridViewTextBoxColumn
      // 
      this.adressIDDataGridViewTextBoxColumn.DataPropertyName = "AdressID";
      this.adressIDDataGridViewTextBoxColumn.HeaderText = "AdressID";
      this.adressIDDataGridViewTextBoxColumn.Name = "adressIDDataGridViewTextBoxColumn";
      this.adressIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // vornameDataGridViewTextBoxColumn
      // 
      this.vornameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
      this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
      this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
      this.vornameDataGridViewTextBoxColumn.Width = 74;
      // 
      // zweitnameDataGridViewTextBoxColumn
      // 
      this.zweitnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.zweitnameDataGridViewTextBoxColumn.DataPropertyName = "Zweitname";
      this.zweitnameDataGridViewTextBoxColumn.HeaderText = "Zweitname";
      this.zweitnameDataGridViewTextBoxColumn.Name = "zweitnameDataGridViewTextBoxColumn";
      this.zweitnameDataGridViewTextBoxColumn.Width = 84;
      // 
      // nachnameDataGridViewTextBoxColumn
      // 
      this.nachnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
      this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
      this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
      // 
      // geburtstagDataGridViewTextBoxColumn
      // 
      this.geburtstagDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.geburtstagDataGridViewTextBoxColumn.DataPropertyName = "Geburtstag";
      this.geburtstagDataGridViewTextBoxColumn.HeaderText = "Geburtstag";
      this.geburtstagDataGridViewTextBoxColumn.Name = "geburtstagDataGridViewTextBoxColumn";
      this.geburtstagDataGridViewTextBoxColumn.Width = 84;
      // 
      // geschlechtDataGridViewTextBoxColumn
      // 
      this.geschlechtDataGridViewTextBoxColumn.DataPropertyName = "Geschlecht";
      this.geschlechtDataGridViewTextBoxColumn.HeaderText = "Geschlecht";
      this.geschlechtDataGridViewTextBoxColumn.Name = "geschlechtDataGridViewTextBoxColumn";
      this.geschlechtDataGridViewTextBoxColumn.Visible = false;
      // 
      // darfKKDataGridViewCheckBoxColumn
      // 
      this.darfKKDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.darfKKDataGridViewCheckBoxColumn.DataPropertyName = "DarfKK";
      this.darfKKDataGridViewCheckBoxColumn.HeaderText = "DarfKK";
      this.darfKKDataGridViewCheckBoxColumn.Name = "darfKKDataGridViewCheckBoxColumn";
      this.darfKKDataGridViewCheckBoxColumn.Width = 47;
      // 
      // darfLGDataGridViewCheckBoxColumn
      // 
      this.darfLGDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.darfLGDataGridViewCheckBoxColumn.DataPropertyName = "DarfLG";
      this.darfLGDataGridViewCheckBoxColumn.HeaderText = "DarfLG";
      this.darfLGDataGridViewCheckBoxColumn.Name = "darfLGDataGridViewCheckBoxColumn";
      this.darfLGDataGridViewCheckBoxColumn.Width = 47;
      // 
      // kleinkaliberIDDataGridViewTextBoxColumn
      // 
      this.kleinkaliberIDDataGridViewTextBoxColumn.DataPropertyName = "KleinkaliberID";
      this.kleinkaliberIDDataGridViewTextBoxColumn.HeaderText = "KleinkaliberID";
      this.kleinkaliberIDDataGridViewTextBoxColumn.Name = "kleinkaliberIDDataGridViewTextBoxColumn";
      this.kleinkaliberIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // luftgewehrIDDataGridViewTextBoxColumn
      // 
      this.luftgewehrIDDataGridViewTextBoxColumn.DataPropertyName = "LuftgewehrID";
      this.luftgewehrIDDataGridViewTextBoxColumn.HeaderText = "LuftgewehrID";
      this.luftgewehrIDDataGridViewTextBoxColumn.Name = "luftgewehrIDDataGridViewTextBoxColumn";
      this.luftgewehrIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // handschuhIDDataGridViewTextBoxColumn
      // 
      this.handschuhIDDataGridViewTextBoxColumn.DataPropertyName = "HandschuhID";
      this.handschuhIDDataGridViewTextBoxColumn.HeaderText = "HandschuhID";
      this.handschuhIDDataGridViewTextBoxColumn.Name = "handschuhIDDataGridViewTextBoxColumn";
      this.handschuhIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // jackeIDDataGridViewTextBoxColumn
      // 
      this.jackeIDDataGridViewTextBoxColumn.DataPropertyName = "JackeID";
      this.jackeIDDataGridViewTextBoxColumn.HeaderText = "JackeID";
      this.jackeIDDataGridViewTextBoxColumn.Name = "jackeIDDataGridViewTextBoxColumn";
      this.jackeIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // pistoleIDDataGridViewTextBoxColumn
      // 
      this.pistoleIDDataGridViewTextBoxColumn.DataPropertyName = "PistoleID";
      this.pistoleIDDataGridViewTextBoxColumn.HeaderText = "PistoleID";
      this.pistoleIDDataGridViewTextBoxColumn.Name = "pistoleIDDataGridViewTextBoxColumn";
      this.pistoleIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // infoDataGridViewTextBoxColumn
      // 
      this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
      this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
      this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
      this.infoDataGridViewTextBoxColumn.Visible = false;
      // 
      // istKoenigDataGridViewCheckBoxColumn
      // 
      this.istKoenigDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.istKoenigDataGridViewCheckBoxColumn.DataPropertyName = "IstKoenig";
      this.istKoenigDataGridViewCheckBoxColumn.HeaderText = "Koenig";
      this.istKoenigDataGridViewCheckBoxColumn.Name = "istKoenigDataGridViewCheckBoxColumn";
      this.istKoenigDataGridViewCheckBoxColumn.Width = 46;
      // 
      // istVizeDataGridViewCheckBoxColumn
      // 
      this.istVizeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.istVizeDataGridViewCheckBoxColumn.DataPropertyName = "IstVize";
      this.istVizeDataGridViewCheckBoxColumn.HeaderText = "Vize";
      this.istVizeDataGridViewCheckBoxColumn.Name = "istVizeDataGridViewCheckBoxColumn";
      this.istVizeDataGridViewCheckBoxColumn.Width = 33;
      // 
      // istArchiviertDataGridViewCheckBoxColumn
      // 
      this.istArchiviertDataGridViewCheckBoxColumn.DataPropertyName = "IstArchiviert";
      this.istArchiviertDataGridViewCheckBoxColumn.HeaderText = "IstArchiviert";
      this.istArchiviertDataGridViewCheckBoxColumn.Name = "istArchiviertDataGridViewCheckBoxColumn";
      this.istArchiviertDataGridViewCheckBoxColumn.Visible = false;
      // 
      // Hauptfenster
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupNamen);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(800, 600);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(800, 600);
      this.Name = "Hauptfenster";
      this.Text = "Ringbuch";
      this.Load += new System.EventHandler(this.Hauptfenster_Load);
      this.groupNamen.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvNamen)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvErgebnisse)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupNamen;
    private System.Windows.Forms.DataGridView dgvNamen;
    private System.Windows.Forms.Button btnNamenSave;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dgvErgebnisse;
    private System.Windows.Forms.Button btnMaterialSave;
    private DatabaseDataSet databaseDataSet;
    private System.Windows.Forms.BindingSource personenBindingSource;
    private DatabaseDataSetTableAdapters.PersonenTableAdapter personenTableAdapter;
    private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn adressIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn zweitnameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn geburtstagDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn geschlechtDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn darfKKDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn darfLGDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn kleinkaliberIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn luftgewehrIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn handschuhIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn jackeIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn pistoleIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn istKoenigDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn istVizeDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn istArchiviertDataGridViewCheckBoxColumn;
  }
}

