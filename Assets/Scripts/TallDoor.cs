using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TallDoor : Doors
{
    protected override void Execute(CharacterMove character)
    {
        character.transform.localScale = new Vector3(transform.localScale.x, 10f, transform.localScale.z);
    }

}
