using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprigganBehavior : BaseEnemyBehavior
{

    [Tooltip("Distance at which this enemy follows the player.")]
    [SerializeField] float followDistance;

    GameObject player;
    Rigidbody myRigidbody;
    Animator myAnimator;
    /// <summary>
    /// Returns -1 if the player is behind the object or 1 if the player is ahead of the object.
    /// </summary>
    int relativeRotation;

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
        if ((transform.position.x - player.transform.position.x) <= 0)
            relativeRotation = -1;
        else
            relativeRotation = 1;
    }

    private void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= followDistance)
        {
            myRigidbody.MovePosition(transform.position + transform.forward * Time.deltaTime * speed);
        }
    }
}
