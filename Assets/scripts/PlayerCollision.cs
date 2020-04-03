using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public int throwX = 500;
    public int throwY = 500;
    public int throwZ = 500;
    public int rotateX = 500;
    public int rotateY = 500;
    public int rotateZ = 500;
    public move movement;
    public Rigidbody rb;
    
    

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "wall")
        {
            movement.enabled = false;
            rb.AddForce(throwX, throwY, throwZ);
            rb.AddTorque(rotateX, rotateY, rotateZ);
            
            
            FindObjectOfType<Damaging>().DestroyIt();
            FindObjectOfType<GameMenager>().EndGame();


        }
        if (collisionInfo.collider.tag == "JumpPad")
        {
            
            FindObjectOfType<Jumppad>().Jump();
            
        }

    }

}

