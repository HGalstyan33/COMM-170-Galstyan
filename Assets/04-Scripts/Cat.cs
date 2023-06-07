using UnityEngine;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Door")
        {
            if (SceneManager.GetActiveScene().name == "Kitchen") SceneManager.LoadScene("Bedroom");
            else SceneManager.LoadScene("Kitchen");

            changePosition(SceneManager.GetActiveScene().name);
        }
    }

    void changePosition(string name) // not working in kitchen
    {
        GameObject cat = GameObject.Find("Player");
        if (name == "Bedroom") cat.transform.position = new Vector3(-26.75f, 0, 19.74f);
        else cat.transform.position = new Vector3(9.92f, 0, 19.97f);
    }
}
