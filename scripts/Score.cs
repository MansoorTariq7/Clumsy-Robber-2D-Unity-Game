using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Score : MonoBehaviour
{

   //public Text scoretext;
   // Text scoretextO;

   // public int score;
    public Text highscore;
    public Text HScore;
    int coins;
    int Hscorecoins;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        // score = GetComponent<Text>();
        //GameObject thePlayer = GameObject.Find("thePlayer");
        //Player_Movement player_Movement = thePlayer.GetComponent<Player_Movement>();
        //scoretextO = player_Movement.highscore;
        //// scoretext = GetComponent<Text>();
        ////FindObjectOfType<Text>().text = score.ToString();
        //scoretext.text = scoretextO.ToString();

        ScoreTextA();
 
    }
    private void ScoreTextA()
    {
        // highscore
        Hscorecoins = PlayerPrefs.GetInt("HighScore", 0);
        HScore.text = Hscorecoins.ToString();



        // totalcoins
        coins = PlayerPrefs.GetInt("TotalCoins", 0);
        highscore.text = coins.ToString();

        

    }
}
