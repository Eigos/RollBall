using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float verticalMovementRange = 0;
    public float verticalMovementSpeed = 0;
    public float rotationSpeed = 0;

    private Vector3 verticalDestinationPosition = Vector3.zero;
    private Vector3 verticalStartPosition = Vector3.zero;
    private bool isVerticalMovingUpwards = true;


    private void Start()
    {
        verticalStartPosition = transform.position;

        verticalDestinationPosition = verticalStartPosition;
        verticalDestinationPosition.y += verticalMovementRange;
    }

    private void Update()
    {
        transform.Rotate(rotationSpeed, 0f ,0f);

        transform.position = Vector3.MoveTowards(transform.position, verticalDestinationPosition, verticalMovementSpeed * Time.deltaTime);

        if (Mathf.Approximately(transform.position.y, verticalDestinationPosition.y))
        {
            if (isVerticalMovingUpwards)
            {
                verticalDestinationPosition.y = verticalStartPosition.y - verticalMovementRange;
            }
            else
            {
                verticalDestinationPosition.y = verticalStartPosition.y + verticalMovementRange;
            }

            isVerticalMovingUpwards = !isVerticalMovingUpwards;
        }
    }


}


