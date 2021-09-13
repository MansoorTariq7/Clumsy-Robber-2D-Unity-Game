//using UnityEngine;

//public class Pillers_Movement : MonoBehaviour
//{
//    public Transform[] spwanPoints;
//    public GameObject obstical;
//    float rate = 1;
//    float wave = 2;

//    // Update is called once per frame
//    void Update()
//    {
//        if (Time.time >= rate)
//        {
//            generate_Obstical();
//            rate = Time.time + wave;
//        }
//    }

//    void generate_Obstical()
//    {
//        int random = Random.Range(0, spwanPoints.Length);
//        Instantiate(obstical, spwanPoints[random].position, Quaternion.identity);
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pillers_Movement : MonoBehaviour
{
    public Transform[] spwanPoints;
    public GameObject[] obs;
    public float rate;
    public float wave;      


    // Update is called once per frame
    void Update()
    {
        if (rate <= Time.time)
        {
            rate = Time.time + wave;
            int random = Random.Range(0, spwanPoints.Length);
            int randomA = Random.Range(0, 2);
            Instantiate(obs[randomA], spwanPoints[random].transform.position, Quaternion.identity);
        }
    }
}



