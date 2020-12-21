using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishHatDecorator : FishDecorator
{
    public FishHatDecorator(IFish fish) : base(fish) {}

    public override void ShowClothes()
    {
        base.ShowClothes();
        Debug.Log("Hat ");
    }
}
