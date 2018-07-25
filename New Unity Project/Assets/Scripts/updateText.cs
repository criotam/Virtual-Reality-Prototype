using UnityEngine;

public class updateText : MonoBehaviour
{
    private MonitorControl monitorControl;

    void Start()
    {
        monitorControl = GameObject.FindGameObjectWithTag("MonitorLevel").GetComponent<MonitorControl>();
    }
    
	public void changeText(string toChangeValue)
    {
        monitorControl.UpdateCurrentBuffer(toChangeValue);
    }

    public void DeleteButtonClick()
    {
        monitorControl.DeleteLastInput();
    }
}
