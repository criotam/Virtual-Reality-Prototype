using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class AudioController : MonoBehaviour {

    [SerializeField]
    GameObject[] clips;
    [SerializeField]
    AudioClip buttonClickSound;

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

    public void PlayButtonClickSound()
    {
        
        GvrReticlePointer gvrr = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<GvrReticlePointer>();
        
        if (gvrr.ReticleOuterAngle > 0.5f)
        
        {
            Debug.Log("pointerClick");
            AudioSource asc = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<AudioSource>();
            asc.PlayOneShot(buttonClickSound);
        }
        
    }
}
