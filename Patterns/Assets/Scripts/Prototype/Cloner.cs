using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Patterns;

public class Cloner : MonoBehaviour
{
    [SerializeField] private List<IPrototype> _prototypes = new List<IPrototype>();

    private void Start()
    {
        PrototyperFactory factory = FindObjectOfType<PrototyperFactory>();
        _prototypes.Add(factory.GetPrototyper(ProrotyperTypes.SINGLE));
        _prototypes.Add(factory.GetPrototyper(ProrotyperTypes.DOUBLE));
        _prototypes.Add(factory.GetPrototyper(ProrotyperTypes.TRIPE));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int len = _prototypes.Count;
            for (var i = 0; i < len; i++)
            {
                _prototypes.AddRange(_prototypes[i].GetClone());
            }
        }
    }
}
