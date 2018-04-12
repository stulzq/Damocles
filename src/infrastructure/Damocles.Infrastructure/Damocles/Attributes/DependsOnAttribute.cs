// #region File Annotation
// 
// Author：Zhiqiang Li
// 
// FileName：DependsOnAttribute.cs
// 
// Project：Damocles
// 
// CreateDate：2018年04月13日
// 
// ProjectUrl：https://github.com/stulzq/Damocles
// 
// .NET Core China Open Source organization  PMC member. https://github.com/dotnetcore
// 
// Note: The reference to this document code must not delete this note, and indicate the source!
// 
// #endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace Damocles.Attributes
{
	/// <summary>
	/// 模块依赖特性 
	/// <para />
	/// 指定改模块依赖的模块
	/// </summary>
	public class DependsOnAttribute:Attribute
	{
		/// <summary>
		/// 该模块依赖的模块集合
		/// </summary>
		public List<Type> Depends;

		public DependsOnAttribute(params Type[] types)
		{
			Depends = types.ToList();
		}
	}
}