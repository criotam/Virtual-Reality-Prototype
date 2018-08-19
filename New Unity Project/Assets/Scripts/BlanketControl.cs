using UnityEngine;

public class BlanketControl : MonoBehaviour {

    [SerializeField]
    GameObject[] blanket;

    public bool AllBlanketHasSheet()
    {
        int count = 0;
        for (int i =0; i<blanket.Length; ++i)
        {
            if (blanket[i].GetComponent<Blanket>().blanket_has_sheet)
            {
                count++;
            }
        }

        if (count == blanket.Length)
            return true;
        return false;
    }

    public void SetBlanketSheetTrue()
    {
        for (int i = 0; i<blanket.Length; ++i)
        {
            blanket[i].GetComponent<Blanket>().blanket_has_sheet = true;
        }
    }
}
