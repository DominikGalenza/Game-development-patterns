using UnityEngine;

public class StrategyClient : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Missile sideWinder = ScriptableObject.CreateInstance<SideWinder>();
            sideWinder.ApplySeek();

            Missile tomahawk = ScriptableObject.CreateInstance<Tomahawk>();
            tomahawk.ApplySeek();

            Torpedo torpedo = ScriptableObject.CreateInstance<Torpedo>();
            torpedo.ApplySeek();

            Missile sideWinderWithSonar = ScriptableObject.CreateInstance<SideWinder>();
            ISeekBehaviour sonar = new SeekWithSonar();
            sideWinderWithSonar.SetSeekBehaviour(sonar);
            sideWinderWithSonar.ApplySeek();
        }
    }
}
