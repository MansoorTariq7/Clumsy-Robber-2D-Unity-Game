using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    public AudioClip retryplay;
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();

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
