using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePrototyper : MonoBehaviour,IPrototype
{
    public int a = 2;
    public string b = "3";

    public IPrototype[] GetClone()
    {
        IPrototype firstPrototype = Instantiate(this);
        return new []{firstPrototype};
    }
}
