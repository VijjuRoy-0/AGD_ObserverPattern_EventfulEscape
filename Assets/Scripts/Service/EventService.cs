using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventService 
{
    private static EventService instace;
    public static EventService Instance
    {
        get
        {
            if(instace == null)
            {
                instace = new EventService();
            }
            return instace;
        }
    }

    public EventController OnLightSwitchToggled { get; private set ; }    
    public EventService()
    {
        OnLightSwitchToggled = new EventController();
    }
}
