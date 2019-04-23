namespace Task1
{
    partial class MainForm
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
            this.ctlTabs = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Awards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAwards = new System.Windows.Forms.TabPage();
            this.dgvAwards = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.наградыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAddAward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditAward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlDeleteAward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTabs.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabAwards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlTabs
            // 
            this.ctlTabs.Controls.Add(this.tabUsers);
            this.ctlTabs.Controls.Add(this.tabAwards);
            this.ctlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTabs.Location = new System.Drawing.Point(0, 24);
            this.ctlTabs.Name = "ctlTabs";
            this.ctlTabs.SelectedIndex = 0;
            this.ctlTabs.Size = new System.Drawing.Size(559, 274);
            this.ctlTabs.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(551, 248);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Пользователи";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.BirthDate,
            this.Age,
            this.Awards});
            this.dgvUsers.Location = new System.Drawing.Point(3, 3);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(545, 244);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_ColumnHeaderMouseClick);
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Дата рождения";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Awards
            // 
            this.Awards.DataPropertyName = "Awards";
            this.Awards.HeaderText = "Награды";
            this.Awards.Name = "Awards";
            this.Awards.ReadOnly = true;
            // 
            // tabAwards
            // 
            this.tabAwards.Controls.Add(this.dgvAwards);
            this.tabAwards.Location = new System.Drawing.Point(4, 22);
            this.tabAwards.Name = "tabAwards";
            this.tabAwards.Padding = new System.Windows.Forms.Padding(3);
            this.tabAwards.Size = new System.Drawing.Size(551, 248);
            this.tabAwards.TabIndex = 1;
            this.tabAwards.Text = "Награды";
            this.tabAwards.UseVisualStyleBackColor = true;
            // 
            // dgvAwards
            // 
            this.dgvAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Description});
            this.dgvAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAwards.Location = new System.Drawing.Point(3, 3);
            this.dgvAwards.MultiSelect = false;
            this.dgvAwards.Name = "dgvAwards";
            this.dgvAwards.Size = new System.Drawing.Size(545, 242);
            this.dgvAwards.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Название награды";
            this.Title.Name = "Title";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.наградыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddUser,
            this.ctlEditUser,
            this.ctlDeleteUser});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // ctlAddUser
            // 
            this.ctlAddUser.Name = "ctlAddUser";
            this.ctlAddUser.Size = new System.Drawing.Size(163, 22);
            this.ctlAddUser.Text = "Добавить...";
            this.ctlAddUser.Click += new System.EventHandler(this.ctlAddUser_Click);
            // 
            // ctlEditUser
            // 
            this.ctlEditUser.Name = "ctlEditUser";
            this.ctlEditUser.Size = new System.Drawing.Size(163, 22);
            this.ctlEditUser.Text = "Редактировать...";
            this.ctlEditUser.Click += new System.EventHandler(this.ctlEditUser_Click);
            // 
            // ctlDeleteUser
            // 
            this.ctlDeleteUser.Name = "ctlDeleteUser";
            this.ctlDeleteUser.Size = new System.Drawing.Size(163, 22);
            this.ctlDeleteUser.Text = "Удалить...";
            this.ctlDeleteUser.Click += new System.EventHandler(this.ctlDeleteUser_Click);
            // 
            // наградыToolStripMenuItem
            // 
            this.наградыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddAward,
            this.ctlEditAward,
            this.ctlDeleteAward});
            this.наградыToolStripMenuItem.Name = "наградыToolStripMenuItem";
            this.наградыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.наградыToolStripMenuItem.Text = "Награды";
            // 
            // ctlAddAward
            // 
            this.ctlAddAward.Name = "ctlAddAward";
            this.ctlAddAward.Size = new System.Drawing.Size(163, 22);
            this.ctlAddAward.Text = "Добавить...";
            this.ctlAddAward.Click += new System.EventHandler(this.ctlAddAward_Click);
            // 
            // ctlEditAward
            // 
            this.ctlEditAward.Name = "ctlEditAward";
            this.ctlEditAward.Size = new System.Drawing.Size(163, 22);
            this.ctlEditAward.Text = "Редактировать...";
            this.ctlEditAward.Click += new System.EventHandler(this.ctlEditAward_Click);
            // 
            // ctlDeleteAward
            // 
            this.ctlDeleteAward.Name = "ctlDeleteAward";
            this.ctlDeleteAward.Size = new System.Drawing.Size(163, 22);
            this.ctlDeleteAward.Text = "Удалить...";
            this.ctlDeleteAward.Click += new System.EventHandler(this.ctlDeleteAward_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 298);
            this.Controls.Add(this.ctlTabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи и награды";
            this.ctlTabs.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabAwards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ctlTabs;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabAwards;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvAwards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctlAddUser;
        private System.Windows.Forms.ToolStripMenuItem ctlEditUser;
        private System.Windows.Forms.ToolStripMenuItem наградыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctlAddAward;
        private System.Windows.Forms.ToolStripMenuItem ctlEditAward;
        private System.Windows.Forms.ToolStripMenuItem ctlDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem ctlDeleteAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Awards;
    }
}

