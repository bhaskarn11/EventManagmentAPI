using EventManagment.Dtos;

namespace EventManagment.Services
{
    public class UserService : IUserService
    {
        public Task<User>? CreateUser(CreateUserDto createUser)
        {
            throw new NotImplementedException();
        }

        public Task<int>? DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User>? GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User>? LogInUser()
        {
            throw new NotImplementedException();
        }

        public Task<User>? LogOutUser()
        {
            throw new NotImplementedException();
        }

        public Task<User>? UpdateUser(UpdateUserDto updateUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
