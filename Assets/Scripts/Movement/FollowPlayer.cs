using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    GameObject player;

    [SerializeField]
    Vector3 offset;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag(GameTags.PLAYER);
    }

    private void Update()
    {
        gameObject.transform.position = player.transform.position + offset;
    }





}
