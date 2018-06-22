using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    [SerializeField]
    GameObject[] MenuTabs;

    public void LoadIntroductionScene() {
        SceneManager.LoadScene(1);
    }

    public void OnClickPrinter() {
        Debug.Log("printer Clicked");
        MenuTabs[1].SetActive(true);
        Debug.Log("Second Tab Activated");
        MenuTabs[0].SetActive(false);
        Debug.Log("Frist Tab de-Activated");
    }

    public void OnLevelClick(int i) {
        SceneManager.LoadScene(i);
    }

    public void OnBackClick() {
        MenuTabs[1].SetActive(true);
        MenuTabs[0].SetActive(false);
    }

    public void OnQuit() {
        Application.Quit();
    }

}
