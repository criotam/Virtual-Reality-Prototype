using UnityEngine;
using UnityEngine.SceneManagement;
public class Level_3 : MonoBehaviour {

	public void OnPointerClick()
    {
        UniqueLevel.NumberOfSheets = 250;
        UniqueLevel.sheetThckness = 0.05f;
        UniqueLevel.BlanketHasMetalSheet = true;
        UniqueLevel.MetalSHeetChangeRequired = false;
        UniqueLevel.hasInk = true;
        UniqueLevel.Objective = "Print 250 sheets of size 0.05mm. Add metal sheets in printer. " +
            "Ink is sufficient to print this much papers";

        SceneManager.LoadScene(5);
    }
}
