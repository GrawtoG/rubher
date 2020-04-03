using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStop : MonoBehaviour
{
    public void Camerastop()
    {
        GetComponent<foolowcamera>().enabled = false;
    }
}
