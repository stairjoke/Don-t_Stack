using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gameJam
{
    public class StackingBehaviour : MonoBehaviour
    {

        public Transform above;
        public Transform below;
        public Transform body;

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.transform.GetComponent<StackingBehaviour>())
            {
                switch (other.transform.GetComponent<StackingBehaviour>().body.GetComponent<Type>().myType)
                {
                    case blockTypes.undefined:
                        undefinedCollision();
                        break;
                    case blockTypes.Apfel:
                        apfelCollision();
                        break;
                    case blockTypes.Erdbeere:
                        erdbeereCollision();
                        break;
                    case blockTypes.Marshmallow:
                        marshmallowCollision();
                        break;
                }
            }
        }

        private void undefinedCollision(){
            Debug.Log("undefined");
        }
        private void apfelCollision() {
            Debug.Log("Apfel");
        }
        private void erdbeereCollision() {
            Debug.Log("Erdbeere");
        }
        private void marshmallowCollision() {
            Debug.Log("Marshmallow");
        }
    }
}