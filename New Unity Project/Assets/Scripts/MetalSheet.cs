using UnityEngine;

public class MetalSheet : MonoBehaviour {

    public static bool sheet_in_hand = false;
    public bool place_metal_sheet { get; set;  }
    
    private GameObject cnv;

    public static GameObject CurrentBufer { get; set; }
    
    void Start()
    {
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

        if (sheet_in_hand)
        {
            Debug.Log("You already have sheet in hand!");
            return;
        }
        
        sheet_in_hand = true;
        Animator _anm;
        _anm = GetComponentInParent<Animator>();
        CurrentBufer = _anm.gameObject;
        _anm.gameObject.SetActive(false);        
    }
    
    public void AcceptSheet() {
    }
}
