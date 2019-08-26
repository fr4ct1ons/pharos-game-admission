using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int controllerNumber = 0;
    [SerializeField] int speed, dashSpeed;
    [SerializeField] float dashTime = 1.5f, dashCooldown = 2.0f;
    [SerializeField] Vector3 jumpDirection;

    PlayerControls controls;

    Vector2 controllerLeftAnalog;
    InputUser myUser;
    Vector3 bufferVector, groundCheck;
    Rigidbody myRigidbody;
    Animator myAnimator;
    int bodyRotation = 1;
    bool canMove = true, doingDash = false, canDash = true, isGrounded;
    float distToGround;

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

    private void Awake()
    {
        controls = new PlayerControls();

        controls.Gameplay.Move.performed += ctx => controllerLeftAnalog = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => controllerLeftAnalog = Vector2.zero;
        controls.Gameplay.BasicAttack.performed += ctx => BasicAttack();
        controls.Gameplay.Quit.performed += ctx => Application.Quit();
        controls.Gameplay.Dash.performed += ctx => ExecDash();
        controls.Gameplay.Jump.performed += ctx => Jump();

        controls.Gameplay.MoveLeft.performed += ctx => controllerLeftAnalog.x = -1.0f;
        controls.Gameplay.MoveRight.performed += ctx => controllerLeftAnalog.x = 1.0f;
        controls.Gameplay.MoveLeft.canceled += ctx => controllerLeftAnalog.x = 0.0f;
        controls.Gameplay.MoveRight.canceled += ctx => controllerLeftAnalog.x = 0.0f;

        myRigidbody = GetComponent<Rigidbody>();
        myAnimator = GetComponent<Animator>();
    }

    void Start()
    {
        bufferVector = transform.position;
        distToGround = GetComponent<Collider>().bounds.extents.y;
        if (transform.eulerAngles.y >= 85.0f && transform.eulerAngles.y <= 95.0f)
        {
            bodyRotation = 1;
        }
        else if (transform.eulerAngles.y >= 265 && transform.eulerAngles.y <= 275)
        {
            bodyRotation = -1;
        }
    }

    void Update()
    {
        if (canMove)
        {
            if (GetAxisUni(controllerLeftAnalog.x) != bodyRotation && GetAxisUni(controllerLeftAnalog.x) != 0)
            {
                transform.Rotate(0.0f, 180.0f, 0.0f);
            }

            if (transform.eulerAngles.y >= 85.0f && transform.eulerAngles.y <= 95.0f)
            {
                bodyRotation = 1;
            }
            else if (transform.eulerAngles.y >= 265 && transform.eulerAngles.y <= 275)
            {
                bodyRotation = -1;
            }

            if (controllerLeftAnalog != Vector2.zero)
                myAnimator.SetBool("Walking", true);
            else
                myAnimator.SetBool("Walking", false);

            
        }

        groundCheck = transform.position;
        groundCheck.Set(groundCheck.x, groundCheck.y - distToGround, groundCheck.z);
        if (Physics.CheckSphere(groundCheck, 0.1f))
            isGrounded = true;
        else
            isGrounded = false;

        myAnimator.SetBool("IsGrounded", isGrounded);
    }

    private void FixedUpdate()
    {
        if (!doingDash)
            myRigidbody.MovePosition(transform.position + (transform.forward * GetAxisUni(controllerLeftAnalog.x) * speed * Time.deltaTime * bodyRotation));
        else
        {
            myRigidbody.MovePosition(transform.position + (transform.forward * dashSpeed * Time.deltaTime));
        }
    }

    private void BasicAttack()
    {
        if (canMove)
        {
            myAnimator.SetTrigger("BasicPunch");
        }
    }

    private void ExecDash()
    {
        if(canDash)
        StartCoroutine(Dash());
    }

    private void Jump()
    {
        Debug.Log("Jumping.");
        if (isGrounded)
        {
            myRigidbody.AddForce(jumpDirection);
            myAnimator.SetTrigger("Jump");
        }
        else
        {
            Debug.Log("Player is on air");
        }
    }

    private IEnumerator Dash()
    {
        doingDash = true;
        canDash = false;
        myRigidbody.useGravity = false;
        myRigidbody.velocity = Vector3.zero;
        myAnimator.SetBool("Dash", true);
        myAnimator.SetTrigger("EnableAnyState");

        yield return new WaitForSeconds(dashTime);

        doingDash = false;
        myAnimator.SetBool("Dash", false);
        myRigidbody.useGravity = true;

        yield return new WaitForSeconds(dashCooldown);

        canDash = true;
    }

    private float GetAxisUni(string axis)
    {
        if (Input.GetAxisRaw(axis) > 0)
            return 1;
        else if (Input.GetAxisRaw(axis) < 0)
            return -1;
        else
            return 0;
    }

    private float GetAxisUni(float value)
    {
        if (value > 0)
            return 1;
        else if (value < 0)
            return -1;
        else
            return 0;
    }

    private IEnumerator Stun(float time)
    {
        canMove = false;
        yield return new WaitForSeconds(time);
        canMove = true;
    }
    public int GetBodyRotation() { return bodyRotation; }

    //Animator scripts

    public void UnallowMovement() { canMove = false; }
    public void AllowMovement() { canMove = true; }
}
