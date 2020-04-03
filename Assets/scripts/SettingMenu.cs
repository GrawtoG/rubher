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
    
    private void OptionsOff()
    {
        settingsMenu.SetActive(false);
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
    
    public void SetQuality (int odd)
    {

        QualitySettings.SetQualityLevel(odd);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(odd);
    }
    public void SetFullscreen (bool IsFullscreen)
    {
        Screen.fullScreen = IsFullscreen;
    }

    

}
