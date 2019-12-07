using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace ASPEX {
	public partial class WebApp {
		public void MapDelete<T1>(string template, Func<T1, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg: GetRequiredArgument<T1>(httpContext, parameters[0].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2>(string template, Func<T1, T2, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3>(string template, Func<T1, T2, T3, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4>(string template, Func<T1, T2, T3, T4, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5>(string template, Func<T1, T2, T3, T4, T5, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6>(string template, Func<T1, T2, T3, T4, T5, T6, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!),
					arg15: GetRequiredArgument<T15>(httpContext, parameters[14].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!),
					arg15: GetRequiredArgument<T15>(httpContext, parameters[14].Name!),
					arg16: GetRequiredArgument<T16>(httpContext, parameters[15].Name!)
				);
			}));
		}

		public void MapGet<T1>(string template, Func<T1, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg: GetRequiredArgument<T1>(httpContext, parameters[0].Name!)
				);
			}));
		}

		public void MapGet<T1, T2>(string template, Func<T1, T2, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3>(string template, Func<T1, T2, T3, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4>(string template, Func<T1, T2, T3, T4, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5>(string template, Func<T1, T2, T3, T4, T5, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6>(string template, Func<T1, T2, T3, T4, T5, T6, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!),
					arg15: GetRequiredArgument<T15>(httpContext, parameters[14].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!),
					arg15: GetRequiredArgument<T15>(httpContext, parameters[14].Name!),
					arg16: GetRequiredArgument<T16>(httpContext, parameters[15].Name!)
				);
			}));
		}

		public void MapPost<T1>(string template, Func<T1, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2>(string template, Func<T1, T2, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3>(string template, Func<T1, T2, T3, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4>(string template, Func<T1, T2, T3, T4, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5>(string template, Func<T1, T2, T3, T4, T5, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6>(string template, Func<T1, T2, T3, T4, T5, T6, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false),
					arg16: await GetBodyOrFormOrRequiredArgumentAsync<T16>(httpContext, parameters[15].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1>(string template, Func<T1, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2>(string template, Func<T1, T2, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3>(string template, Func<T1, T2, T3, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4>(string template, Func<T1, T2, T3, T4, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5>(string template, Func<T1, T2, T3, T4, T5, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6>(string template, Func<T1, T2, T3, T4, T5, T6, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false),
					arg16: await GetBodyOrFormOrRequiredArgumentAsync<T16>(httpContext, parameters[15].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1>(string verb, string template, Func<T1, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2>(string verb, string template, Func<T1, T2, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3>(string verb, string template, Func<T1, T2, T3, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4>(string verb, string template, Func<T1, T2, T3, T4, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5>(string verb, string template, Func<T1, T2, T3, T4, T5, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false),
					arg16: await GetBodyOrFormOrRequiredArgumentAsync<T16>(httpContext, parameters[15].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void Map(Action<WebAppRouter> setupAction) {
			setupAction.Invoke(new WebAppRouter(this, ""));
		}

		[SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "This is a general purpose library.")]
		private T GetRequiredArgument<T>(HttpContext httpContext, string parameterName) {
			if (typeof(T) == typeof(HttpContext)) {
				return (T)Convert.ChangeType(httpContext, httpContext.GetType());
			} else if (typeof(T) == typeof(HttpRequest)) {
				HttpRequest request = httpContext.Request;
				return (T)Convert.ChangeType(request, request.GetType());
			} else if (typeof(T) == typeof(HttpResponse)) {
				HttpResponse response = httpContext.Response;
				return (T)Convert.ChangeType(response, response.GetType());
			} else if (typeof(T) == typeof(RouteData)) {
				RouteData routeData = httpContext.GetRouteData();
				return (T)Convert.ChangeType(routeData, routeData.GetType());
			} else if (typeof(T) == typeof(CancellationToken)) {
				return (T)Convert.ChangeType(httpContext.RequestAborted, typeof(CancellationToken));
			} else if (typeof(T) == typeof(string)) {
				if (httpContext.GetRouteData().Values.TryGetValue(parameterName, out object value)) {
					return (T)Convert.ChangeType(value.ToString(), typeof(string))!;
				} else {
					return default!;
				}
			} else if (typeof(T) == typeof(int) || typeof(T) == typeof(int?)) {
				if (httpContext.GetRouteData().Values.TryGetValue(parameterName, out object value)) {
					if (value is string s && int.TryParse(s, out int v)) {
						return (T)Convert.ChangeType(v, typeof(T));
					} else if (value is int i) {
						return (T)Convert.ChangeType(i, typeof(T));
					} else {
						return default!;
					}
				} else {
					return default!;
				}
			} else {
				return httpContext.RequestServices.GetRequiredService<T>();
			}
		}

		[SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "This is a general purpose library.")]
		private async Task<T> GetBodyOrFormOrRequiredArgumentAsync<T>(HttpContext httpContext, string parameterName) {
			if (parameterName == "body") {
				using StreamReader streamReader = new StreamReader(httpContext.Request.Body);
				string json = await streamReader.ReadToEndAsync().ConfigureAwait(false);
				return JsonConvert.DeserializeObject<T>(json);
			} else if (typeof(T) == typeof(IFormCollection)) {
				IFormCollection form = await httpContext.Request.ReadFormAsync(httpContext.RequestAborted).ConfigureAwait(false);
				return (T)Convert.ChangeType(form, form.GetType());
			} else {
				return GetRequiredArgument<T>(httpContext, parameterName);
			}
		}
	}

	public class WebAppRouter {
		private readonly WebApp _webApp;
		private readonly string _basePath;

		public WebAppRouter(WebApp webApp, string basePath) {
			_webApp = webApp;
			_basePath = basePath;
		}

		public void MapDelete<T1>(string template, Func<T1, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg: GetRequiredArgument<T1>(httpContext, parameters[0].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2>(string template, Func<T1, T2, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3>(string template, Func<T1, T2, T3, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4>(string template, Func<T1, T2, T3, T4, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5>(string template, Func<T1, T2, T3, T4, T5, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6>(string template, Func<T1, T2, T3, T4, T5, T6, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!),
					arg15: GetRequiredArgument<T15>(httpContext, parameters[14].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!),
					arg15: GetRequiredArgument<T15>(httpContext, parameters[14].Name!),
					arg16: GetRequiredArgument<T16>(httpContext, parameters[15].Name!)
				);
			}));
		}

		public void MapGet<T1>(string template, Func<T1, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg: GetRequiredArgument<T1>(httpContext, parameters[0].Name!)
				);
			}));
		}

		public void MapGet<T1, T2>(string template, Func<T1, T2, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3>(string template, Func<T1, T2, T3, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4>(string template, Func<T1, T2, T3, T4, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5>(string template, Func<T1, T2, T3, T4, T5, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6>(string template, Func<T1, T2, T3, T4, T5, T6, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!),
					arg15: GetRequiredArgument<T15>(httpContext, parameters[14].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!),
					arg4: GetRequiredArgument<T4>(httpContext, parameters[3].Name!),
					arg5: GetRequiredArgument<T5>(httpContext, parameters[4].Name!),
					arg6: GetRequiredArgument<T6>(httpContext, parameters[5].Name!),
					arg7: GetRequiredArgument<T7>(httpContext, parameters[6].Name!),
					arg8: GetRequiredArgument<T8>(httpContext, parameters[7].Name!),
					arg9: GetRequiredArgument<T9>(httpContext, parameters[8].Name!),
					arg10: GetRequiredArgument<T10>(httpContext, parameters[9].Name!),
					arg11: GetRequiredArgument<T11>(httpContext, parameters[10].Name!),
					arg12: GetRequiredArgument<T12>(httpContext, parameters[11].Name!),
					arg13: GetRequiredArgument<T13>(httpContext, parameters[12].Name!),
					arg14: GetRequiredArgument<T14>(httpContext, parameters[13].Name!),
					arg15: GetRequiredArgument<T15>(httpContext, parameters[14].Name!),
					arg16: GetRequiredArgument<T16>(httpContext, parameters[15].Name!)
				);
			}));
		}

		public void MapPost<T1>(string template, Func<T1, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2>(string template, Func<T1, T2, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3>(string template, Func<T1, T2, T3, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4>(string template, Func<T1, T2, T3, T4, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5>(string template, Func<T1, T2, T3, T4, T5, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6>(string template, Func<T1, T2, T3, T4, T5, T6, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false),
					arg16: await GetBodyOrFormOrRequiredArgumentAsync<T16>(httpContext, parameters[15].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1>(string template, Func<T1, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2>(string template, Func<T1, T2, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3>(string template, Func<T1, T2, T3, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4>(string template, Func<T1, T2, T3, T4, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5>(string template, Func<T1, T2, T3, T4, T5, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6>(string template, Func<T1, T2, T3, T4, T5, T6, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false),
					arg16: await GetBodyOrFormOrRequiredArgumentAsync<T16>(httpContext, parameters[15].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1>(string verb, string template, Func<T1, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2>(string verb, string template, Func<T1, T2, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3>(string verb, string template, Func<T1, T2, T3, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4>(string verb, string template, Func<T1, T2, T3, T4, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5>(string verb, string template, Func<T1, T2, T3, T4, T5, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string verb, string template, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> handler) {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false),
					arg4: await GetBodyOrFormOrRequiredArgumentAsync<T4>(httpContext, parameters[3].Name!).ConfigureAwait(false),
					arg5: await GetBodyOrFormOrRequiredArgumentAsync<T5>(httpContext, parameters[4].Name!).ConfigureAwait(false),
					arg6: await GetBodyOrFormOrRequiredArgumentAsync<T6>(httpContext, parameters[5].Name!).ConfigureAwait(false),
					arg7: await GetBodyOrFormOrRequiredArgumentAsync<T7>(httpContext, parameters[6].Name!).ConfigureAwait(false),
					arg8: await GetBodyOrFormOrRequiredArgumentAsync<T8>(httpContext, parameters[7].Name!).ConfigureAwait(false),
					arg9: await GetBodyOrFormOrRequiredArgumentAsync<T9>(httpContext, parameters[8].Name!).ConfigureAwait(false),
					arg10: await GetBodyOrFormOrRequiredArgumentAsync<T10>(httpContext, parameters[9].Name!).ConfigureAwait(false),
					arg11: await GetBodyOrFormOrRequiredArgumentAsync<T11>(httpContext, parameters[10].Name!).ConfigureAwait(false),
					arg12: await GetBodyOrFormOrRequiredArgumentAsync<T12>(httpContext, parameters[11].Name!).ConfigureAwait(false),
					arg13: await GetBodyOrFormOrRequiredArgumentAsync<T13>(httpContext, parameters[12].Name!).ConfigureAwait(false),
					arg14: await GetBodyOrFormOrRequiredArgumentAsync<T14>(httpContext, parameters[13].Name!).ConfigureAwait(false),
					arg15: await GetBodyOrFormOrRequiredArgumentAsync<T15>(httpContext, parameters[14].Name!).ConfigureAwait(false),
					arg16: await GetBodyOrFormOrRequiredArgumentAsync<T16>(httpContext, parameters[15].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void Map(Action<WebAppRouter> setupAction) {
			setupAction.Invoke(this);
		}

		[SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "This is a general purpose library.")]
		private T GetRequiredArgument<T>(HttpContext httpContext, string parameterName) {
			if (typeof(T) == typeof(HttpContext)) {
				return (T)Convert.ChangeType(httpContext, httpContext.GetType());
			} else if (typeof(T) == typeof(HttpRequest)) {
				HttpRequest request = httpContext.Request;
				return (T)Convert.ChangeType(request, request.GetType());
			} else if (typeof(T) == typeof(HttpResponse)) {
				HttpResponse response = httpContext.Response;
				return (T)Convert.ChangeType(response, response.GetType());
			} else if (typeof(T) == typeof(RouteData)) {
				RouteData routeData = httpContext.GetRouteData();
				return (T)Convert.ChangeType(routeData, routeData.GetType());
			} else if (typeof(T) == typeof(CancellationToken)) {
				return (T)Convert.ChangeType(httpContext.RequestAborted, typeof(CancellationToken));
			} else if (typeof(T) == typeof(string)) {
				if (httpContext.GetRouteData().Values.TryGetValue(parameterName, out object value)) {
					return (T)Convert.ChangeType(value.ToString(), typeof(string))!;
				} else {
					return default!;
				}
			} else if (typeof(T) == typeof(int) || typeof(T) == typeof(int?)) {
				if (httpContext.GetRouteData().Values.TryGetValue(parameterName, out object value)) {
					if (value is string s && int.TryParse(s, out int v)) {
						return (T)Convert.ChangeType(v, typeof(T));
					} else if (value is int i) {
						return (T)Convert.ChangeType(i, typeof(T));
					} else {
						return default!;
					}
				} else {
					return default!;
				}
			} else {
				return httpContext.RequestServices.GetRequiredService<T>();
			}
		}

		[SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "This is a general purpose library.")]
		private async Task<T> GetBodyOrFormOrRequiredArgumentAsync<T>(HttpContext httpContext, string parameterName) {
			if (parameterName == "body") {
				using StreamReader streamReader = new StreamReader(httpContext.Request.Body);
				string json = await streamReader.ReadToEndAsync().ConfigureAwait(false);
				return JsonConvert.DeserializeObject<T>(json);
			} else if (typeof(T) == typeof(IFormCollection)) {
				IFormCollection form = await httpContext.Request.ReadFormAsync(httpContext.RequestAborted).ConfigureAwait(false);
				return (T)Convert.ChangeType(form, form.GetType());
			} else {
				return GetRequiredArgument<T>(httpContext, parameterName);
			}
		}
	}
}