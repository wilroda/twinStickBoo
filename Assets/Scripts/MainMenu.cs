using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button button = gameObject.GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(delegate () { ReturnMainMenu(); });
        }
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("Menu");

        // Reset Pause
        Time.timeScale = 1;
    }
}
