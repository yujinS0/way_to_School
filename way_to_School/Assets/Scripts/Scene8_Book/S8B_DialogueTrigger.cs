// 버튼 클릭 시 대화 시작하게 하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S8B_DialogueTrigger : MonoBehaviour
{
	public Dialogue info;

	public void Trigger() {
		var system = FindObjectOfType<S8B_DialogueSystem>(); // 타입 DialogueSystem은 상황에 맞게 변경해서 각 Scene 폴더에 복붙하기
		system.Begin(info);
	}
}
