using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    int i = 3;

    public Renderer rend;

    int rand;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        rand = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (i == 100)
        {
            if (gameObject.tag == "Red")
            {
                gameObject.SetActive(false);
            }
        }

        if (i == rand)
        {
            if (gameObject.tag == "Blue")
            {
                rend.enabled = false;
            }
        }
    }
}
