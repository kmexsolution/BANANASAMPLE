using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DemoClient.Controls
{
	public class DataGridViewTextBoxColumn2 : System.Windows.Forms.DataGridViewColumn
	{
		#region DataGridViewTextBoxColumn : 생성자 함수
		/// <summary>
		/// 생성자 함수
		/// </summary>
		public DataGridViewTextBoxColumn2() : base(new DataGridViewTextBoxCell())
		{
			// DefaultValue를 Property에 적용시킨다.
			foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(this))
			{
				DefaultValueAttribute myAttribute = (DefaultValueAttribute)property.Attributes[typeof(DefaultValueAttribute)];
				if (myAttribute != null)
					property.SetValue(this, myAttribute.Value);
			}
		}
		#endregion

		#region FooterMath : 푸터에 사용할 수학함수
		/// <summary>
		/// 푸터에 사용할 수학함수
		/// </summary>
		[Category("BANANA Framework")]
		[DefaultValue(typeof(Controls.FooterMath), "Sum")]
		public FooterMath FooterMath { get; set; }
		#endregion

		#region Clone : 사용자 정의 속성값 유지
		/// <summary>
		/// 사용자 정의 속성값 유지
		/// </summary>
		/// <returns></returns>
		public override object Clone()
		{
			DataGridViewTextBoxColumn2 _copy	= (DataGridViewTextBoxColumn2)base.Clone();
			_copy.FooterMath					= FooterMath;
			
			return _copy;
		}
		#endregion
	}
}
