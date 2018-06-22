using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour {

    [SerializeField]
    GameObject Cvas;

    public void OnPointerClick() {
        Cvas.SetActive(false);
    }
}
