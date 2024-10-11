using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : EnemyBehaviour
{
    Vector2 loc;

    public override void StartBehaviour()
    {
        // choose a new location
        loc = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
    }

    public override void MainBehaviour()
    {
        // move to that location
        ourObject.transform.position = Vector2.MoveTowards(ourObject.transform.position, loc, 5 * Time.deltaTime);
    }
}
