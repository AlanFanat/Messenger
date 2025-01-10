
namespace Messenger
{
    partial class FormRegistration
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
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxRegUserName = new System.Windows.Forms.TextBox();
            this.comboBoxUserChoise = new System.Windows.Forms.ComboBox();
            this.labelRegInfo = new System.Windows.Forms.Label();
            this.labelRegUserName = new System.Windows.Forms.Label();
            this.labeUserChoise = new System.Windows.Forms.Label();
            this.labelRegUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReg.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonReg.FlatAppearance.BorderSize = 2;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(33, 195);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(232, 40);
            this.buttonReg.TabIndex = 0;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxRegUserName
            // 
            this.textBoxRegUserName.Location = new System.Drawing.Point(145, 153);
            this.textBoxRegUserName.Name = "textBoxRegUserName";
            this.textBoxRegUserName.Size = new System.Drawing.Size(128, 20);
            this.textBoxRegUserName.TabIndex = 1;
            // 
            // comboBoxUserChoise
            // 
            this.comboBoxUserChoise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUserChoise.FormattingEnabled = true;
            this.comboBoxUserChoise.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBoxUserChoise.Location = new System.Drawing.Point(33, 347);
            this.comboBoxUserChoise.Name = "comboBoxUserChoise";
            this.comboBoxUserChoise.Size = new System.Drawing.Size(232, 26);
            this.comboBoxUserChoise.TabIndex = 2;
            this.comboBoxUserChoise.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserChoise_SelectedIndexChanged);
            // 
            // labelRegInfo
            // 
            this.labelRegInfo.AutoSize = true;
            this.labelRegInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegInfo.Location = new System.Drawing.Point(18, 31);
            this.labelRegInfo.Name = "labelRegInfo";
            this.labelRegInfo.Size = new System.Drawing.Size(276, 39);
            this.labelRegInfo.TabIndex = 3;
            this.labelRegInfo.Text = "РЕГИСТРАЦИЯ";
            // 
            // labelRegUserName
            // 
            this.labelRegUserName.AutoSize = true;
            this.labelRegUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegUserName.Location = new System.Drawing.Point(12, 149);
            this.labelRegUserName.Name = "labelRegUserName";
            this.labelRegUserName.Size = new System.Drawing.Size(127, 24);
            this.labelRegUserName.TabIndex = 4;
            this.labelRegUserName.Text = "Введите имя";
            // 
            // labeUserChoise
            // 
            this.labeUserChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeUserChoise.ForeColor = System.Drawing.Color.SteelBlue;
            this.labeUserChoise.Location = new System.Drawing.Point(12, 279);
            this.labeUserChoise.Name = "labeUserChoise";
            this.labeUserChoise.Size = new System.Drawing.Size(276, 55);
            this.labeUserChoise.TabIndex = 5;
            this.labeUserChoise.Text = "Войти под существующим пользователем";
            this.labeUserChoise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegUser
            // 
            this.labelRegUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelRegUser.Location = new System.Drawing.Point(18, 83);
            this.labelRegUser.Name = "labelRegUser";
            this.labelRegUser.Size = new System.Drawing.Size(276, 55);
            this.labelRegUser.TabIndex = 6;
            this.labelRegUser.Text = "Зарегистрировать нового пользователя";
            this.labelRegUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this.labelRegUser);
            this.Controls.Add(this.labeUserChoise);
            this.Controls.Add(this.labelRegUserName);
            this.Controls.Add(this.labelRegInfo);
            this.Controls.Add(this.comboBoxUserChoise);
            this.Controls.Add(this.textBoxRegUserName);
            this.Controls.Add(this.buttonReg);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxRegUserName;
        private System.Windows.Forms.ComboBox comboBoxUserChoise;
        private System.Windows.Forms.Label labelRegInfo;
        private System.Windows.Forms.Label labelRegUserName;
        private System.Windows.Forms.Label labeUserChoise;
        private System.Windows.Forms.Label labelRegUser;
    }
}