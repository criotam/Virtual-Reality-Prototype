using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Blanket : MonoBehaviour {

    [SerializeField]
    GameObject newPosition;

    public bool blanket_has_sheet = false;

    public void PlaceMetalSheet()
    {
        if (!blanket_has_sheet)
        {
            blanket_has_sheet = true;
            MetalSheet MonitorLevelSheet;
            MonitorLevelSheet = GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<MetalSheet>();
            if (MonitorLevelSheet.place_metal_sheet == true)
            {
                MonitorLevelSheet.CurrentBufer.SetActive(true);
                MonitorLevelSheet.CurrentBufer.transform.position = newPosition.transform.position;
                MonitorLevelSheet.CurrentBufer.transform.rotation = newPosition.transform.rotation;
                MonitorLevelSheet.CurrentBufer.GetComponent<Animator>().SetBool("place_metal_sheet", true);
                GameObject.FindGameObjectWithTag("Companion").SetActive(false);
                MetalSheet.sheet_in_hand = false;
                MonitorLevelSheet.place_metal_sheet = false;
            }
        }
        else
        {
            Text temp = GameObject.FindGameObjectWithTag("Companion").GetComponentInChildren<Text>();
            string st = temp.text;
            temp.text = "Blancket Already has sheet";
            StartCoroutine(ChangeToOriginal(temp,st));

        }
    }

    IEnumerator ChangeToOriginal(Text temp, string st) {
        yield return new WaitForSeconds(2);
        temp.text = st;
    }
}
