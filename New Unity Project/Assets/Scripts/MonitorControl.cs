using UnityEngine;
using UnityEngine.UI;
using System;

public class MonitorControl : MonoBehaviour {

    [SerializeField]
    GameObject SheetCount, SheetThickness;

    private Text CurrentBuffer;
    private string temp;
    void Start()
    {
        CurrentBuffer = null;
    }

    public void SheetCountInBuffer()
    {
        CurrentBuffer = SheetCount.GetComponentInChildren<Text>();
        temp = CurrentBuffer.text;
        CurrentBuffer.text = "";

    }
    public void SheetThicknessInBuffer()
    {
        CurrentBuffer = SheetThickness.GetComponentInChildren<Text>();
        temp = CurrentBuffer.text;
        CurrentBuffer.text = "";
    }

    public void UpdateCurrentBuffer(string s)
    {
        if (CurrentBuffer == null)
            return;
        CurrentBuffer.text = CurrentBuffer.text + s;
    }

    public void DeleteLastInput()
    {
        if (CurrentBuffer == null)
            return;
        if (CurrentBuffer.text == "")
            return;
        CurrentBuffer.text = CurrentBuffer.text.Remove(CurrentBuffer.text.Length - 1);
    }

    public void IncreaseValue()
    {
        Text count = SheetCount.GetComponentInChildren<Text>();
        if (count.text == "")
            return;

        count.text = (Convert.ToInt32(count.text) + 1).ToString();
    }

    public void DecreaseValue()
    {
        Text count = SheetCount.GetComponentInChildren<Text>();
        if (count.text == "" || count.text == "0")
            return;

        count.text = (Convert.ToInt32(count.text) - 1).ToString();
    }

    public void ResetValues()
    {
        CurrentBuffer.text = temp;
    }

    public void ClearBuffer()
    {
        string s1 = SheetThickness.GetComponentInChildren<Text>().text;
        string s2 = SheetCount.GetComponentInChildren<Text>().text;

        double n1;
        int n2;
        try
        {
            n1 = Convert.ToDouble(s1);
            n2 = Convert.ToInt32(s2);
        }
        catch
        {
            Debug.Log("Please input correct values");
            return;
        }

        if (n1 <0.04 || n1 > 0.6)
        {
            Debug.Log("This thickness cannot be4 handled");
        }

        CurrentBuffer = null;
        temp = null;
    }


}
