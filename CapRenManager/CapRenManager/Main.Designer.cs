namespace CapRenManager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this._bSalesRegister = new System.Windows.Forms.Button();
            this._bSalesRecord = new System.Windows.Forms.Button();
            this._bInventary = new System.Windows.Forms.Button();
            this._tlpMainButtons = new System.Windows.Forms.TableLayoutPanel();
            this._tlpMainScreen = new System.Windows.Forms.TableLayoutPanel();
            this._ucSalesRegister1 = new CapRenManager.ucSalesRegister();
            this._tlpMainButtons.SuspendLayout();
            this._tlpMainScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bSalesRegister
            // 
            this._bSalesRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this._bSalesRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bSalesRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._bSalesRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bSalesRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._bSalesRegister.Image = ((System.Drawing.Image)(resources.GetObject("_bSalesRegister.Image")));
            this._bSalesRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._bSalesRegister.Location = new System.Drawing.Point(0, 222);
            this._bSalesRegister.Margin = new System.Windows.Forms.Padding(0);
            this._bSalesRegister.Name = "_bSalesRegister";
            this._bSalesRegister.Size = new System.Drawing.Size(290, 95);
            this._bSalesRegister.TabIndex = 1;
            this._bSalesRegister.Text = "Registrar Ventas";
            this._bSalesRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._bSalesRegister.UseVisualStyleBackColor = false;
            this._bSalesRegister.Click += new System.EventHandler(this._bSalesRegister_Click);
            // 
            // _bSalesRecord
            // 
            this._bSalesRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this._bSalesRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bSalesRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._bSalesRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this._bSalesRecord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._bSalesRecord.Image = ((System.Drawing.Image)(resources.GetObject("_bSalesRecord.Image")));
            this._bSalesRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._bSalesRecord.Location = new System.Drawing.Point(0, 317);
            this._bSalesRecord.Margin = new System.Windows.Forms.Padding(0);
            this._bSalesRecord.Name = "_bSalesRecord";
            this._bSalesRecord.Size = new System.Drawing.Size(290, 95);
            this._bSalesRecord.TabIndex = 2;
            this._bSalesRecord.Text = "Historial de Ventas";
            this._bSalesRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._bSalesRecord.UseVisualStyleBackColor = false;
            this._bSalesRecord.Click += new System.EventHandler(this._bSalesRecord_Click);
            // 
            // _bInventary
            // 
            this._bInventary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this._bInventary.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bInventary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._bInventary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this._bInventary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._bInventary.Image = ((System.Drawing.Image)(resources.GetObject("_bInventary.Image")));
            this._bInventary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._bInventary.Location = new System.Drawing.Point(0, 412);
            this._bInventary.Margin = new System.Windows.Forms.Padding(0);
            this._bInventary.Name = "_bInventary";
            this._bInventary.Size = new System.Drawing.Size(290, 95);
            this._bInventary.TabIndex = 3;
            this._bInventary.Text = "Inventario";
            this._bInventary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._bInventary.UseVisualStyleBackColor = false;
            this._bInventary.Click += new System.EventHandler(this._bInventary_Click);
            // 
            // _tlpMainButtons
            // 
            this._tlpMainButtons.ColumnCount = 1;
            this._tlpMainButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpMainButtons.Controls.Add(this._bInventary, 0, 3);
            this._tlpMainButtons.Controls.Add(this._bSalesRegister, 0, 1);
            this._tlpMainButtons.Controls.Add(this._bSalesRecord, 0, 2);
            this._tlpMainButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpMainButtons.Location = new System.Drawing.Point(3, 3);
            this._tlpMainButtons.Name = "_tlpMainButtons";
            this._tlpMainButtons.RowCount = 5;
            this._tlpMainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._tlpMainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpMainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpMainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpMainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tlpMainButtons.Size = new System.Drawing.Size(290, 635);
            this._tlpMainButtons.TabIndex = 1;
            // 
            // _tlpMainScreen
            // 
            this._tlpMainScreen.ColumnCount = 2;
            this._tlpMainScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tlpMainScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this._tlpMainScreen.Controls.Add(this._tlpMainButtons, 0, 0);
            this._tlpMainScreen.Controls.Add(this._ucSalesRegister1, 1, 0);
            this._tlpMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpMainScreen.Location = new System.Drawing.Point(0, 0);
            this._tlpMainScreen.Name = "_tlpMainScreen";
            this._tlpMainScreen.RowCount = 1;
            this._tlpMainScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpMainScreen.Size = new System.Drawing.Size(1184, 641);
            this._tlpMainScreen.TabIndex = 2;
            // 
            // _ucSalesRegister1
            // 
            this._ucSalesRegister1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this._ucSalesRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucSalesRegister1.Location = new System.Drawing.Point(299, 3);
            this._ucSalesRegister1.Name = "_ucSalesRegister1";
            this._ucSalesRegister1.Size = new System.Drawing.Size(882, 635);
            this._ucSalesRegister1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this._tlpMainScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivador";
            this.Load += new System.EventHandler(this.Main_Load);
            this._tlpMainButtons.ResumeLayout(false);
            this._tlpMainScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _bInventary;
        private System.Windows.Forms.Button _bSalesRecord;
        private System.Windows.Forms.Button _bSalesRegister;
        private System.Windows.Forms.TableLayoutPanel _tlpMainButtons;
        private System.Windows.Forms.TableLayoutPanel _tlpMainScreen;
        private ucSalesRegister _ucSalesRegister1;
    }
}

