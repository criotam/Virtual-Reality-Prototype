using System.Collections;
using UnityEngine;


public class IntroductionScene : MonoBehaviour {

    [SerializeField]
    GameObject Player, Image;

    [SerializeField]
    GameObject PlayerPoint = null, CanvasPoint = null, TutorialInterface;


    IEnumerator timeLapse()
    {
        yield return new WaitForSeconds(1);
        Image.SetActive(false);
    }

    void Start()
    {
        if (CanvasPoint != null && PlayerPoint != null)
        {
            TutorialInterface.transform.position = CanvasPoint.transform.position;
            TutorialInterface.transform.rotation = CanvasPoint.transform.rotation;
            Player.transform.position = PlayerPoint.transform.position;
            Player.transform.rotation = PlayerPoint.transform.rotation;
        }
        Player.SetActive(true);
        Image.GetComponent<Animator>().SetBool("LoadFade", true);
        StartCoroutine(timeLapse());
    }
}
