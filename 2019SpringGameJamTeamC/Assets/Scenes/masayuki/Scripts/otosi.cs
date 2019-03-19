using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otosi : MonoBehaviour
{
    float time;
    float speed;
    public GameObject mono;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        speed = 5;
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity
                            = -transform.up * speed;
    }
}
