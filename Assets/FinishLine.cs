using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other){
        //When the player reaches the object that has been set to other, the scene will load to the new level
        if(other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("level2");
        }
    }
}
