using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level_1 : MonoBehaviour {

    public Text SheetThickness;
    public GameObject Status;
    public GameObject quitButton;
    public GameObject ImpressionButton;
    bool QuestVerified = false;


    void Start()
    {
        GetComponent<BlanketControl>().SetBlanketSheetTrue();
    }

    void Update() {
        if (ImpressionButton == null)
        {
            Debug.Log("Impression Button is not Assigned Any Value");
            return;
        }
        if (ImpressionButton.GetComponent<FrontOperation>().IsImressionActive() && !QuestVerified)
        {
            QuestVerified = true;
            VerifyQuest();
        }
    }


    public void VerifyQuest() {
        if (SheetThickness.text == "0.06")
        {
            quitButton.SetActive(true);
            Status.SetActive(true);
            Status.GetComponent<Text>().text = "Sucess";
            Debug.Log("Success");
            //SceneManager.LoadScene(0);
        }
        else {
            quitButton.SetActive(true);
            Status.SetActive(true);
            Status.GetComponent<Text>().text = "Operation Failed!!!";
            Debug.Log("Quest Failed.\nRetry");
           // SceneManager.LoadScene(0);
        }
    }

    public void GoHome() {
        SceneManager.LoadScene(0);
    }


}
