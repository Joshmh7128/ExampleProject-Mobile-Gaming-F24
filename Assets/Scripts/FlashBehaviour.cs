using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashBehaviour : EnemyBehaviour
{
    [SerializeField] Color prime, alternate;

    public override void StartBehaviour()
    {
    }

    public override void MainBehaviour()
    {
        ourObject.GetComponent<SpriteRenderer>().color = Color.Lerp(prime, alternate, Mathf.Sin(Time.time));
    }


}
