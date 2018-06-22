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

//    public void OnPointerClick() {
//       if (ButtonIsActive)
//        {
//            _frontOperation.SetButtonMaterial(primaryMaterial, this.gameObject);
//            ButtonIsActive = false;
//        }
//        else {
//            _frontOperation.SetButtonMaterial(SecondaryMaterial, this.gameObject);
 //           ButtonIsActive = true;
//        }
//    }

    public void RunIsClicked() {
        if (!_frontOperation.IsRunActive())
        {
            _frontOperation.toggleRun();
            ButtonIsActive = true;
        }
        else
        {
            ButtonIsActive = false;
            _frontOperation.SetRunFalse();
        }

    }

    public void PaperIsClicked() {
        if (!_frontOperation.IsPaperActive() && _frontOperation.IsRunActive())
        {
            _frontOperation.togglePaper();
            ButtonIsActive = true;
        }
        else
        {
            ButtonIsActive = false;
            _frontOperation.SetPaperFalse();
        }
    }

    public void ImpressionIsClicked() {
        if (_frontOperation.IsImressionActive() == false && _frontOperation.IsPaperActive())
        {
            _frontOperation.toggleImpression();
            ButtonIsActive = true;
        }
        else
        {
            ButtonIsActive = false;
            _frontOperation.SetImpressionFalse();
        }
    }

}