using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestCompleteButton : MonoBehaviour {

	public void OnPointerClick()
    {
        SceneManager.LoadScene(0);
    }
}
