using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int controllerNumber = 0;
    [SerializeField] int speed;

    PlayerControls controls;

    Vector2 controllerLeftAnalog;
    InputUser myUser;
    Vector3 bufferVector;
    Rigidbody myRigidbody;
    Animator myAnimator;
    int bodyRotation = 1;
    bool canMove = true;

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

        if (transform.eulerAngles.y >= 85.0f && transform.eulerAngles.y <= 95.0f)
        {
            bodyRotation = 1;
        }
        else if (transform.eulerAngles.y >= 265 && transform.eulerAngles.y <= 275)
        {
            bodyRotation = -1;
        }
    }

    void BasicAttack()
    {
        if (canMove)
        {
            myAnimator.SetTrigger("BasicPunch");
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

            myRigidbody.MovePosition(transform.position + (transform.forward * GetAxisUni(controllerLeftAnalog.x) * speed * Time.deltaTime * bodyRotation));
        }
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
