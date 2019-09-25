using System;
using System.Collections.Generic;

namespace DemoClient.Controllers
{
	/// <summary>
	/// 우편번호를 검색하는 클래스
	/// </summary>
	public class ZipCode
	{
		#region GetZipCode : 주소를 이용하여 우편번호를 검색하여 반환
		/// <summary>
		/// 주소를 이용하여 우편번호를 검색하여 반환
		/// </summary>
		/// <param name="Address">주소</param>
		/// <returns>우편번호</returns>
		public static string GetZipCode(string Address)
		{
			string _retValue	= string.Empty;
			BANANA.Windows.ScreenScraping _sc	= new BANANA.Windows.ScreenScraping();

			try
			{
				string url		= "http://search.naver.com/search.naver?where=&sm=tab_drt&query={0}";
				url				= string.Format(url, System.Web.HttpUtility.UrlEncode(string.Format("우편번호 {0}", Address)));
				string html		= _sc.GetHtmlSource(url);
				string[] temp	= _sc.FindText(html, "<td class=\"tc\"><strong>", "</strong></td>");
				if (temp.Length == 0)
				{
					Exception err	= new Exception(string.Format("우편번호를 검색하지 못 하였습니다. 검색 주소: {0}", Address));
					BANANA.Windows.Logger.Error(err);
					return "";
				}
				_retValue		= temp[0];

				if ((_retValue.Length != 7) && (_retValue.Trim() != ""))
				{
					throw new ArgumentException("반환된 우편번호가 7자리가 아닙니다.");
				}
			}
			catch
			{
				throw;
			}

			return _retValue.Trim();
		}
		#endregion
	}
}
