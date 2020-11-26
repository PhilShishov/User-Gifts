namespace UsersGiftsRegistryTask.Models
{
    using System;

    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public bool Present { get; set; }
    }
}
