using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

/*

Using the event manager: 

- Listener script A: add code from EventListener
- OnEvent() will run once from script A on the event sent out by trigger script B ("testEvent")
- Trigger script B: EventManager.TriggerEvent ("testEvent")




*/



public class EventManager : MonoBehaviour {

    private Dictionary <string, UnityEvent> eventDictionary;

    private static EventManager eventManager;

    public static EventManager instance
    {
        get
        {
            if (!eventManager)
            {
                eventManager = FindObjectOfType (typeof (EventManager)) as EventManager;

                if (!eventManager)
                {
                    Debug.LogError ("There needs to be one active EventManger script on a GameObject in your scene.");
                }
                else
                {
                    eventManager.Init (); 
                }
            }

            return eventManager;
        }
    }

    void Init ()
    {
        if (eventDictionary == null)
        {
            eventDictionary = new Dictionary<string, UnityEvent>();
        }
    }

    public static void StartListening (string eventName, UnityAction listener)
    {
        UnityEvent thisEvent = null;
        if (instance.eventDictionary.TryGetValue (eventName, out thisEvent))
        {
            thisEvent.AddListener (listener);
        } 
        else
        {
            thisEvent = new UnityEvent ();
            thisEvent.AddListener (listener);
            instance.eventDictionary.Add (eventName, thisEvent);
        }
    }

    public static void StopListening (string eventName, UnityAction listener)
    {
        if (eventManager == null) return;
        UnityEvent thisEvent = null;
        if (instance.eventDictionary.TryGetValue (eventName, out thisEvent))
        {
            thisEvent.RemoveListener (listener);
        }
    }

    public static void TriggerEvent (string eventName)
    {
        UnityEvent thisEvent = null;
        if (instance.eventDictionary.TryGetValue (eventName, out thisEvent))
        {
            thisEvent.Invoke ();
        }
    }
}





// https://learn.unity.com/tutorial/create-a-simple-messaging-system-with-events#5cf5960fedbc2a281acd21fa


/*


goatus
2 points
·
2 years ago
I do a lot of data visualisation in Unity and a lot of it is event driven:

Domain Model classes using INotifyPropertyChanged and INotifyCollectionChanged

Data communication APIs. Events are also fired in background threads

Lately I've been moving towards an MVVM design (where GameObjects and prefabs are the 'view'), with my own data binding behaviours (which are MonoBehaviours) and a DataContext (just like WPF). Basically what I'm saying is, everything is event driven.

I decided to give reactive extensions ago, using UniRX on the asset store. I am sold on the idea of Rx in Unity. Here are a few examples:

No need for me to care about threading. All I need to do is: observable.SubscribeOnMainThread().Subscribe( PropertyChanged );

Filter out super frequent events by Throttle and/or Sample. I had a MonoBehaviour that would create a mesh based off of 4 or more properties. Using .Throttle I can wait until all properties are set and haven't changed for X milliseconds. Otherwise setting the 4 properties would fire the event 4 times, and I'd get 4 different meshes, when I only want the last one.

Easily dispose of all event subscriptions

Hard to get your head around, but it is enjoyable when you reap the benefits



https://www.reddit.com/r/Unity3D/comments/4uoc9p/event_driven_programming_in_unity/

*/
