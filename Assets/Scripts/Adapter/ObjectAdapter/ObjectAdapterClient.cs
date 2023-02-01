using UnityEngine;

public class ObjectAdapterClient : MonoBehaviour
{
    private OnlinePlayerForAdapter onlinePlayerForAdapter;
    private OnlinePlayerObjectAdapter onlinePlayerObjectAdapter;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            onlinePlayerForAdapter = ScriptableObject.CreateInstance<OnlinePlayerForAdapter>();
            onlinePlayerObjectAdapter = ScriptableObject.CreateInstance<OnlinePlayerObjectAdapter>();

            string firstName = onlinePlayerForAdapter.GetFirstName(0);
            string lastName = onlinePlayerForAdapter.GetLastName(0);
            string fullNameLastFirst = onlinePlayerForAdapter.GetFullName(0);
            string fullNameFirstLast = onlinePlayerObjectAdapter.GetFullName(onlinePlayerForAdapter, 0);

            Debug.Log(firstName);
            Debug.Log(lastName);
            Debug.Log(fullNameLastFirst);
            Debug.Log(fullNameFirstLast);
        }
    }
}
