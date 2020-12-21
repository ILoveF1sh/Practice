using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : Singleton<ServiceLocator>
{
    private IDictionary<object, object> _services = new Dictionary<object, object>();
    
    public void RegisterService<T>(T instance)
    {
        _services.Add(typeof(T), instance);
    }

    public T GetService<T>() where  T : Component
    {
        if (!_services.ContainsKey(typeof(T)))
        {
            T gm = new GameObject(typeof(T).Name).AddComponent<T>();
            _services.Add(typeof(T), gm);
        }
        return (T) _services[typeof(T)];
    }    
}
