public class HumanFactory : AbstractFactory
{
    public override IHuman GetHuman(HumanType humanType)
    {
        switch (humanType)
        {
            case HumanType.Beggar:
                IHuman beggar = new AbstractBeggar();
                return beggar;
            case HumanType.Farmer:
                IHuman farmer = new AbstractFarmer();
                return farmer;
            case HumanType.Shopowner:
                IHuman shopowner = new AbstractShopowner();
                return shopowner;
        }
        return null;
    }

    public override IAnimal GetAnimal(AnimalType animalType)
    {
        return null;
    }
}
