
using UnityEngine;

public class Jumppad : MonoBehaviour
{
    public int throwX;
    public int throwY;
    public int throwZ;
    public Rigidbody rb;
   public void Jump()
    {
        rb.AddForce(throwX, throwY, throwZ);

    }

}
