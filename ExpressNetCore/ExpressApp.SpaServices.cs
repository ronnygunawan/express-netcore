using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace ExpressNetCore {
	public partial class ExpressApp {
		internal List<(string SourcePath, string DevServerNpmScript)> SpaSettings { get; } = new List<(string SourcePath, string DevServerNpmScript)>();

		public IServiceCollection AddSpa(string sourcePath, string buildPath, string devServerNpmScript = "start") {
			_serviceCollection.AddSpaStaticFiles(configuration => {
				configuration.RootPath = buildPath;
			});

			SpaSettings.Add((sourcePath, devServerNpmScript));

			return _serviceCollection;
		}
	}
}
