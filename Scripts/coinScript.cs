using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinScript : MonoBehaviour
{
    private int value;

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }

}
