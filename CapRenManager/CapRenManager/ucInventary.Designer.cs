namespace CapRenManager
{
    partial class ucInventary
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._dgvInventary = new System.Windows.Forms.DataGridView();
            this._btnSearch = new System.Windows.Forms.Button();
            this._btnExport = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._cbType = new System.Windows.Forms.ComboBox();
            this._nudNewQuantity = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._btnAddNew = new System.Windows.Forms.Button();
            this._nudNewTypeQuantity = new System.Windows.Forms.NumericUpDown();
            this._tbNewType = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvInventary)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudNewQuantity)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudNewTypeQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._dgvInventary, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnSearch, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._btnExport, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 635);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _dgvInventary
            // 
            this._dgvInventary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvInventary.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvInventary.Location = new System.Drawing.Point(3, 3);
            this._dgvInventary.Name = "_dgvInventary";
            this.tableLayoutPanel1.SetRowSpan(this._dgvInventary, 4);
            this._dgvInventary.Size = new System.Drawing.Size(611, 629);
            this._dgvInventary.TabIndex = 0;
            // 
            // _btnSearch
            // 
            this._btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(240)))));
            this._btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnSearch.Location = new System.Drawing.Point(620, 383);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(259, 121);
            this._btnSearch.TabIndex = 1;
            this._btnSearch.Text = "Buscar";
            this._btnSearch.UseVisualStyleBackColor = false;
            // 
            // _btnExport
            // 
            this._btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(240)))));
            this._btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnExport.Location = new System.Drawing.Point(620, 510);
            this._btnExport.Name = "_btnExport";
            this._btnExport.Size = new System.Drawing.Size(259, 122);
            this._btnExport.TabIndex = 2;
            this._btnExport.Text = "Exportar";
            this._btnExport.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this._btnUpdate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this._cbType, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this._nudNewQuantity, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(620, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(259, 184);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnUpdate
            // 
            this.tableLayoutPanel2.SetColumnSpan(this._btnUpdate, 2);
            this._btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnUpdate.Location = new System.Drawing.Point(28, 111);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(200, 30);
            this._btnUpdate.TabIndex = 2;
            this._btnUpdate.Text = "Actualizar";
            this._btnUpdate.UseVisualStyleBackColor = true;
            // 
            // _cbType
            // 
            this._cbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbType.FormattingEnabled = true;
            this._cbType.Location = new System.Drawing.Point(131, 39);
            this._cbType.Name = "_cbType";
            this._cbType.Size = new System.Drawing.Size(97, 21);
            this._cbType.TabIndex = 3;
            // 
            // _nudNewQuantity
            // 
            this._nudNewQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nudNewQuantity.Location = new System.Drawing.Point(131, 75);
            this._nudNewQuantity.Name = "_nudNewQuantity";
            this._nudNewQuantity.Size = new System.Drawing.Size(97, 20);
            this._nudNewQuantity.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this._btnAddNew, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this._nudNewTypeQuantity, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this._tbNewType, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(620, 193);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(259, 184);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnAddNew
            // 
            this.tableLayoutPanel3.SetColumnSpan(this._btnAddNew, 2);
            this._btnAddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnAddNew.Location = new System.Drawing.Point(28, 111);
            this._btnAddNew.Name = "_btnAddNew";
            this._btnAddNew.Size = new System.Drawing.Size(200, 30);
            this._btnAddNew.TabIndex = 2;
            this._btnAddNew.Text = "Añadir Nuevo";
            this._btnAddNew.UseVisualStyleBackColor = true;
            // 
            // _nudNewTypeQuantity
            // 
            this._nudNewTypeQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nudNewTypeQuantity.Location = new System.Drawing.Point(131, 75);
            this._nudNewTypeQuantity.Name = "_nudNewTypeQuantity";
            this._nudNewTypeQuantity.Size = new System.Drawing.Size(97, 20);
            this._nudNewTypeQuantity.TabIndex = 4;
            // 
            // _tbNewType
            // 
            this._tbNewType.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbNewType.Location = new System.Drawing.Point(131, 39);
            this._tbNewType.Name = "_tbNewType";
            this._tbNewType.Size = new System.Drawing.Size(97, 20);
            this._tbNewType.TabIndex = 5;
            // 
            // ucInventary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucInventary";
            this.Size = new System.Drawing.Size(882, 635);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvInventary)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudNewQuantity)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudNewTypeQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView _dgvInventary;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.Button _btnExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.ComboBox _cbType;
        private System.Windows.Forms.NumericUpDown _nudNewQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnAddNew;
        private System.Windows.Forms.NumericUpDown _nudNewTypeQuantity;
        private System.Windows.Forms.TextBox _tbNewType;
    }
}
