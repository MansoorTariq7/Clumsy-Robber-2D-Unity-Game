using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
//using UnityEngine.UI;
using System.IO;

public class Player_Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public int scorevalue = 0;
    public static int tempscore = 1;
    public Text score;
    public Text highscore;
    public int totalcoins;
    public AudioSource audioJUMP;
    public AudioClip pointaudio;
    private AudioSource pointA;
    public AudioClip Highscore_audio;
    private int smoth = 1;
    Quaternion down;
    Quaternion fawd;
    int OverScore;
    int check = 1;
    //  public int counterTime;
    // public Text counter;

    void Start()
    {
       // StartCoroutine(CountDownToStart());

        rb = GetComponent<Rigidbody2D>();


        audioJUMP = GetComponent<AudioSource>();
        pointA = GetComponent<AudioSource>();
        down = Quaternion.Euler(0,0,-70);
        fawd = Quaternion.Euler(0, 0, 25);
        highscore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        totalcoins = PlayerPrefs.GetInt("TotalCoins", 0);
        OverScore = PlayerPrefs.GetInt("Score", 0);

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = fawd;
            rb.velocity = new Vector2(rb.velocity.x, 5);
            audioJUMP.Play();
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, down, smoth * Time.deltaTime);

    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        scorevalue++;
        tempscore++;

        score.text = scorevalue.ToString();
        
        pointA.PlayOneShot(pointaudio);
        
        
        if (scorevalue > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scorevalue);
            highscore.text = scorevalue.ToString();
            
            if(check == 1)
            {
                pointA.PlayOneShot(Highscore_audio);
                check = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        
        PlayerPrefs.SetInt("TotalCoins", scorevalue + totalcoins);
        PlayerPrefs.SetInt("Score", scorevalue);

    }


    //IEnumerator CountDownToStart()
    //{


    //    while (counterTime > 0)
    //    {
    //        counter.text = counterTime.ToString();
    //        yield return new WaitForSeconds(1f);
    //        counterTime--;
    //    }
    //    counter.text = "GO!";

    //    yield return new WaitForSeconds(1f);
    //    counter.gameObject.SetActive(false);

    //}

}
