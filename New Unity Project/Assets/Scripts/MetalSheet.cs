using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class MetalSheet : MonoBehaviour {


    public static bool sheet_in_hand { get; set; }
    public bool place_metal_sheet { get; set;  }

    [SerializeField]
    GameObject Canvas;

    public GameObject CurrentBufer { get; set; }

    void Start()
    {
        place_metal_sheet = false;
    }

	public void OnPointerEnter()
    {
        Canvas.SetActive(true);
    }
    public void OnPointerExit() {
        Canvas.SetActive(false);
    }

    public void TakeMetalSheet() {
        if (sheet_in_hand == false)
        {
            sheet_in_hand = true;
            Animator _anm;
            _anm = GetComponentInParent<Animator>();
            GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<MetalSheet>().ShowCompanion(_anm.gameObject);
            _anm.gameObject.SetActive(false);
        }
        else
        {
            GameObject.FindGameObjectWithTag("Companion").GetComponentInChildren<Text>().text = "One Sheet at a time";
            StartCoroutine(ChangeCompanionText());
        }
        //Debug.Log(sheet_in_hand);
    }
    IEnumerator ChangeCompanionText() {
        yield return new WaitForSeconds(2);
        GameObject.FindGameObjectWithTag("Companion").GetComponentInChildren<Text>().text = "Metal Sheet taken";

    }


    public void AcceptSheet() {
    }

    // Monitor Level COmmands
    public void ShowCompanion(GameObject _buffer)
    {
        CurrentBufer = _buffer;
        Canvas.SetActive(true);
    }
}
