namespace UsersGiftsRegistryTask.Views
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    using UsersGiftsRegistryTask.Models;

    public partial class FormAddEditUser : Form
    {
        private User user;

        public FormAddEditUser(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormAddEditUser_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("{0} - Add-Edit User", user.ID > 0 ? "Edit user" : "Add user");
                textBoxFirstName.Text = user.FirstName;
                textBoxLastName.Text = user.LastName;

                if (user.Birthday != null)
                {
                    dateTimePickerBirthday.Value = DateTime.Parse(user.Birthday, CultureInfo.InvariantCulture);
                }
                checkBoxPresent.Checked = user.Present;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something wrong happened in the Add-Edit User Form :", ex);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                user.FirstName = textBoxFirstName.Text;
                user.LastName = textBoxLastName.Text;
                user.Birthday = dateTimePickerBirthday.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                user.Present = checkBoxPresent.Checked;

                if (string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text))
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show("Please complete empty fields.");
                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Add-Edit User Form :", ex);
            }

        }
    }
}
