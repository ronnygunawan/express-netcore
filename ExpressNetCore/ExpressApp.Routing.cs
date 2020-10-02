using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using ExpressNetCore.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace ExpressNetCore {
	public partial class ExpressApp {
		public ExpressApp MapRouter<TRouter>(string basePath) where TRouter : class {
			_serviceCollection.AddScoped<TRouter>();

			// TODO: Replace reflection codes with IL
			foreach (MethodInfo methodInfo in typeof(TRouter).GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly)) {
				// Delete
				foreach (MapDeleteAttribute mapDeleteAttribute in methodInfo.GetCustomAttributes<MapDeleteAttribute>()) {
					RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(basePath, mapDeleteAttribute.Template).Replace('\\', '/'), async httpContext => {
						TRouter router = httpContext.RequestServices.GetRequiredService<TRouter>();
						ParameterInfo[] parameterInfos = methodInfo.GetParameters();
						object?[] arguments = parameterInfos
							.Select(parameterInfo => GetRequiredArgument(httpContext, parameterInfo))
							.ToArray();
						object? returnValue = methodInfo.Invoke(router, arguments);
						if (methodInfo.ReturnType != typeof(void)) {
							if (returnValue is Task task) {
								await task.ConfigureAwait(false);
								if (methodInfo.ReturnType.IsGenericType) {
									object? taskResult = methodInfo.ReturnType.GetProperty("Result")!.GetValue(task);
									await httpContext.Response.WriteAsJsonAsync(taskResult, arguments.OfType<CancellationToken>().FirstOrDefault()).ConfigureAwait(false);
								}
							} else {
								await httpContext.Response.WriteAsJsonAsync(returnValue, arguments.OfType<CancellationToken>().FirstOrDefault()).ConfigureAwait(false);
							}
						}
					}));
				}

				// Get
				foreach (MapGetAttribute mapGetAttribute in methodInfo.GetCustomAttributes<MapGetAttribute>()) {
					RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(basePath, mapGetAttribute.Template).Replace('\\', '/'), async httpContext => {
						TRouter router = httpContext.RequestServices.GetRequiredService<TRouter>();
						ParameterInfo[] parameterInfos = methodInfo.GetParameters();
						object?[] arguments = parameterInfos
							.Select(parameterInfo => GetRequiredArgument(httpContext, parameterInfo))
							.ToArray();
						object? returnValue = methodInfo.Invoke(router, arguments);
						if (methodInfo.ReturnType != typeof(void)) {
							if (returnValue is Task task) {
								await task.ConfigureAwait(false);
								if (methodInfo.ReturnType.IsGenericType) {
									object? taskResult = methodInfo.ReturnType.GetProperty("Result")!.GetValue(task);
									await httpContext.Response.WriteAsJsonAsync(taskResult, arguments.OfType<CancellationToken>().FirstOrDefault()).ConfigureAwait(false);
								}
							} else {
								await httpContext.Response.WriteAsJsonAsync(returnValue, arguments.OfType<CancellationToken>().FirstOrDefault()).ConfigureAwait(false);
							}
						}
					}));
				}

				// Post
				foreach (MapPostAttribute mapPostAttribute in methodInfo.GetCustomAttributes<MapPostAttribute>()) {
					RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(basePath, mapPostAttribute.Template).Replace('\\', '/'), async httpContext => {
						TRouter router = httpContext.RequestServices.GetRequiredService<TRouter>();
						ParameterInfo[] parameterInfos = methodInfo.GetParameters();
						object?[] arguments = await Task.WhenAll(parameterInfos
							.Select(parameterInfo => GetBodyOrFormOrRequiredArgumentAsync(httpContext, parameterInfo))
						).ConfigureAwait(false);
						object? returnValue = methodInfo.Invoke(router, arguments);
						if (methodInfo.ReturnType != typeof(void)) {
							if (returnValue is Task task) {
								await task.ConfigureAwait(false);
								if (methodInfo.ReturnType.IsGenericType) {
									object? taskResult = methodInfo.ReturnType.GetProperty("Result")!.GetValue(task);
									await httpContext.Response.WriteAsJsonAsync(taskResult, arguments.OfType<CancellationToken>().FirstOrDefault()).ConfigureAwait(false);
								}
							} else {
								await httpContext.Response.WriteAsJsonAsync(returnValue, arguments.OfType<CancellationToken>().FirstOrDefault()).ConfigureAwait(false);
							}
						}
					}));
				}

				// Put
				foreach (MapPutAttribute mapPutAttribute in methodInfo.GetCustomAttributes<MapPutAttribute>()) {
					RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(basePath, mapPutAttribute.Template).Replace('\\', '/'), async httpContext => {
						TRouter router = httpContext.RequestServices.GetRequiredService<TRouter>();
						ParameterInfo[] parameterInfos = methodInfo.GetParameters();
						object?[] arguments = await Task.WhenAll(parameterInfos
							.Select(parameterInfo => GetBodyOrFormOrRequiredArgumentAsync(httpContext, parameterInfo))
						).ConfigureAwait(false);
						object? returnValue = methodInfo.Invoke(router, arguments);
						if (methodInfo.ReturnType != typeof(void)) {
							if (returnValue is Task task) {
								await task.ConfigureAwait(false);
								if (methodInfo.ReturnType.IsGenericType) {
									object? taskResult = methodInfo.ReturnType.GetProperty("Result")!.GetValue(task);
									await httpContext.Response.WriteAsJsonAsync(taskResult, arguments.OfType<CancellationToken>().FirstOrDefault()).ConfigureAwait(false);
								}
							} else {
								await httpContext.Response.WriteAsJsonAsync(returnValue, arguments.OfType<CancellationToken>().FirstOrDefault()).ConfigureAwait(false);
							}
						}
					}));
				}

				// Verb
				foreach (MapVerbAttribute mapVerbAttribute in methodInfo.GetCustomAttributes<MapVerbAttribute>()) {
					RouteSetupActions.Add(builder => builder.MapVerb(mapVerbAttribute.Verb, Path.Combine(basePath, mapVerbAttribute.Template).Replace('\\', '/'), async httpContext => {
						TRouter router = httpContext.RequestServices.GetRequiredService<TRouter>();
						ParameterInfo[] parameterInfos = methodInfo.GetParameters();
						object?[] arguments = await Task.WhenAll(parameterInfos
							.Select(parameterInfo => GetBodyOrFormOrRequiredArgumentAsync(httpContext, parameterInfo))
						).ConfigureAwait(false);
						object? returnValue = methodInfo.Invoke(router, arguments);
						if (methodInfo.ReturnType != typeof(void)) {
							if (returnValue is Task task) {
								await task.ConfigureAwait(false);
								if (methodInfo.ReturnType.IsGenericType) {
									object? taskResult = methodInfo.ReturnType.GetProperty("Result")!.GetValue(task);
									await httpContext.Response.WriteAsJsonAsync(taskResult, arguments.OfType<CancellationToken>().FirstOrDefault()).ConfigureAwait(false);
								}
							} else {
								await httpContext.Response.WriteAsJsonAsync(returnValue, arguments.OfType<CancellationToken>().FirstOrDefault()).ConfigureAwait(false);
							}
						}
					}));
				}
			}

			return this;
		}

		private static object? GetRequiredArgument(HttpContext httpContext, ParameterInfo parameterInfo) {
			if (parameterInfo.ParameterType == typeof(HttpContext)) {
				return httpContext;
			} else if (parameterInfo.ParameterType == typeof(HttpRequest)) {
				return httpContext.Request;
			} else if (parameterInfo.ParameterType == typeof(HttpResponse)) {
				return httpContext.Response;
			} else if (parameterInfo.ParameterType == typeof(RouteData)) {
				return httpContext.GetRouteData();
			} else if (parameterInfo.ParameterType == typeof(CancellationToken)) {
				return httpContext.RequestAborted;
			} else if (parameterInfo.ParameterType == typeof(string)) {
				if (httpContext.GetRouteData().Values.TryGetValue(parameterInfo.Name!, out object? value)) {
					return value?.ToString();
				} else {
					return null;
				}
			} else if (parameterInfo.ParameterType == typeof(int) || parameterInfo.ParameterType == typeof(int?)) {
				if (httpContext.GetRouteData().Values.TryGetValue(parameterInfo.Name!, out object? value)) {
					if (value is string s && int.TryParse(s, out int v)) {
						return v;
					} else if (value is int i) {
						return i;
					} else {
						return null;
					}
				} else {
					return null;
				}
			} else {
				return httpContext.RequestServices.GetRequiredService(parameterInfo.ParameterType);
			}
		}

		private static async Task<object?> GetBodyOrFormOrRequiredArgumentAsync(HttpContext httpContext, ParameterInfo parameterInfo) {
			if (parameterInfo.Name == "body") {
				using StreamReader streamReader = new StreamReader(httpContext.Request.Body);
				string json = await streamReader.ReadToEndAsync().ConfigureAwait(false);
				return JsonConvert.DeserializeObject(json, parameterInfo.ParameterType);
			} else if (parameterInfo.ParameterType == typeof(IFormCollection)) {
				return await httpContext.Request.ReadFormAsync(httpContext.RequestAborted).ConfigureAwait(false);
			} else {
				return GetRequiredArgument(httpContext, parameterInfo);
			}
		}
	}
}
