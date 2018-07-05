using UnityEngine;

public class SheetAnimationControl : MonoBehaviour {

    public GameObject[] sheets;
    public float animationSpeed = 1;
    public GameObject FeederUnit;
    public Texture2D PrintImage;

    public Material SheetPrintMaterial;

    bool feeder_is_active = false;

    void Start()
    {
        SheetPrintMaterial.mainTexture = PrintImage;
    }

    public void StartSheetAnimation() {
        
        for (int i = 0; i < sheets.Length; ++i) {
            sheets[i].GetComponent<Animator>().speed = animationSpeed;
            sheets[i].GetComponent<Animator>().SetBool("feeder_is_active", true);
        }
    }

    public void StopSheetAnimation() {
        for (int i = 0; i < sheets.Length; ++i)
        {
            sheets[i].GetComponent<Animator>().SetBool("feeder_is_active", false);
        }
    }

    public void StartFeederAnimation() {
        FeederUnit.GetComponent<Animator>().speed = animationSpeed;
        FeederUnit.GetComponent<Animator>().SetBool("feeder_is_active", true);
    }
    public void StopFeederAnimation() {
        FeederUnit.GetComponent<Animator>().SetBool("feeder_is_active", false);
    }

    public void ToggleFeederActivity()
    {
        if (feeder_is_active)
        {
            StopFeederAnimation();
            StopSheetAnimation();
            feeder_is_active = false;
        }
        else
        {
            StartFeederAnimation();
            StartSheetAnimation();
            feeder_is_active = true;
        }
    }


}
