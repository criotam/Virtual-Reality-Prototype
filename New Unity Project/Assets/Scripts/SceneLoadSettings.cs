﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadSettings : MonoBehaviour {

    [SerializeField]
    GameObject Player,text = null,quitButton = null, Image;

    IEnumerator timeLapse() {
        yield return new WaitForSeconds(1);
        Image.SetActive(false);
        //if (S)
        Player.GetComponent<Player>().SetCompanion();
        GameObject.FindGameObjectWithTag("Companion").SetActive(false);

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
