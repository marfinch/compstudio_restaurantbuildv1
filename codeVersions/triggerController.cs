//code reference https://youtu.be/tJiO4cvsHAo
//myDoor - firstLight
// open - on   close - off

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    [SerializeField] private Animator firstLight = null;
    
    [SerilizeField] private bool onTrigger = false;
        
    [SerilizeField] private bool offTrigger = false;

        
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (onTrigger)
            {
            my.Play("LightOn", 0, 0.0f);
            gameObject.SetActive(false)
        }
        
        else if (offTrigger)
        {
            my.Play("LightOff", 0, 0.0f);
            gameObject.SetActive(false)
        }
    }
}

