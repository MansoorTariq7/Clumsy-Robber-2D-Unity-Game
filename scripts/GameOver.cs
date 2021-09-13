using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

//using UnityEditor.XR.WSA.Input;
    public AudioClip retryplay;
    private AudioSource audio;
    public Text score;
    int OverScore;
    
    public GameObject Ad;

    private void Start()
    {
        Ad.GetComponent<AdMob>().showInterstitial();
        audio = GetComponent<AudioSource>();
        ScoreText();

    }

    private void ScoreText()
    {
        OverScore = PlayerPrefs.GetInt("Score", 0);
        score.text = OverScore.ToString();
    }

    public void re_playgame()
    {
        audio.PlayOneShot(retryplay);

        for (int i = 0; i < 99555550 + 150000000; i++)
        {

        }
        SceneManager.LoadScene(1);
    }

    public void backgame()
    {
        audio.PlayOneShot(retryplay);

        for (int i = 0; i < 99555550 + 150000000; i++)
        {

        }
        SceneManager.LoadScene(0);
    }

}
