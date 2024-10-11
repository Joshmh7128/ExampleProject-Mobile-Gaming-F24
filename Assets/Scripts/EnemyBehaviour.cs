using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehaviour : MonoBehaviour
{
    // this is the main behaviour that runs when this behaviour is chosen
    public abstract void MainBehaviour();
    public abstract void StartBehaviour();

    // time for behaviour
    public float runtime;

    public GameObject ourObject;
}
