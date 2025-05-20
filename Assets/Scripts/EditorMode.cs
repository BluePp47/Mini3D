using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class EditorMode : MonoBehaviour
{
    public float editorMoveSpeed = 1f;
    public float editorJumpPower = 3f;


    public PlayerController PC;


    void Start()
    {
        //매번 리셋할때마다 컴포넌트 가져오기 귀찮으시잖아요 제가 편하게 넣어드릴게요예 다가져가세요
        PC = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }
    void Update()
    {
        PC.movespeed = editorMoveSpeed;
        PC.jumpPower = editorJumpPower;
    }




}


#region 에디터모드 토글 예시코드
/*
    bool isToggleEditor = false;
 * 
if (Input.GetKeyDown(KeyCode.F))
        {
            isToggleEditor = !isToggleEditor;

            if (isToggleEditor == true)
            {
                Debug.Log("에디터모드 실행중일건데아마한번맞춰보셈");
            }

            else if(isToggleEditor == false)
            {
                Debug.Log("에디터모드 종?료할게요");

            }

        }


//기존 설계
[SerializeField]
    private float speed { get { return PC.movespeed; } set { PC.movespeed = value; } }
    public float Speed { get { return speed; } set { PC.movespeed = value; } }
    //{ get { return speed; } }
*/
#endregion