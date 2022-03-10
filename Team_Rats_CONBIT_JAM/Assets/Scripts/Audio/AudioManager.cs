using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    AudioClip fail;

    // Start is called before the first frame update
    void Start()
    {
        fail = GetComponent<AudioSource>().clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
