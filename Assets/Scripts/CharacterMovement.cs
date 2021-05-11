using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public string movePlayer;
    public string turnPlayer;

    public float turnSpeed;
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(movePlayer) && !Input.GetButton(turnPlayer))
        {
            transform.Translate((Vector3.forward * moveSpeed) * Time.deltaTime);
        }

        if (Input.GetButton(turnPlayer))
        {
            transform.Rotate(0, (Input.GetAxis(turnPlayer) * turnSpeed) * Time.deltaTime, 0);
        }
    }
}
