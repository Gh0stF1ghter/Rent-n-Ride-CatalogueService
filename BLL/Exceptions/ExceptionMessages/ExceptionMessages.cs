namespace BLL.Exceptions.ExceptionMessages;

public static class ExceptionMessages
{
    public static string NotFound(string entityType, Guid guid) =>
        $"{entityType} with id:{guid} was not found";

    public static string IdIsNotGuid(string id) =>
        $"Provided id is not GUID ({id})";
}