using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public GameObject cameraPivot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("CameraLeft") > 0)
        {

        }
        else if (Input.GetAxis("CameraRight") > 0)
        {

        }
    }
}
