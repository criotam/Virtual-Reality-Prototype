using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MetalSheet : MonoBehaviour {

    public static bool sheet_in_hand { get; set; }
    public bool place_metal_sheet { get; set;  }

    private GameObject cnv;

    public static GameObject CurrentBufer { get; set; }
    
    void Start()
    {
        sheet_in_hand = false;
        place_metal_sheet = false;
        if (GetComponentInChildren<Canvas>())
        {
            cnv = GetComponentInChildren<Canvas>().gameObject;
            cnv.SetActive(false);
        }
    }

	public void OnPointerEnter()
    {
        cnv.SetActive(true);
    }
    public void OnPointerExit() {
        cnv.SetActive(false);
    }

    public void TakeMetalSheet() {

        if (sheet_in_hand == true)
            return;
        
        sheet_in_hand = true;
        Animator _anm;
        _anm = GetComponentInParent<Animator>();
        CurrentBufer = _anm.gameObject;
        _anm.gameObject.SetActive(false);        
    }
    
    public void AcceptSheet() {
    }
}
