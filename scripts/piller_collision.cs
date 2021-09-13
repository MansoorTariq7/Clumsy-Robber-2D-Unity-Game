using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor.UI;
using UnityEngine.UI;
using UnityEngine.Audio;

public class piller_collision : MonoBehaviour
{
    private AudioSource audio;

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

        audio.Play();
        Debug.Log("eeeeeeeeeee");


    }



}
