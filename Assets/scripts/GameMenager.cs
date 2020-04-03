
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMenager : MonoBehaviour
{
    public float restartDelay = 5f;
    bool gameHasEnded = false;
    public GameObject LevelCompleteUI;
    public GameObject Text;
    public GameObject MusicMenager;

    public void LevelComplete()
    {
             
        Text.SetActive(false);
        MusicMenager.SetActive(false);
        LevelCompleteUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        gameHasEnded = true;
        
        Invoke("Restart", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    private void Start()
    {
        Time.timeScale = 1f;
    }
}
