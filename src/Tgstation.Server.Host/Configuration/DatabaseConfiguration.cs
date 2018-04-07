﻿namespace Tgstation.Server.Host.Configuration
{
	sealed class DatabaseConfiguration
	{
		public DatabaseType DatabaseType { get; set; }
		public string ConnectionString { get; set; }
	}
}
