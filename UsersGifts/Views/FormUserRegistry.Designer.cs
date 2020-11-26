namespace UsersGiftsRegistryTask.Views
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormUserRegistry
    {
        private IContainer components = null;

        private ToolStrip toolStripMain;
        private DataGridView dataGridViewUsers;
        private BindingSource bindingSourceUsers;
        private ToolStripButton AddButton;
        private ToolStripButton EditButton;
        private ToolStripButton DeleteButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormUserRegistry));
            this.toolStripMain = new ToolStrip();
            this.AddButton = new ToolStripButton();
            this.EditButton = new ToolStripButton();
            this.DeleteButton = new ToolStripButton();
            this.dataGridViewUsers = new DataGridView();
            this.bindingSourceUsers = new BindingSource(this.components);
            this.toolStripMain.SuspendLayout();
            ((ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new ToolStripItem[] {
            this.AddButton,
            this.EditButton,
            this.DeleteButton});
            this.toolStripMain.Location = new Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new Size(800, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.AddButton.Image = ((Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new Size(33, 22);
            this.AddButton.Text = "Add";
            this.AddButton.Click += new EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.EditButton.Image = ((Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new Size(31, 22);
            this.EditButton.Text = "Edit";
            this.EditButton.Click += new EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.DeleteButton.Image = ((Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new Size(44, 22);
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new EventHandler(this.DeleteButton_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = DockStyle.Fill;
            this.dataGridViewUsers.Location = new Point(0, 25);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new Size(800, 425);
            this.dataGridViewUsers.TabIndex = 1;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.toolStripMain);
            this.Name = "FormUserRegistry";
            this.Text = "User Registry";
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}