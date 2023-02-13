using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Room1Clicker : MonoBehaviour
{
    public GameObject player;
    public GameObject hp;
    public GameObject bb1;
    public GameObject dr;
    DialogueTrigger dt;
    void OnMouseDown()
    {
        hp = GameObject.Find("Hairpin");
        player = GameObject.Find("Player");
        bb1 = GameObject.Find("BodyBag1");
        dr = GameObject.Find("Door");
        string clickedObject = this.name;
        SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
        Image hpImg = hp.GetComponent<Image>();
        if(this.transform.position.x + 4 > player.transform.position.x)
        {
            if(clickedObject == "BodyBag1")
            {
                if(hpImg.enabled == false)
                {
                    dt = bb1.GetComponent<DialogueTrigger>();
                    dt.TriggerDialogue();
                }
                hpImg.enabled = true;
            }
            else if(clickedObject == "Player" || clickedObject == "BodyBag2" || clickedObject == "BodyBag3" || clickedObject == "BodyBag4" || clickedObject == "BodyBag5" || clickedObject == "Cupboard" || clickedObject == "BookshelfSmall")
            {
                dt = this.GetComponent<DialogueTrigger>();
                dt.TriggerDialogue();
            }
            else if(clickedObject == "Door")
            {
                if(hpImg.enabled == true)
                {
                    SceneManager.LoadScene("Puzzle Room");
                }
                else
                {
                    dt = dr.GetComponent<DialogueTrigger>();
                    dt.TriggerDialogue();
                }
            }
        }
    }
}