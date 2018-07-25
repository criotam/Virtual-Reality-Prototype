using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Blanket : MonoBehaviour {

    [SerializeField]
    GameObject newPosition;

    public bool blanket_has_sheet = false;

    private GameObject Companion;
    private GameObject MonitorLevel;

    void Start()
    {
        MonitorLevel = GameObject.FindGameObjectWithTag("MonitorLevel");
    }

    public void PlaceMetalSheet()
    {
        if (!blanket_has_sheet)
        {
            Companion = GameObject.FindGameObjectWithTag("Companion");
            if (Companion == null)
                return;
            
            if (MonitorLevel == null)
                MonitorLevel = GameObject.FindGameObjectWithTag("MonitorLevel"); 

            MetalSheet MonitorLevelSheet = MonitorLevel.GetComponent<MetalSheet>();
            if (MonitorLevelSheet == null)
                return;

            if (MonitorLevelSheet.place_metal_sheet == true)
            {
                blanket_has_sheet = true;
                MonitorLevelSheet.CurrentBufer.SetActive(true);
                MonitorLevelSheet.CurrentBufer.transform.position = newPosition.transform.position;
                MonitorLevelSheet.CurrentBufer.transform.rotation = newPosition.transform.rotation;
                MonitorLevelSheet.CurrentBufer.GetComponent<Animator>().SetBool("place_metal_sheet", true);
                Companion.SetActive(false);
                MetalSheet.sheet_in_hand = false;
                MonitorLevelSheet.place_metal_sheet = false;
            }
        }
        else
        {
            Companion = GameObject.FindGameObjectWithTag("Companion");
            if (Companion != null)
            {
                Text temp = Companion.GetComponentInChildren<Text>();
                string st = temp.text;
                temp.text = "Blancket Already has sheet";
                StartCoroutine(ChangeToOriginal(temp, st));
            }

        }
    }

    IEnumerator ChangeToOriginal(Text temp, string st) {
        yield return new WaitForSeconds(2);
        temp.text = st;
    }
}
