namespace da.Wins
{
    partial class WAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WAccounts));
            this.Table = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safePwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgNums = new System.Windows.Forms.DataGridViewImageColumn();
            this.realName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.BackgroundColor = System.Drawing.Color.White;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.pwd,
            this.safePwd,
            this.characterName,
            this.pgId,
            this.pgNums,
            this.realName,
            this.sfz,
            this.tel,
            this.email,
            this.question,
            this.answer});
            this.Table.Location = new System.Drawing.Point(0, 20);
            this.Table.Name = "Table";
            this.Table.RowTemplate.Height = 23;
            this.Table.Size = new System.Drawing.Size(1245, 150);
            this.Table.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "登录名";
            this.name.Name = "name";
            // 
            // pwd
            // 
            this.pwd.HeaderText = "密码";
            this.pwd.Name = "pwd";
            // 
            // safePwd
            // 
            this.safePwd.HeaderText = "财产安全口令";
            this.safePwd.Name = "safePwd";
            // 
            // characterName
            // 
            this.characterName.HeaderText = "角色名";
            this.characterName.Name = "characterName";
            // 
            // pgId
            // 
            this.pgId.HeaderText = "密保卡序列号";
            this.pgId.Name = "pgId";
            // 
            // pgNums
            // 
            this.pgNums.HeaderText = "密保卡";
            this.pgNums.Name = "pgNums";
            this.pgNums.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pgNums.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // realName
            // 
            this.realName.HeaderText = "真实姓名";
            this.realName.Name = "realName";
            // 
            // sfz
            // 
            this.sfz.HeaderText = "身份证";
            this.sfz.Name = "sfz";
            // 
            // tel
            // 
            this.tel.HeaderText = "手机号码";
            this.tel.Name = "tel";
            // 
            // email
            // 
            this.email.HeaderText = "邮箱";
            this.email.Name = "email";
            // 
            // question
            // 
            this.question.HeaderText = "密保问题";
            this.question.Name = "question";
            // 
            // answer
            // 
            this.answer.HeaderText = "密保问题答案";
            this.answer.Name = "answer";
            // 
            // WAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 261);
            this.Controls.Add(this.Table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WAccounts";
            this.Text = "WAccounts";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn safePwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pgId;
        private System.Windows.Forms.DataGridViewImageColumn pgNums;
        private System.Windows.Forms.DataGridViewTextBoxColumn realName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfz;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
    }
}