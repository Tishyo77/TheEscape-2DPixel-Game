using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Room2Clicker : MonoBehaviour
{
    public GameObject player;
    public GameObject piano;
    public GameObject bs;
    DialogueTrigger dt;
    void OnMouseDown()
    {
        player = GameObject.Find("Player");
        piano = GameObject.Find("Piano");
        bs = GameObject.Find("Bookshelf");
        string clickedObject = this.name;
        SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
        if(this.transform.position.x + 4 > player.transform.position.x)
        {
            if(clickedObject == "Piano")
            {
                SceneManager.LoadScene("Piano");
            }
            else if(clickedObject == "EntryDoor")
            {
                SceneManager.LoadScene("Start Room");
            }
            else if(clickedObject == "ExitDoor")
            {
                SceneManager.LoadScene("Boss Room");
            }
            else if(clickedObject == "SecretDoor")
            {
                if(bs.transform.position.x != -5)
                    SceneManager.LoadScene("Secret Room");
            }
            else if(clickedObject == "Bookshelf")
            {
                dt = bs.GetComponent<DialogueTrigger>();
                dt.TriggerDialogue();
            }
        }
    }
}