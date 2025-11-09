using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button button = gameObject.GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(delegate () { RestartGame(); });
        }
    }

    public void RestartGame()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);

        // Reset Pause
        Time.timeScale = 1;
    }
    
}
