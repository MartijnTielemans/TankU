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

    private void Update()
    {
        //if (!moveUp && !moveDown)
        //{

        //}
        //else if (moveUp)
        //{
        //    transform.position = new Vector3(transform.position.x, Mathf.Lerp(startPoint, endPoint, interpolation), transform.position.z);

        //    if (interpolation !>= 1)
        //    interpolation += interpolSpeed * Time.deltaTime;
        //}
        //else if (moveDown)
        //{
        //    transform.position = new Vector3(transform.position.x, Mathf.Lerp(endPoint, startPoint, interpolation), transform.position.z);

        //    if (interpolation !>= 1)
        //        interpolation += interpolSpeed * Time.deltaTime;
        //}
        if (moveUp && interpolation <= 1)
        {
            interpolation += interpolSpeed * Time.deltaTime;
        }
        if (moveDown && interpolation >= 0)
        {
            interpolation -= interpolSpeed * Time.deltaTime;
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
