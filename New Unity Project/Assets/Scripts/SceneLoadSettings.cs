using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoadSettings : MonoBehaviour {

    [SerializeField]
    GameObject Player, Image;

    IEnumerator timeLapse() {
        yield return new WaitForSeconds(1);
        Image.SetActive(false);

    }

    void Start() {
        Player.SetActive(true);
        Image.GetComponent<Animator>().SetBool("LoadFade", true);
        StartCoroutine(timeLapse());
        

    }

}
