using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private void Update()
    {
        if (PlayerController.instance!= null && !PlayerController.instance.dead)
        {
            Vector3 targetPos = PlayerController.instance.transform.position;
            targetPos.z= -10;

            transform.position = targetPos;
        }
    }
}
