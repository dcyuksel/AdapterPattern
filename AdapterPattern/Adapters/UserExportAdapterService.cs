using AdapterPattern.Export;
using AdapterPattern.Models;

namespace AdapterPattern.Adapters;
public class UserExportAdapterService(IUserExportService userExportService) : IUserExportAdapterService
{
    public void Export(IReadOnlyList<string> users)
    {
        userExportService.Export(Parse(users).ToList());
    }

    private static IEnumerable<User> Parse(IReadOnlyList<string> users)
    {
        foreach (var user in users) 
        {
            var splitted= user.Split(' ');

            yield return new(splitted[0], splitted[1]);
        }
    }
}
