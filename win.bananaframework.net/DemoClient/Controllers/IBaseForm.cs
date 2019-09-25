using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClient.Controllers
{
	interface IBaseForm
	{
		/// <summary>
		/// 컨트롤 초기화
		/// </summary>
		void ClearControls();

		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		void EnableControls1(bool _bTrue);

		/// <summary>
		/// 컨트롤 활성화/비활성화 처리
		/// </summary>
		void EnableControls2(bool _bTrue);
	}
}
