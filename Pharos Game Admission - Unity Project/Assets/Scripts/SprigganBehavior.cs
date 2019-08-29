using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprigganBehavior : BaseEnemyBehavior
{

    [Tooltip("Distance at which this enemy follows the player.")]
    [SerializeField] float followDistance;
    [Tooltip("Distance at which this enemy starts to attack the player.")]
    [SerializeField] float attackDistance;
    [Tooltip("Time between attacks.")]
    [SerializeField] float attackCooldown;
    [Tooltip("Chance for the ranged attack to happen, between 0 and the inserted value. 0 to 5 means the attack will happen.")]
    [SerializeField] float attackChance;
    [SerializeField] float timeBetweenRandoms;
    [SerializeField] GameObject damageCollider;

    GameObject player;
    Rigidbody myRigidbody;
    Animator myAnimator;
    Vector3 bufferVector;
    bool canMove = true, canCallCoroutine = true, hasCalled = false;
    /// <summary>
    /// equals -1 if the player is behind the object or 1 if the player is ahead of the object.
    /// </summary>
    int relativeRotation;
    /// <summary>
    /// Distance between the player and the enemy.
    /// </summary>
    float distanceFromPlayer, randomValue = 0.0f;

    private void Awake()
    {
        myAnimator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(relativeRotation);
        if ((transform.position.x - player.transform.position.x) >= 0)
            relativeRotation = -1;
        else
            relativeRotation = 1;
    }

    private void FixedUpdate()
    {

        bufferVector.Set(0.0f, 90.0f * relativeRotation, 0.0f);
        transform.eulerAngles = bufferVector;

        distanceFromPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceFromPlayer <= followDistance && distanceFromPlayer >= attackDistance && canMove)
        {
            myRigidbody.MovePosition(transform.position + transform.forward * Time.deltaTime * speed);
            StartCoroutine(GetRandomValue());
            if (randomValue <= 5 && !hasCalled)
            {
                hasCalled = true;
                StartCoroutine(TreeGrow());
            }
        }
        else if (distanceFromPlayer < attackDistance)
        {
            if (canMove)
            {
                StartCoroutine(SporeSpray());
            }
        }
    }

    private IEnumerator TreeGrow()
    {
        myAnimator.SetTrigger("TreeGrow");
        canMove = false;
        yield return new WaitForSeconds(attackCooldown);
        canMove = true;
    }

    private IEnumerator SporeSpray()
    {
        myAnimator.SetTrigger("SporeSpray");
        canMove = false;
        yield return new WaitForSeconds(attackCooldown);
        canMove = true;
    }

    private IEnumerator GetRandomValue()
    {
        if (canCallCoroutine)
        {
            randomValue = Random.Range(0, attackChance);
            canCallCoroutine = false;
            yield return new WaitForSeconds(timeBetweenRandoms);
            canCallCoroutine = true;
            hasCalled = false;
        }
    }

    public void SetTreeAttack()
    {
        Vector3 treeVector = transform.position;
        treeVector.Set(player.transform.position.x, treeVector.y, treeVector.z);
        damageCollider.transform.position = treeVector;
        Debug.Log(damageCollider.transform.position);
    }
}
