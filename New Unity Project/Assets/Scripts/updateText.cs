using UnityEngine;
using UnityEngine.UI;

public class updateText : MonoBehaviour
{

    //Text Field to target
    public Text textShow = null;

	private void Start()
	{
        Debug.Log(textShow.text);
	}
	public void changeText(string toChangeValue)
    {
        textShow.text = textShow.text + toChangeValue;

        Debug.Log(textShow.text);
    }

    public void ResetValue() {
        textShow.text = "";
    }
}
