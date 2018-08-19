using UnityEngine;
using UnityEngine.UI;
public class LevelObjective : MonoBehaviour {

    public GameObject Status, quitButton;
    public GameObject NumberOfSheets, SheetThickness, IntroductionDeskText;
    public GameObject Run;
    bool completed = true;
    bool visitedOnce = false;

    void Start()
    {
        IntroductionDeskText.GetComponent<Text>().text = UniqueLevel.Objective;

        if (UniqueLevel.BlanketHasMetalSheet)
        {
            GetComponent<BlanketControl>().SetBlanketSheetTrue();
        }
    }

    void Update()
    {
        completed = true;
        if (NumberOfSheets.GetComponent<Text>().text != UniqueLevel.NumberOfSheets.ToString())
        {
            completed = false;
        }
        if (SheetThickness.GetComponentInChildren<Text>().text != UniqueLevel.sheetThckness.ToString())
        {
            completed = false;
        }

        if (!GetComponent<BlanketControl>().AllBlanketHasSheet())
            completed = false;

        if (completed && !visitedOnce)
        {
            visitedOnce = true;
            Run.GetComponent<OperationsButtons>().RunIsClicked();
            //quitButton.SetActive(true);
            Status.SetActive(true);
            Status.GetComponent<Text>().text = "Quest Complete!!!";
            Debug.Log("Success");
        }

        
    }
}
