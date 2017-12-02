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
        public Sprite effect;
        private bool hasStacked = false;


        void Start()
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,-2), ForceMode2D.Impulse);
        }

        void OnCollisionEnter2D(Collision2D other){
            switch(body.GetComponent<Type>().myType){
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

        /*
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
*/
        private void undefinedCollision(){
            hasStacked = true;
        }
        private void apfelCollision() {
            Debug.Log("Apfel");
            if(!hasStacked){
                body.GetComponent<SpriteRenderer>().sprite = effect;
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10f), ForceMode2D.Impulse);
                GetComponent<Rigidbody2D>().AddTorque(Mathf.Ceil(Random.Range(0f, 1f) - 0.5f) * 20f, ForceMode2D.Impulse);
            }
            hasStacked = true;
        }
        private void erdbeereCollision() {
            Debug.Log("Erdbeere");

            hasStacked = true;
        }
        private void marshmallowCollision() {
            Debug.Log("Marshmallow");

            hasStacked = true;
        }
    }
}