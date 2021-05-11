using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butoon : MonoBehaviour
{
    public GameObject interactable;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Butoon pressed.");
            interactable.GetComponent<IInteractable>().Action("on");
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Butoon unpressed.");
            interactable.GetComponent<IInteractable>().Action("off");
        }
    }
}
