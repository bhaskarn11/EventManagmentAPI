namespace EventManagment.Services.Interfaces
{
    public interface IUserService
    {
        public User? GetUser();

        public User? UpdateUser();

        public User? CreateUser();
        public User? LogInUser();
        public User? LogOutUser();

        public User? DeleteUser();
    }
}
