using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
public int coinValue = 1;

// i am going to save it
// When the player hits the object set to other the scoreManager script will activate and will also disapear the coin
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            ScoreManager.instance.ChangeScore(coinValue);
            // add in sound effect script here 
        }
    }
}
