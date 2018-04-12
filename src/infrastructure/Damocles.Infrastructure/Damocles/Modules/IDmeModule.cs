// #region File Annotation
// 
// Author：Zhiqiang Li
// 
// FileName：IDmeModule.cs
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

namespace Damocles.Modules
{
	/// <summary>
	/// 定义模块生命周期钩子
	/// </summary>
	public interface IDmeModule
	{
		/// <summary>
		/// 预初始化
		/// </summary>
		void PreInitialize();

		/// <summary>
		/// 初始化
		/// </summary>
		void Initialize();

		/// <summary>
		/// 初始化完成
		/// </summary>
		void PostInitialize();

		/// <summary>
		/// 应用关闭时调用
		/// </summary>
		void Shutdown();
	}
}