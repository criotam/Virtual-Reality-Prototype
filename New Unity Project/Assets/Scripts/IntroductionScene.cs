using System.Collections;
using UnityEngine;

public class IntroductionScene : MonoBehaviour {

    [SerializeField]
    GameObject Player, Image;

    [SerializeField]
    GameObject PlayerPoint = null, CanvasPoint = null, TutorialInterface;

    [SerializeField]
    GameObject WelcomeAudio;

    IEnumerator timeLapse()
    {
        yield return new WaitForSeconds(1);
        Image.SetActive(false);
        AudioClip ad;
        if (WelcomeAudio.GetComponent<Introduction>()!=null)
             ad = WelcomeAudio.GetComponent<Introduction>().IntroductionAudio;
        else
            ad = ad = WelcomeAudio.GetComponent<PrinterTutorial>().IntroductionAudio;
        Player.GetComponentInChildren<AudioSource>().PlayOneShot(ad);
    }

    void Start()
    {
        //This if loop is only for PrinterTutorial Scene
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
