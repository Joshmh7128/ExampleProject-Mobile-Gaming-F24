using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorBehaviour : EnemyBehaviour
{
    [SerializeField] Color prime;

    public override void StartBehaviour()
    {
        ourObject.GetComponent<SpriteRenderer>().color = prime;
    }

    public override void MainBehaviour()
    {
    }
}

