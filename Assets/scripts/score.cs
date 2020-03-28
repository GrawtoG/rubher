
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
   
    void FixedUpdate()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
