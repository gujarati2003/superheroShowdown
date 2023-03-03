using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        //The cursor will not be visible when the game is being played
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // If the escape key is pressed 
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            // and the pause menu is not active
            if(!pauseMenu.activeSelf)
            {
                // the pause menu will appear
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
            } else{
                Time.timeScale = 1f;
                pauseMenu.SetActive(false);
                Cursor.visible = false;
            }
        }
    }
    // if quit is pressed then the game will quit
    public void quit(){
        Application.Quit();
    }
    //if resume is pressed then the game will be resumed and the pause menu will disapear
    public void resume(){
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
    }
}
