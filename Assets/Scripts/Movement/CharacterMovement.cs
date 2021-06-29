using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace NINJA.Movement
{
    public class CharacterMovement : MonoBehaviour
    {
        NavMeshAgent character;
        Animator animator;

        // Start is called before the first frame update
        void Start()
        {
            character = GetComponent<NavMeshAgent>();
            animator = GetComponentInChildren<Animator>();
        }

        public void MoveTo(Vector3 destination, float speed)
        {
            if (Input.GetMouseButton(0))
            {
                character.destination = destination;
                character.speed = speed;

                UpdateAnimator(speed);
            }
        }


        void UpdateAnimator(float characterSpeed)
        {
            characterSpeed = transform.InverseTransformDirection(character.velocity).z;

            animator.SetFloat(AnimationTags.MOVE_PLAYER, characterSpeed);
        }


    }
}
