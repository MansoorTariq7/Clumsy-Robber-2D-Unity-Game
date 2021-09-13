using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor.UI;
//using UnityEditor.Audio;
using UnityEngine.Audio;
using UnityEngine.UI;
using GoogleMobileAds.Api;


public class Collision : MonoBehaviour
{
    public AudioClip audiocollide;
    private AudioSource audio;
    int check = 0;


    private void Start()
    {
        audio = GetComponent<AudioSource>();

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Debug.Log("OnCollisionEnter2D");
       // Application.LoadLevel(Application.loadedLevel);
        //Player_Movement.tempscore = 1;
        //SceneManager.LoadScene(2);
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Obsticals");
        GameObject.Find("Piller_creation").GetComponent<Pillers_Movement>().enabled = false;

        for (int counter = 0; counter < obj.Length; counter++)
        {
            obj[counter].GetComponent<Movement>().enabled = false;

        }
        if (check == 0)
        {
            audio.PlayOneShot(audiocollide);
            check++;
        }
        // SceneManager.LoadScene(2);

        //StartCoroutine(stop());


   
        SceneManager.LoadScene(2);

    }
}
