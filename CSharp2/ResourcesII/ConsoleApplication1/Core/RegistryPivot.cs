using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Core
{
	public class RegistryPivot<T> : IEnumerator<T> where T : IModel, new()
	{
		protected StreamReader File { get; set; }
		public AbstractMap Map { get; set; }
		public RegistryPivot(AbstractMap map)
		{
			Map = map;
			string root = string.Format(@"Resources\Text_Files\{0}", map.Root);
			File = new StreamReader(root);
		}

		public T Current { get; set; }

		object IEnumerator.Current
		{
			get
			{
				return this;
			}
		}

		public void Dispose()
		{
			File.Close();
			File.Dispose();
		}

		public bool MoveNext()
		{
			string str = File.ReadLine();
			if (str != null)
			{
				Current = (T)Map.ToModel(str);
			}
			return str != null;
		}

		public void Reset()
		{
			Current = default(T);
		}
	}
}
