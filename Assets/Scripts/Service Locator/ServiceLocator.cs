using System;
using System.Collections.Generic;


public class ServiceLocator : Singleton<ServiceLocator>
{
    private IDictionary<object, object> services;

    public override void Awake()
    {
        base.Awake();
        FillRegistry();
    }

    private void FillRegistry()
    {
        services = new Dictionary<object, object>();

        services.Add(typeof(LobbyCoordinator), new LobbyCoordinator());
        services.Add(typeof(CurrencyConverter), new CurrencyConverter());
        services.Add(typeof(LightingCoordinator), new LightingCoordinator());
    }

    public T GetService<T>()
    {
        try
        {
            return (T)services[typeof(T)];
        }
        catch
        {
            throw new ApplicationException("The requested service is not found.");
        }
    }
}
