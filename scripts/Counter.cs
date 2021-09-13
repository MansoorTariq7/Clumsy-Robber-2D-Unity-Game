using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int counterTime;
    public Text counter;

    public GameObject Player;
    public GameObject Pillers_Creation_Object;
    public GameObject Buildings;
    public GameObject Police;

    public GameObject Buildings_Prop;
    public GameObject Police_Prop;
    public GameObject Player_Prop;

    int player_index;
    public GameObject[] obj;
    public GameObject[] prop;

    public AudioSource Audio_Counter;
    public AudioClip Three;
    public AudioClip Two;
    public AudioClip One;
    public AudioClip Go;


    private void Start()
    {
        Audio_Counter = GetComponent<AudioSource>();

        // gameObject.GetComponent<Player_Movement>.enabled(false);
        //Player.gameObject.SetActive(false);

        player_index = PlayerPrefs.GetInt("Player", 0);
        //obj[player_index].gameObject.SetActive(false);
        for (int i = 0; i < obj.Length; i++)
        {
            obj[i].gameObject.SetActive(false);
            prop[i].gameObject.SetActive(false);

            if(i == player_index)
            {
                prop[i].gameObject.SetActive(true);
            }
        }

        Pillers_Creation_Object.gameObject.SetActive(false);
        Buildings.gameObject.SetActive(false);
        Police.gameObject.SetActive(false);

        StartCoroutine(CountDownToStart());
    }



    IEnumerator CountDownToStart()
    {
        while (counterTime > 0)
        {
            counter.text = counterTime.ToString();
            
            if(counterTime == 3)
            {
                Audio_Counter.PlayOneShot(Three);
            }

            if (counterTime == 2)
            {
                Audio_Counter.PlayOneShot(Two);
            }

            if (counterTime == 1)
            {
                Audio_Counter.PlayOneShot(One);
            }

            yield return new WaitForSeconds(1f);
            counterTime--;
        }
        counter.text = "GO!";
        Audio_Counter.PlayOneShot(Go);
        yield return new WaitForSeconds(1f);
        counter.gameObject.SetActive(false);


        //Player.gameObject.SetActive(true);
        Skins(player_index);
        prop[player_index].gameObject.SetActive(false);
        //--
        Pillers_Creation_Object.gameObject.SetActive(true);
        Buildings.gameObject.SetActive(true);
        Police.gameObject.SetActive(true);
        Buildings_Prop.gameObject.SetActive(false);
        Police_Prop.gameObject.SetActive(false);
        Player_Prop.gameObject.SetActive(false);


    }

    void Skins(int A)
    {
        for (int i = 0; i < obj.Length; i++)
        {
            if (i != A)
            {
                obj[i].gameObject.SetActive(false);
            }
            else
            {
                obj[i].gameObject.SetActive(true);
            }
        }
    }
}
