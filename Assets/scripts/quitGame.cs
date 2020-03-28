
using UnityEngine;
using UnityEngine.SceneManagement;
public class quitGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitGame ()
    {
        SceneManager.LoadScene("Welcome", LoadSceneMode.Single);
    }

    
}
