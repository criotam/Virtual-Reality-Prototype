using System.Collections;
using UnityEngine;

public class SceneLoadSettings : MonoBehaviour {

    [SerializeField]
    GameObject Player,text,quitButton, Image;

    IEnumerator timeLapse() {
        yield return new WaitForSeconds(1);
        Image.SetActive(false);

    }

    void Start() {
        Player.SetActive(true);
        text.SetActive(false);
        quitButton.SetActive(false);
        Image.GetComponent<Animator>().SetBool("LoadFade", true);
        StartCoroutine(timeLapse());
        

    }

}
