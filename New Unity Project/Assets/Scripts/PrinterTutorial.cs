using UnityEngine;
using UnityEngine.SceneManagement;

public class PrinterTutorial : MonoBehaviour {

    [SerializeField]
    GameObject[] CurrentTab, NextTab;
    [SerializeField]
    GameObject Cvas, CanvasPoint, PlayerPoint;
    
    public void ChangeTab() {
        for (int i = 0; i < NextTab.Length; ++i)
        {
            NextTab[i].SetActive(true);
        }

        Cvas.transform.position = CanvasPoint.transform.position;
        Cvas.transform.rotation = CanvasPoint.transform.rotation;

        GameObject plyr = GameObject.FindGameObjectWithTag("Player");
        plyr.transform.position = PlayerPoint.transform.position;
        plyr.transform.rotation = PlayerPoint.transform.rotation;

        for (int i = 0; i < CurrentTab.Length; ++i)
        {
            CurrentTab[i].SetActive(false);
        }
    }

    public void BackToHome() {
        SceneManager.LoadScene(0);
    }

}
