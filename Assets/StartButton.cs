using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Name of the scene you want to load
    public string sceneToLoad = "Gameplay";

    // This function will be called when the button is clicked
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}