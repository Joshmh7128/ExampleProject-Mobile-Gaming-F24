using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ArrayExample : MonoBehaviour
{
    public List<ArrayHolder> arrayHolders;

    private void Start()
    {
        Debug.Log(arrayHolders[0].arrayHolders[0].arrayAgainAgains[0].strings[0]);
    }
}

[System.Serializable]
public class ArrayHolder
{
    public List<ArrayHolderAgain> arrayHolders = new List<ArrayHolderAgain>();
}

[System.Serializable]
public class ArrayHolderAgain
{
    public List<ArrayHolderAgainAgain> arrayAgainAgains = new List<ArrayHolderAgainAgain>();
}

[System.Serializable]
public class ArrayHolderAgainAgain
{
    public List<string> strings = new List<string>();
}