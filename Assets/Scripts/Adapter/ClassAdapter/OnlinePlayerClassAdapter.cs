using UnityEngine;

public class OnlinePlayerClassAdapter : OnlinePlayerForClassAdapter, IOnlinePlayer
{
    public string GetFullNameLastFirst(int userID)
    {
        return GetFullName(userID);
    }

    public string GetFullNameFirstLast(int userID)
    {
        return $"{GetFirstName(userID)} {GetLastName(userID)}";
    }
}
