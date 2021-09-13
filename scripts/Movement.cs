//using UnityEngine;

//public class Movement : MonoBehaviour
//{
//    public float speed;
//    public float increase_Speed_After;
//    public float speed_Increase_By;

//    // Update is called once per frame
//    void Update()
//    {
//        if (this.transform.position.x < -14)
//        {
//            Destroy(this.gameObject);
//        }

//        if (increase_Speed_After < Time.timeSinceLevelLoad)
//        {
//            increase_Speed_After += Time.time;
//            speed += speed_Increase_By;
//        }
//    }

//    private void FixedUpdate()
//    {
//        MoveObstical();
//    }

//    void MoveObstical()
//    {
//        Vector2 new_pos = -(Time.deltaTime * speed * Vector2.right);

//        this.transform.Translate(new_pos);
//    }

//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float rate;
    public float wave;

    private void Update()
    {
        if (this.transform.position.x < -34)
        {
            Destroy(this.gameObject);
        }
        if (rate <= Time.timeSinceLevelLoad)
        {
            rate = Time.timeSinceLevelLoad + wave;
            speed += 1;
        }
        move();
    }

    void move()
    {
        transform.Translate(new Vector2(-(speed * Time.deltaTime), 0));
    }
}

















