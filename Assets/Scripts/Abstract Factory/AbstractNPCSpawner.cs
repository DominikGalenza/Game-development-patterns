using UnityEngine;

public class AbstractNPCSpawner : MonoBehaviour
{
    private IAnimal cat;
    private IAnimal dog;
    private IHuman beggar;
    private IHuman farmer;
    private IHuman shopowner;
    private AbstractFactory abstractFactory;

    public void SpawnAnimals()
    {
        abstractFactory = FactoryProducer.GetFactory(FactoryType.Animal);

        cat = abstractFactory.GetAnimal(AnimalType.Cat);
        dog = abstractFactory.GetAnimal(AnimalType.Dog);

        cat.Voice();
        dog.Voice();
    }

    public void SpawnHumans()
    {
        abstractFactory = FactoryProducer.GetFactory(FactoryType.Human);

        beggar = abstractFactory.GetHuman(HumanType.Beggar);
        farmer = abstractFactory.GetHuman(HumanType.Farmer);
        shopowner = abstractFactory.GetHuman(HumanType.Shopowner);

        beggar.Speak();
        farmer.Speak();
        shopowner.Speak();
    }
}
