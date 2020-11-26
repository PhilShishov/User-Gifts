namespace UsersGiftsRegistryTask
{
    using System;
    using System.Windows.Forms;
    using UsersGiftsRegistryTask.Views;
    using UsersGiftsRegistryTask.Services.Repositories;

    public static class UsersGiftsRegistry
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormUserRegistry(new UserRepository()));
        }
    }
}
