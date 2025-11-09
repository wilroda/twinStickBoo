using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    Button button;
    GameObject pauseMenu;
    private AudioSource[] allAudioSources;
    
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(delegate () { PauseGame(); });
        }

        pauseMenu = GameObject.Find("PauseMenu");   
    }

    public void PauseGame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            DisablePauseMenu();
        }
        else
        {
            Time.timeScale = 0;
            StopAllAudio();
        }

    }

    void StopAllAudio()
    {
        allAudioSources = Object.FindObjectsByType<AudioSource>(FindObjectsSortMode.None) as AudioSource[];
        foreach (AudioSource audios in allAudioSources)
        {
            audios.Stop();
        }
    }
    
    void DisablePauseMenu()
    {
        if(pauseMenu != null) 
            pauseMenu.SetActive(false);
    }
}