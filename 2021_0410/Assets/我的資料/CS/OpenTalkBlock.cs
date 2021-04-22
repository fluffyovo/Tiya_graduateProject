using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTalkBlock : MonoBehaviour
{
    public Animator FadeInAni;
    public GameObject talkBlock;

    void Start()
    {
        FadeInAni.SetBool("FadeIn", true);
        StartCoroutine("Destroyitself");
    }


    public void OpenTalk_1()
    {
        talkBlock.SetActive(true);
    }

    IEnumerator Destroyitself()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
        yield break;

    }
}
