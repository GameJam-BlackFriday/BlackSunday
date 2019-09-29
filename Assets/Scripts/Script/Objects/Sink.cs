using System.Collections;
using System.Collections.Generic;
using Objects.MyObject;
using UnityEngine;

public class Sink : MonoBehaviour
{
    string name = "Sink";

    public AudioClip MusicClip;

    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        MusicSource.Play();
        print("I feel so dizzy....... Ehh the icy water makes me feel better.");
    }

    void Update()
    {
        if (MusicSource.time > 3f)
        {
            MusicSource.Stop();
        }
    }

}
