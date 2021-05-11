using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butoon : MonoBehaviour
{
    public GameObject interactable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
        }
    }
}
