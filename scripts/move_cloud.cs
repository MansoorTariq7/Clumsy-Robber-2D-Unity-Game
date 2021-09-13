using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_cloud : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector2(-1 * Time.deltaTime, 0));

        if (transform.position.x <= -20.99)
        {
            Destroy(gameObject);
        }

    }
}
