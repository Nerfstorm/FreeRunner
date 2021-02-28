using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCameraMovement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        if(RunCharacterMovement.END == false) transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }

}
