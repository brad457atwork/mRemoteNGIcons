﻿

using mRemoteNG.UI.Controls;

namespace mRemoteNG.UI.Forms.OptionsPages
{
	
    public sealed partial class IconsPage : OptionsPage
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
		[System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
		{
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listIcons = new mRemoteNG.UI.Controls.MrngListView();
            this.IconIndexCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.IconNameCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.IconImageCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listIcons)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listIcons, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.65306F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.346939F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 612);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listIcons
            // 
            this.listIcons.AllColumns.Add(this.IconIndexCol);
            this.listIcons.AllColumns.Add(this.IconNameCol);
            this.listIcons.AllColumns.Add(this.IconImageCol);
            this.listIcons.CellEditUseWholeCell = false;
            this.listIcons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IconIndexCol,
            this.IconNameCol,
            this.IconImageCol});
            this.listIcons.Cursor = System.Windows.Forms.Cursors.Default;
            this.listIcons.DecorateLines = true;
            this.listIcons.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listIcons.HideSelection = false;
            this.listIcons.Location = new System.Drawing.Point(4, 4);
            this.listIcons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listIcons.Name = "listIcons";
            this.listIcons.Size = new System.Drawing.Size(754, 558);
            this.listIcons.TabIndex = 0;
            this.listIcons.UseCompatibleStateImageBehavior = false;
            this.listIcons.View = System.Windows.Forms.View.Details;
            // 
            // IconIndexCol
            // 
            this.IconIndexCol.AspectName = "IconIndexCol";
            this.IconIndexCol.Hideable = false;
            this.IconIndexCol.IsVisible = false;
            this.IconIndexCol.Text = "Icon Index";
            this.IconIndexCol.Width = 127;
            // 
            // IconNameCol
            // 
            this.IconNameCol.AspectName = "IconNameCol";
            this.IconNameCol.Text = "Icon Name";
            // 
            // IconImageCol
            // 
            this.IconImageCol.AspectName = "IconImageCol";
            this.IconImageCol.Text = "Icon Image";
            this.IconImageCol.Width = 100;
            // 
            // IconsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "IconsPage";
            this.Size = new System.Drawing.Size(762, 612);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listIcons)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MrngListView listIcons;
        private BrightIdeasSoftware.OLVColumn IconIndexCol;
        private BrightIdeasSoftware.OLVColumn IconImageCol;
        private BrightIdeasSoftware.OLVColumn IconNameCol;
    }
}
