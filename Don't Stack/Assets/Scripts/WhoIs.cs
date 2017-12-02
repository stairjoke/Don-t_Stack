using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhoIs : MonoBehaviour
{

    private BlockType other = null;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<BlockType>()){
            this.other = other.GetComponent<BlockType>();
        }

    }

    public BlockType.blockTypes getType()
    {
        return other.type();
    }
}