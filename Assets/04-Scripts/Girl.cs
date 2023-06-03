using UnityEngine;

public class Girl : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Important")
        {
            anim.SetTrigger("Pet");
        }
    }
}
