using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gameJam
{
    public class StackingBehaviour : MonoBehaviour
    {
        public Transform body;
        public AudioClip marshmallowExtraSound;
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
                case blockTypes.Wurst:
                    wurstCollision();
                    break;
                case blockTypes.Chicken:
                    chickenCollision();
                    break;
            }
        }

        private void undefinedCollision(){
            hasStacked = true;
            if (!hasStacked)
            {
                Camera.main.GetComponent<Score>().updateScore(500);
            }
        }
        private void apfelCollision() {
            if(!hasStacked){
                GetComponent<AudioSource>().Play();
                body.GetComponent<Animator>().SetBool("bounce", true);
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10f), ForceMode2D.Impulse);
                GetComponent<Rigidbody2D>().AddTorque(Mathf.Ceil(Random.Range(0f, 1f) - 0.5f) * 5f, ForceMode2D.Impulse);
                if(!hasStacked){
                    Camera.main.GetComponent<Score>().updateScore(50);
                }
                hasStacked = true;
            }
        }
        private void erdbeereCollision() {
            if (!hasStacked)
            {
                Camera.main.GetComponent<Score>().updateScore(50);
                GetComponent<AudioSource>().Play();
            }
            hasStacked = true;
        }

        private IEnumerator playAudioClip(AudioClip audio){
            yield return new WaitForSeconds(1.7f);
            AudioSource.PlayClipAtPoint(audio, transform.position);
        }
        private void marshmallowCollision() {
            if (!hasStacked)
            {
                if (Random.value > 0.5){
                    body.GetComponent<Animator>().SetBool("smash", true);
                    Camera.main.GetComponent<Score>().updateScore(50);
                    StartCoroutine(playAudioClip(marshmallowExtraSound));
                }else{
                    GetComponent<AudioSource>().Play();
                    Camera.main.GetComponent<Score>().updateScore(150);
                }
                hasStacked = true;
            }
        }
        private void wurstCollision()
        {
            if (!hasStacked)
            {
                body.GetComponent<Animator>().SetBool("splash", true);
                Camera.main.GetComponent<Score>().updateScore(50);
                GetComponent<AudioSource>().Play();
                hasStacked = true;
            }
        }
        private void chickenCollision()
        {
            if (!hasStacked)
            {
                body.GetComponent<Animator>().SetBool("break", true);
                Camera.main.GetComponent<Score>().updateScore(50);
                GetComponent<AudioSource>().Play();
                hasStacked = true;
            }
        }
    }
}