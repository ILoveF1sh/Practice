using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FishDecorator : MonoBehaviour, IFish
{
    private IFish _decoratedFish;

    public FishDecorator(IFish fish)
    {
        _decoratedFish = fish;
    }
    public virtual void ShowClothes()
    {
        Debug.Log("Fish has ");
    }
}
