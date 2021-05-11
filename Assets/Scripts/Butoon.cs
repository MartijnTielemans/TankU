using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butoon : MonoBehaviour
{
    public GameObject interactable;
    private int pCount = 0;

    private void OnTriggerEnter(Collider col)
    {
        pCount++;
        if (col.gameObject.CompareTag("Player") && pCount == 1)
        {
            Debug.Log("Butoon pressed.");
            interactable.GetComponent<IInteractable>().Action("on");
        }
    }

    private void OnTriggerExit(Collider col)
    {
        pCount--;
        if (col.gameObject.CompareTag("Player") && pCount == 0)
        {
            Debug.Log("Butoon unpressed.");
            interactable.GetComponent<IInteractable>().Action("off");
        }
    }
}
