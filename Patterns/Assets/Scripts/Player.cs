using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private IFish fish = new BaseFish();

    private void Awake()
    {
        fish = new GameObject("Fish").AddComponent<BaseFish>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ServiceLocator.Instance.GetService<ServiceOne>().DoSomething();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ServiceLocator.Instance.GetService<ServiceTwo>().DoSomething();
        }
    }
}
