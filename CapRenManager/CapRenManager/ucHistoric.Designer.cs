namespace CapRenManager
{
    partial class ucHistoric
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tlpHistoric = new System.Windows.Forms.TableLayoutPanel();
            this._bSearchByFilters = new System.Windows.Forms.Button();
            this._bExportData = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._cbMonth = new System.Windows.Forms.ComboBox();
            this._lblDateFilter = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._chkServiceType = new System.Windows.Forms.CheckBox();
            this._cbServiceType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._chkCoffinType = new System.Windows.Forms.CheckBox();
            this._cbCoffinType = new System.Windows.Forms.ComboBox();
            this._dgvHistoric = new System.Windows.Forms.DataGridView();
            this._tlpHistoric.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvHistoric)).BeginInit();
            this.SuspendLayout();
            // 
            // _tlpHistoric
            // 
            this._tlpHistoric.ColumnCount = 2;
            this._tlpHistoric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._tlpHistoric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._tlpHistoric.Controls.Add(this._bSearchByFilters, 1, 3);
            this._tlpHistoric.Controls.Add(this._bExportData, 1, 4);
            this._tlpHistoric.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this._tlpHistoric.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this._tlpHistoric.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this._tlpHistoric.Controls.Add(this._dgvHistoric, 0, 0);
            this._tlpHistoric.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpHistoric.Location = new System.Drawing.Point(0, 0);
            this._tlpHistoric.Name = "_tlpHistoric";
            this._tlpHistoric.RowCount = 5;
            this._tlpHistoric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tlpHistoric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tlpHistoric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tlpHistoric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tlpHistoric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tlpHistoric.Size = new System.Drawing.Size(882, 635);
            this._tlpHistoric.TabIndex = 0;
            // 
            // _bSearchByFilters
            // 
            this._bSearchByFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(240)))));
            this._bSearchByFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bSearchByFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bSearchByFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bSearchByFilters.ForeColor = System.Drawing.Color.AliceBlue;
            this._bSearchByFilters.Location = new System.Drawing.Point(620, 384);
            this._bSearchByFilters.Name = "_bSearchByFilters";
            this._bSearchByFilters.Size = new System.Drawing.Size(259, 121);
            this._bSearchByFilters.TabIndex = 0;
            this._bSearchByFilters.Text = "Buscar";
            this._bSearchByFilters.UseVisualStyleBackColor = false;
            this._bSearchByFilters.Click += new System.EventHandler(this._bSearchByFilters_Click);
            // 
            // _bExportData
            // 
            this._bExportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(240)))));
            this._bExportData.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bExportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bExportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bExportData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._bExportData.Location = new System.Drawing.Point(620, 511);
            this._bExportData.Name = "_bExportData";
            this._bExportData.Size = new System.Drawing.Size(259, 121);
            this._bExportData.TabIndex = 1;
            this._bExportData.Text = "Exportar Busqueda";
            this._bExportData.UseVisualStyleBackColor = false;
            this._bExportData.Click += new System.EventHandler(this._bExportData_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this._cbMonth, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._lblDateFilter, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(620, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 121);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // _cbMonth
            // 
            this._cbMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbMonth.FormattingEnabled = true;
            this._cbMonth.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this._cbMonth.Location = new System.Drawing.Point(54, 75);
            this._cbMonth.Name = "_cbMonth";
            this._cbMonth.Size = new System.Drawing.Size(149, 21);
            this._cbMonth.TabIndex = 1;
            // 
            // _lblDateFilter
            // 
            this._lblDateFilter.AutoSize = true;
            this._lblDateFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDateFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._lblDateFilter.Location = new System.Drawing.Point(54, 24);
            this._lblDateFilter.Name = "_lblDateFilter";
            this._lblDateFilter.Size = new System.Drawing.Size(149, 24);
            this._lblDateFilter.TabIndex = 2;
            this._lblDateFilter.Text = "Filtrar por Mes";
            this._lblDateFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this._chkServiceType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this._cbServiceType, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(620, 130);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(259, 121);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // _chkServiceType
            // 
            this._chkServiceType.AutoSize = true;
            this._chkServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chkServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkServiceType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._chkServiceType.Location = new System.Drawing.Point(54, 27);
            this._chkServiceType.Name = "_chkServiceType";
            this._chkServiceType.Size = new System.Drawing.Size(149, 18);
            this._chkServiceType.TabIndex = 0;
            this._chkServiceType.Text = "Filtrar por Servicio";
            this._chkServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._chkServiceType.UseVisualStyleBackColor = true;
            this._chkServiceType.CheckedChanged += new System.EventHandler(this._chkServiceType_CheckedChanged);
            // 
            // _cbServiceType
            // 
            this._cbServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbServiceType.Enabled = false;
            this._cbServiceType.FormattingEnabled = true;
            this._cbServiceType.Location = new System.Drawing.Point(54, 75);
            this._cbServiceType.Name = "_cbServiceType";
            this._cbServiceType.Size = new System.Drawing.Size(149, 21);
            this._cbServiceType.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this._chkCoffinType, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this._cbCoffinType, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(620, 257);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(259, 121);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // _chkCoffinType
            // 
            this._chkCoffinType.AutoSize = true;
            this._chkCoffinType.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chkCoffinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkCoffinType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._chkCoffinType.Location = new System.Drawing.Point(54, 27);
            this._chkCoffinType.Name = "_chkCoffinType";
            this._chkCoffinType.Size = new System.Drawing.Size(149, 18);
            this._chkCoffinType.TabIndex = 0;
            this._chkCoffinType.Text = "Filtrar por Ataud";
            this._chkCoffinType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._chkCoffinType.UseVisualStyleBackColor = true;
            this._chkCoffinType.CheckedChanged += new System.EventHandler(this._chkCoffinType_CheckedChanged);
            // 
            // _cbCoffinType
            // 
            this._cbCoffinType.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbCoffinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbCoffinType.Enabled = false;
            this._cbCoffinType.FormattingEnabled = true;
            this._cbCoffinType.Location = new System.Drawing.Point(54, 75);
            this._cbCoffinType.Name = "_cbCoffinType";
            this._cbCoffinType.Size = new System.Drawing.Size(149, 21);
            this._cbCoffinType.TabIndex = 1;
            // 
            // _dgvHistoric
            // 
            this._dgvHistoric.AllowUserToAddRows = false;
            this._dgvHistoric.AllowUserToDeleteRows = false;
            this._dgvHistoric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvHistoric.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvHistoric.Location = new System.Drawing.Point(3, 3);
            this._dgvHistoric.Name = "_dgvHistoric";
            this._dgvHistoric.ReadOnly = true;
            this._tlpHistoric.SetRowSpan(this._dgvHistoric, 5);
            this._dgvHistoric.Size = new System.Drawing.Size(611, 629);
            this._dgvHistoric.TabIndex = 6;
            // 
            // ucHistoric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.Controls.Add(this._tlpHistoric);
            this.Name = "ucHistoric";
            this.Size = new System.Drawing.Size(882, 635);
            this.Load += new System.EventHandler(this.ucHistoric_Load);
            this._tlpHistoric.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvHistoric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tlpHistoric;
        private System.Windows.Forms.Button _bSearchByFilters;
        private System.Windows.Forms.Button _bExportData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox _chkServiceType;
        private System.Windows.Forms.ComboBox _cbServiceType;
        private System.Windows.Forms.CheckBox _chkCoffinType;
        private System.Windows.Forms.ComboBox _cbCoffinType;
        private System.Windows.Forms.ComboBox _cbMonth;
        private System.Windows.Forms.DataGridView _dgvHistoric;
        private System.Windows.Forms.Label _lblDateFilter;
    }
}
