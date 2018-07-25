using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SheetCounter : MonoBehaviour {

    [SerializeField]
    GameObject SheetCountScreen;
    
    void Start()
    {
        count = 0;
    }

    public int count
    {
        get;
        set;
    }

    public void OnTriggerExit(Collider col)
    {
        Debug.Log("Collision");
        count = count + 1;
        SheetCountScreen.GetComponent<Text>().text = count.ToString();
    }

    public void SetSheetsToZero()
    {
        count = 0;
    }
}
