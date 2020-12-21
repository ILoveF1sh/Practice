using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBootDecorator : FishDecorator
{
    public FishBootDecorator(IFish fish) : base(fish) {}

    public override void ShowClothes()
    {
        base.ShowClothes();
        Debug.Log("Boots ");
    }
}
