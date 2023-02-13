using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuClicker : MonoBehaviour
{
    public GameObject cred;
    public GameObject back;
    void OnMouseDown()
    {
        cred = GameObject.Find("Credits");
        back = GameObject.Find("Back");
        string clickedObject = this.name;
        SpriteRenderer sr1 = cred.GetComponent<SpriteRenderer>();
        SpriteRenderer sr2 = back.GetComponent<SpriteRenderer>();
        if(clickedObject == "Start")
        {
            SceneManager.LoadScene("Start Room");
        }
        else if(clickedObject == "CreditsButton")
        {
            sr1.enabled = true;
            sr2.enabled = true;
        }
        else if(clickedObject == "Back")
        {
            sr1.enabled = false;
            sr2.enabled = false;
        }
    }
}