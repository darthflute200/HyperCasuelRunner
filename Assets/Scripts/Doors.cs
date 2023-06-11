using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Doors : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<CharacterMove>(out CharacterMove character))
        {
            Execute(character);
        }
    }
    protected abstract void Execute(CharacterMove character);


}


