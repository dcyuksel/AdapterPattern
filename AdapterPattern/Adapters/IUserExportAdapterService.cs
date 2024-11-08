namespace AdapterPattern.Adapters;
public interface IUserExportAdapterService
{
    void Export(IReadOnlyList<string> users);
}
