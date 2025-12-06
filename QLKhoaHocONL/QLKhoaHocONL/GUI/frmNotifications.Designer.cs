// ============= FILE: frmNotifications.Designer.cs =============
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLKhoaHocONL.GUI
{
    partial class frmNotifications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridNotifications = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMarkAll = new System.Windows.Forms.Button();
            this.btnMarkRead = new System.Windows.Forms.Button();
            this.chkOnlyUnread = new System.Windows.Forms.CheckBox();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotifications)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridNotifications
            // 
            this.gridNotifications.AllowUserToAddRows = false;
            this.gridNotifications.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.gridNotifications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNotifications.BackgroundColor = System.Drawing.Color.White;
            this.gridNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridNotifications.ColumnHeadersHeight = 38;
            this.gridNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitle,
            this.colContent,
            this.colCreatedAt,
            this.colStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNotifications.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNotifications.EnableHeadersVisualStyles = false;
            this.gridNotifications.Location = new System.Drawing.Point(0, 26);
            this.gridNotifications.Name = "gridNotifications";
            this.gridNotifications.ReadOnly = true;
            this.gridNotifications.RowHeadersVisible = false;
            this.gridNotifications.RowHeadersWidth = 51;
            this.gridNotifications.RowTemplate.Height = 28;
            this.gridNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNotifications.Size = new System.Drawing.Size(820, 444);
            this.gridNotifications.TabIndex = 0;
            this.gridNotifications.DoubleClick += new System.EventHandler(this.gridNotifications_DoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colTitle
            // 
            this.colTitle.FillWeight = 130F;
            this.colTitle.HeaderText = "Tiêu đề";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colContent
            // 
            this.colContent.FillWeight = 230F;
            this.colContent.HeaderText = "Nội dung";
            this.colContent.MinimumWidth = 6;
            this.colContent.Name = "colContent";
            this.colContent.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FillWeight = 90F;
            this.colCreatedAt.HeaderText = "Thời gian";
            this.colCreatedAt.MinimumWidth = 6;
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 70F;
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnRefresh);
            this.panelButtons.Controls.Add(this.btnMarkAll);
            this.panelButtons.Controls.Add(this.btnMarkRead);
            this.panelButtons.Controls.Add(this.chkOnlyUnread);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Location = new System.Drawing.Point(0, 470);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelButtons.Size = new System.Drawing.Size(820, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(705, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMarkAll
            // 
            this.btnMarkAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAll.ForeColor = System.Drawing.Color.White;
            this.btnMarkAll.Location = new System.Drawing.Point(569, 11);
            this.btnMarkAll.Name = "btnMarkAll";
            this.btnMarkAll.Size = new System.Drawing.Size(250, 30);
            this.btnMarkAll.TabIndex = 2;
            this.btnMarkAll.Text = "Đánh dấu tất cả";
            this.btnMarkAll.UseVisualStyleBackColor = false;
            this.btnMarkAll.Click += new System.EventHandler(this.btnMarkAll_Click);
            // 
            // btnMarkRead
            // 
            this.btnMarkRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMarkRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkRead.ForeColor = System.Drawing.Color.White;
            this.btnMarkRead.Location = new System.Drawing.Point(413, 11);
            this.btnMarkRead.Name = "btnMarkRead";
            this.btnMarkRead.Size = new System.Drawing.Size(250, 30);
            this.btnMarkRead.TabIndex = 1;
            this.btnMarkRead.Text = "Đánh dấu đã xem";
            this.btnMarkRead.UseVisualStyleBackColor = false;
            this.btnMarkRead.Click += new System.EventHandler(this.btnMarkRead_Click);
            // 
            // chkOnlyUnread
            // 
            this.chkOnlyUnread.AutoSize = true;
            this.chkOnlyUnread.Location = new System.Drawing.Point(271, 11);
            this.chkOnlyUnread.Name = "chkOnlyUnread";
            this.chkOnlyUnread.Size = new System.Drawing.Size(136, 20);
            this.chkOnlyUnread.TabIndex = 0;
            this.chkOnlyUnread.Text = "Chỉ hiện chưa xem";
            this.chkOnlyUnread.UseVisualStyleBackColor = true;
            this.chkOnlyUnread.CheckedChanged += new System.EventHandler(this.chkOnlyUnread_CheckedChanged);
            // 
            // lblHint
            // 
            this.lblHint.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint.Location = new System.Drawing.Point(0, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblHint.Size = new System.Drawing.Size(820, 26);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "Mẹo: double-click để đánh dấu đã xem.";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHint.Click += new System.EventHandler(this.lblHint_Click);
            // 
            // frmNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 520);
            this.Controls.Add(this.gridNotifications);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.lblHint);
            this.MaximizeBox = false;
            this.Name = "frmNotifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông báo";
            ((System.ComponentModel.ISupportInitialize)(this.gridNotifications)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gridNotifications;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colContent;
        private DataGridViewTextBoxColumn colCreatedAt;
        private DataGridViewTextBoxColumn colStatus;
        private FlowLayoutPanel panelButtons;
        private CheckBox chkOnlyUnread;
        private Button btnMarkRead;
        private Button btnMarkAll;
        private Button btnRefresh;
        private Label lblHint;
    }
}