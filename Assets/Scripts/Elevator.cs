using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour, IInteractable
{
    void IInteractable.Action(string type)
    {
        if (type == "on")
        {
            Debug.Log("Iton");
        }
        else if (type == "off")
        {

        }
    }
}
