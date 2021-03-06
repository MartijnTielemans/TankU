using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour, IInteractable
{
    float startPoint;
    public float endPoint;

    [Range(0, 1)]
    public float interpolation;

    [Range(0, 1)]
    public float interpolSpeed;
    public bool moveUp = false;
    public bool moveDown = false;

    private void Start()
    {
        startPoint = transform.position.y;
    }

    private void FixedUpdate()
    {
        if (moveUp && interpolation <= 1)
        {
            interpolation += interpolSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, interpolation * 360, 0);
        }
        if (moveDown && interpolation >= 0)
        {
            interpolation -= interpolSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, interpolation * 360, 0);
        }
        transform.position = new Vector3(transform.position.x, Mathf.Lerp(startPoint, endPoint, interpolation), transform.position.z);
    }

    void IInteractable.Action(string type)
    {
        if (type == "on")
        {
            moveUp = true;
            moveDown = false;
        }
        else if (type == "off")
        {
            moveDown = true;
            moveUp = false;
        }
    }
}
