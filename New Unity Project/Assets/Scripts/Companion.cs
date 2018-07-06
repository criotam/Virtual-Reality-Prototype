using UnityEngine;
using UnityEngine.UI;
public class Companion : MonoBehaviour {

    [SerializeField]
    GameObject StatusBar;

    public void PlaceMetalSheet()
    {
        GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<MetalSheet>().place_metal_sheet = true;
        StatusBar.GetComponent<Text>().text = "Select blanket to place Metal Sheet";
    }
}
