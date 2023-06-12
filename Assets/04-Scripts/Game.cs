using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    private bool _getFood;
    [SerializeField] private PlayerData data;

    public GameObject[] events;

    void Awake()
    {
        _getFood = data._getFood;

        if (events.Length > 0)
        {
            events[0].SetActive(true);
            events[1].SetActive(false);
            events[2].SetActive(false);
        }
    }

    void OnEnable()
    {
        if (_getFood)
        {
            events[0].SetActive(false);
            events[1].SetActive(true);
            events[2].SetActive(true);
        }
    }


    public bool getFood()
    {
        return data._getFood;
    }

    public void setFood()
    {
        _getFood = true;
        data._getFood = _getFood;
    }
}
