using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    public void OnPointerClick() {
        SceneManager.LoadScene(0);
    }
	
}
