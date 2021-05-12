using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearTurn : MonoBehaviour
{
    public Vector3 turnVector;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(turnVector * Time.deltaTime);
    }
}
