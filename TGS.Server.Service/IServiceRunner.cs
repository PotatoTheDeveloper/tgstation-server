﻿using System.ServiceProcess;

namespace TGS.Server.Service
{
	/// <summary>
	/// <see langword="interface"/> for running a <see cref="ServiceBase"/>
	/// </summary>
	interface IServiceRunner
	{
		/// <summary>
		/// Runs a <see cref="ServiceBase"/>
		/// </summary>
		/// <param name="service">The <see cref="ServiceBase"/> to run</param>
		void Run(ServiceBase service);
	}
}
