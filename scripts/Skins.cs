using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Skins : MonoBehaviour
{
    public int Player_Index;
    public int coins;
    int ONE = 0;
    int TWO = 0;
    int THREE = 0;
    int FOUR = 0;
    int FIVE = 0;
    public AudioClip Button;
    public AudioSource Press;
    public Text totalscore;
    public GameObject[] pirces;
    public GameObject[] after_buy;


    void Start()
    {


        MonoBehaviour.print(totalscore.text);
        int coins = PlayerPrefs.GetInt("TotalCoins", 0);
        totalscore.text = coins.ToString();

        MonoBehaviour.print(totalscore.text);


        Player_Index = PlayerPrefs.GetInt("Player", 0);
        Press = GetComponent<AudioSource>();

        // before_buy[Player_Index].gameObject.SetActive(false);
    //     // players
    //    PlayerPrefs.DeleteKey("PLAYER_ONE");
    //    PlayerPrefs.DeleteKey("Player");

        ONE = PlayerPrefs.GetInt("PLAYER_ONE", 0);
        TWO = PlayerPrefs.GetInt("PLAYER_TWO", 0);
        THREE = PlayerPrefs.GetInt("PLAYER_THREE", 0);
        FOUR = PlayerPrefs.GetInt("PLAYER_FOUR", 0);
        FIVE = PlayerPrefs.GetInt("PLAYER_FIVE", 0);

        if(ONE == 1)
        {
            pirces[0].gameObject.SetActive(false);
        }
        if(TWO == 2)
        {
            pirces[1].gameObject.SetActive(false);

        }
        if(THREE == 3)
        {
            pirces[2].gameObject.SetActive(false);

        }
        if(FOUR == 4)
        {
            pirces[3].gameObject.SetActive(false);

        }
        if(FIVE == 5)
        {
            pirces[4].gameObject.SetActive(false);

        }
                set(Player_Index);


    }

    public void Default()
    {
        coins = PlayerPrefs.GetInt("TotalCoins", 0);
        
        PlayerPrefs.SetInt("Player", 0);
        set(0);

    }

    public void player_one()
    {
        coins = PlayerPrefs.GetInt("TotalCoins", 0);
        int ONE_check = PlayerPrefs.GetInt("PLAYER_ONE", 0);
        if (coins >= 500 && ONE_check != 1)
        {
            Press.PlayOneShot(Button);
            PlayerPrefs.SetInt("Player", 1);
            PlayerPrefs.SetInt("TotalCoins", coins - 500);
            PlayerPrefs.SetInt("PLAYER_ONE", 1);

            int tcoins = PlayerPrefs.GetInt("TotalCoins", 0);
            totalscore.text = tcoins.ToString();

            pirces[0].gameObject.SetActive(false);
            set(1);

            MonoBehaviour.print(ONE);

            //after_buy[1].gameObject.SetActive(true);
            //before_buy[1].gameObject.SetActive(false);


        }
        else if (ONE_check == 1)
        {
            PlayerPrefs.SetInt("Player", 1);
            set(1);

            //after_buy[1].gameObject.SetActive(true);
            //before_buy[1].gameObject.SetActive(false);

        }

    }
    public void player_Two()
    {
        coins = PlayerPrefs.GetInt("TotalCoins", 0);
        int TWO_check = PlayerPrefs.GetInt("PLAYER_TWO", 0);

        if (coins >= 3000 && TWO_check != 2)
        {
            PlayerPrefs.SetInt("Player", 2);
            PlayerPrefs.SetInt("TotalCoins", coins - 3000);
            PlayerPrefs.SetInt("PLAYER_TWO", 2);
            Press.PlayOneShot(Button);
            int tcoins = PlayerPrefs.GetInt("TotalCoins", 0);
            totalscore.text = tcoins.ToString();
            pirces[1].gameObject.SetActive(false);
            set(2);
             MonoBehaviour.print(TWO);

        }
        else if (TWO_check == 2)
        {
            PlayerPrefs.SetInt("Player", 2);
            set(2);

        }

    }

    public void player_Three()
    {
        coins = PlayerPrefs.GetInt("TotalCoins", 0);
        int THREE_check = PlayerPrefs.GetInt("PLAYER_THREE", 0);

        if (coins >= 6000 && THREE_check != 3)
        {
            PlayerPrefs.SetInt("Player", 3);
            PlayerPrefs.SetInt("TotalCoins", coins - 6000);
            PlayerPrefs.SetInt("PLAYER_THREE", 3);
            Press.PlayOneShot(Button);
            int tcoins = PlayerPrefs.GetInt("TotalCoins", 0);
            totalscore.text = tcoins.ToString();
            pirces[2].gameObject.SetActive(false);
            set(3);
            MonoBehaviour.print(THREE);

        }
        else if (THREE_check == 3)
        {
            PlayerPrefs.SetInt("Player", 3);
            set(3);

        }

    }

    public void player_Four()
    {
        coins = PlayerPrefs.GetInt("TotalCoins", 0);
        int FOUR_check = PlayerPrefs.GetInt("PLAYER_FOUR", 0);

        if (coins >= 9000 && FOUR_check != 4)
        {
            PlayerPrefs.SetInt("Player", 4);
            PlayerPrefs.SetInt("TotalCoins", coins - 9000);
            PlayerPrefs.SetInt("PLAYER_FOUR", 4);
            Press.PlayOneShot(Button);
             int tcoins = PlayerPrefs.GetInt("TotalCoins", 0);
            totalscore.text = tcoins.ToString();
            pirces[3].gameObject.SetActive(false);
            set(4);
 MonoBehaviour.print(FOUR);
        }
        else if (FOUR_check == 4)
        {
            PlayerPrefs.SetInt("Player", 4);
            set(4);

        }

    }

    public void player_Five()
    {
        coins = PlayerPrefs.GetInt("TotalCoins", 0);
        int FIVE_check = PlayerPrefs.GetInt("PLAYER_FIVE", 0);

        if (coins >= 12000 && FIVE_check != 5)
        {
            PlayerPrefs.SetInt("Player", 5);
            PlayerPrefs.SetInt("TotalCoins", coins - 12000);
            PlayerPrefs.SetInt("PLAYER_FIVE", 5);
            Press.PlayOneShot(Button);

            int tcoins = PlayerPrefs.GetInt("TotalCoins", 0);
            totalscore.text = tcoins.ToString();
            pirces[4].gameObject.SetActive(false);
            set(5);

        }
        else if (FIVE_check == 5)
        {
            PlayerPrefs.SetInt("Player", 5);
            set(5);

        }

    }

    private void set(int index)
    {
        for(int i = 0; i < 6;i++)
        {
            if(i == index)
            {
                after_buy[index].gameObject.SetActive(true);
                //before_buy[index].gameObject.SetActive(false);
            }
            else
            {
                after_buy[i].gameObject.SetActive(false);
                //before_buy[i].gameObject.SetActive(true);
            }                
        }
    }

}
