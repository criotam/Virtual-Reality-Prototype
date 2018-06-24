using UnityEngine;

public class FrontOperation : MonoBehaviour {

    [SerializeField]
    GameObject[] FeederPipe;

    [SerializeField]
    GameObject runButton, paperButton, impressionButton;

    [SerializeField]
    GameObject[] PaperObject;

    //bool run, paper, impression;
    bool feeder_is_active = false;
    public bool ButtonActivity { get; set; }

    void Start() {
        //run = false;
        //paper = false;
        //impression = false;
    }

    public void SetButtonMaterial(Material matt, GameObject _gameObject) {
        _gameObject.GetComponent<Renderer>().material = matt;
    }
    
    public void ToggleFeederActivity() {
        if (feeder_is_active)
            feeder_is_active = false;
        else
            feeder_is_active = true;

        for (int i = 0; i < FeederPipe.Length; ++i)
        {
            FeederPipe[i].GetComponent<Animator>().SetBool("feeder_is_active", feeder_is_active);
        }
        for (int i = 0; i < PaperObject.Length; ++i) {
            PaperObject[i].GetComponent<Animator>().SetBool("feeder_is_active", feeder_is_active);
        }
        //PaperObject[1].GetComponent<Animator>().SetBool("feeder_is_active", false);
    }

    public bool IsRunActive() { return runButton.GetComponent<FrontOperation>().ButtonActivity;  }
    public bool IsPaperActive() { return paperButton.GetComponent<FrontOperation>().ButtonActivity; }
    public bool IsImressionActive() { return impressionButton.GetComponent<FrontOperation>().ButtonActivity; }

    public void SetRunTrue() {
        Debug.Log("Front Operation: Set Run true");
        runButton.GetComponent<FrontOperation>().ButtonActivity = true;
        runButton.GetComponent<Renderer>().material = runButton.GetComponent<OperationsButtons>().SecondaryMaterial;
    }

    public bool SetPaperTrue() {
        if (runButton.GetComponent<FrontOperation>().ButtonActivity)
        {
            Debug.Log("Front Operation: Set Paper true");
            paperButton.GetComponent<FrontOperation>().ButtonActivity = true;
            paperButton.GetComponent<Renderer>().material = paperButton.GetComponent<OperationsButtons>().SecondaryMaterial;
            return true;
        }
        return false;
    }

    public bool SetImpressionTrue() {
        if (paperButton.GetComponent<FrontOperation>().ButtonActivity)
        { 
            Debug.Log("Front Operation : Set Impression True");
            impressionButton.GetComponent<FrontOperation>().ButtonActivity = true;
            impressionButton.GetComponent<Renderer>().material = impressionButton.GetComponent<OperationsButtons>().SecondaryMaterial;
            ToggleFeederActivity();
            GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<Level_1>().VerifyQuest();
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
    }
}