using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    
    Button button;

    void Start()
    {
        button = gameObject.GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(delegate () { StartGame(); });
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");

        // Reset Pause
        Time.timeScale = 1;
    }
}
