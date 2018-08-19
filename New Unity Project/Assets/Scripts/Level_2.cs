using UnityEngine;
using UnityEngine.UI;
public class Level_2 : MonoBehaviour {

    [SerializeField]
    GameObject[] blancket;

    [SerializeField]
    GameObject quitButton, Status;
    bool questVerified = false;

    void Update() {
        if (!questVerified)
        {
            int i = 0;
            for (int j = 0; j < blancket.Length; ++j)
            {
                if (blancket[j].GetComponent<Blanket>().blanket_has_sheet)
                {
                    i++;
                }
            }

            if (i == 5)
            {
                quitButton.SetActive(true);
                Status.SetActive(true);
                Status.GetComponent<Text>().text = "Quest Complete!!!";
                Debug.Log("Success");
                questVerified = true;
            }
        }
    }

}
