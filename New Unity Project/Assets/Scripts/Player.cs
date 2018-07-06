using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    GameObject Cvas;

    Camera _cam=null;

    void Update() {
        if (_cam!=null)
            Cvas.GetComponent<eventCamera>().changePos(_cam.transform.position, _cam.transform.forward, _cam.transform.rotation);
    }

    public void SetCompanion()
    {
        _cam = GetComponentInChildren<Camera>();
        Cvas.transform.position = this.transform.position + new Vector3(0, 0, 0.5f);
        Cvas.GetComponent<eventCamera>().setEventCamera(Camera.main, this.gameObject.transform.position);
    }
}
