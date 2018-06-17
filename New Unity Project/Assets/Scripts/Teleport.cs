using UnityEngine;

public class Teleport : MonoBehaviour {

    GameObject Player;

    void Start() {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnPointerClick()
    {
        Player.transform.position = new Vector3(transform.position.x, Player.transform.position.y, transform.position.z);
    }    

}
