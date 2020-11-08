namespace Zork.Builder.WinForms
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
            System.Windows.Forms.Label fileLabel;
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.playerTabPage = new System.Windows.Forms.TabPage();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.roomsTabPage = new System.Windows.Forms.TabPage();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.playerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new System.Drawing.Point(12, 12);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new System.Drawing.Size(38, 20);
            fileLabel.TabIndex = 0;
            fileLabel.Text = "File:";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "Filename", true));
            this.filenameTextBox.Location = new System.Drawing.Point(56, 9);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(751, 26);
            this.filenameTextBox.TabIndex = 1;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(813, 9);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(46, 26);
            this.selectFileButton.TabIndex = 2;
            this.selectFileButton.Text = "...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files(*json)|*.json";
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork.Builder.WinForms.ViewModels.WorldViewModel);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playerTabPage);
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Controls.Add(this.roomsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 52);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(847, 608);
            this.mainTabControl.TabIndex = 3;
            // 
            // playerTabPage
            // 
            this.playerTabPage.Controls.Add(this.deletePlayerButton);
            this.playerTabPage.Controls.Add(this.addPlayerButton);
            this.playerTabPage.Controls.Add(this.playerListBox);
            this.playerTabPage.Location = new System.Drawing.Point(4, 29);
            this.playerTabPage.Name = "playerTabPage";
            this.playerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playerTabPage.Size = new System.Drawing.Size(839, 575);
            this.playerTabPage.TabIndex = 0;
            this.playerTabPage.Text = "Player";
            this.playerTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Location = new System.Drawing.Point(4, 29);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(839, 575);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // roomsTabPage
            // 
            this.roomsTabPage.Location = new System.Drawing.Point(4, 29);
            this.roomsTabPage.Name = "roomsTabPage";
            this.roomsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTabPage.Size = new System.Drawing.Size(839, 575);
            this.roomsTabPage.TabIndex = 2;
            this.roomsTabPage.Text = "Rooms";
            this.roomsTabPage.UseVisualStyleBackColor = true;
            // 
            // playerListBox
            // 
            this.playerListBox.DataSource = this.playerBindingSource;
            this.playerListBox.DisplayMember = "Name";
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 20;
            this.playerListBox.Location = new System.Drawing.Point(0, 0);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(287, 504);
            this.playerListBox.TabIndex = 1;
            this.playerListBox.ValueMember = "Health";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(6, 510);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 36);
            this.addPlayerButton.TabIndex = 2;
            this.addPlayerButton.Text = "&Add...";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Location = new System.Drawing.Point(87, 510);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(75, 36);
            this.deletePlayerButton.TabIndex = 3;
            this.deletePlayerButton.Text = "&Delete";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(ZorkBuilder.Data.PlayerCharacter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 672);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(fileLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.playerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage playerTabPage;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.TabPage roomsTabPage;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Button deletePlayerButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.BindingSource playerBindingSource;
    }
}

