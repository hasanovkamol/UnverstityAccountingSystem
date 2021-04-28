
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
            this.tbEducationalDirection = new System.Windows.Forms.TextBox();
            this.tbFacultet = new System.Windows.Forms.TextBox();
            this.lsFacultet = new System.Windows.Forms.ListBox();
            this.lsEducationalDirection = new System.Windows.Forms.ListBox();
            this.btnFacultet = new System.Windows.Forms.Button();
            this.btnEducationalDirection = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEducationalDirection
            // 
            this.tbEducationalDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEducationalDirection.Location = new System.Drawing.Point(240, 61);
            this.tbEducationalDirection.Name = "tbEducationalDirection";
            this.tbEducationalDirection.Size = new System.Drawing.Size(171, 22);
            this.tbEducationalDirection.TabIndex = 0;
            // 
            // tbFacultet
            // 
            this.tbFacultet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFacultet.Location = new System.Drawing.Point(25, 61);
            this.tbFacultet.Name = "tbFacultet";
            this.tbFacultet.Size = new System.Drawing.Size(163, 22);
            this.tbFacultet.TabIndex = 1;
            // 
            // lsFacultet
            // 
            this.lsFacultet.FormattingEnabled = true;
            this.lsFacultet.Location = new System.Drawing.Point(25, 96);
            this.lsFacultet.Name = "lsFacultet";
            this.lsFacultet.Size = new System.Drawing.Size(197, 147);
            this.lsFacultet.TabIndex = 2;
            this.lsFacultet.SelectedValueChanged += new System.EventHandler(this.lsFacultet_SelectedValueChanged);
            // 
            // lsEducationalDirection
            // 
            this.lsEducationalDirection.FormattingEnabled = true;
            this.lsEducationalDirection.Location = new System.Drawing.Point(240, 96);
            this.lsEducationalDirection.Name = "lsEducationalDirection";
            this.lsEducationalDirection.Size = new System.Drawing.Size(204, 147);
            this.lsEducationalDirection.TabIndex = 3;
            this.lsEducationalDirection.SelectedIndexChanged += new System.EventHandler(this.lsEducationalDirection_SelectedIndexChanged);
            // 
            // btnFacultet
            // 
            this.btnFacultet.Location = new System.Drawing.Point(194, 61);
            this.btnFacultet.Name = "btnFacultet";
            this.btnFacultet.Size = new System.Drawing.Size(28, 23);
            this.btnFacultet.TabIndex = 4;
            this.btnFacultet.Text = "+";
            this.btnFacultet.UseVisualStyleBackColor = true;
            this.btnFacultet.Click += new System.EventHandler(this.btnFacultet_Click);
            // 
            // btnEducationalDirection
            // 
            this.btnEducationalDirection.Location = new System.Drawing.Point(417, 61);
            this.btnEducationalDirection.Name = "btnEducationalDirection";
            this.btnEducationalDirection.Size = new System.Drawing.Size(27, 23);
            this.btnEducationalDirection.TabIndex = 5;
            this.btnEducationalDirection.Text = "+";
            this.btnEducationalDirection.UseVisualStyleBackColor = true;
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
            this.materialLabel2.Location = new System.Drawing.Point(240, 39);
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
            this.button1.Location = new System.Drawing.Point(206, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
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
            this.btnSave.Location = new System.Drawing.Point(331, 264);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Добавить";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // FacultetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnEducationalDirection);
            this.Controls.Add(this.btnFacultet);
            this.Controls.Add(this.lsEducationalDirection);
            this.Controls.Add(this.lsFacultet);
            this.Controls.Add(this.tbFacultet);
            this.Controls.Add(this.tbEducationalDirection);
            this.Name = "FacultetView";
            this.Text = "FacultetView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEducationalDirection;
        private System.Windows.Forms.TextBox tbFacultet;
        private System.Windows.Forms.ListBox lsFacultet;
        private System.Windows.Forms.ListBox lsEducationalDirection;
        private System.Windows.Forms.Button btnFacultet;
        private System.Windows.Forms.Button btnEducationalDirection;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
    }
}