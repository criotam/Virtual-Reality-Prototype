using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontOperation : MonoBehaviour {

    [SerializeField]
    Material BaseMaterial, SecondaryMaterial;


    public void OnPointerEnter() {
        GetComponent<Renderer>().material = SecondaryMaterial;
    }

    public void OnPointerExit() {
        GetComponent<Renderer>().material = BaseMaterial;
    }

    public void OnPointerClick() {

    }

}
