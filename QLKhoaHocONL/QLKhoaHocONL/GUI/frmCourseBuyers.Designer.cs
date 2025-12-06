// ============= FILE: frmCourseBuyers.Designer.cs =============
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLKhoaHocONL.GUI
{
    partial class frmCourseBuyers
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
            this.gridBuyers = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBuyers
            // 
            this.gridBuyers.AllowUserToAddRows = false;
            this.gridBuyers.AllowUserToDeleteRows = false;
            this.gridBuyers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBuyers.BackgroundColor = System.Drawing.Color.White;
            this.gridBuyers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBuyers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBuyers.ColumnHeadersHeight = 40;
            this.gridBuyers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colName,
            this.colEmail,
            this.colPhone,
            this.colPurchaseDate});
            this.gridBuyers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBuyers.EnableHeadersVisualStyles = false;
            this.gridBuyers.Location = new System.Drawing.Point(0, 0);
            this.gridBuyers.Name = "gridBuyers";
            this.gridBuyers.ReadOnly = true;
            this.gridBuyers.RowHeadersVisible = false;
            this.gridBuyers.RowHeadersWidth = 51;
            this.gridBuyers.RowTemplate.Height = 28;
            this.gridBuyers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBuyers.Size = new System.Drawing.Size(760, 420);
            this.gridBuyers.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 40F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Họ tên/Username";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.FillWeight = 80F;
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colPurchaseDate
            // 
            this.colPurchaseDate.FillWeight = 90F;
            this.colPurchaseDate.HeaderText = "Ngày mua";
            this.colPurchaseDate.MinimumWidth = 6;
            this.colPurchaseDate.Name = "colPurchaseDate";
            this.colPurchaseDate.ReadOnly = true;
            // 
            // frmCourseBuyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.gridBuyers);
            this.MaximizeBox = false;
            this.Name = "frmCourseBuyers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Học viên mua khóa học";
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gridBuyers;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colPurchaseDate;
    }
}