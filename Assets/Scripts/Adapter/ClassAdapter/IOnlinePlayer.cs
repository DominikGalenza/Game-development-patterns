public interface IOnlinePlayer
{
    string GetFirstName(int userID);
    string GetLastName(int userID);
    string GetFullNameLastFirst(int userID);
    string GetFullNameFirstLast(int userID);
}
