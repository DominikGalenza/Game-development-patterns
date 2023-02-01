using UnityEngine;

public class OnlinePlayerObjectAdapter : ScriptableObject
{
    public string GetFullName(OnlinePlayerForAdapter onlinePlayerForAdapter, int userId)
    {
        return $"{onlinePlayerForAdapter.GetFirstName(userId)} {onlinePlayerForAdapter.GetLastName(userId)}";  
    }
}
