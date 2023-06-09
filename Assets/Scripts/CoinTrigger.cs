using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    private int point = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            point++;
            Destroy(other.gameObject);
            Debug.Log("Point");
        }
    }

}
