using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        // score will be set to 0 when the game is started
        if(instance == null){
            instance = this;
        }
        
    }
    // when the coins are collected by the player the sore will increment by the coin value that is set inside of unity
    public void ChangeScore(int coinValue){
        score += coinValue;
        text.text = "X" + score.ToString();
    }

}
