using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator myAn;
    private Transform targeted;
    public Transform returnHome;
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float _maxRange;
    [SerializeField]
    private float _minRange;
    // Start is called before the first frame update
    void Start()
    {
        myAn = GetComponent<Animator>();
        targeted = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(targeted.position, transform.position) <= _maxRange && Vector3.Distance(targeted.position, transform.position) >= _minRange)
        {
            FollowPlayer();
        }
        else if (Vector3.Distance(targeted.position, transform.position) >= _maxRange)
        {
            HeadHome();
        }
    }

    public void FollowPlayer()
    {
        myAn.SetBool("isMoving", true);
        myAn.SetFloat("moveX", (targeted.position.x - transform.position.x));
        myAn.SetFloat("moveY", (targeted.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, targeted.transform.position, movementSpeed * Time.deltaTime);
    }

    public void HeadHome()
    {
        myAn.SetFloat("moveX", (returnHome.position.x - transform.position.x));
        myAn.SetFloat("moveY", (returnHome.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, returnHome.position, movementSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, returnHome.position) == 0)
        { 
        myAn.SetBool("isMoving", false);
        }
    }
}
