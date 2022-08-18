﻿// 수정이 포함 여러 명이 대화할 때 대화창 시작하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S8C_DialogueStart : MonoBehaviour
{
	public Dialogue info;

	public S8C_DialogueSystem system;

	public Animator anim_nextSpot;
	void Start() {
		var system = FindObjectOfType<S8C_DialogueSystem>();
		system.Begin(info);
	}
	void Update() {
		if (system.finishedCount == 1) {
			anim_nextSpot.SetBool("isOpen", true);
		}
	}
}
