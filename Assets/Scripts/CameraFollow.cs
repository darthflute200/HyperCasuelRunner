using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;

    private void CameraMove()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Player.position.z - 2f);
    }
    private void Update()
    {
        CameraMove();
    }

}
