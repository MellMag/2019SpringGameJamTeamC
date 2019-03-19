using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seisei : MonoBehaviour
{
  
    float time;
    public GameObject Image;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 2)
        {
            Instantiate(Image, transform.position, transform.rotation);
            time = 0f;
        }
    }
}
