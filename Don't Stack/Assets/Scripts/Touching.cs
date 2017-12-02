using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gameJam{

public class Touching : MonoBehaviour
    {
        private blockTypes touch = blockTypes.undefined;
        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.GetComponent<Type>())
            {
                touch = other.GetComponent<Type>().myType;
            }else{
                touch = blockTypes.undefined;
            }
        }
        public void OnTriggerExit2D()
        {
                touch = blockTypes.undefined;
        }
    }
}