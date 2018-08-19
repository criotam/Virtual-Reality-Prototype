using UnityEngine;

public class Blanket : MonoBehaviour {

    [SerializeField]
    GameObject newPosition;

    public bool blanket_has_sheet { get; set; }

    //private GameObject MonitorLevel;

    void Start()
    {
        blanket_has_sheet = false;
        //MonitorLevel = GameObject.FindGameObjectWithTag("MonitorLevel");
    }

    public void PlaceMetalSheet()
    {
        if (blanket_has_sheet)
            return;

        if (!MetalSheet.sheet_in_hand)
            return;

        MetalSheet.CurrentBufer.SetActive(true);
        blanket_has_sheet = true;
        MetalSheet.CurrentBufer.transform.position = newPosition.transform.position;
        MetalSheet.CurrentBufer.transform.rotation = newPosition.transform.rotation;

        MetalSheet.CurrentBufer.GetComponent<Animator>().SetBool("place_metal_sheet", true);
        MetalSheet.sheet_in_hand = false;
    }

}
