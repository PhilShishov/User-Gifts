namespace UsersGiftsRegistryTask.Views
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormAddEditUser
    {
        private IContainer components = null;

        private Label labelFirstName;
        private Label labelLastName;
        private Label labelPresent;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private CheckBox checkBoxPresent;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelBirthday;
        private DateTimePicker dateTimePickerBirthday;

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
            this.labelFirstName = new Label();
            this.labelLastName = new Label();
            this.labelPresent = new Label();
            this.textBoxFirstName = new TextBox();
            this.textBoxLastName = new TextBox();
            this.checkBoxPresent = new CheckBox();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            this.labelBirthday = new Label();
            this.dateTimePickerBirthday = new DateTimePicker();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new Point(68, 65);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new Point(68, 99);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new Size(58, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // labelPresent
            // 
            this.labelPresent.AutoSize = true;
            this.labelPresent.Location = new Point(68, 169);
            this.labelPresent.Name = "labelPresent";
            this.labelPresent.Size = new Size(43, 13);
            this.labelPresent.TabIndex = 3;
            this.labelPresent.Text = "Present";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new Point(129, 62);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new Size(200, 20);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new Point(129, 96);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new Size(200, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // checkBoxPresent
            // 
            this.checkBoxPresent.AutoSize = true;
            this.checkBoxPresent.Location = new Point(129, 169);
            this.checkBoxPresent.Name = "checkBoxPresent";
            this.checkBoxPresent.Size = new Size(15, 14);
            this.checkBoxPresent.TabIndex = 7;
            this.checkBoxPresent.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = DialogResult.OK;
            this.buttonSave.Location = new Point(129, 204);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(254, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new Point(68, 134);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new Size(45, 13);
            this.labelBirthday.TabIndex = 10;
            this.labelBirthday.Text = "Birthday";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new Point(129, 128);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new Size(200, 20);
            this.dateTimePickerBirthday.TabIndex = 11;
            this.dateTimePickerBirthday.Value = new DateTime(2019, 1, 9, 23, 9, 0, 0);
            // 
            // FormAddEditUser
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxPresent);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelPresent);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "FormAddEditUser";
            this.Text = "Add/Edit Users";
            this.Load += new EventHandler(this.FormAddEditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}