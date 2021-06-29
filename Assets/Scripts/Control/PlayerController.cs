using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NINJA.Movement;

namespace NINJA.Control
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] float playerSpeed = 8f;

        private void Update()
        {
            ControlMovement();
        }

        private void ControlMovement()
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 destination = GetDestination();
                GetComponent<CharacterMovement>().MoveTo(destination, playerSpeed);
            }
        }

        private Vector3 GetDestination()
        {
            RaycastHit hit;
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);
            return hit.point;
        }
    }
}
