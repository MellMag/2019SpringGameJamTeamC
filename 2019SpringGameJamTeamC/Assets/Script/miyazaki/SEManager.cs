using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    private AudioSource sound01;
    // Start is called before the first frame update
    void Start()
    {
        sound01 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SE()
    {
        sound01.PlayOneShot(sound01.clip);
    }
}
