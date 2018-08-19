using UnityEngine;
using UnityEngine.UI;
using System;

public class MonitorControl : MonoBehaviour {

    [SerializeField]
    GameObject SheetCount, SheetThickness;

    public bool VerifyValues()
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
            return false;
        }
        if (n1 < 0.04 || n1 > 0.6)
        {
            return false;
        }
        return true;
    }
}
