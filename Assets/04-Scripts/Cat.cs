using UnityEngine;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door") SceneManager.LoadScene("Bedroom");
    }
}
