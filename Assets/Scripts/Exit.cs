using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    
    Button button;

    void Start()
    {
        button = gameObject.GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(delegate () { ExitGame(); });
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
