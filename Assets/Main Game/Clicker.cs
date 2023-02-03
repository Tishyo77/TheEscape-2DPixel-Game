using UnityEngine;
using UnityEngine.UI;
public class Clicker : MonoBehaviour
{
    public int hair_pin; 
    public GameObject player;
    public GameObject hp;
    void OnMouseDown()
    {
        hp = GameObject.Find("Hairpin");
        player = GameObject.Find("Player");
        string clickedObject = this.name;
        SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
        Image ig = hp.GetComponent<Image>();
        if(this.transform.position.x + 4 > player.transform.position.x)
        {
            if(clickedObject == "BodyBag1")
            {
                ig.enabled = true;
            }
            else if(clickedObject == "Door")
            {
                if(ig.enabled == true)
                {
                    sr.enabled = false;
                    Destroy(GetComponent<BoxCollider2D>());
                }
            }
        }
    }
}