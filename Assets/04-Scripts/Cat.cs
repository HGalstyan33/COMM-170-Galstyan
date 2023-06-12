using UnityEngine;
using UnityEngine.SceneManagement;

public class Cat : MonoBehaviour
{
    private Game _gameScript;
    private bool teleport;

    [SerializeField] private PlayerData data;

    void Awake()
    {
        teleport = data.teleport;
    }

    void OnEnable()
    {
        _gameScript = GameObject.FindGameObjectWithTag("Room").GetComponent<Game>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Door" && teleport)
        {
            if (SceneManager.GetActiveScene().name == "Kitchen") SceneManager.LoadScene("Bedroom");
            else
            {
                if(_gameScript.getFood())
                {
                    teleport = false;
                    data.teleport = teleport;
                }
                SceneManager.LoadScene("Kitchen");
            }
        }
    }
}
