using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFish : MonoBehaviour, IFish
{
    public void ShowClothes()
    {
        Debug.Log("Fish is naked");
    }
}
