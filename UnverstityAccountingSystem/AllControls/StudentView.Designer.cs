
namespace UnverstityAccountingSystem.AllControls
{
    partial class StudentView
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
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddStudent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.StudentContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.StudentContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgStudent
            // 
            this.dgStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Location = new System.Drawing.Point(66, 108);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.ReadOnly = true;
            this.dgStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudent.Size = new System.Drawing.Size(709, 278);
            this.dgStudent.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(616, 35);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(159, 50);
            this.btnDelete.TabIndex = 1;
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
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Изменять";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.AddStudent.TabIndex = 4;
            this.AddStudent.Text = "Добавлять";
            this.AddStudent.UseVisualStyleBackColor = false;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // StudentContent
            // 
            this.StudentContent.Controls.Add(this.dgStudent);
            this.StudentContent.Controls.Add(this.AddStudent);
            this.StudentContent.Controls.Add(this.btnDelete);
            this.StudentContent.Controls.Add(this.btnUpdate);
            this.StudentContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentContent.Location = new System.Drawing.Point(0, 0);
            this.StudentContent.Name = "StudentContent";
            this.StudentContent.Size = new System.Drawing.Size(840, 461);
            this.StudentContent.TabIndex = 5;
            this.StudentContent.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentContent_Paint);
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentContent);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StudentView";
            this.Size = new System.Drawing.Size(840, 461);
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.StudentContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStudent;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton AddStudent;
        private System.Windows.Forms.Panel StudentContent;
    }
}
