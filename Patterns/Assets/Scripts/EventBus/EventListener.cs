using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns;
public class EventListener : MonoBehaviour
{ 
   private void OnEnable()
   {
      EventBus.StartListening("A", Shoot);
   }

   private void Shoot()
   {
      Debug.Log("Shoot !");
   }
   
}
