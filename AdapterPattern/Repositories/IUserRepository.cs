namespace AdapterPattern.Repositories;
public interface IUserRepository
{
    IReadOnlyList<string> GetUsers();
}