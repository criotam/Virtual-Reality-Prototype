using UnityEngine;

public class Teleport : MonoBehaviour {

    GameObject Player;

    
    public void OnPointerClick()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Player.transform.position = new Vector3(transform.position.x, Player.transform.position.y, transform.position.z);
    }    

}
