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
        curSpeed += -Input.GetAxis("CameraLeftP1") + Input.GetAxis("CameraRightP1") + -Input.GetAxis("CameraLeftP2") + Input.GetAxis("CameraRightP2");
        Debug.Log(curSpeed);
        curSpeed *= speed;

        cameraPivot.transform.Rotate(0, curSpeed * Time.deltaTime, 0);
    }
}
