

using mRemoteNG.UI.Controls;

namespace mRemoteNG.UI.Forms.OptionsPages
{
	
    public sealed partial class ThemePage : OptionsPage
	{
			
		//UserControl overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
			
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
			
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.btnThemeDelete = new mRemoteNG.UI.Controls.MrngButton();
            this.btnThemeNew = new mRemoteNG.UI.Controls.MrngButton();
            this.cboTheme = new mRemoteNG.UI.Controls.MrngComboBox();
            this.listPalette = new mRemoteNG.UI.Controls.MrngListView();
            this.keyCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ColorCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ColorNameCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.labelRestart = new mRemoteNG.UI.Controls.MrngLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.listPalette)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemeDelete
            // 
            this.btnThemeDelete._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.btnThemeDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemeDelete.Location = new System.Drawing.Point(633, 4);
            this.btnThemeDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemeDelete.Name = "btnThemeDelete";
            this.btnThemeDelete.Size = new System.Drawing.Size(117, 31);
            this.btnThemeDelete.TabIndex = 2;
            this.btnThemeDelete.Text = "&Delete";
            this.btnThemeDelete.UseVisualStyleBackColor = true;
            this.btnThemeDelete.Click += new System.EventHandler(this.btnThemeDelete_Click);
            // 
            // btnThemeNew
            // 
            this.btnThemeNew._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.btnThemeNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemeNew.Location = new System.Drawing.Point(508, 4);
            this.btnThemeNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemeNew.Name = "btnThemeNew";
            this.btnThemeNew.Size = new System.Drawing.Size(117, 31);
            this.btnThemeNew.TabIndex = 1;
            this.btnThemeNew.Text = "&New";
            this.btnThemeNew.UseVisualStyleBackColor = true;
            this.btnThemeNew.Click += new System.EventHandler(this.btnThemeNew_Click);
            // 
            // cboTheme
            // 
            this.cboTheme._mice = mRemoteNG.UI.Controls.MrngComboBox.MouseState.HOVER;
            this.cboTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Location = new System.Drawing.Point(4, 4);
            this.cboTheme.Margin = new System.Windows.Forms.Padding(4);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(496, 27);
            this.cboTheme.TabIndex = 0;
            this.cboTheme.SelectionChangeCommitted += new System.EventHandler(this.cboTheme_SelectionChangeCommitted);
            // 
            // listPalette
            // 
            this.listPalette.AllColumns.Add(this.keyCol);
            this.listPalette.AllColumns.Add(this.ColorCol);
            this.listPalette.AllColumns.Add(this.ColorNameCol);
            this.listPalette.CellEditUseWholeCell = false;
            this.listPalette.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.keyCol,
            this.ColorCol,
            this.ColorNameCol});
            this.listPalette.Cursor = System.Windows.Forms.Cursors.Default;
            this.listPalette.DecorateLines = true;
            this.listPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPalette.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPalette.HideSelection = false;
            this.listPalette.Location = new System.Drawing.Point(4, 46);
            this.listPalette.Margin = new System.Windows.Forms.Padding(4);
            this.listPalette.Name = "listPalette";
            this.listPalette.ShowGroups = false;
            this.listPalette.Size = new System.Drawing.Size(754, 520);
            this.listPalette.TabIndex = 3;
            this.listPalette.UseCellFormatEvents = true;
            this.listPalette.UseCompatibleStateImageBehavior = false;
            this.listPalette.View = System.Windows.Forms.View.Details;
            this.listPalette.SelectedIndexChanged += new System.EventHandler(this.listPalette_SelectedIndexChanged);
            // 
            // keyCol
            // 
            this.keyCol.AspectName = "Key";
            this.keyCol.IsEditable = false;
            this.keyCol.Text = "Element";
            this.keyCol.Width = 262;
            // 
            // ColorCol
            // 
            this.ColorCol.Sortable = false;
            this.ColorCol.Text = "Color";
            this.ColorCol.Width = 45;
            // 
            // ColorNameCol
            // 
            this.ColorNameCol.AspectName = "Value";
            this.ColorNameCol.Sortable = false;
            this.ColorNameCol.Text = "Color Name";
            this.ColorNameCol.Width = 265;
            // 
            // labelRestart
            // 
            this.labelRestart.AutoSize = true;
            this.labelRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRestart.Location = new System.Drawing.Point(4, 0);
            this.labelRestart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(746, 34);
            this.labelRestart.TabIndex = 4;
            this.labelRestart.Text = "Warning: Restart is required...";
            this.labelRestart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Controls.Add(this.cboTheme, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThemeNew, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnThemeDelete, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 34);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Controls.Add(this.labelRestart, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 574);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(754, 34);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpMain.Controls.Add(this.listPalette, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpMain.Size = new System.Drawing.Size(762, 612);
            this.tlpMain.TabIndex = 8;
            // 
            // ThemePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ThemePage";
            this.Size = new System.Drawing.Size(762, 612);
            ((System.ComponentModel.ISupportInitialize)(this.listPalette)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		internal MrngButton btnThemeDelete;
		internal MrngButton btnThemeNew;
		internal MrngComboBox cboTheme;
        private Controls.MrngListView listPalette;
        private Controls.MrngLabel labelRestart;
        private BrightIdeasSoftware.OLVColumn keyCol;
        private BrightIdeasSoftware.OLVColumn ColorCol;
        private BrightIdeasSoftware.OLVColumn ColorNameCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
    }
}
