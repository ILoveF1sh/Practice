using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns;
public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            EventBus.TriggerEvent("A");
        }
    }
}
