using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Room4Clicker : MonoBehaviour
{
    public GameObject player;
    public GameObject pun;
    public GameObject sht;
    public GameObject gun;
    DialogueTrigger dt;
    void OnMouseDown()
    {
        player = GameObject.Find("Player");
        pun = GameObject.Find("Punch");
        sht = GameObject.Find("Shoot");
        gun = GameObject.Find("Gun");
        string clickedObject = this.name;
        SpriteRenderer sr1 = pun.GetComponent<SpriteRenderer>();
        SpriteRenderer sr2 = sht.GetComponent<SpriteRenderer>();
        BoxCollider2D bc1 = pun.GetComponent<BoxCollider2D>();
        BoxCollider2D bc2 = sht.GetComponent<BoxCollider2D>();
        Image gunImg = gun.GetComponent<Image>();
        if(this.transform.position.x + 4 > player.transform.position.x)
        {
            if(clickedObject == "Killer")
            {
                sr1.enabled = true; sr2.enabled = true;
                bc1.enabled = true; bc2.enabled = true;
                dt = this.GetComponent<DialogueTrigger>();
                dt.TriggerDialogue();
            }
            else if(clickedObject == "Punch")
            {
                SceneManager.LoadScene("Ending2");
            }
            else if(clickedObject == "Shoot")
            {
                if(gunImg.enabled == false)
                {
                    dt = this.GetComponent<DialogueTrigger>();
                    dt.TriggerDialogue();
                }
                else
                {
                    SceneManager.LoadScene("Ending3");
                }
            }
        }
    }
}