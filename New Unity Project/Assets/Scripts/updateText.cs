using System;
using UnityEngine;
using UnityEngine.UI;

public class updateText : MonoBehaviour
{
    private MonitorControl monitorControl;

    static Text CurrentBuffer;
    static string temp;

    void Start()
    {
        monitorControl = GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<MonitorControl>();
    }
    
	public void changeText(string toChangeValue)
    {
        if (CurrentBuffer == null)
            return;
        CurrentBuffer.text = CurrentBuffer.text + toChangeValue;
    }

    public void DeleteButtonClick()
    {
        if (CurrentBuffer == null)
            return;
        if (CurrentBuffer.text == "")
            return;
        CurrentBuffer.text = CurrentBuffer.text.Remove(CurrentBuffer.text.Length - 1);
    }

    public void AddToBuffer()
    {
        if (CurrentBuffer == this.gameObject.GetComponentInChildren<Text>())
            return;
        CurrentBuffer = this.gameObject.GetComponentInChildren<Text>();
        temp = CurrentBuffer.text;
        CurrentBuffer.text = "";
    }

    public void IncreaseValue()
    {
        int t;
        try
        {
            t = Convert.ToInt32(CurrentBuffer.text);
        }
        catch
        {
            return;
        }
        CurrentBuffer.text = (t + 1).ToString();
    }
    public void DecreaseValue()
    {
        int t;
        try
        {
            t = Convert.ToInt32(CurrentBuffer.text);
        }
        catch
        {
            return;
        }
        if (t < 1)
        {
            return;
        }
        CurrentBuffer.text = (t - 1).ToString();
    }

    public void ResetValues()
    {
        if (CurrentBuffer!=null)
            CurrentBuffer.text = temp;
    }

    public void ClearBuffer()
    {
        Text errorLog = GameObject.FindGameObjectWithTag("TVErrorLog").GetComponent<Text>();
        bool values = monitorControl.VerifyValues();
        if (values)
        {
            errorLog.text = "Saved Successfully!!!";
            CurrentBuffer = null;
            temp = null;
            return;
        }
        errorLog.text = "Invalid Input!!!";
    }

}
