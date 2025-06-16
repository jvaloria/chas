using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PajarilloTejado : InteractableObject
{
    [SerializeField] public int pajaritoState = 0;
    [SerializeField] private Animator animator;
    protected override void CustomAction()
    {
        if (animator.GetBool("isClickable")){
            animator.SetBool("isClicked", true);
            animator.SetBool("isClickable", false);
        }
        
    }

    void OnMouseDown()
    {
        OnClick();
    }

    public void EnableStory() {
        continuesStory = true;
    }

    /*public void setPajaritoState(int pState)
    {
        pajaritoState = pState;
    }

    public void addPajaritoState()
    {
        pajaritoState++;
    }

    public void movePajarito(float x, float y)
    {
        this.transform.position = new Vector3(this.transform.position.x + x, this.transform.position.y + y, this.transform.position.z);
    }*/


}
