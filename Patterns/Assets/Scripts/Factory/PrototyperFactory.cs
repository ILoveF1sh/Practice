using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototyperFactory : MonoBehaviour
{
    [SerializeField] private SinglePrototyper singlePrototyper;
    [SerializeField] private DoubleProrotyper doublePrototyper;
    [SerializeField] private TriplePrototyper triplePrototyper;
    
    
    public IPrototype GetPrototyper(ProrotyperTypes type)
    {
        return type switch
        {
            ProrotyperTypes.SINGLE => singlePrototyper,
            ProrotyperTypes.DOUBLE => doublePrototyper,
            ProrotyperTypes.TRIPE => triplePrototyper,

        };
    }
}

public enum ProrotyperTypes
{
    SINGLE,
    DOUBLE,
    TRIPE
}
