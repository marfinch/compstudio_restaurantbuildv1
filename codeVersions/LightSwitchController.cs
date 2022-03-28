using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitchRaycast : MonoBehaviour
{
    [SerializeField] private boo1 isLightOn;
    
    [SerilizeField] private UnityEvent lightOnEvent;
    [SerilizeField] private UnityEvent lightOffEvent;
    
    public void InteractSwitch()
    {
        if (lisLightON)
        {
            isLightOn = true;
            lightOnEvent.Invoke();
        }
        else
        {
            isLightOn= false;
            lightOffEvent.Invoke();
        }
    }
}

