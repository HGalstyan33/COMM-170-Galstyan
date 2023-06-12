using UnityEngine;

public class Girl : MonoBehaviour
{
    [SerializeField] private Light spotlight;
    [SerializeField] private GameObject text;

    private Game _gameScript;
    private GameObject target;
    private Animator anim;
    private float speed = 10.0f;
    private Vector3 targetDirection;

    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Door");
        _gameScript = GameObject.FindGameObjectWithTag("Room").GetComponent<Game>();
        text.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Important")
        {
            anim.SetTrigger("Pet");
            text.SetActive(false);
        }
        if (other.gameObject.tag == "Door")
        {
            _gameScript.setFood();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
        {
            var step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
            targetDirection = target.transform.position - transform.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, step, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);

            Vector3 temp = new Vector3(transform.position.x, spotlight.transform.position.y, transform.position.z);
            spotlight.transform.position = temp;
        }
    }
}
