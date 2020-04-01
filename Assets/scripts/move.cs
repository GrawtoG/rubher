
using UnityEngine;
using UnityEngine.Rendering;


public class move : MonoBehaviour
    {
    public Rigidbody rb;
    public int velocity = 2000;
    public int goRight = 500;
    public int goLeft = -500;
    public Material Material1;
    public Renderer Object;


    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, velocity * Time.fixedDeltaTime);
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(goRight * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(goLeft * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);

        }
        
        
        if (rb.position.y < 215)
        {
            
            
            Object.material = Material1;
            GetComponent<DissolveSphere>().enabled = true;
            
            FindObjectOfType<GameMenager>().EndGame();
            


        }

        

    }
}
