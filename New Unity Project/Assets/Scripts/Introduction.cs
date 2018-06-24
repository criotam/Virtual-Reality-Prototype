using UnityEngine;
using UnityEngine.SceneManagement;
public class Introduction : MonoBehaviour {

    [SerializeField]
    GameObject[] CurrentTab;
        
    [SerializeField]
    GameObject[] NextTab;


    public void NextButtonClick() {
        for (int i = 0; i < NextTab.Length; ++i) {
            NextTab[i].SetActive(true);
        }
        for (int i = 0; i < CurrentTab.Length; ++i)
        {
            CurrentTab[i].SetActive(false);
        }   
    }

    public void BackToHome() {
        SceneManager.LoadScene(0);
        
    }

    public void LoadPrinterTutorial() {
        SceneManager.LoadScene(3);
    }
}
