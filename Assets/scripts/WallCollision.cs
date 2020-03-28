
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    public int throwX = 500;
    public int throwY = 500;
    public int throwZ = 500;
    public Rigidbody rd;
    private void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.name == "player")
        {
            rd.AddForce(throwX, throwY, throwZ);

    


        }
    }
}

