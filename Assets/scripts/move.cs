
using UnityEngine;

public class move : MonoBehaviour
    {
    public Rigidbody rb;
    public int velocity = 2000;
    public int goRight = 500;
    public int goLeft = -500;

   

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, velocity * Time.fixedDeltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(goRight * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(goLeft * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if(rb.position.y < -1)
        {
            FindObjectOfType<GameMenager>().EndGame();
        }
    }
}
