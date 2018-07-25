using UnityEngine;

public class tempmMetalPlate : MonoBehaviour {

    [SerializeField]
    GameObject Positions, Plates;
    private bool place_metal_sheet = false;
    public void StartAnimation() {
        if (place_metal_sheet == false)
        {
            place_metal_sheet = true;
            Plates.transform.position = Positions.transform.position;
            Plates.transform.rotation = Positions.transform.rotation;
            Plates.GetComponent<Animator>().SetBool("place_metal_sheet", true);
        }
        else
        {
            place_metal_sheet = false;
            Plates.GetComponent<Animator>().SetBool("place_metal_sheet", false);
        }
    }
    
}