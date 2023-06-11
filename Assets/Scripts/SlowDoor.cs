using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDoor : Doors
{
    protected override void Execute(CharacterMove character)
    {
        character.speed = 1f;
    }

}
