using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{

    public AudioSource hurt;

    private void OnMouseDown()
    {
        gameObject.GetComponent<AudioSource>().Play();

        Destroy(gameObject);
    }
}
