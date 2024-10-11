using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherArrayExample : MonoBehaviour
{
    // our sprite object prefab
    [SerializeField] GameObject prefab;

    int max = 500;

    // our map to be heated
    public float[,] numbersXY = new float[500,500];
    public SpriteRenderer[,] renderers = new SpriteRenderer[500,500];

    private void Start()
    {
        // build numbers xy to be a grid
        for (int x = 0; x < max; x++)
        {
            for (int y = 0; y < max; y++)
            {
                // place the numbers!
                numbersXY[x,y] = 0 + Random.Range(0,max);
                // make a square!
                renderers[x,y] = Instantiate(prefab, new Vector2(x, y), Quaternion.identity).GetComponent<SpriteRenderer>();
                // set the color
                renderers[x,y].color = Color.Lerp(Color.grey, Color.red, numbersXY[x,y] / max);
            }
        }
    }

    private void FixedUpdate()
    {
        // build numbers xy to be a grid
        for (int x = 0; x < max; x++)
        {
            for (int y = 0; y < max; y++)
            {
                if ((int)Time.time % 2 == (x % 2))
                {
                    // place the numbers!
                    numbersXY[x, y] = numbersXY[x, y] + 1;
                    if (numbersXY[x, y] > max)
                        numbersXY[x, y] = 0;
                    if (renderers[x, y].isVisible)
                    {
                        // set the color
                        renderers[x, y].color = Color.Lerp(Color.grey, Color.red, numbersXY[x, y] / max);
                    }
                }
            }
        }

        /*
        if ((int)Time.time % 2 == 0)
        {
            // build numbers xy to be a grid
            for (int x = 0; x < max/2; x++)
            {
                for (int y = 0; y < max; y++)
                {
                    // place the numbers!
                    numbersXY[x, y] = numbersXY[x, y] + 1;
                    if (numbersXY[x, y] > max)
                        numbersXY[x, y] = 0;
                    // set the color
                    renderers[x, y].color = Color.Lerp(Color.grey, Color.red, numbersXY[x, y] / max);
                }
            }
        }
        else
        {
            // build numbers xy to be a grid
            for (int x = max/2; x < max; x++)
            {
                for (int y = 0; y < max; y++)
                {
                    // place the numbers!
                    numbersXY[x, y] = numbersXY[x, y] + 1;
                    if (numbersXY[x, y] > max)
                        numbersXY[x, y] = 0;
                    // set the color
                    renderers[x, y].color = Color.Lerp(Color.grey, Color.red, numbersXY[x, y] / max);
                }
            }
        }*/
    }

}