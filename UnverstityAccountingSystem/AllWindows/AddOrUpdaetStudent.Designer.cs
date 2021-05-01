
namespace UnverstityAccountingSystem.AllWindows
{
    partial class AddOrUpdaetStudent
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
            this.Content = new System.Windows.Forms.Panel();
            this.cobDirection = new System.Windows.Forms.ComboBox();
            this.tbError = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.chackScholarship = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cobCourse = new System.Windows.Forms.ComboBox();
            this.checkPaymentAgreement = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbCourse = new MaterialSkin.Controls.MaterialLabel();
            this.tbSurname = new MaterialSkin.Controls.MaterialLabel();
            this.tbName = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddFacultet = new System.Windows.Forms.Button();
            this.cobFacultet = new System.Windows.Forms.ComboBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Content.Controls.Add(this.cobDirection);
            this.Content.Controls.Add(this.tbError);
            this.Content.Controls.Add(this.button1);
            this.Content.Controls.Add(this.chackScholarship);
            this.Content.Controls.Add(this.btnSave);
            this.Content.Controls.Add(this.cobCourse);
            this.Content.Controls.Add(this.checkPaymentAgreement);
            this.Content.Controls.Add(this.materialLabel4);
            this.Content.Controls.Add(this.materialLabel3);
            this.Content.Controls.Add(this.tbCourse);
            this.Content.Controls.Add(this.tbSurname);
            this.Content.Controls.Add(this.tbName);
            this.Content.Controls.Add(this.btnAddFacultet);
            this.Content.Controls.Add(this.cobFacultet);
            this.Content.Controls.Add(this.tbSName);
            this.Content.Controls.Add(this.tbFName);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(559, 442);
            this.Content.TabIndex = 1;
            // 
            // cobDirection
            // 
            this.cobDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cobDirection.FormattingEnabled = true;
            this.cobDirection.Items.AddRange(new object[] {
            "Matematika",
            "Fizika",
            "Kimyo",
            "Tarix"});
            this.cobDirection.Location = new System.Drawing.Point(162, 243);
            this.cobDirection.Name = "cobDirection";
            this.cobDirection.Size = new System.Drawing.Size(300, 28);
            this.cobDirection.TabIndex = 48;
            // 
            // tbError
            // 
            this.tbError.AutoSize = true;
            this.tbError.Depth = 0;
            this.tbError.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbError.Location = new System.Drawing.Point(214, 327);
            this.tbError.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(0, 19);
            this.tbError.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(162, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chackScholarship
            // 
            this.chackScholarship.AutoSize = true;
            this.chackScholarship.Depth = 0;
            this.chackScholarship.Font = new System.Drawing.Font("Roboto", 10F);
            this.chackScholarship.Location = new System.Drawing.Point(361, 297);
            this.chackScholarship.Margin = new System.Windows.Forms.Padding(0);
            this.chackScholarship.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chackScholarship.MouseState = MaterialSkin.MouseState.HOVER;
            this.chackScholarship.Name = "chackScholarship";
            this.chackScholarship.Ripple = true;
            this.chackScholarship.Size = new System.Drawing.Size(101, 30);
            this.chackScholarship.TabIndex = 46;
            this.chackScholarship.Text = "Стипендия ";
            this.chackScholarship.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(333, 357);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 40);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Добавить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cobCourse
            // 
            this.cobCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cobCourse.FormattingEnabled = true;
            this.cobCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cobCourse.Location = new System.Drawing.Point(162, 143);
            this.cobCourse.Name = "cobCourse";
            this.cobCourse.Size = new System.Drawing.Size(300, 28);
            this.cobCourse.TabIndex = 13;
            // 
            // checkPaymentAgreement
            // 
            this.checkPaymentAgreement.AutoSize = true;
            this.checkPaymentAgreement.Depth = 0;
            this.checkPaymentAgreement.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkPaymentAgreement.Location = new System.Drawing.Point(162, 297);
            this.checkPaymentAgreement.Margin = new System.Windows.Forms.Padding(0);
            this.checkPaymentAgreement.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkPaymentAgreement.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkPaymentAgreement.Name = "checkPaymentAgreement";
            this.checkPaymentAgreement.Ripple = true;
            this.checkPaymentAgreement.Size = new System.Drawing.Size(177, 30);
            this.checkPaymentAgreement.TabIndex = 45;
            this.checkPaymentAgreement.Text = "Соглашение об оплате ";
            this.checkPaymentAgreement.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(50, 249);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(105, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Направление";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(72, 194);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(83, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Факультет";
            // 
            // tbCourse
            // 
            this.tbCourse.AutoSize = true;
            this.tbCourse.Depth = 0;
            this.tbCourse.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbCourse.Location = new System.Drawing.Point(113, 147);
            this.tbCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(42, 19);
            this.tbCourse.TabIndex = 10;
            this.tbCourse.Text = "Курс";
            // 
            // tbSurname
            // 
            this.tbSurname.AutoSize = true;
            this.tbSurname.Depth = 0;
            this.tbSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbSurname.Location = new System.Drawing.Point(80, 98);
            this.tbSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(75, 19);
            this.tbSurname.TabIndex = 9;
            this.tbSurname.Text = "Фамилия";
            // 
            // tbName
            // 
            this.tbName.AutoSize = true;
            this.tbName.Depth = 0;
            this.tbName.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbName.Location = new System.Drawing.Point(116, 48);
            this.tbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(39, 19);
            this.tbName.TabIndex = 8;
            this.tbName.Text = "Имя";
            // 
            // btnAddFacultet
            // 
            this.btnAddFacultet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddFacultet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFacultet.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFacultet.Location = new System.Drawing.Point(432, 189);
            this.btnAddFacultet.Name = "btnAddFacultet";
            this.btnAddFacultet.Size = new System.Drawing.Size(37, 28);
            this.btnAddFacultet.TabIndex = 5;
            this.btnAddFacultet.Text = "...";
            this.btnAddFacultet.UseVisualStyleBackColor = false;
            this.btnAddFacultet.Click += new System.EventHandler(this.btnAddFacultet_Click);
            // 
            // cobFacultet
            // 
            this.cobFacultet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cobFacultet.FormattingEnabled = true;
            this.cobFacultet.Location = new System.Drawing.Point(162, 189);
            this.cobFacultet.Name = "cobFacultet";
            this.cobFacultet.Size = new System.Drawing.Size(264, 28);
            this.cobFacultet.TabIndex = 3;
            this.cobFacultet.SelectedIndexChanged += new System.EventHandler(this.cobFacultet_SelectedIndexChanged);
            // 
            // tbSName
            // 
            this.tbSName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSName.Location = new System.Drawing.Point(162, 93);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(300, 28);
            this.tbSName.TabIndex = 1;
            // 
            // tbFName
            // 
            this.tbFName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFName.Location = new System.Drawing.Point(162, 45);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(300, 28);
            this.tbFName.TabIndex = 0;
            // 
            // AddOrUpdaetStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 442);
            this.Controls.Add(this.Content);
            this.Name = "AddOrUpdaetStudent";
            this.Text = "Добавить студента";
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.ComboBox cobDirection;
        private MaterialSkin.Controls.MaterialLabel tbError;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialCheckBox chackScholarship;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cobCourse;
        private MaterialSkin.Controls.MaterialCheckBox checkPaymentAgreement;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel tbCourse;
        private MaterialSkin.Controls.MaterialLabel tbSurname;
        private MaterialSkin.Controls.MaterialLabel tbName;
        private System.Windows.Forms.Button btnAddFacultet;
        private System.Windows.Forms.ComboBox cobFacultet;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.TextBox tbFName;
    }
}