namespace Zork.Builder.WinForms.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
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
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameListLabel = new System.Windows.Forms.Label();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.playerInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.playerInventoryListBox = new System.Windows.Forms.ListBox();
            this.playerScoreTextBox = new System.Windows.Forms.TextBox();
            this.playerHealthTextBox = new System.Windows.Forms.TextBox();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.playerInventoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork.Builder.WinForms.ViewModels.WorldViewModel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files(*json)|*.json";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(885, 33);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.openWorldToolStripMenuItem.Text = "&Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World Files(*json)|*.json";
            this.saveFileDialog.Title = "Save world file";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Items";
            this.inventoryBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // nameListLabel
            // 
            this.nameListLabel.AutoSize = true;
            this.nameListLabel.Location = new System.Drawing.Point(12, 75);
            this.nameListLabel.Name = "nameListLabel";
            this.nameListLabel.Size = new System.Drawing.Size(60, 20);
            this.nameListLabel.TabIndex = 30;
            this.nameListLabel.Text = "&Players";
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Location = new System.Drawing.Point(93, 568);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(75, 36);
            this.deletePlayerButton.TabIndex = 22;
            this.deletePlayerButton.Text = "&Delete";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(12, 568);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 36);
            this.addPlayerButton.TabIndex = 21;
            this.addPlayerButton.Text = "&Add...";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // playerListBox
            // 
            this.playerListBox.DataSource = this.playersBindingSource;
            this.playerListBox.DisplayMember = "Name";
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 20;
            this.playerListBox.Location = new System.Drawing.Point(6, 98);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(233, 464);
            this.playerListBox.TabIndex = 20;
            this.playerListBox.ValueMember = "Name";
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(87, 235);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(75, 36);
            this.deleteItemButton.TabIndex = 7;
            this.deleteItemButton.Text = "&Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(6, 235);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 36);
            this.addItemButton.TabIndex = 6;
            this.addItemButton.Text = "&Add...";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // playerInventoryGroupBox
            // 
            this.playerInventoryGroupBox.Controls.Add(this.deleteItemButton);
            this.playerInventoryGroupBox.Controls.Add(this.addItemButton);
            this.playerInventoryGroupBox.Controls.Add(this.playerInventoryListBox);
            this.playerInventoryGroupBox.Location = new System.Drawing.Point(249, 274);
            this.playerInventoryGroupBox.Name = "playerInventoryGroupBox";
            this.playerInventoryGroupBox.Size = new System.Drawing.Size(250, 288);
            this.playerInventoryGroupBox.TabIndex = 29;
            this.playerInventoryGroupBox.TabStop = false;
            this.playerInventoryGroupBox.Text = "In&ventory";
            // 
            // playerInventoryListBox
            // 
            this.playerInventoryListBox.DataSource = this.inventoryBindingSource;
            this.playerInventoryListBox.DisplayMember = "Name";
            this.playerInventoryListBox.FormattingEnabled = true;
            this.playerInventoryListBox.ItemHeight = 20;
            this.playerInventoryListBox.Location = new System.Drawing.Point(6, 25);
            this.playerInventoryListBox.Name = "playerInventoryListBox";
            this.playerInventoryListBox.Size = new System.Drawing.Size(232, 204);
            this.playerInventoryListBox.TabIndex = 0;
            this.playerInventoryListBox.ValueMember = "Name";
            // 
            // playerScoreTextBox
            // 
            this.playerScoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Score", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerScoreTextBox.Location = new System.Drawing.Point(249, 222);
            this.playerScoreTextBox.Name = "playerScoreTextBox";
            this.playerScoreTextBox.Size = new System.Drawing.Size(140, 26);
            this.playerScoreTextBox.TabIndex = 28;
            // 
            // playerHealthTextBox
            // 
            this.playerHealthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Health", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerHealthTextBox.Location = new System.Drawing.Point(249, 150);
            this.playerHealthTextBox.Name = "playerHealthTextBox";
            this.playerHealthTextBox.Size = new System.Drawing.Size(140, 26);
            this.playerHealthTextBox.TabIndex = 26;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerNameTextBox.Location = new System.Drawing.Point(249, 78);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(283, 26);
            this.playerNameTextBox.TabIndex = 24;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(245, 199);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(51, 20);
            this.playerScoreLabel.TabIndex = 27;
            this.playerScoreLabel.Text = "&Score";
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(245, 127);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(56, 20);
            this.playerHealthLabel.TabIndex = 25;
            this.playerHealthLabel.Text = "&Health";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(245, 55);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(51, 20);
            this.playerNameLabel.TabIndex = 23;
            this.playerNameLabel.Text = "&Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 672);
            this.Controls.Add(this.nameListLabel);
            this.Controls.Add(this.deletePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.playerInventoryGroupBox);
            this.Controls.Add(this.playerScoreTextBox);
            this.Controls.Add(this.playerHealthTextBox);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.playerInventoryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.Label nameListLabel;
        private System.Windows.Forms.Button deletePlayerButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.GroupBox playerInventoryGroupBox;
        private System.Windows.Forms.ListBox playerInventoryListBox;
        private System.Windows.Forms.TextBox playerScoreTextBox;
        private System.Windows.Forms.TextBox playerHealthTextBox;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Label playerNameLabel;
    }
}

