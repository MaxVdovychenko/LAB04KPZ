using System;
using System.Collections.Generic;

namespace LightHTMLObserver
{
    public abstract class LightElementNode
    {
        private Dictionary<EventType, List<Action>> listeners = new();

        public void AddEventListener(EventType type, Action handler)
        {
            if (!listeners.ContainsKey(type))
            {
                listeners[type] = new List<Action>();
            }

            listeners[type].Add(handler);
        }

        public void RemoveEventListener(EventType type, Action handler)
        {
            if (listeners.ContainsKey(type))
            {
                listeners[type].Remove(handler);
            }
        }

        protected void DispatchEvent(EventType type)
        {
            if (listeners.ContainsKey(type))
            {
                foreach (var handler in listeners[type])
                {
                    handler.Invoke();
                }
            }
        }

        public abstract void Render();
    }
}