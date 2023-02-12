using UnityEngine;
public class PianoPlayer : MonoBehaviour
{
    public static int clickOrder;
    public static int loaded = 0;
    public GameObject shelf;
    public GameObject dialogue;
    DialogueTrigger dt;    
    void OnMouseDown()
    {
        shelf = GameObject.Find("Bookshelf");
        string clickedObject = this.name;
        if(clickedObject == "E")
        {
            this.GetComponent<AudioSource>().Play();
            clickOrder = clickOrder == 0 || clickOrder == 2 || clickOrder == 4 ? clickOrder+1 : 0;
        }
        else if(clickedObject == "D#")
        {
            this.GetComponent<AudioSource>().Play();
            clickOrder = clickOrder == 1 || clickOrder == 3 ? clickOrder+1 : 0;
        }
        else if(clickedObject == "D")
        {
            this.GetComponent<AudioSource>().Play();
            clickOrder = clickOrder == 6 ? clickOrder+1 : 0;
        }
        else if(clickedObject == "C")
        {
            this.GetComponent<AudioSource>().Play();
            clickOrder = clickOrder == 7 ? clickOrder+1 : 0;
        }
        else if(clickedObject == "B")
        {
            this.GetComponent<AudioSource>().Play();
            clickOrder = clickOrder == 5 ? clickOrder+1 : 0;
        }
        else if(clickedObject == "A")
        {
            this.GetComponent<AudioSource>().Play();
            clickOrder = clickOrder == 8 ? clickOrder+1 : 0;
        }
        else if(clickedObject == "Hint")
        {
            dt = this.GetComponent<DialogueTrigger>();
            dt.TriggerDialogue();
        }
        if(clickOrder == 9)
        {
            Debug.Log(clickOrder);
            shelf.transform.Translate(4,0,0);
        }
    }
}