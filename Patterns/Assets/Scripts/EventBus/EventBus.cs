using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Patterns
{
    public class EventBus : Singleton<EventBus>
    {
        private Dictionary<string, UnityEvent> _eventDictionary;
    
        protected override void Awake()
        {
            base.Awake();
            Instance.Init();
        }
    
        private void Init()
        {
            if (_eventDictionary == null)
            {
                _eventDictionary = new Dictionary<string, UnityEvent>();
            }
        }
    
        public static void StartListening(string eventName, UnityAction listener)
        {
            if (Instance._eventDictionary.TryGetValue(eventName, out UnityEvent newEvent))
            {
                newEvent.AddListener(listener);
            }
            else
            {
                newEvent = new UnityEvent();
                newEvent.AddListener(listener);
                Instance._eventDictionary.Add(eventName, newEvent);
            }
        }
    
        public static void StopListening(string eventName, UnityAction listener)
        {
            if (Instance._eventDictionary.TryGetValue(eventName, out UnityEvent newEvent))
            {
                newEvent.RemoveListener(listener);
            }
        }
    
        public static void TriggerEvent(string eventName)
        {
            if (Instance._eventDictionary.TryGetValue(eventName, out UnityEvent newEvent))
            {
                newEvent.Invoke();
            }
        }
        
    }
}

