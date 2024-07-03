using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public MenuButton playButton;
    public MenuButton optionsButton;
    public MenuButton quitButton;

    void Start()
    {
        // Set the default selected button
        EventSystem.current.SetSelectedGameObject(playButton.gameObject);
    }

    void Update()
    {
        // Check if the Enter key is pressed
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Get the currently selected GameObject
            GameObject selectedObject = EventSystem.current.currentSelectedGameObject;

            // Check which button is selected and invoke its action
            if (selectedObject == playButton.gameObject)
            {
                PlayGame();
            }
            else if (selectedObject == optionsButton.gameObject)
            {
                GetOptions();
            }
            else if (selectedObject == quitButton.gameObject)
            {
                QuitGame();
            }
        }
    }

    public void PlayGame()
    {
        // loads the next scene in the build settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GetOptions()
    {
        // should load the options menu
        // SceneManager.LoadScene("OptionsMenu");
    }

    public void QuitGame()
    {
        // a debug statement to check if the operation was performed
        Debug.Log("The game was quitted!");
        // quits the game
        Application.Quit();
    }
}
