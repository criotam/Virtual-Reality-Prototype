using System.Collections;
using UnityEngine;

public class SceneLoadSettings : MonoBehaviour {

    [SerializeField]
    GameObject Player,text = null,quitButton = null, Image;

    IEnumerator timeLapse() {
        yield return new WaitForSeconds(1);
        Image.SetActive(false);
        
        if (Player.GetComponent<Player>() != null)
        {
            //Player.GetComponent<Player>().SetCompanion();
        }
    }

    void Start() {
        //Debug.Log("WOrking Fine here");
        Player.SetActive(true);
        if (text != null && quitButton != null) {
            text.SetActive(false);
            quitButton.SetActive(false);
        }
        Image.GetComponent<Animator>().SetBool("LoadFade", true);
        StartCoroutine(timeLapse());
    }
}
