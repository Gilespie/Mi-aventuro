using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pause;
    [SerializeField] private FirstPersonController m_TargetCharacter;
   
    void Start()
    {
        pause.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            m_TargetCharacter.enabled = false;
            pause.SetActive(true);
            Time.timeScale = 0;
            
        }
    }
    public void pauseOff()
    {
        Cursor.visible = false;
        pause.SetActive(false);
        m_TargetCharacter.enabled = true;
        Time.timeScale = 1;
        
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
