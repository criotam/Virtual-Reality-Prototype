using UnityEngine;

public class FrontOperation : MonoBehaviour {

    [SerializeField]
    GameObject[] FeederPipe;

    [SerializeField]
    GameObject runButton, paperButton, impressionButton;

    [SerializeField]
    GameObject[] PaperObject;

    bool run, paper, impression;
    bool feeder_is_active = false;

    void Start() {
        run = false;
        paper = false;
        impression = false;
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
        PaperObject[1].GetComponent<Animator>().SetBool("feeder_is_active", false);
    }

    public bool IsRunActive() { return run;  }
    public bool IsPaperActive() { return paper; }
    public bool IsImressionActive() { return impression; }

    public void toggleRun() {
        if (!run)
        {
            run = true;
            runButton.GetComponent<Renderer>().material = runButton.GetComponent<OperationsButtons>().SecondaryMaterial;
        }
        else
        {
            SetRunFalse();
            runButton.GetComponent<OperationsButtons>().SetButtonFalse();
        }
    }
    public void togglePaper() {
        if (run) {
            if (!paper)
            {
                paper = true;
                paperButton.GetComponent<Renderer>().material = paperButton.GetComponent<OperationsButtons>().SecondaryMaterial;
            }
            else
            {
                SetPaperFalse();
                paperButton.GetComponent<OperationsButtons>().SetButtonFalse();
            }
        }
    }
    public void toggleImpression() {
        if (paper == true) {
            if (impression == false)
            {
                impression = true;
                impressionButton.GetComponent<Renderer>().material = impressionButton.GetComponent<OperationsButtons>().SecondaryMaterial;
                ToggleFeederActivity();
                runButton.GetComponent<OperationsButtons>().enabled = false;
                paperButton.GetComponent<OperationsButtons>().enabled = false;
                impressionButton.GetComponent<OperationsButtons>().enabled = false;
                Debug.Log("eeder is active");
            }
            else
            {
                SetImpressionFalse();
                impressionButton.GetComponent<OperationsButtons>().SetButtonFalse();
            }
        }
    }

    public void SetRunFalse() {
        run = false;
        runButton.GetComponent<Renderer>().material = runButton.GetComponent<OperationsButtons>().primaryMaterial;
        SetPaperFalse();
        SetImpressionFalse();
    }
    public void SetPaperFalse() {
        paper = false;
        paperButton.GetComponent<Renderer>().material = paperButton.GetComponent<OperationsButtons>().primaryMaterial;
        SetImpressionFalse();
    }
    public void SetImpressionFalse() {
        impression = false;
        impressionButton.GetComponent<Renderer>().material = impressionButton.GetComponent<OperationsButtons>().primaryMaterial;
    }
}