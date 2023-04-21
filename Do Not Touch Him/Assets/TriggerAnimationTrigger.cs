using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TriggerAnimationTrigger : MonoBehaviour
{
    public Animator animator;

    public void Awake()
    {
        if(animator == null )
            animator = GetComponent<Animator>();
        //StartCoroutine("ClenchHands");
    }

    public IEnumerator ClenchHands()
    {
        yield return new WaitForSeconds( 3.0f );
        print("Clenching monkey fists");
        animator.SetTrigger("Clench Fist");
    }
    public void ClenchHand()
    {
        print("Clenching monkey fists");
        animator.SetTrigger("Clench Fist");
    }
}
