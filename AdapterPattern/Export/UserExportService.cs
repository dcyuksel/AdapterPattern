using AdapterPattern.Models;

namespace AdapterPattern.Export;
public class UserExportService : IUserExportService
{
    public void Export(IReadOnlyList<User> users)
    {
        foreach (var user in users)
        {
            Console.WriteLine($"{nameof(User.FirstName)}: {user.FirstName} - {nameof(user.LastName)}: {user.LastName}.");
        }
    }
}
