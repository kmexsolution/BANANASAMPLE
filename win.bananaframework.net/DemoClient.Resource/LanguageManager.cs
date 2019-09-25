using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web.Configuration;

namespace DemoClient.Resource
{
	public class LanguageManager
	{
		#region IsHosted : 웹폼/윈폼 여부 반환
		/// <summary>
		/// 클래스를 호출한 프로세스가 웹 사이트인지 윈도우 응용 프로그램인지 여부를 반환하는 속성이다.
		/// 웹 사이트이면 true를 반환하고, 윈도우 응용 프로그램이면 false를 반환한다.
		/// </summary>
		public static bool IsHosted
		{
			get
			{
				try
				{
					var webAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("System.Web"));
					foreach (var webAssembly in webAssemblies)
					{
						var hostingEnvironmentType = webAssembly.GetType("System.Web.Hosting.HostingEnvironment");
						if (hostingEnvironmentType != null)
						{
							var isHostedProperty = hostingEnvironmentType.GetProperty("IsHosted", System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
							if (isHostedProperty != null)
							{
								object result = isHostedProperty.GetValue(null, null);
								if (result is bool)
								{
									return (bool)result;
								}
							}
						}
					}
				}
				catch (Exception)
				{
					// Failed to find or execute HostingEnvironment.IsHosted; assume false
				}
				return false;
			}
		}
		#endregion

		#region GetCurrentCultureShortName : 현재의 OS/브라우저 언어 설정 정보
		/// <summary>
		/// 현재의 OS/브라우저 언어 설정 정보
		/// </summary>
		public static string GetCurrentCultureShortName
		{
			get
			{
				string _cultureName		= GetCurrentCultureName;

				if (!_cultureName.StartsWith("zh"))
				{
					_cultureName	= _cultureName.Substring(0, 2);
				}

				return _cultureName;
			}
		}

		#endregion

		#region GetCurrentCultureName : 현재의 OS/브라우저 언어 설정 정보
		/// <summary>
		/// 현재의 OS/브라우저 언어 설정 정보
		/// </summary>
		public static string GetCurrentCultureName
		{
			get
			{
				string cultureName = string.Empty;

				try
				{
					// WEB
					if (IsHosted)
					{
						// 브라우저의 언어정보
						string[] languages = System.Web.HttpContext.Current.Request.UserLanguages;

						// web.config
						GlobalizationSection gl = (GlobalizationSection)WebConfigurationManager.GetSection("system.web/globalization");

						// 쿠키에 저장된 언어코드가 있다면, 해당 언어를 로드한다.
						if (System.Web.HttpContext.Current.Request.Cookies["CurrentLanguageCode"] != null)
						{
							cultureName	= System.Web.HttpContext.Current.Request.Cookies["CurrentLanguageCode"].Value;
						}
						else
						{
							// web.config에 강제로 지정된 언어코드가 있다면, 해당 언어를 로드한다.
							if (gl.UICulture != "")
								cultureName = gl.UICulture;
							// 브라우저의 언어정보를 기준으로 로드한다.
							else
								cultureName = languages[0].ToLowerInvariant().Trim();
						}
					}
					// Windows
					else
					{
						// OS의 언어정보(언어팩 감안)
						//CultureInfo ci = CultureInfo.GetCultureInfo(NativeMethods.GetUserDefaultUILanguage());
						//cultureName = ci.Name;

						// [2015-03-18] 현재 사용자가 설정해 놓은 언어로 반환
						cultureName		= Thread.CurrentThread.CurrentUICulture.Name;
						//cultureName = "en-US";
					}
				}
				catch
				{
					cultureName = "en-US";
				}

				return cultureName;
			}
		}

		#endregion

		#region GetString : 언어별 텍스트 값 반환
		/// <summary>
		/// 언어별 텍스트 값 반환
		/// </summary>
		/// <param name="LanguageText">텍스트키</param>
		/// <returns>언어별 텍스트</returns>
		public static string GetString(string LanguageText)
		{
			string _retValue						= string.Empty;

			try
			{
				_retValue	= LanguageManager.GetString(LanguageText, "");
				if (string.IsNullOrEmpty(_retValue))
				{
					_retValue	= LanguageText;
				}
			}
			catch
			{
				throw;
			}

			return _retValue;
		}

		/// <summary>
		/// 언어별 텍스트 값 반환
		/// </summary>
		/// <param name="LanguageText">텍스트키</param>
		/// <param name="LanguageCode">언어코드</param>
		/// <returns>언어별 텍스트</returns>
		public static string GetString(string LanguageText, string LanguageCode)
		{
			string _retValue						= string.Empty;

			try
			{
				//string _languageText				= LanguageText.ToMultilingualKey();

				if (string.IsNullOrEmpty(LanguageCode))
				{
					LanguageCode	= GetCurrentCultureName;
				}
				
				CultureInfo cultureInfo					= CultureInfo.CreateSpecificCulture(LanguageCode);
				CultureInfo _browserCulture				= cultureInfo;
				Thread.CurrentThread.CurrentCulture		= _browserCulture;
				Thread.CurrentThread.CurrentUICulture	= _browserCulture;

				_retValue								= Resource.LanguageManager.GetString(LanguageText, cultureInfo);
				if (string.IsNullOrEmpty(_retValue))
				{
					_retValue		= LanguageText;
				}
			}
			catch
			{
				throw;
			}

			return _retValue;
		}

		/// <summary>
		/// 실제 다국어 정보를 가져오는 함수
		/// </summary>
		/// <param name="LanguageText"></param>
		/// <param name="CultureInfo"></param>
		/// <returns></returns>
		static string GetString(string LanguageText, CultureInfo CultureInfo)
		{
			return Languages.Language.ResourceManager.GetString(LanguageText, CultureInfo);
		}
		#endregion

		#region GetResourceJsonKeyValue : 언어별 리소스 데이터를 반환
		/// <summary>
		/// 언어별 리소스 데이터를 반환
		/// </summary>
		/// <param name="ResourceManager">리소스매니저</param>
		/// <returns>Json형의 key & value로 리소스 내용을 반환</returns>
		public static string GetResourceJsonKeyValue(System.Resources.ResourceManager ResourceManager)
		{
			string _retValue = string.Empty;

			int i = 0;
			_retValue = "{";
			CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(GetCurrentCultureName);
			System.Resources.ResourceSet resourceSet = ResourceManager.GetResourceSet(cultureInfo, true, true);
			foreach (System.Collections.DictionaryEntry entry in resourceSet)
			{
				if (i == 0)
					_retValue += entry.Key.ToString() + ": \"" + entry.Value.ToString() + "\"";
				else
					_retValue += ", " + entry.Key.ToString() + ": \"" + entry.Value.ToString() + "\"";
				i++;
			}
			_retValue += "};";

			return _retValue;
		}
		#endregion
	}
}
