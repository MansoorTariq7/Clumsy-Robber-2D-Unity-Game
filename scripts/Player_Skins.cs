//using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Skins : MonoBehaviour
{
    int player_index;
    public GameObject[] obj;

    void Start()
    {
        
        player_index = PlayerPrefs.GetInt("Player", 0);
        Skins(player_index);
    }

    void Skins(int A)
    {
        for(int i = 0; i < obj.Length;i++)
        {
            if(i != A)
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
