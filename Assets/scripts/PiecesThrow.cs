using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecesThrow : MonoBehaviour
{
    public float Xgora = 0.5f;
    public float Xdol = 0.5f;
    public float Ygora = 0.5f;
    public float Ydol = 0.5f;
    public float Zgora = 0.5f;
    public float Zdol = 0.5f;
    
    public Rigidbody rd;

    private void Start()
    {
        rd.AddForce(Random.Range(Xdol, Xgora), Random.Range(Ydol, Ygora), Random.Range(Zdol, Zgora));
    }


}
