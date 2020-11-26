namespace UsersGiftsRegistryTask.Views
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    using UsersGiftsRegistryTask.Models;
    using UsersGiftsRegistryTask.Services.Repositories;

    public partial class FormUserRegistry : Form
    {
        private UserRepository userRepository;

        public FormUserRegistry(UserRepository userRepository)
        {
            InitializeComponent();
            this.userRepository = userRepository;
            RefreshControls();
        }

        private void RefreshControls()
        {
            bindingSourceUsers.Clear();
            IEnumerable<User> objResultList = userRepository
                    .GetAll()
                    .OrderByDescending(u => u.ID)
                    .Where(u => !u.FirstName.Contains("m"));
            if (objResultList.Count() == 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("FirstName", typeof(string)));
                dt.Columns.Add(new DataColumn("LastName", typeof(string)));
                dt.Columns.Add(new DataColumn("Birthday", typeof(string)));
                dt.Columns.Add(new DataColumn("Present", typeof(bool)));
                dt.Columns.Add(new DataColumn("ID", typeof(int)));

                dataGridViewUsers.DataSource = dt;

                //bindingSourceUsers.List.Add(new User());
            }
            else
            {
                bindingSourceUsers.DataSource = objResultList;
                dataGridViewUsers.DataSource = bindingSourceUsers;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                FormAddEditUser formAddUser = new FormAddEditUser(user);

                DialogResult dr = formAddUser.ShowDialog();
                if (dr == DialogResult.Abort)
                {
                    do
                    {
                        dr = formAddUser.ShowDialog();
                    } while (dr != DialogResult.OK && dr != DialogResult.Cancel);
                }
                if (dr == DialogResult.OK)
                {
                    userRepository.Insert(user);
                    RefreshControls();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something wrong happened in the Users Form :", ex);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewUsers.CurrentRow == null)
                {
                    return;
                }

                User user = (User)dataGridViewUsers.CurrentRow.DataBoundItem;
                FormAddEditUser formEditUser = new FormAddEditUser(user);

                DialogResult dr = formEditUser.ShowDialog();
                if (dr == DialogResult.Abort)
                {
                    do
                    {
                        dr = formEditUser.ShowDialog();
                    } while (dr != DialogResult.OK && dr != DialogResult.Cancel);
                }
                if (dr == DialogResult.OK)
                {
                    userRepository.Update(user);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something wrong happened in the Users Form :", ex);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dataGridViewUsers.CurrentRow == null)
                {
                    return;
                }
                User user = (User)dataGridViewUsers.CurrentRow.DataBoundItem;//bindingSourceUsers.Current;

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this item?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    userRepository.Delete(user);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something wrong happened in the Users Form :", ex);
            }
        }
    }
}
