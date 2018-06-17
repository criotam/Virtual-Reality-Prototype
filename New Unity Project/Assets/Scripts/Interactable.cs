using UnityEngine;

public class Interactable : MonoBehaviour {

    [SerializeField]
    GameObject Active, NonActive;
    

    private bool activated = false;

    public void OnPointerClick() {
        if (activated)
        {
            NonActive.SetActive(true);
            Active.SetActive(false);
            activated = false;
        }
        else {
            activated = true;
            Active.SetActive(true);
            NonActive.SetActive(false);
        }
    }
	
}
