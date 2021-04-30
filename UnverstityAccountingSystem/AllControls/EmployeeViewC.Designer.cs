
namespace UnverstityAccountingSystem.AllControls
{
    partial class EmployeeViewC
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
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.AddStudent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmployee
            // 
            this.dgEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Location = new System.Drawing.Point(66, 108);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.ReadOnly = true;
            this.dgEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmployee.Size = new System.Drawing.Size(709, 278);
            this.dgEmployee.TabIndex = 9;
            // 
            // AddStudent
            // 
            this.AddStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddStudent.Depth = 0;
            this.AddStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddStudent.Location = new System.Drawing.Point(250, 35);
            this.AddStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Primary = true;
            this.AddStudent.Size = new System.Drawing.Size(159, 50);
            this.AddStudent.TabIndex = 12;
            this.AddStudent.Text = "Добавлять";
            this.AddStudent.UseVisualStyleBackColor = false;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(616, 35);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(159, 50);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(433, 35);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(159, 50);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Изменять";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EmployeeViewC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgEmployee);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EmployeeViewC";
            this.Size = new System.Drawing.Size(840, 420);
            this.Load += new System.EventHandler(this.EmployeeViewC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton AddStudent;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
    }
}
