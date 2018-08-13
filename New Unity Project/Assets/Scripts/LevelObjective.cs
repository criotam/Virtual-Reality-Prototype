using UnityEngine;
using UnityEngine.UI;
public class LevelObjective : MonoBehaviour {

    public GameObject Status, quitButton;
    public GameObject NumberOfSheets, SheetThickness, IntroductionDeskText;
    public GameObject Run;
    public GameObject[] blanket;
    bool completed = true;
    bool visitedOnce = false;

    void Start()
    {
        IntroductionDeskText.GetComponent<Text>().text = UniqueLevel.Objective;

        if (UniqueLevel.BlanketHasMetalSheet)
        {
            for(int i = 0; i < blanket.Length; ++i)
            {
                blanket[i].GetComponent<Blanket>().blanket_has_sheet = true;
            }
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

        int i = 0;
        for (int j = 0; j < blanket.Length; ++j)
        {
            if (blanket[j].GetComponent<Blanket>().blanket_has_sheet)
            {
                i++;
            }
        }

        if (i < 5)
        {
            completed = false;
        }

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
