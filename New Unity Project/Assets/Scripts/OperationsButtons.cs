using UnityEngine;

public class OperationsButtons : MonoBehaviour {
    
    public Material primaryMaterial, SecondaryMaterial;

    FrontOperation _frontOperation;
    private bool ButtonIsActive = false;
    
    void Start() {
        _frontOperation = GetComponentInParent<FrontOperation>();
    }

    public void SetButtonFalse() { ButtonIsActive = false; }

    public void OnPointerEnter() {
        if (ButtonIsActive) {
            return;
        }
        _frontOperation.SetButtonMaterial(SecondaryMaterial, this.gameObject);
    }

    public void OnPointerExit() {
        if (ButtonIsActive) {
            return;
        }
        _frontOperation.SetButtonMaterial(primaryMaterial, this.gameObject);
    }

    public void RunIsClicked() {

        if (!ButtonIsActive)
        {
            _frontOperation.SetRunTrue();
            Debug.Log("Operation Buttons: ButtonIsActive true");
            ButtonIsActive = true;
        }
        else {
            _frontOperation.SetRunFalse();
            ButtonIsActive = false;
            Debug.Log("Operation Buttons: ButtonIsActive false");
        }
    }

    public void PaperIsClicked()
    {

        if (!ButtonIsActive)
        {
            bool temp = _frontOperation.SetPaperTrue();
            if (temp) {
                Debug.Log("Operation Buttons: ButtonIsActive true");
                ButtonIsActive = true;
            }
        }
        else
        {
            _frontOperation.SetPaperFalse();
            ButtonIsActive = false;
            Debug.Log("Operation Buttons: ButtonIsActive false");
        }
    }

    public void ImpressionIsClicked()
    {

        if (!ButtonIsActive)
        {
            bool temp = _frontOperation.SetImpressionTrue();
            if (temp) {
                Debug.Log("Operation Buttons: ButtonIsActive true");
                ButtonIsActive = true;
            }
        }
        else
        {
            _frontOperation.SetImpressionFalse();
            ButtonIsActive = false;
            Debug.Log("Operation Buttons: ButtonIsActive false");
        }
    }
    //public bool ButtonActivity() { return ButtonIsActive; }
}