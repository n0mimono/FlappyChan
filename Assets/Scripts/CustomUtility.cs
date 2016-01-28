using UnityEngine;
using System.Collections;
using System;

namespace Custom {
	public static class Utility {
		public static Vector3 SetPosition(this MonoBehaviour behav, Transform src) {
			return behav.transform.position = src.position;
		}
	}

	public class ConditionalEnumerator : IEnumerator {
		private IEnumerator routine;
		private Func<bool> predicate;

		public ConditionalEnumerator(IEnumerator routine, Func<bool> predicate) {
			this.routine = routine;
			this.predicate = predicate;
		}

		public bool MoveNext () {
			return predicate () && routine.MoveNext ();
		}

		public void Reset () {
			routine.Reset ();
		}

		public object Current {
			get {
				return routine.Current;
			}
		}

	}

	public static class EnumeratorExtension {
		public static IEnumerator While(this IEnumerator routine, Func<bool> predicate) {
			return new ConditionalEnumerator (routine, predicate);
		}

		public static Coroutine StartBy(this IEnumerator routine, MonoBehaviour behav) {
			return behav.StartCoroutine (routine);
		}
	}

}
