using UnityEngine;

public class ClassAdapterClient : MonoBehaviour
{
    private IOnlinePlayer onlinePlayer;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            onlinePlayer = ScriptableObject.CreateInstance<OnlinePlayerClassAdapter>();

            string firstName = onlinePlayer.GetFirstName(0);
            string lastName = onlinePlayer.GetLastName(0);
            string fullNameLastFirst = onlinePlayer.GetFullNameLastFirst(0);
            string fullNameFirstLast = onlinePlayer.GetFullNameFirstLast(0);

            Debug.Log(firstName);
            Debug.Log(lastName);
            Debug.Log(fullNameLastFirst);
            Debug.Log(fullNameFirstLast);
        }
    }
}
