using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory factory;

    private INPC beggar;
    private INPC farmer;
    private INPC shopowner;

    public void SpawnVillagers()
    {
        beggar = factory.GetNPC(NPCType.Beggar);
        farmer = factory.GetNPC(NPCType.Farmer);
        shopowner = factory.GetNPC(NPCType.Shopowner);

        beggar.Speak();
        farmer.Speak();
        shopowner.Speak();
    }
}
