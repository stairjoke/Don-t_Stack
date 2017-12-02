using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEverything : MonoBehaviour {

    public AudioClip[] missed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        AudioSource.PlayClipAtPoint(missed[Random.Range(0, missed.Length)], other.transform.position);
        StartCoroutine(kill(other.gameObject));
    }

    private IEnumerator kill(GameObject g){
        yield return new WaitForSeconds(1);
        Destroy(g);
    }
}
