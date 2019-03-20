using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour
{

    float speed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3 (0, speed, 0);
        if (transform.position.y >= -5)
        {
            speed -= 0.000002f;
            this.transform.localScale -= new Vector3(0.001f, 0.001f, 0);
        }
        if(transform.localScale.x <= 0)
        {
            Destroy(gameObject);
        }
    }
}
