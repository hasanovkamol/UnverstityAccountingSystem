
namespace UnverstityAccountingSystem.AllWindows
{
    partial class PositonViewW
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
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbDescreption = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPosition
            // 
            this.tbPosition.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(114, 46);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(206, 24);
            this.tbPosition.TabIndex = 0;
            // 
            // tbDescreption
            // 
            this.tbDescreption.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescreption.Location = new System.Drawing.Point(114, 84);
            this.tbDescreption.Name = "tbDescreption";
            this.tbDescreption.Size = new System.Drawing.Size(206, 61);
            this.tbDescreption.TabIndex = 1;
            this.tbDescreption.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Должность";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(29, 84);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Описание";
            // 
            // tbBack
            // 
            this.tbBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tbBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbBack.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbBack.Location = new System.Drawing.Point(89, 174);
            this.tbBack.Margin = new System.Windows.Forms.Padding(6);
            this.tbBack.Name = "tbBack";
            this.tbBack.Size = new System.Drawing.Size(110, 35);
            this.tbBack.TabIndex = 44;
            this.tbBack.Text = "Выход";
            this.tbBack.UseVisualStyleBackColor = false;
            this.tbBack.Click += new System.EventHandler(this.tbBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(225, 174);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Добавить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbError
            // 
            this.tbError.AutoSize = true;
            this.tbError.ForeColor = System.Drawing.Color.Red;
            this.tbError.Location = new System.Drawing.Point(125, 152);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(0, 13);
            this.tbError.TabIndex = 45;
            // 
            // PositonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 232);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.tbBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tbDescreption);
            this.Controls.Add(this.tbPosition);
            this.Name = "PositonView";
            this.Text = "Добавить новую должность ";
            this.Load += new System.EventHandler(this.PositonView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.RichTextBox tbDescreption;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button tbBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label tbError;
    }
}