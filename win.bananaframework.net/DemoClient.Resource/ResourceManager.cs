using System;
using System.IO;
using System.Reflection;

namespace DemoClient.Resource
{
	public class ResourceManager
	{
		#region GetResource : 리소스 내용 반환
		/// <summary>
		/// 리소스 내용 반환
		/// </summary>
		/// <param name="ResourcePath"></param>
		/// <returns></returns>
		public static string GetResource(string ResourcePath)
		{
			string _retValue = string.Empty;

			try
			{
				var assembly = Assembly.GetExecutingAssembly();
				using (Stream stream = assembly.GetManifestResourceStream(ResourcePath))
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						_retValue = reader.ReadToEnd();
					}
				}
			}
			catch
			{
				throw;
			}

			return _retValue;
		}
		#endregion
	}
}
