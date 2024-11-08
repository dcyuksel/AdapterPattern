using AdapterPattern.Models;

namespace AdapterPattern.Export;
public interface IUserExportService
{
    void Export(IReadOnlyList<User> users);
}
