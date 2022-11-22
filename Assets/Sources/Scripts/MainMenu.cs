using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
    }
    public void LoadScene(int Level)
    {
        SceneManager.LoadScene(1);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
