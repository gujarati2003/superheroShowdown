using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
public GameObject background;
public GameObject startPoint;
public GameObject Player;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        DeathScript checkIfDead = new DeathScript();
        bool dead = checkIfDead.getIsDead();
        if(dead == true)
        {
            if(!background.activeSelf)
            {
                Time.timeScale = 0f;
                background.SetActive(true);
                Cursor.visible = true;
            } else{
                Time.timeScale = 1f;
                background.SetActive(false);
                Cursor.visible = false;
            }
        }
    }

    public void restart(){
        Time.timeScale = 1f;
        background.SetActive(false);
        Cursor.visible = false;
        SceneManager.LoadScene("Level1");
    }

    public void Setup(){
        
    }
}
