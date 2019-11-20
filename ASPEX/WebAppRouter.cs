using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace ASPEX {
	public partial class WebApp {
		public void MapDelete<T1>(string template, Func<T1?, Task> handler) where T1 : class {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg: GetRequiredArgument<T1>(httpContext, parameters[0].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2>(string template, Func<T1?, T2?, Task> handler) where T1 : class where T2 : class {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3>(string template, Func<T1?, T2?, T3?, Task> handler) where T1 : class where T2 : class where T3 : class {
			RouteSetupActions.Add(builder => builder.MapDelete(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4>(string template, Func<T1?, T2?, T3?, T4?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5>(string template, Func<T1?, T2?, T3?, T4?, T5?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, T16?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class where T16 : class {
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

		public void MapGet<T1>(string template, Func<T1?, Task> handler) where T1 : class {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg: GetRequiredArgument<T1>(httpContext, parameters[0].Name!)
				);
			}));
		}

		public void MapGet<T1, T2>(string template, Func<T1?, T2?, Task> handler) where T1 : class where T2 : class {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3>(string template, Func<T1?, T2?, T3?, Task> handler) where T1 : class where T2 : class where T3 : class {
			RouteSetupActions.Add(builder => builder.MapGet(template, httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4>(string template, Func<T1?, T2?, T3?, T4?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class {
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

		public void MapGet<T1, T2, T3, T4, T5>(string template, Func<T1?, T2?, T3?, T4?, T5?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, T16?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class where T16 : class {
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

		public void MapPost<T1>(string template, Func<T1?, Task> handler) where T1 : class {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2>(string template, Func<T1?, T2?, Task> handler) where T1 : class where T2 : class {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3>(string template, Func<T1?, T2?, T3?, Task> handler) where T1 : class where T2 : class where T3 : class {
			RouteSetupActions.Add(builder => builder.MapPost(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4>(string template, Func<T1?, T2?, T3?, T4?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class {
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

		public void MapPost<T1, T2, T3, T4, T5>(string template, Func<T1?, T2?, T3?, T4?, T5?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, T16?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class where T16 : class {
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

		public void MapPut<T1>(string template, Func<T1?, Task> handler) where T1 : class {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2>(string template, Func<T1?, T2?, Task> handler) where T1 : class where T2 : class {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3>(string template, Func<T1?, T2?, T3?, Task> handler) where T1 : class where T2 : class where T3 : class {
			RouteSetupActions.Add(builder => builder.MapPut(template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4>(string template, Func<T1?, T2?, T3?, T4?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class {
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

		public void MapPut<T1, T2, T3, T4, T5>(string template, Func<T1?, T2?, T3?, T4?, T5?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, T16?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class where T16 : class {
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

		public void MapVerb<T1>(string verb, string template, Func<T1?, Task> handler) where T1 : class {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2>(string verb, string template, Func<T1?, T2?, Task> handler) where T1 : class where T2 : class {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3>(string verb, string template, Func<T1?, T2?, T3?, Task> handler) where T1 : class where T2 : class where T3 : class {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4>(string verb, string template, Func<T1?, T2?, T3?, T4?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, T16?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class where T16 : class {
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

		private T? GetRequiredArgument<T>(HttpContext httpContext, string parameterName) where T : class {
			if (typeof(T) == typeof(HttpContext)) {
				return httpContext as T;
			} else if (typeof(T) == typeof(HttpRequest)) {
				return httpContext.Request as T;
			} else if (typeof(T) == typeof(HttpResponse)) {
				return httpContext.Response as T;
			} else if (typeof(T) == typeof(RouteData)) {
				return httpContext.GetRouteData() as T;
			} else if (typeof(T) == typeof(string)) {
				if (httpContext.GetRouteData().Values.TryGetValue(parameterName, out object value)) {
					return value.ToString() as T;
				} else {
					return null;
				}
			} else if (typeof(T) == typeof(Int)) {
				if (httpContext.GetRouteData().Values.TryGetValue(parameterName, out object value)) {
					if (value is string s && int.TryParse(s, out int v)) {
						return new Int(v) as T;
					} else if (value is int i) {
						return new Int(i) as T;
					} else {
						return null;
					}
				} else {
					return null;
				}
			} else {
				return httpContext.RequestServices.GetRequiredService<T>();
			}
		}

		private async Task<T?> GetBodyOrFormOrRequiredArgumentAsync<T>(HttpContext httpContext, string parameterName) where T : class {
			if (parameterName == "body") {
				using StreamReader streamReader = new StreamReader(httpContext.Request.Body);
				string json = await streamReader.ReadToEndAsync().ConfigureAwait(false);
				return JsonConvert.DeserializeObject<T>(json);
			} else if (typeof(T) == typeof(IFormCollection)) {
				return await httpContext.Request.ReadFormAsync(httpContext.RequestAborted).ConfigureAwait(false) as T;
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

		public void MapDelete<T1>(string template, Func<T1?, Task> handler) where T1 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg: GetRequiredArgument<T1>(httpContext, parameters[0].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2>(string template, Func<T1?, T2?, Task> handler) where T1 : class where T2 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3>(string template, Func<T1?, T2?, T3?, Task> handler) where T1 : class where T2 : class where T3 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapDelete(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!)
				);
			}));
		}

		public void MapDelete<T1, T2, T3, T4>(string template, Func<T1?, T2?, T3?, T4?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5>(string template, Func<T1?, T2?, T3?, T4?, T5?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class {
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

		public void MapDelete<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, T16?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class where T16 : class {
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

		public void MapGet<T1>(string template, Func<T1?, Task> handler) where T1 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg: GetRequiredArgument<T1>(httpContext, parameters[0].Name!)
				);
			}));
		}

		public void MapGet<T1, T2>(string template, Func<T1?, T2?, Task> handler) where T1 : class where T2 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3>(string template, Func<T1?, T2?, T3?, Task> handler) where T1 : class where T2 : class where T3 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapGet(Path.Combine(_basePath, template).Replace('\\', '/'), httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				return handler.Invoke(
					arg1: GetRequiredArgument<T1>(httpContext, parameters[0].Name!),
					arg2: GetRequiredArgument<T2>(httpContext, parameters[1].Name!),
					arg3: GetRequiredArgument<T3>(httpContext, parameters[2].Name!)
				);
			}));
		}

		public void MapGet<T1, T2, T3, T4>(string template, Func<T1?, T2?, T3?, T4?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class {
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

		public void MapGet<T1, T2, T3, T4, T5>(string template, Func<T1?, T2?, T3?, T4?, T5?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class {
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

		public void MapGet<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, T16?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class where T16 : class {
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

		public void MapPost<T1>(string template, Func<T1?, Task> handler) where T1 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2>(string template, Func<T1?, T2?, Task> handler) where T1 : class where T2 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3>(string template, Func<T1?, T2?, T3?, Task> handler) where T1 : class where T2 : class where T3 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapPost(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPost<T1, T2, T3, T4>(string template, Func<T1?, T2?, T3?, T4?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class {
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

		public void MapPost<T1, T2, T3, T4, T5>(string template, Func<T1?, T2?, T3?, T4?, T5?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class {
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

		public void MapPost<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, T16?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class where T16 : class {
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

		public void MapPut<T1>(string template, Func<T1?, Task> handler) where T1 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2>(string template, Func<T1?, T2?, Task> handler) where T1 : class where T2 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3>(string template, Func<T1?, T2?, T3?, Task> handler) where T1 : class where T2 : class where T3 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapPut(Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapPut<T1, T2, T3, T4>(string template, Func<T1?, T2?, T3?, T4?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class {
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

		public void MapPut<T1, T2, T3, T4, T5>(string template, Func<T1?, T2?, T3?, T4?, T5?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class {
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

		public void MapPut<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, T16?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class where T16 : class {
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

		public void MapVerb<T1>(string verb, string template, Func<T1?, Task> handler) where T1 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2>(string verb, string template, Func<T1?, T2?, Task> handler) where T1 : class where T2 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3>(string verb, string template, Func<T1?, T2?, T3?, Task> handler) where T1 : class where T2 : class where T3 : class {
			_webApp.RouteSetupActions.Add(builder => builder.MapVerb(verb, Path.Combine(_basePath, template).Replace('\\', '/'), async httpContext => {
				ParameterInfo[] parameters = handler.Method.GetParameters();
				await handler.Invoke(
					arg1: await GetBodyOrFormOrRequiredArgumentAsync<T1>(httpContext, parameters[0].Name!).ConfigureAwait(false),
					arg2: await GetBodyOrFormOrRequiredArgumentAsync<T2>(httpContext, parameters[1].Name!).ConfigureAwait(false),
					arg3: await GetBodyOrFormOrRequiredArgumentAsync<T3>(httpContext, parameters[2].Name!).ConfigureAwait(false)
				).ConfigureAwait(false);
			}));
		}

		public void MapVerb<T1, T2, T3, T4>(string verb, string template, Func<T1?, T2?, T3?, T4?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class {
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

		public void MapVerb<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string verb, string template, Func<T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, T9?, T10?, T11?, T12?, T13?, T14?, T15?, T16?, Task> handler) where T1 : class where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class where T11 : class where T12 : class where T13 : class where T14 : class where T15 : class where T16 : class {
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

		private T? GetRequiredArgument<T>(HttpContext httpContext, string parameterName) where T : class {
			if (typeof(T) == typeof(HttpContext)) {
				return httpContext as T;
			} else if (typeof(T) == typeof(HttpRequest)) {
				return httpContext.Request as T;
			} else if (typeof(T) == typeof(HttpResponse)) {
				return httpContext.Response as T;
			} else if (typeof(T) == typeof(RouteData)) {
				return httpContext.GetRouteData() as T;
			} else if (typeof(T) == typeof(string)) {
				if (httpContext.GetRouteData().Values.TryGetValue(parameterName, out object value)) {
					return value.ToString() as T;
				} else {
					return null;
				}
			} else if (typeof(T) == typeof(Int)) {
				if (httpContext.GetRouteData().Values.TryGetValue(parameterName, out object value)) {
					if (value is string s && int.TryParse(s, out int v)) {
						return new Int(v) as T;
					} else if (value is int i) {
						return new Int(i) as T;
					} else {
						return null;
					}
				} else {
					return null;
				}
			} else {
				return httpContext.RequestServices.GetRequiredService<T>();
			}
		}

		private async Task<T?> GetBodyOrFormOrRequiredArgumentAsync<T>(HttpContext httpContext, string parameterName) where T : class {
			if (parameterName == "body") {
				using StreamReader streamReader = new StreamReader(httpContext.Request.Body);
				string json = await streamReader.ReadToEndAsync().ConfigureAwait(false);
				return JsonConvert.DeserializeObject<T>(json);
			} else if (typeof(T) == typeof(IFormCollection)) {
				return await httpContext.Request.ReadFormAsync(httpContext.RequestAborted).ConfigureAwait(false) as T;
			} else {
				return GetRequiredArgument<T>(httpContext, parameterName);
			}
		}
	}
}