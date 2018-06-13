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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
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
            this.Table.Location = new System.Drawing.Point(0, 50);
            this.Table.Name = "Table";
            this.Table.RowTemplate.Height = 23;
            this.Table.Size = new System.Drawing.Size(1245, 200);
            this.Table.TabIndex = 0;
            this.Table.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.tRowStateChanged);
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
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(20, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "新建";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(145, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(270, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // WAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 251);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
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
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}