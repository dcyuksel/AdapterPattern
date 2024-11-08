namespace AdapterPattern.Repositories;
public class UserRepository : IUserRepository
{
    public IReadOnlyList<string> GetUsers()
    {
        return ["Albert Einstein", "Isaac Newton", "Stephen Hawking"];
    }
}