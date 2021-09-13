using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds_Move : MonoBehaviour
{
    public Transform[] obj;
    public GameObject obstical;
    float rate = 0;

    // Update is called once per frame
    void Update()
    {
        if (rate <= Time.time)
        {
            create();
            rate = (Time.time + 20f);
        }

    }

    void create()
    {
        int position = Random.Range(0, obj.Length);

        Instantiate(obstical, obj[position].position, Quaternion.identity);
    }
}
