using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class SettingMenu : MonoBehaviour
{

    public GameObject PauseMenu;
    public AudioMixer audioMixer;
    public AudioMixer audioEffectMixer;
    public GameObject settingsMenu;
    public GameObject scoreUI;
    
    private void OptioinsOff()
    {
        SceneManager.LoadScene("pauseMenu", LoadSceneMode.Single);
    }


    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void QuitOptions()
    {
        PauseMenu.SetActive(true);
        settingsMenu.SetActive(false);
        scoreUI.SetActive(true);
    }

    public void SetEffectVolume(float EffectVolume)
    {
        audioMixer.SetFloat("EffectVolume", EffectVolume);
    }
}
