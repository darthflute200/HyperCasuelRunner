using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastDoor : Doors
{
    protected override void Execute(CharacterMove character)
    {
        character.speed = 10f;
    }

}
