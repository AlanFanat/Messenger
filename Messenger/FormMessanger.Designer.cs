
namespace Messenger
{
    partial class FormMessanger
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.toolStripMenuItem1Users = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridViewDialogs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelCompanionUser = new System.Windows.Forms.Label();
            this.labelCurrentSession = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDialogArea = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxInputMessage = new System.Windows.Forms.TextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDialogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDialogArea)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Location = new System.Drawing.Point(734, 9);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(34, 13);
            this.labelCurrentUser.TabIndex = 1;
            this.labelCurrentUser.Text = ".........";
            // 
            // toolStripMenuItem1Users
            // 
            this.toolStripMenuItem1Users.Name = "toolStripMenuItem1Users";
            this.toolStripMenuItem1Users.Size = new System.Drawing.Size(134, 20);
            this.toolStripMenuItem1Users.Text = "Выбор пользователя";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1Users});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridViewDialogs
            // 
            this.dataGridViewDialogs.AllowUserToAddRows = false;
            this.dataGridViewDialogs.AllowUserToDeleteRows = false;
            this.dataGridViewDialogs.AllowUserToResizeColumns = false;
            this.dataGridViewDialogs.AllowUserToResizeRows = false;
            this.dataGridViewDialogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDialogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDialogs.ColumnHeadersVisible = false;
            this.dataGridViewDialogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewDialogs.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewDialogs.MultiSelect = false;
            this.dataGridViewDialogs.Name = "dataGridViewDialogs";
            this.dataGridViewDialogs.ReadOnly = true;
            this.dataGridViewDialogs.RowHeadersVisible = false;
            this.dataGridViewDialogs.RowTemplate.Height = 70;
            this.dataGridViewDialogs.Size = new System.Drawing.Size(161, 396);
            this.dataGridViewDialogs.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labelCompanionUser
            // 
            this.labelCompanionUser.AutoSize = true;
            this.labelCompanionUser.Location = new System.Drawing.Point(376, 24);
            this.labelCompanionUser.Name = "labelCompanionUser";
            this.labelCompanionUser.Size = new System.Drawing.Size(40, 13);
            this.labelCompanionUser.TabIndex = 4;
            this.labelCompanionUser.Text = "...........";
            // 
            // labelCurrentSession
            // 
            this.labelCurrentSession.AutoSize = true;
            this.labelCurrentSession.Location = new System.Drawing.Point(630, 9);
            this.labelCurrentSession.Name = "labelCurrentSession";
            this.labelCurrentSession.Size = new System.Drawing.Size(88, 13);
            this.labelCurrentSession.TabIndex = 5;
            this.labelCurrentSession.Text = "Текущий сеанс:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Собеседник:";
            // 
            // dataGridViewDialogArea
            // 
            this.dataGridViewDialogArea.AllowUserToAddRows = false;
            this.dataGridViewDialogArea.AllowUserToDeleteRows = false;
            this.dataGridViewDialogArea.AllowUserToResizeColumns = false;
            this.dataGridViewDialogArea.AllowUserToResizeRows = false;
            this.dataGridViewDialogArea.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDialogArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDialogArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDialogArea.ColumnHeadersVisible = false;
            this.dataGridViewDialogArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDialogArea.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDialogArea.Location = new System.Drawing.Point(212, 40);
            this.dataGridViewDialogArea.MultiSelect = false;
            this.dataGridViewDialogArea.Name = "dataGridViewDialogArea";
            this.dataGridViewDialogArea.RowHeadersVisible = false;
            this.dataGridViewDialogArea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDialogArea.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDialogArea.RowTemplate.Height = 70;
            this.dataGridViewDialogArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDialogArea.Size = new System.Drawing.Size(556, 369);
            this.dataGridViewDialogArea.TabIndex = 7;
            this.dataGridViewDialogArea.TabStop = false;
            this.dataGridViewDialogArea.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Companion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 278;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CurrentUser";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 277;
            // 
            // textBoxInputMessage
            // 
            this.textBoxInputMessage.Location = new System.Drawing.Point(212, 418);
            this.textBoxInputMessage.Name = "textBoxInputMessage";
            this.textBoxInputMessage.Size = new System.Drawing.Size(470, 20);
            this.textBoxInputMessage.TabIndex = 8;
            this.textBoxInputMessage.Visible = false;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(693, 415);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonSendMessage.TabIndex = 9;
            this.buttonSendMessage.Text = "Отправить";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Visible = false;
            this.buttonSendMessage.Click += new System.EventHandler(this.ButtonSendMessage_Click);
            // 
            // FormMessanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.textBoxInputMessage);
            this.Controls.Add(this.dataGridViewDialogArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCurrentSession);
            this.Controls.Add(this.labelCompanionUser);
            this.Controls.Add(this.dataGridViewDialogs);
            this.Controls.Add(this.labelCurrentUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMessanger";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMessanger_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDialogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDialogArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1Users;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewDialogs;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Label labelCompanionUser;
        private System.Windows.Forms.Label labelCurrentSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDialogArea;
        private System.Windows.Forms.TextBox textBoxInputMessage;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

