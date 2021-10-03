

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
            this.PBIcon = new mRemoteNG.UI.Controls.MrngPictureBox(this.components);
            this.mrngBtnIconImageChange = new mRemoteNG.UI.Controls.MrngButton();
            this.tableLayoutPanelIconUpdate = new System.Windows.Forms.TableLayoutPanel();
            this.mrngBtnIconAdd = new mRemoteNG.UI.Controls.MrngButton();
            this.ButtonIconDelete = new mRemoteNG.UI.Controls.MrngButton();
            this.mrngBtnIconSave = new mRemoteNG.UI.Controls.MrngButton();
            this.tableLayoutPanelOpenIconsDir = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonOpenIconsDir = new mRemoteNG.UI.Controls.MrngButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tableLayoutPanelIconEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.tableLayoutPanelIconUpdate.SuspendLayout();
            this.tableLayoutPanelOpenIconsDir.SuspendLayout();
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
            this.panelRight.Controls.Add(this.tableLayoutPanelOpenIconsDir);
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
            this.tableLayoutPanelIconEdit.Controls.Add(this.tableLayoutPanelIconUpdate, 0, 4);
            this.tableLayoutPanelIconEdit.Controls.Add(this.PBIcon, 1, 2);
            this.tableLayoutPanelIconEdit.Controls.Add(this.mrngBtnIconImageChange, 0, 3);
            this.tableLayoutPanelIconEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelIconEdit.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelIconEdit.Name = "tableLayoutPanelIconEdit";
            this.tableLayoutPanelIconEdit.RowCount = 5;
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelIconEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelIconEdit.Size = new System.Drawing.Size(148, 428);
            this.tableLayoutPanelIconEdit.TabIndex = 0;
            this.tableLayoutPanelIconEdit.Visible = false;
            // 
            // lblIconName
            // 
            this.lblIconName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconName.AutoSize = true;
            this.tableLayoutPanelIconEdit.SetColumnSpan(this.lblIconName, 2);
            this.lblIconName.Location = new System.Drawing.Point(3, 23);
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
            this.txtIconName.Location = new System.Drawing.Point(3, 77);
            this.txtIconName.Name = "txtIconName";
            this.txtIconName.Size = new System.Drawing.Size(139, 22);
            this.txtIconName.TabIndex = 1;
            // 
            // lblIconImage
            // 
            this.lblIconImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconImage.AutoSize = true;
            this.lblIconImage.Location = new System.Drawing.Point(3, 141);
            this.lblIconImage.Name = "lblIconImage";
            this.lblIconImage.Size = new System.Drawing.Size(68, 13);
            this.lblIconImage.TabIndex = 2;
            this.lblIconImage.Text = "Icon Image";
            this.lblIconImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBIcon
            // 
            this.PBIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBIcon.Location = new System.Drawing.Point(98, 134);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(26, 26);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBIcon.TabIndex = 3;
            this.PBIcon.TabStop = false;
            // 
            // mrngBtnIconImageChange
            // 
            this.mrngBtnIconImageChange._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.mrngBtnIconImageChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelIconEdit.SetColumnSpan(this.mrngBtnIconImageChange, 2);
            this.mrngBtnIconImageChange.Location = new System.Drawing.Point(24, 195);
            this.mrngBtnIconImageChange.Margin = new System.Windows.Forms.Padding(2);
            this.mrngBtnIconImageChange.Name = "mrngBtnIconImageChange";
            this.mrngBtnIconImageChange.Size = new System.Drawing.Size(100, 23);
            this.mrngBtnIconImageChange.TabIndex = 4;
            this.mrngBtnIconImageChange.Text = "Change Image";
            this.mrngBtnIconImageChange.UseVisualStyleBackColor = true;
            this.mrngBtnIconImageChange.Click += new System.EventHandler(this.mrngBtnIconImageChange_Click);
            // 
            // tableLayoutPanelIconUpdate
            // 
            this.tableLayoutPanelIconUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelIconUpdate.ColumnCount = 2;
            this.tableLayoutPanelIconEdit.SetColumnSpan(this.tableLayoutPanelIconUpdate, 2);
            this.tableLayoutPanelIconUpdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanelIconUpdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanelIconUpdate.Controls.Add(this.mrngBtnIconAdd, 0, 2);
            this.tableLayoutPanelIconUpdate.Controls.Add(this.ButtonIconDelete, 0, 1);
            this.tableLayoutPanelIconUpdate.Controls.Add(this.mrngBtnIconSave, 0, 0);
            this.tableLayoutPanelIconUpdate.Location = new System.Drawing.Point(3, 243);
            this.tableLayoutPanelIconUpdate.Name = "tableLayoutPanelIconUpdate";
            this.tableLayoutPanelIconUpdate.RowCount = 3;
            this.tableLayoutPanelIconUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelIconUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelIconUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelIconUpdate.Size = new System.Drawing.Size(142, 177);
            this.tableLayoutPanelIconUpdate.TabIndex = 7;
            this.tableLayoutPanelIconUpdate.Visible = false;
            // 
            // mrngBtnIconAdd
            // 
            this.mrngBtnIconAdd._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.mrngBtnIconAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelIconUpdate.SetColumnSpan(this.mrngBtnIconAdd, 2);
            this.mrngBtnIconAdd.Location = new System.Drawing.Point(21, 136);
            this.mrngBtnIconAdd.Name = "mrngBtnIconAdd";
            this.mrngBtnIconAdd.Size = new System.Drawing.Size(100, 23);
            this.mrngBtnIconAdd.TabIndex = 5;
            this.mrngBtnIconAdd.Text = "Add New Icon";
            this.mrngBtnIconAdd.UseVisualStyleBackColor = true;
            this.mrngBtnIconAdd.Click += new System.EventHandler(this.mrngBtnIconAdd_Click);
            // 
            // ButtonIconDelete
            // 
            this.ButtonIconDelete._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.ButtonIconDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelIconUpdate.SetColumnSpan(this.ButtonIconDelete, 2);
            this.ButtonIconDelete.Location = new System.Drawing.Point(21, 77);
            this.ButtonIconDelete.Name = "ButtonIconDelete";
            this.ButtonIconDelete.Size = new System.Drawing.Size(100, 23);
            this.ButtonIconDelete.TabIndex = 6;
            this.ButtonIconDelete.Text = "Delete Icon";
            this.ButtonIconDelete.UseVisualStyleBackColor = true;
            // 
            // mrngBtnIconSave
            // 
            this.mrngBtnIconSave._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.mrngBtnIconSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelIconUpdate.SetColumnSpan(this.mrngBtnIconSave, 2);
            this.mrngBtnIconSave.Location = new System.Drawing.Point(21, 18);
            this.mrngBtnIconSave.Name = "mrngBtnIconSave";
            this.mrngBtnIconSave.Size = new System.Drawing.Size(100, 23);
            this.mrngBtnIconSave.TabIndex = 3;
            this.mrngBtnIconSave.Text = "Save Icon";
            this.mrngBtnIconSave.UseVisualStyleBackColor = true;
            this.mrngBtnIconSave.Click += new System.EventHandler(this.mrngBtnIconSave_Click_1);
            // 
            // tableLayoutPanelOpenIconsDir
            // 
            this.tableLayoutPanelOpenIconsDir.ColumnCount = 1;
            this.tableLayoutPanelOpenIconsDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelOpenIconsDir.Controls.Add(this.ButtonOpenIconsDir, 0, 0);
            this.tableLayoutPanelOpenIconsDir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelOpenIconsDir.Location = new System.Drawing.Point(0, 426);
            this.tableLayoutPanelOpenIconsDir.Name = "tableLayoutPanelOpenIconsDir";
            this.tableLayoutPanelOpenIconsDir.RowCount = 1;
            this.tableLayoutPanelOpenIconsDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOpenIconsDir.Size = new System.Drawing.Size(148, 60);
            this.tableLayoutPanelOpenIconsDir.TabIndex = 9;
            // 
            // ButtonOpenIconsDir
            // 
            this.ButtonOpenIconsDir._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.OUT;
            this.ButtonOpenIconsDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonOpenIconsDir.Location = new System.Drawing.Point(24, 18);
            this.ButtonOpenIconsDir.Name = "ButtonOpenIconsDir";
            this.ButtonOpenIconsDir.Size = new System.Drawing.Size(100, 23);
            this.ButtonOpenIconsDir.TabIndex = 7;
            this.ButtonOpenIconsDir.Text = "Open Icons Dir";
            this.ButtonOpenIconsDir.UseVisualStyleBackColor = true;
            this.ButtonOpenIconsDir.Click += new System.EventHandler(this.mrngOpenIconsDir_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.tableLayoutPanelIconUpdate.ResumeLayout(false);
            this.tableLayoutPanelOpenIconsDir.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewIcons;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIconEdit;
        private System.Windows.Forms.Label lblIconName;
        private System.Windows.Forms.TextBox txtIconName;
        private System.Windows.Forms.Label lblIconImage;
        private MrngPictureBox PBIcon;
        private MrngButton mrngBtnIconImageChange;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIconUpdate;
        private MrngButton mrngBtnIconSave;
        private MrngButton mrngBtnIconAdd;
        private MrngButton ButtonIconDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOpenIconsDir;
        private MrngButton ButtonOpenIconsDir;
    }
}
