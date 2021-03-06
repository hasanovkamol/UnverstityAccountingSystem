
namespace UnverstityAccountingSystem.AllControls
{
    partial class PositionView
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
            this.dgUserAccount = new System.Windows.Forms.DataGridView();
            this.AddStudent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgPositons = new System.Windows.Forms.DataGridView();
            this.lbUser = new MaterialSkin.Controls.MaterialLabel();
            this.lbPosition = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPositons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUserAccount
            // 
            this.dgUserAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgUserAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserAccount.Location = new System.Drawing.Point(44, 131);
            this.dgUserAccount.Margin = new System.Windows.Forms.Padding(2);
            this.dgUserAccount.Name = "dgUserAccount";
            this.dgUserAccount.ReadOnly = true;
            this.dgUserAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUserAccount.Size = new System.Drawing.Size(397, 239);
            this.dgUserAccount.TabIndex = 5;
            this.dgUserAccount.Click += new System.EventHandler(this.dgUserAccount_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddStudent.Depth = 0;
            this.AddStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddStudent.Location = new System.Drawing.Point(444, 44);
            this.AddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.AddStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Primary = true;
            this.AddStudent.Size = new System.Drawing.Size(102, 37);
            this.AddStudent.TabIndex = 8;
            this.AddStudent.Text = "Добавлять";
            this.AddStudent.UseVisualStyleBackColor = false;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(678, 44);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(102, 37);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(561, 44);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(102, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Изменять";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgPositons
            // 
            this.dgPositons.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgPositons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPositons.Location = new System.Drawing.Point(459, 131);
            this.dgPositons.Margin = new System.Windows.Forms.Padding(2);
            this.dgPositons.Name = "dgPositons";
            this.dgPositons.ReadOnly = true;
            this.dgPositons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPositons.Size = new System.Drawing.Size(322, 239);
            this.dgPositons.TabIndex = 9;
            this.dgPositons.Click += new System.EventHandler(this.dgPositons_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Depth = 0;
            this.lbUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUser.Location = new System.Drawing.Point(45, 107);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(176, 19);
            this.lbUser.TabIndex = 10;
            this.lbUser.Text = "Список пользователей";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Depth = 0;
            this.lbPosition.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPosition.Location = new System.Drawing.Point(461, 107);
            this.lbPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(244, 19);
            this.lbPosition.TabIndex = 11;
            this.lbPosition.Text = "Типы сотрудников организации ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(19, 14);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(0, 19);
            this.materialLabel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Организационный менеджмент ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PositionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.dgPositons);
            this.Controls.Add(this.dgUserAccount);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PositionView";
            this.Size = new System.Drawing.Size(840, 420);
            this.Load += new System.EventHandler(this.PositionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPositons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUserAccount;
        private MaterialSkin.Controls.MaterialRaisedButton AddStudent;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private System.Windows.Forms.DataGridView dgPositons;
        private MaterialSkin.Controls.MaterialLabel lbUser;
        private MaterialSkin.Controls.MaterialLabel lbPosition;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label label1;
    }
}
