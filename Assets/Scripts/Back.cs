using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Back : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Puzzle Room");
    }
}