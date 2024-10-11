using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // all of our behaviours
    public List<GameObject> behaviourObjects = new List<GameObject>();

    List<EnemyBehaviour> behaviours = new List<EnemyBehaviour>();

    // current behaviour
    [SerializeField] EnemyBehaviour currentBehaviour = null;

    // current behaviour num
    int cb = 0;

    // run our behaviours
    private void Start()
    {
        foreach (GameObject gameObject in behaviourObjects)
            behaviours.Add(gameObject.GetComponent<EnemyBehaviour>());

        foreach (EnemyBehaviour behaviour in behaviours)
            behaviour.ourObject = gameObject;

        // start our first behaviour
        StartBehaviour();
    }

    void StartBehaviour()
    {
        if (currentBehaviour == null)
            currentBehaviour = behaviours[0];

        StartCoroutine(RunBehaviours());
    }

    IEnumerator RunBehaviours()
    {
        // wait for our runtime
        yield return new WaitForSecondsRealtime(currentBehaviour.runtime);
        // choose our current behaviour
        if (cb < behaviours.Count)
            cb++;
        if (cb >= behaviours.Count)
            cb = 0;
        // assign our current behaviour
        currentBehaviour = behaviours[cb];
        Debug.Log("changed behaviour to: " + currentBehaviour.name);
        currentBehaviour.StartBehaviour();
        // run it again!
        StartBehaviour();
    }

    private void FixedUpdate()
    {
        currentBehaviour.MainBehaviour();
    }

}
