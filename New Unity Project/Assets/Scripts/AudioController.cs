using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    [SerializeField]
    GameObject[] clips;

    public void StartMachineAudio()
    {
        for(int i =0; i<clips.Length; ++i)
        {
            clips[i].GetComponent<AudioSource>().loop = true;
            clips[i].GetComponent<AudioSource>().Play();
        }
    }

    public void StopMachineAudio()
    {
        for (int i =0; i<clips.Length; ++i)
        {
            clips[i].GetComponent<AudioSource>().Stop();
        }
    }
}
