using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(10, 0, 0);

    // Main Camera siga al Game Object Player
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
