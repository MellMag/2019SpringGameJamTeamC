using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            this.transform.position += new Vector3(0, 0.005f, 0);
        }
    }
}
