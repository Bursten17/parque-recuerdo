namespace morcom_api.Application.Abstract
{
    public interface IUserAccessor
    {
        string GetCurrentUserName();
        string GetCurrentUserIdRol();
    }
}