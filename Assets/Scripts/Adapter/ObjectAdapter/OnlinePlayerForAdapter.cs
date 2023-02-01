using UnityEngine;

public sealed class OnlinePlayerForAdapter : ScriptableObject
{
    public string GetFirstName(int id)
    {
        return "John";
    }

    public string GetLastName(int id)
    {
        return "Doe";
    }

    public string GetFullName(int id)
    {
        return "Doe John";
    }
}
