using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public Transform[] blocks;
    public Transform stack;
    private float coolDown = 0.5f;
    private float offset = 0f;
    private float lastSpawn = 0;

	// Update is called once per frame
	void Update () {
        offset += 3f * Time.deltaTime;
        transform.position = new Vector3(Mathf.Sin(offset) * 8f, transform.position.y, transform.position.z);
        if(Input.anyKey){
            spawnRandom();
        }
	}

    private void spawnRandom(){
        if(lastSpawn + coolDown < Time.time){
            lastSpawn = Time.time;
            Instantiate(blocks[Random.Range(0, blocks.Length)], transform.position, transform.rotation, stack);
        }
    }
}
