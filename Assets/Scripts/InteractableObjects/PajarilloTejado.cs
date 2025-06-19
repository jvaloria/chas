using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PajarilloTejado : InteractableObject
{
    [SerializeField] public int pajaritoState = 0;
    [SerializeField] private Animator animator;
    private bool isflying = false;
    [SerializeField] float SpeedX;
    [SerializeField] float SpeedY;
    [SerializeField] float SpeedSizeIncrease;
    private float passedTime = 0f;
    [SerializeField] float currentXpos = 0;
    [SerializeField] float targetXpos;
    [SerializeField] float speedUntilXpos;
    [SerializeField] bool hasReachedPos = false;
    void Update()
    {
        if (!hasReachedPos)
        {
            if(currentXpos >= targetXpos)
            {
                hasReachedPos = true;
                currentXpos = targetXpos;
            }
            else if (currentXpos < targetXpos)
            {
                currentXpos += speedUntilXpos * Time.deltaTime;
                transform.position += new Vector3(speedUntilXpos * Time.deltaTime, 0, 0);
            }
        }
        /*passedTime += Time.deltaTime;
        if (passedTime < 1) {
            transform.position += new Vector3(0.055f,0,0);
        }*/
        if (isflying)
        {
            transform.position = new Vector3(SpeedX * Time.deltaTime + transform.position.x, SpeedY * Time.deltaTime + transform.position.y, transform.position.z);
            transform.localScale = new Vector3(SpeedSizeIncrease * Time.deltaTime + transform.localScale.x, SpeedSizeIncrease * Time.deltaTime + transform.localScale.y, SpeedSizeIncrease * Time.deltaTime + transform.localScale.z);
            if (transform.localScale.x <= 0)
            {
                gameObject.SetActive(false);
            }

        }
    }
    protected override void CustomAction()
    {
        if (animator.GetBool("isClickable")){
            animator.SetBool("isClicked", true);
            animator.SetBool("isClickable", false);
            if (continuesStory)
            {
                StartFlying();
            }
        }

    }

    void OnMouseDown()
    {
        OnClick();
    }

    public void EnableStory() {
        continuesStory = true;
    }

    public void moveToCompensate()
    {
        transform.position += new Vector3(0.75f, 0f, 0f);
    }

    public void StartFlying()
    {
        //continuesStory = false;
        isflying = true;
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
