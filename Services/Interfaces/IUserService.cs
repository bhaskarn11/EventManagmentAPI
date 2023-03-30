using EventManagment.Dtos;

namespace EventManagment.Services.Interfaces
{
    public interface IUserService
    {
        public Task<User>? GetUser(int userId);

        public Task<User>? UpdateUser(UpdateUserDto updateUserDto);

        public Task<User>? CreateUser(CreateUserDto createUser);
        public Task<User>? LogInUser();
        public Task<User>? LogOutUser();

        public Task<int>? DeleteUser(int userId);
    }
}
