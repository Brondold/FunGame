using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{

    public AudioClip hurt;

    private void OnMouseDown()
    {
        AudioSource.PlayClipAtPoint(hurt, transform.position);
        //gameObject.GetComponent<AudioSource>().Play();
        Destroy(gameObject);
    }
}
