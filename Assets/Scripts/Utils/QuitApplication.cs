using UnityEditor;
using UnityEngine;

namespace Utils
{
	public class QuitApplication : MonoBehaviour
	{
		public void Quit()
		{
#if UNITY_EDITOR
			EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
		}
	}
}
