using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;
    [SerializeField] bool followXPos = false, followYPos = false, followZPos = false;
    [SerializeField] float xOffset = 0.0f, yOffset = 0.0f, zOffset = 0.0f;

    Vector3 bufferVector = new Vector3();

    private void Awake()
    {
        bufferVector = transform.position;
    }

    void Update()
    {
        if(objectToFollow)
        {
            if (followXPos)
                bufferVector.x = objectToFollow.transform.position.x + xOffset;
            if(followYPos)
                bufferVector.y = objectToFollow.transform.position.y + yOffset;
            if (followZPos)
                bufferVector.z = objectToFollow.transform.position.z + zOffset;

            transform.position = bufferVector;
        }
    }
}
