using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public GameObject cameraPivot;
    public float speed;
    public float curSpeed;

    // Update is called once per frame
    void Update()
    {
        curSpeed = 0;
        curSpeed += Input.GetAxis("CameraP1") + Input.GetAxis("CameraP2");
        curSpeed *= speed;

        cameraPivot.transform.Rotate(0, curSpeed * Time.deltaTime, 0);
    }
}
