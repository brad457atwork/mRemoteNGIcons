

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
			
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewIcons = new System.Windows.Forms.ListView();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tableLayoutPanelIconEdit = new System.Windows.Forms.TableLayoutPanel();
            this.lblIconName = new System.Windows.Forms.Label();
            this.txtIconName = new System.Windows.Forms.TextBox();
            this.lblIconImage = new System.Windows.Forms.Label();
            this.mrngPictureBox1 = new mRemoteNG.UI.Controls.MrngPictureBox(this.components);
            this.mrngBtnIconImageChange = new mRemoteNG.UI.Controls.MrngButton();
            this.tableLayoutPanelIconUpdate = new System.Windows.Forms.TableLayoutPanel();
            this.mrngBtnIconSave = new mRemoteNG.UI.Controls.MrngButton();
            this.mrngBtnIconAdd = new mRemoteNG.UI.Controls.MrngButton();
            this.mrngBtnIconDelete = new mRemoteNG.UI.Controls.MrngButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tableLayoutPanelIconEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mrngPictureBox1)).BeginInit();
            this.tableLayoutPanelIconUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.listViewIcons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelRight, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listViewIcons
            // 
            this.listViewIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.listViewIcons, 3);
            this.listViewIcons.HideSelection = false;
            this.listViewIcons.Location = new System.Drawing.Point(2, 2);
            this.listViewIcons.Margin = new System.Windows.Forms.Padding(2);
            this.listViewIcons.MultiSelect = false;
            this.listViewIcons.Name = "listViewIcons";
            this.listViewIcons.Size = new System.Drawing.Size(452, 488);
            this.listViewIcons.TabIndex = 1;
            this.listViewIcons.UseCompatibleStateImageBehavior = false;
            this.listViewIcons.View = System.Windows.Forms.View.List;
            this.listViewIcons.SelectedIndexChanged += new System.EventHandler(this.listViewIcons_SelectedIndexChanged);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.tableLayoutPanelIconEdit);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(459, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(148, 486);
            this.panelRight.TabIndex = 2;
            // 
            // tableLayoutPanelIconEdit
            // 
            this.tableLayoutPanelIconEdit.ColumnCount = 2;
            this.tableLayoutPanelIconEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanelIconEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanelIconEdit.Controls.Add(this.lblIconName, 0, 0);
            this.tableLayoutPanelIconEdit.Controls.Add(this.txtIconName, 0, 1);
            this.tableLayoutPanelIconEdit.Controls.Add(this.lblIconImage, 0, 2);
            this.tableLayoutPanelIconEdit.Controls.Add(this.mrngPictureBox1, 0, 3);
            this.tableLayoutPanelIconEdit.Controls.Add(this.mrngBtnIconImageChange, 1, 3);
            this.tableLayoutPanelIconEdit.Controls.Add(this.tableLayoutPanelIconUpdate, 0, 4);
            this.tableLayoutPanelIconEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelIconEdit.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelIconEdit.Name = "tableLayoutPanelIconEdit";
            this.tableLayoutPanelIconEdit.RowCount = 5;
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelIconEdit.Size = new System.Drawing.Size(148, 486);
            this.tableLayoutPanelIconEdit.TabIndex = 0;
            this.tableLayoutPanelIconEdit.Visible = false;
            // 
            // lblIconName
            // 
            this.lblIconName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconName.AutoSize = true;
            this.tableLayoutPanelIconEdit.SetColumnSpan(this.lblIconName, 2);
            this.lblIconName.Location = new System.Drawing.Point(3, 18);
            this.lblIconName.Name = "lblIconName";
            this.lblIconName.Size = new System.Drawing.Size(142, 13);
            this.lblIconName.TabIndex = 0;
            this.lblIconName.Text = "Icon Name";
            this.lblIconName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIconName
            // 
            this.txtIconName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelIconEdit.SetColumnSpan(this.txtIconName, 2);
            this.txtIconName.Location = new System.Drawing.Point(3, 64);
            this.txtIconName.Name = "txtIconName";
            this.txtIconName.Size = new System.Drawing.Size(139, 22);
            this.txtIconName.TabIndex = 1;
            // 
            // lblIconImage
            // 
            this.lblIconImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconImage.AutoSize = true;
            this.tableLayoutPanelIconEdit.SetColumnSpan(this.lblIconImage, 2);
            this.lblIconImage.Location = new System.Drawing.Point(3, 118);
            this.lblIconImage.Name = "lblIconImage";
            this.lblIconImage.Size = new System.Drawing.Size(142, 13);
            this.lblIconImage.TabIndex = 2;
            this.lblIconImage.Text = "Icon Image";
            this.lblIconImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mrngPictureBox1
            // 
            this.mrngPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrngPictureBox1.Location = new System.Drawing.Point(24, 162);
            this.mrngPictureBox1.Name = "mrngPictureBox1";
            this.mrngPictureBox1.Size = new System.Drawing.Size(26, 26);
            this.mrngPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mrngPictureBox1.TabIndex = 3;
            this.mrngPictureBox1.TabStop = false;
            // 
            // mrngBtnIconImageChange
            // 
            this.mrngBtnIconImageChange._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.mrngBtnIconImageChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrngBtnIconImageChange.Location = new System.Drawing.Point(83, 163);
            this.mrngBtnIconImageChange.Margin = new System.Windows.Forms.Padding(2);
            this.mrngBtnIconImageChange.Name = "mrngBtnIconImageChange";
            this.mrngBtnIconImageChange.Size = new System.Drawing.Size(55, 23);
            this.mrngBtnIconImageChange.TabIndex = 4;
            this.mrngBtnIconImageChange.Text = "Change";
            this.mrngBtnIconImageChange.UseVisualStyleBackColor = true;
            this.mrngBtnIconImageChange.Click += new System.EventHandler(this.mrngBtnIconImageChange_Click);
            // 
            // tableLayoutPanelIconUpdate
            // 
            this.tableLayoutPanelIconUpdate.ColumnCount = 2;
            this.tableLayoutPanelIconEdit.SetColumnSpan(this.tableLayoutPanelIconUpdate, 2);
            this.tableLayoutPanelIconUpdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanelIconUpdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanelIconUpdate.Controls.Add(this.mrngBtnIconSave, 0, 1);
            this.tableLayoutPanelIconUpdate.Controls.Add(this.mrngBtnIconAdd, 0, 0);
            this.tableLayoutPanelIconUpdate.Controls.Add(this.mrngBtnIconDelete, 0, 2);
            this.tableLayoutPanelIconUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelIconUpdate.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanelIconUpdate.Name = "tableLayoutPanelIconUpdate";
            this.tableLayoutPanelIconUpdate.RowCount = 4;
            this.tableLayoutPanelIconUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelIconUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelIconUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelIconUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelIconUpdate.Size = new System.Drawing.Size(142, 280);
            this.tableLayoutPanelIconUpdate.TabIndex = 7;
            this.tableLayoutPanelIconUpdate.Visible = false;
            // 
            // mrngBtnIconSave
            // 
            this.mrngBtnIconSave._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.mrngBtnIconSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelIconUpdate.SetColumnSpan(this.mrngBtnIconSave, 2);
            this.mrngBtnIconSave.Location = new System.Drawing.Point(24, 63);
            this.mrngBtnIconSave.Name = "mrngBtnIconSave";
            this.mrngBtnIconSave.Size = new System.Drawing.Size(93, 23);
            this.mrngBtnIconSave.TabIndex = 3;
            this.mrngBtnIconSave.Text = "Save Icon";
            this.mrngBtnIconSave.UseVisualStyleBackColor = true;
            this.mrngBtnIconSave.Click += new System.EventHandler(this.mrngBtnIconSave_Click_1);
            // 
            // mrngBtnIconAdd
            // 
            this.mrngBtnIconAdd._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.mrngBtnIconAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelIconUpdate.SetColumnSpan(this.mrngBtnIconAdd, 2);
            this.mrngBtnIconAdd.Location = new System.Drawing.Point(24, 13);
            this.mrngBtnIconAdd.Name = "mrngBtnIconAdd";
            this.mrngBtnIconAdd.Size = new System.Drawing.Size(93, 23);
            this.mrngBtnIconAdd.TabIndex = 5;
            this.mrngBtnIconAdd.Text = "Add New Icon";
            this.mrngBtnIconAdd.UseVisualStyleBackColor = true;
            this.mrngBtnIconAdd.Click += new System.EventHandler(this.mrngBtnIconAdd_Click);
            // 
            // mrngBtnIconDelete
            // 
            this.mrngBtnIconDelete._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.mrngBtnIconDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelIconUpdate.SetColumnSpan(this.mrngBtnIconDelete, 2);
            this.mrngBtnIconDelete.Location = new System.Drawing.Point(24, 113);
            this.mrngBtnIconDelete.Name = "mrngBtnIconDelete";
            this.mrngBtnIconDelete.Size = new System.Drawing.Size(93, 23);
            this.mrngBtnIconDelete.TabIndex = 6;
            this.mrngBtnIconDelete.Text = "Delete Icon";
            this.mrngBtnIconDelete.UseVisualStyleBackColor = true;
            // 
            // IconsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IconsPage";
            this.Size = new System.Drawing.Size(610, 490);
            this.Load += new System.EventHandler(this.IconsPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.tableLayoutPanelIconEdit.ResumeLayout(false);
            this.tableLayoutPanelIconEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mrngPictureBox1)).EndInit();
            this.tableLayoutPanelIconUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewIcons;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIconEdit;
        private System.Windows.Forms.Label lblIconName;
        private System.Windows.Forms.TextBox txtIconName;
        private System.Windows.Forms.Label lblIconImage;
        private MrngPictureBox mrngPictureBox1;
        private MrngButton mrngBtnIconImageChange;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIconUpdate;
        private MrngButton mrngBtnIconSave;
        private MrngButton mrngBtnIconAdd;
        private MrngButton mrngBtnIconDelete;
    }
}
