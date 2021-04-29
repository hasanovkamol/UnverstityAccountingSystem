
namespace UnverstityAccountingSystem.AllWindows
{
    partial class FacultetView
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
            this.components = new System.ComponentModel.Container();
            this.tbEducationalDirection = new System.Windows.Forms.TextBox();
            this.tbFacultet = new System.Windows.Forms.TextBox();
            this.btnFacultet = new System.Windows.Forms.Button();
            this.btnEducationalDirection = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btDirectionDelete = new System.Windows.Forms.Button();
            this.tbFacultetDelete = new System.Windows.Forms.Button();
            this.dgFacultet = new System.Windows.Forms.DataGridView();
            this.dgDirection = new System.Windows.Forms.DataGridView();
            this.tbError = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacultet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirection)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEducationalDirection
            // 
            this.tbEducationalDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEducationalDirection.Location = new System.Drawing.Point(288, 60);
            this.tbEducationalDirection.Name = "tbEducationalDirection";
            this.tbEducationalDirection.Size = new System.Drawing.Size(175, 29);
            this.tbEducationalDirection.TabIndex = 0;
            // 
            // tbFacultet
            // 
            this.tbFacultet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFacultet.Location = new System.Drawing.Point(25, 60);
            this.tbFacultet.Name = "tbFacultet";
            this.tbFacultet.Size = new System.Drawing.Size(175, 29);
            this.tbFacultet.TabIndex = 1;
            // 
            // btnFacultet
            // 
            this.btnFacultet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFacultet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacultet.Location = new System.Drawing.Point(206, 60);
            this.btnFacultet.Name = "btnFacultet";
            this.btnFacultet.Size = new System.Drawing.Size(29, 29);
            this.btnFacultet.TabIndex = 4;
            this.btnFacultet.Text = "+";
            this.btnFacultet.UseVisualStyleBackColor = false;
            this.btnFacultet.Click += new System.EventHandler(this.btnFacultet_Click);
            // 
            // btnEducationalDirection
            // 
            this.btnEducationalDirection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEducationalDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEducationalDirection.Location = new System.Drawing.Point(469, 60);
            this.btnEducationalDirection.Name = "btnEducationalDirection";
            this.btnEducationalDirection.Size = new System.Drawing.Size(29, 29);
            this.btnEducationalDirection.TabIndex = 5;
            this.btnEducationalDirection.Text = "+";
            this.btnEducationalDirection.UseVisualStyleBackColor = false;
            this.btnEducationalDirection.Click += new System.EventHandler(this.btnEducationalDirection_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 39);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Факультет";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(290, 39);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Направление";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(248, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 40);
            this.button1.TabIndex = 46;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(394, 285);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Подтверждение";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btDirectionDelete
            // 
            this.btDirectionDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDirectionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDirectionDelete.ForeColor = System.Drawing.Color.Red;
            this.btDirectionDelete.Location = new System.Drawing.Point(499, 60);
            this.btDirectionDelete.Name = "btDirectionDelete";
            this.btDirectionDelete.Size = new System.Drawing.Size(29, 29);
            this.btDirectionDelete.TabIndex = 47;
            this.btDirectionDelete.Text = "X";
            this.btDirectionDelete.UseVisualStyleBackColor = false;
            this.btDirectionDelete.Click += new System.EventHandler(this.btDirectionDelete_Click);
            // 
            // tbFacultetDelete
            // 
            this.tbFacultetDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFacultetDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbFacultetDelete.ForeColor = System.Drawing.Color.Red;
            this.tbFacultetDelete.Location = new System.Drawing.Point(236, 60);
            this.tbFacultetDelete.Name = "tbFacultetDelete";
            this.tbFacultetDelete.Size = new System.Drawing.Size(29, 29);
            this.tbFacultetDelete.TabIndex = 48;
            this.tbFacultetDelete.Text = "X";
            this.tbFacultetDelete.UseVisualStyleBackColor = false;
            this.tbFacultetDelete.Click += new System.EventHandler(this.tbFacultetDelete_Click);
            // 
            // dgFacultet
            // 
            this.dgFacultet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacultet.Location = new System.Drawing.Point(25, 112);
            this.dgFacultet.Name = "dgFacultet";
            this.dgFacultet.ReadOnly = true;
            this.dgFacultet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFacultet.Size = new System.Drawing.Size(240, 150);
            this.dgFacultet.TabIndex = 49;
            this.dgFacultet.Click += new System.EventHandler(this.dgFacultet_Click);
            // 
            // dgDirection
            // 
            this.dgDirection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDirection.Location = new System.Drawing.Point(288, 112);
            this.dgDirection.Name = "dgDirection";
            this.dgDirection.ReadOnly = true;
            this.dgDirection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDirection.Size = new System.Drawing.Size(240, 150);
            this.dgDirection.TabIndex = 50;
            this.dgDirection.Click += new System.EventHandler(this.dgDirection_Click);
            // 
            // tbError
            // 
            this.tbError.AutoSize = true;
            this.tbError.Depth = 0;
            this.tbError.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbError.ForeColor = System.Drawing.Color.Red;
            this.tbError.Location = new System.Drawing.Point(28, 270);
            this.tbError.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(0, 19);
            this.tbError.TabIndex = 51;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FacultetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 350);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.dgDirection);
            this.Controls.Add(this.dgFacultet);
            this.Controls.Add(this.tbFacultetDelete);
            this.Controls.Add(this.btDirectionDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnEducationalDirection);
            this.Controls.Add(this.btnFacultet);
            this.Controls.Add(this.tbFacultet);
            this.Controls.Add(this.tbEducationalDirection);
            this.Name = "FacultetView";
            this.Text = "FacultetView";
            this.Load += new System.EventHandler(this.FacultetView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacultet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEducationalDirection;
        private System.Windows.Forms.TextBox tbFacultet;
        private System.Windows.Forms.Button btnFacultet;
        private System.Windows.Forms.Button btnEducationalDirection;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btDirectionDelete;
        private System.Windows.Forms.Button tbFacultetDelete;
        private System.Windows.Forms.DataGridView dgFacultet;
        private System.Windows.Forms.DataGridView dgDirection;
        private MaterialSkin.Controls.MaterialLabel tbError;
        private System.Windows.Forms.Timer timer1;
    }
}