using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour

{
    public GameObject startPoint;
    public GameObject Player;
    public bool isDead;

    public DeathScript(){

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D other){
    // when the player hits the object that is set to other the player will return to the active scene
        if(other.gameObject.CompareTag("Player")){
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
            // Player.transform.position = startPoint.transform.position;
            // isDead = true;
        }
    }

    public bool getIsDead(){
        return isDead;
    }
}
