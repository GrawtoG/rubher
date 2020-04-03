using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaging : MonoBehaviour
{
    public GameObject DamagedVersion;
    public Transform player;
    public GameObject EffectManager;
    public GameObject MusicManager;
    public GameObject Score;


    public void DestroyIt()
    {
        
        Score.SetActive(false);
        MusicManager.SetActive(false);
        EffectManager.SetActive(true);
        Instantiate(DamagedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
        FindObjectOfType<CameraStop>().Camerastop();
    }
    
}
