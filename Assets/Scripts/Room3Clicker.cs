using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Room3Clicker : MonoBehaviour
{
    public GameObject player;
    public GameObject gun;
    public GameObject cigar;
    public GameObject esc;
    public GameObject stay;
    public static int c;
    DialogueTrigger dt;
    void Start()
    {
        Debug.Log(player.transform.position.x);
        cigar = GameObject.Find("Cigarette");
        gun = GameObject.Find("Gun");
        player = GameObject.Find("Player");
        Image gunImg = gun.GetComponent<Image>();
        Image cigarImg = cigar.GetComponent<Image>();
        if(player.transform.position.x == -11.25)
        {
            if(c == 1)
            {
                gunImg.enabled = true;
                cigarImg.enabled = true;
            }
        }
    }
    void OnMouseDown()
    {
        player = GameObject.Find("Player");
        cigar = GameObject.Find("Cigarette");
        gun = GameObject.Find("Gun");
        esc = GameObject.Find("Escape");
        stay = GameObject.Find("Stay");
        string clickedObject = this.name;
        SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
        SpriteRenderer sr1 = esc.GetComponent<SpriteRenderer>();
        SpriteRenderer sr2 = stay.GetComponent<SpriteRenderer>();
        BoxCollider2D bc1 = esc.GetComponent<BoxCollider2D>();
        BoxCollider2D bc2 = stay.GetComponent<BoxCollider2D>();
        Image gunImg = gun.GetComponent<Image>();
        Image cigarImg = cigar.GetComponent<Image>(); 
        if(this.transform.position.x + 4 > player.transform.position.x)
        {
            if(clickedObject == "Chest")
            {
                dt = this.GetComponent<DialogueTrigger>();
                dt.TriggerDialogue();
                gunImg.enabled = true;
                cigarImg.enabled = true;
                c = 1;
            }
            else if(clickedObject == "EntryDoor")
            {
                SceneManager.LoadScene("Puzzle Room");
            }
            else if(clickedObject == "ExitDoor")
            {
                sr1.enabled = true; sr2.enabled = true;
                bc1.enabled = true; bc2.enabled = true;
                dt = this.GetComponent<DialogueTrigger>();
                dt.TriggerDialogue();
            }
            else if(clickedObject == "Escape")
            {
                SceneManager.LoadScene("Ending1");
            }
            else if(clickedObject == "Stay")
            {
                sr1.enabled = false; sr2.enabled = false;
                bc1.enabled = false; bc2.enabled = false;
                dt = this.GetComponent<DialogueTrigger>();
                dt.TriggerDialogue();
            }
        }
    }
}