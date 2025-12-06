using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QLKhoaHocONL
{
    partial class frmXMLData
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelControls = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReadXml = new Guna.UI2.WinForms.Guna2Button();
            this.btnSyncSelected = new Guna.UI2.WinForms.Guna2Button();
            this.btnSyncAll = new Guna.UI2.WinForms.Guna2Button();
            this.cboLoaiDuLieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLoaiDuLieu = new System.Windows.Forms.Label();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.grpTree = new Guna.UI2.WinForms.Guna2GroupBox();
            this.treeXML = new System.Windows.Forms.TreeView();
            this.grpContent = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtXMLContent = new System.Windows.Forms.TextBox();
            this.elipseBorder = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelTop.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpTree.SuspendLayout();
            this.grpContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1320, 60);
            this.panelTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 8;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1161, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕ Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(404, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đồng Bộ Dữ Liệu (XML ↔ SQL)";
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.White;
            this.panelControls.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControls.BorderRadius = 10;
            this.panelControls.BorderThickness = 1;
            this.panelControls.Controls.Add(this.btnReadXml);
            this.panelControls.Controls.Add(this.btnSyncSelected);
            this.panelControls.Controls.Add(this.btnSyncAll);
            this.panelControls.Controls.Add(this.cboLoaiDuLieu);
            this.panelControls.Controls.Add(this.lblLoaiDuLieu);
            this.panelControls.Location = new System.Drawing.Point(20, 75);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(15);
            this.panelControls.Size = new System.Drawing.Size(1280, 85);
            this.panelControls.TabIndex = 1;
            // 
            // btnReadXml
            // 
            this.btnReadXml.BorderRadius = 8;
            this.btnReadXml.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReadXml.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReadXml.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReadXml.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReadXml.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReadXml.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReadXml.ForeColor = System.Drawing.Color.White;
            this.btnReadXml.Location = new System.Drawing.Point(1085, 22);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(180, 40);
            this.btnReadXml.TabIndex = 4;
            this.btnReadXml.Text = "🔄 Làm Mới";
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // btnSyncSelected
            // 
            this.btnSyncSelected.BorderRadius = 8;
            this.btnSyncSelected.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSyncSelected.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSyncSelected.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSyncSelected.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSyncSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSyncSelected.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSyncSelected.ForeColor = System.Drawing.Color.White;
            this.btnSyncSelected.Location = new System.Drawing.Point(750, 22);
            this.btnSyncSelected.Name = "btnSyncSelected";
            this.btnSyncSelected.Size = new System.Drawing.Size(306, 40);
            this.btnSyncSelected.TabIndex = 3;
            this.btnSyncSelected.Text = "📤 Đồng Bộ XML → SQL";
            this.btnSyncSelected.Click += new System.EventHandler(this.btnSyncSelected_Click);
            // 
            // btnSyncAll
            // 
            this.btnSyncAll.BorderRadius = 8;
            this.btnSyncAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSyncAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSyncAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSyncAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSyncAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSyncAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSyncAll.ForeColor = System.Drawing.Color.White;
            this.btnSyncAll.Location = new System.Drawing.Point(424, 22);
            this.btnSyncAll.Name = "btnSyncAll";
            this.btnSyncAll.Size = new System.Drawing.Size(299, 40);
            this.btnSyncAll.TabIndex = 2;
            this.btnSyncAll.Text = "⚡ Đồng Bộ SQL → XML";
            this.btnSyncAll.Click += new System.EventHandler(this.btnSyncAll_Click);
            // 
            // cboLoaiDuLieu
            // 
            this.cboLoaiDuLieu.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiDuLieu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.cboLoaiDuLieu.BorderRadius = 8;
            this.cboLoaiDuLieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiDuLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiDuLieu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cboLoaiDuLieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cboLoaiDuLieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiDuLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cboLoaiDuLieu.ItemHeight = 30;
            this.cboLoaiDuLieu.Items.AddRange(new object[] {
            "Khóa Học",
            "Học Viên",
            "Giảng Viên",
            "Tất Cả"});
            this.cboLoaiDuLieu.Location = new System.Drawing.Point(134, 22);
            this.cboLoaiDuLieu.Name = "cboLoaiDuLieu";
            this.cboLoaiDuLieu.Size = new System.Drawing.Size(220, 36);
            this.cboLoaiDuLieu.TabIndex = 1;
            // 
            // lblLoaiDuLieu
            // 
            this.lblLoaiDuLieu.AutoSize = true;
            this.lblLoaiDuLieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoaiDuLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblLoaiDuLieu.Location = new System.Drawing.Point(18, 28);
            this.lblLoaiDuLieu.Name = "lblLoaiDuLieu";
            this.lblLoaiDuLieu.Size = new System.Drawing.Size(101, 23);
            this.lblLoaiDuLieu.TabIndex = 0;
            this.lblLoaiDuLieu.Text = "Đối Tượng:";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Controls.Add(this.splitContainer);
            this.panelContent.Location = new System.Drawing.Point(20, 175);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1280, 550);
            this.panelContent.TabIndex = 2;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.grpTree);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.grpContent);
            this.splitContainer.Size = new System.Drawing.Size(1280, 550);
            this.splitContainer.SplitterDistance = 420;
            this.splitContainer.TabIndex = 0;
            // 
            // grpTree
            // 
            this.grpTree.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpTree.BorderRadius = 10;
            this.grpTree.Controls.Add(this.treeXML);
            this.grpTree.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTree.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTree.ForeColor = System.Drawing.Color.White;
            this.grpTree.Location = new System.Drawing.Point(0, 0);
            this.grpTree.Name = "grpTree";
            this.grpTree.Size = new System.Drawing.Size(420, 550);
            this.grpTree.TabIndex = 0;
            this.grpTree.Text = "📁 Cấu Trúc XML";
            this.grpTree.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // treeXML
            // 
            this.treeXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.treeXML.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeXML.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.treeXML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.treeXML.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.treeXML.Location = new System.Drawing.Point(15, 55);
            this.treeXML.Name = "treeXML";
            this.treeXML.Size = new System.Drawing.Size(390, 480);
            this.treeXML.TabIndex = 0;
            // 
            // grpContent
            // 
            this.grpContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpContent.BorderRadius = 10;
            this.grpContent.Controls.Add(this.txtXMLContent);
            this.grpContent.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContent.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContent.ForeColor = System.Drawing.Color.White;
            this.grpContent.Location = new System.Drawing.Point(0, 0);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(856, 550);
            this.grpContent.TabIndex = 0;
            this.grpContent.Text = "📄 Nội Dung XML";
            this.grpContent.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtXMLContent
            // 
            this.txtXMLContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXMLContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtXMLContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXMLContent.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtXMLContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtXMLContent.Location = new System.Drawing.Point(15, 55);
            this.txtXMLContent.Multiline = true;
            this.txtXMLContent.Name = "txtXMLContent";
            this.txtXMLContent.ReadOnly = true;
            this.txtXMLContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXMLContent.Size = new System.Drawing.Size(826, 480);
            this.txtXMLContent.TabIndex = 0;
            this.txtXMLContent.WordWrap = false;
            // 
            // elipseBorder
            // 
            this.elipseBorder.BorderRadius = 15;
            this.elipseBorder.TargetControl = this;
            // 
            // frmXMLData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1320, 750);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXMLData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý XML";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.grpTree.ResumeLayout(false);
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Panel panelTop;
        private Label lblTitle;
        private Guna2Button btnClose;
        private Guna2Panel panelControls;
        private Label lblLoaiDuLieu;
        private Guna2ComboBox cboLoaiDuLieu;
        private Guna2Button btnSyncAll;
        private Guna2Button btnSyncSelected;
        private Guna2Button btnReadXml;
        private Guna2Panel panelContent;
        private SplitContainer splitContainer;
        private Guna2GroupBox grpTree;
        private TreeView treeXML;
        private Guna2GroupBox grpContent;
        private TextBox txtXMLContent;
        private Guna2Elipse elipseBorder;
    }
}