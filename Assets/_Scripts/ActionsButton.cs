﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ActionsButton : MonoBehaviour, ISelectHandler {

	private Text buttonText;

	// Use this for initialization
	void Start () {
		buttonText = GetComponentInChildren<Text>();
		buttonText.text = "Actions (" + 1.ToString() + ")"; //TODO This will pull the acting player's action count
	}
	
	public void OnSelect(BaseEventData eventData) {
		if(GameObject.Find("ActionButtons")){
			GameObject.Find("ActionButtons").SetActive(false);
		}

		if(GameObject.Find("AttackOptions")){
			GameObject.Find("AttackOptions").SetActive(false);
		}
		if(GameObject.Find("SpellAttackOptions")){
			GameObject.Find("SpellAttackOptions").SetActive(false);
		}
		if(GameObject.Find("SpellBuffOptions")){
			GameObject.Find("SpellBuffOptions").SetActive(false);
		}

		if(GetComponent<FightMenuButton>().subMenuInactive){
			GetComponent<Button>().image.overrideSprite = GetComponent<FightMenuButton>().subMenuInactive;
		}
	}
}
