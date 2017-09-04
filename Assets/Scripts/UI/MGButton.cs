using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace UI
{
	[RequireComponent(typeof(Button))]
	public class MGButton : MonoBehaviour
	{
		protected virtual void Start() {
			GetComponent<Button>().onClick.AddListener(OnClick);
		}

		public virtual void OnClick() {
			// TODO: Add sfx here.
		}
	}
}

