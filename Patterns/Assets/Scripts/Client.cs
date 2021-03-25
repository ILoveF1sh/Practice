using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns;

public class Client : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SomeClass a = new SomeClass(12);
            gameObject.AddComponent(a.GetType());
        }
    }
}
