namespace QLKhoaHocONL
{
    partial class frmXMLData
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
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXSLT = new System.Windows.Forms.Button();
            this.btnXPath = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnXoaNode = new System.Windows.Forms.Button();
            this.btnSuaNode = new System.Windows.Forms.Button();
            this.btnThemNode = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.grpContent = new System.Windows.Forms.GroupBox();
            this.txtXMLContent = new System.Windows.Forms.TextBox();
            this.grpTree = new System.Windows.Forms.GroupBox();
            this.treeXML = new System.Windows.Forms.TreeView();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.btnGhiXML = new System.Windows.Forms.Button();
            this.btnDocXML = new System.Windows.Forms.Button();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.cboLoaiDuLieu = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.grpChucNang.SuspendLayout();
            this.grpContent.SuspendLayout();
            this.grpTree.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Controls.Add(this.btnXSLT);
            this.grpChucNang.Controls.Add(this.btnXPath);
            this.grpChucNang.Controls.Add(this.btnValidate);
            this.grpChucNang.Controls.Add(this.btnXoaNode);
            this.grpChucNang.Controls.Add(this.btnSuaNode);
            this.grpChucNang.Controls.Add(this.btnThemNode);
            this.grpChucNang.Controls.Add(this.lblNote);
            this.grpChucNang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChucNang.Location = new System.Drawing.Point(419, 563);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(840, 120);
            this.grpChucNang.TabIndex = 7;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Thao Tác";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(340, 85);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 30);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXSLT
            // 
            this.btnXSLT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnXSLT.FlatAppearance.BorderSize = 0;
            this.btnXSLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXSLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXSLT.ForeColor = System.Drawing.Color.White;
            this.btnXSLT.Location = new System.Drawing.Point(180, 85);
            this.btnXSLT.Name = "btnXSLT";
            this.btnXSLT.Size = new System.Drawing.Size(150, 30);
            this.btnXSLT.TabIndex = 6;
            this.btnXSLT.Text = "Biến đổi XSLT";
            this.btnXSLT.UseVisualStyleBackColor = false;
            // 
            // btnXPath
            // 
            this.btnXPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnXPath.FlatAppearance.BorderSize = 0;
            this.btnXPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXPath.ForeColor = System.Drawing.Color.White;
            this.btnXPath.Location = new System.Drawing.Point(20, 85);
            this.btnXPath.Name = "btnXPath";
            this.btnXPath.Size = new System.Drawing.Size(150, 30);
            this.btnXPath.TabIndex = 5;
            this.btnXPath.Text = "Truy vấn XPath";
            this.btnXPath.UseVisualStyleBackColor = false;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(500, 50);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(150, 30);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Validate XML";
            this.btnValidate.UseVisualStyleBackColor = false;
            // 
            // btnXoaNode
            // 
            this.btnXoaNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaNode.FlatAppearance.BorderSize = 0;
            this.btnXoaNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaNode.ForeColor = System.Drawing.Color.White;
            this.btnXoaNode.Location = new System.Drawing.Point(340, 50);
            this.btnXoaNode.Name = "btnXoaNode";
            this.btnXoaNode.Size = new System.Drawing.Size(150, 30);
            this.btnXoaNode.TabIndex = 3;
            this.btnXoaNode.Text = "Xóa Node";
            this.btnXoaNode.UseVisualStyleBackColor = false;
            // 
            // btnSuaNode
            // 
            this.btnSuaNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSuaNode.FlatAppearance.BorderSize = 0;
            this.btnSuaNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaNode.ForeColor = System.Drawing.Color.White;
            this.btnSuaNode.Location = new System.Drawing.Point(180, 50);
            this.btnSuaNode.Name = "btnSuaNode";
            this.btnSuaNode.Size = new System.Drawing.Size(150, 30);
            this.btnSuaNode.TabIndex = 2;
            this.btnSuaNode.Text = "Sửa Node";
            this.btnSuaNode.UseVisualStyleBackColor = false;
            // 
            // btnThemNode
            // 
            this.btnThemNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThemNode.FlatAppearance.BorderSize = 0;
            this.btnThemNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemNode.ForeColor = System.Drawing.Color.White;
            this.btnThemNode.Location = new System.Drawing.Point(20, 50);
            this.btnThemNode.Name = "btnThemNode";
            this.btnThemNode.Size = new System.Drawing.Size(150, 30);
            this.btnThemNode.TabIndex = 1;
            this.btnThemNode.Text = "Thêm Node";
            this.btnThemNode.UseVisualStyleBackColor = false;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNote.Location = new System.Drawing.Point(20, 25);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(194, 20);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Chức năng thao tác với XML:";
            // 
            // grpContent
            // 
            this.grpContent.Controls.Add(this.txtXMLContent);
            this.grpContent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpContent.Location = new System.Drawing.Point(419, 103);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(840, 450);
            this.grpContent.TabIndex = 6;
            this.grpContent.TabStop = false;
            this.grpContent.Text = "Nội Dung XML";
            // 
            // txtXMLContent
            // 
            this.txtXMLContent.BackColor = System.Drawing.Color.White;
            this.txtXMLContent.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtXMLContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtXMLContent.Location = new System.Drawing.Point(10, 25);
            this.txtXMLContent.Multiline = true;
            this.txtXMLContent.Name = "txtXMLContent";
            this.txtXMLContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXMLContent.Size = new System.Drawing.Size(820, 415);
            this.txtXMLContent.TabIndex = 0;
            // 
            // grpTree
            // 
            this.grpTree.Controls.Add(this.treeXML);
            this.grpTree.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTree.Location = new System.Drawing.Point(9, 103);
            this.grpTree.Name = "grpTree";
            this.grpTree.Size = new System.Drawing.Size(400, 580);
            this.grpTree.TabIndex = 5;
            this.grpTree.TabStop = false;
            this.grpTree.Text = "Cấu Trúc XML";
            // 
            // treeXML
            // 
            this.treeXML.BackColor = System.Drawing.Color.White;
            this.treeXML.Font = new System.Drawing.Font("Consolas", 9F);
            this.treeXML.Location = new System.Drawing.Point(10, 25);
            this.treeXML.Name = "treeXML";
            this.treeXML.Size = new System.Drawing.Size(380, 545);
            this.treeXML.TabIndex = 0;
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.btnGhiXML);
            this.grpFile.Controls.Add(this.btnDocXML);
            this.grpFile.Controls.Add(this.btnChonFile);
            this.grpFile.Controls.Add(this.txtFilePath);
            this.grpFile.Controls.Add(this.lblFile);
            this.grpFile.Controls.Add(this.cboLoaiDuLieu);
            this.grpFile.Controls.Add(this.lblLoai);
            this.grpFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpFile.Location = new System.Drawing.Point(9, 13);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(1250, 80);
            this.grpFile.TabIndex = 4;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "Chọn File XML";
            // 
            // btnGhiXML
            // 
            this.btnGhiXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnGhiXML.FlatAppearance.BorderSize = 0;
            this.btnGhiXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhiXML.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGhiXML.ForeColor = System.Drawing.Color.White;
            this.btnGhiXML.Location = new System.Drawing.Point(1150, 32);
            this.btnGhiXML.Name = "btnGhiXML";
            this.btnGhiXML.Size = new System.Drawing.Size(90, 27);
            this.btnGhiXML.TabIndex = 6;
            this.btnGhiXML.Text = "Ghi XML";
            this.btnGhiXML.UseVisualStyleBackColor = false;
            // 
            // btnDocXML
            // 
            this.btnDocXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnDocXML.FlatAppearance.BorderSize = 0;
            this.btnDocXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocXML.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDocXML.ForeColor = System.Drawing.Color.White;
            this.btnDocXML.Location = new System.Drawing.Point(1050, 32);
            this.btnDocXML.Name = "btnDocXML";
            this.btnDocXML.Size = new System.Drawing.Size(90, 27);
            this.btnDocXML.TabIndex = 5;
            this.btnDocXML.Text = "Đọc XML";
            this.btnDocXML.UseVisualStyleBackColor = false;
            // 
            // btnChonFile
            // 
            this.btnChonFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnChonFile.FlatAppearance.BorderSize = 0;
            this.btnChonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChonFile.ForeColor = System.Drawing.Color.White;
            this.btnChonFile.Location = new System.Drawing.Point(1000, 32);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(40, 27);
            this.btnChonFile.TabIndex = 4;
            this.btnChonFile.Text = "...";
            this.btnChonFile.UseVisualStyleBackColor = false;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilePath.Location = new System.Drawing.Point(490, 32);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(500, 27);
            this.txtFilePath.TabIndex = 3;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFile.Location = new System.Drawing.Point(380, 35);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(89, 20);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "Đường Dẫn:";
            // 
            // cboLoaiDuLieu
            // 
            this.cboLoaiDuLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiDuLieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiDuLieu.FormattingEnabled = true;
            this.cboLoaiDuLieu.Items.AddRange(new object[] {
            "Khóa Học",
            "Học Viên",
            "Đăng Ký",
            "Tất cả dữ liệu"});
            this.cboLoaiDuLieu.Location = new System.Drawing.Point(130, 32);
            this.cboLoaiDuLieu.Name = "cboLoaiDuLieu";
            this.cboLoaiDuLieu.Size = new System.Drawing.Size(200, 28);
            this.cboLoaiDuLieu.TabIndex = 1;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoai.Location = new System.Drawing.Point(20, 35);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(95, 20);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Loại Dữ Liệu:";
            // 
            // frmXMLData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 697);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.grpTree);
            this.Controls.Add(this.grpFile);
            this.Name = "frmXMLData";
            this.Text = "Form1";
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.grpTree.ResumeLayout(false);
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXSLT;
        private System.Windows.Forms.Button btnXPath;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnXoaNode;
        private System.Windows.Forms.Button btnSuaNode;
        private System.Windows.Forms.Button btnThemNode;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox grpContent;
        private System.Windows.Forms.TextBox txtXMLContent;
        private System.Windows.Forms.GroupBox grpTree;
        private System.Windows.Forms.TreeView treeXML;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.Button btnGhiXML;
        private System.Windows.Forms.Button btnDocXML;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.ComboBox cboLoaiDuLieu;
        private System.Windows.Forms.Label lblLoai;
    }
}

