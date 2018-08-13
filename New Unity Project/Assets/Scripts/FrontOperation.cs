using UnityEngine;

public class FrontOperation : MonoBehaviour {

    [SerializeField]
    GameObject runButton, paperButton, impressionButton;

    bool feeder_is_active = false;
    public bool ButtonActivity { get; set; }

    public void SheetButtonClicked() {
        GameObject _Level = GameObject.FindGameObjectWithTag("MonitorLevel");
        _Level.GetComponent<SheetAnimationControl>().StartFeederAnimation();
        _Level.GetComponent<SheetAnimationControl>().StartSheetAnimation();
    }
 

    public void SetButtonMaterial(Material matt, GameObject _gameObject) {
        _gameObject.GetComponent<Renderer>().material = matt;
    }
    
    public bool IsRunActive() { return runButton.GetComponent<FrontOperation>().ButtonActivity;  }
    public bool IsPaperActive() { return paperButton.GetComponent<FrontOperation>().ButtonActivity; }
    public bool IsImressionActive() { return impressionButton.GetComponent<FrontOperation>().ButtonActivity; }

    public void SetRunTrue() {
        Debug.Log("Front Operation: Set Run true");
        GetComponent<FrontOperation>().ButtonActivity = true;
        GetComponent<Renderer>().material = runButton.GetComponent<OperationsButtons>().SecondaryMaterial;
    }

    public bool SetPaperTrue() {
        if (runButton.GetComponent<FrontOperation>().ButtonActivity)
        {
            Debug.Log("Front Operation: Set Paper true");
            GetComponent<FrontOperation>().ButtonActivity = true;
            GetComponent<Renderer>().material = paperButton.GetComponent<OperationsButtons>().SecondaryMaterial;
            return true;
        }
        return false;
    }

    public bool SetImpressionTrue() {
        if (paperButton.GetComponent<FrontOperation>().ButtonActivity)
        { 
            Debug.Log("Front Operation : Set Impression True");
            GetComponent<FrontOperation>().ButtonActivity = true;
            GetComponent<Renderer>().material = impressionButton.GetComponent<OperationsButtons>().SecondaryMaterial;
            GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<SheetAnimationControl>().ToggleFeederActivity();
            return true;
        }
        return false;
    }

    public void SetRunFalse() {
        Debug.Log("Front Operation : Set Run false");
        runButton.GetComponent<FrontOperation>().ButtonActivity = false;
        paperButton.GetComponent<FrontOperation>().SetPaperFalse();
        runButton.GetComponent<Renderer>().material = runButton.GetComponent<OperationsButtons>().primaryMaterial;
        //SetPaperFalse();
        //SetImpressionFalse();
    }
    public void SetPaperFalse() {
        Debug.Log("Front Operation : Set paper false");
        paperButton.GetComponent<FrontOperation>().ButtonActivity = false;
        impressionButton.GetComponent<FrontOperation>().SetImpressionFalse();
        paperButton.GetComponent<Renderer>().material = paperButton.GetComponent<OperationsButtons>().primaryMaterial;
        //SetImpressionFalse();
    }
    public void SetImpressionFalse() {
        Debug.Log("Front Operation : Set Impression false");
        impressionButton.GetComponent<FrontOperation>().ButtonActivity = false;
        impressionButton.GetComponent<Renderer>().material = impressionButton.GetComponent<OperationsButtons>().primaryMaterial;
        GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<SheetAnimationControl>().ToggleFeederActivity();
    }
}