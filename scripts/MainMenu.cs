using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor.UI;
using UnityEngine.UI;



public class MainMenu : MonoBehaviour
{
    public AudioClip policeplay;
    public AudioClip quitplay;
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    public void playgame()
    {
        audio.PlayOneShot(policeplay);
        for (int i = 0; i < 99555550+150000000; i++)
        {

        }
      // StartCoroutine(stop());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitgame()
    {
        audio.PlayOneShot(quitplay);
        for (int i = 0; i < 99555550 + 150000000; i++)
        {

        }
        Debug.Log("quit");
        Application.Quit();
    }

    public void shop()
    {
        audio.PlayOneShot(quitplay);
        for (int i = 0; i < 99555550 + 150000000; i++)
        {

        }
        SceneManager.LoadScene(3);

    }


    public IEnumerator stop()
    {
        yield return new WaitForSeconds(5f);
    }
}
