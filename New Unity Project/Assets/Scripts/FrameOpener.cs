using UnityEngine;

public class FrameOpener : MonoBehaviour {

    Animator _opener;

    public Material PrimaryMaterial, SecondaryMaterial;

    void Start() {
        _opener = GetComponentInParent<Animator>();
        //Debug.Log(_opener);
    }

    public void OpenFrame() {
        //Debug.Log(_opener);
        _opener.SetBool("open_frame", true);
    }
    public void CloseFrame()
    {
        _opener.SetBool("open_frame", false);
    }

    public void OnPointerEnter() {
       GetComponent<Renderer>().material = SecondaryMaterial;
       
    }
    public void OnPointerExit() {
        GetComponent<Renderer>().material = PrimaryMaterial;
    }
    
	
}
