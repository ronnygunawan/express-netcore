using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace ASPEX {
	public partial class WebApp {
		public void MapDelete(string template, RequestDelegate handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, handler));
		}

		public void MapDelete(string template, Func<HttpRequest, HttpResponse, RouteData, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapDelete(template, handler));
		}

		public void MapGet(string template, RequestDelegate handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, handler));
		}

		public void MapGet(string template, Func<HttpRequest, HttpResponse, RouteData, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapGet(template, handler));
		}

		public void MapMiddlewareDelete(string template, Action<IApplicationBuilder> action) {
			RouteSetupActions.Add(builder => builder.MapMiddlewareDelete(template, action));
		}

		public void MapMiddlewareGet(string template, Action<IApplicationBuilder> action) {
			RouteSetupActions.Add(builder => builder.MapMiddlewareGet(template, action));
		}

		public void MapMiddlewarePost(string template, Action<IApplicationBuilder> action) {
			RouteSetupActions.Add(builder => builder.MapMiddlewarePost(template, action));
		}

		public void MapMiddlewarePut(string template, Action<IApplicationBuilder> action) {
			RouteSetupActions.Add(builder => builder.MapMiddlewarePut(template, action));
		}

		public void MapMiddlewareRoute(string template, Action<IApplicationBuilder> action) {
			RouteSetupActions.Add(builder => builder.MapMiddlewareRoute(template, action));
		}

		public void MapMiddlewareVerb(string verb, string template, Action<IApplicationBuilder> action) {
			RouteSetupActions.Add(builder => builder.MapMiddlewareVerb(verb, template, action));
		}

		public void MapPost(string template, RequestDelegate handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, handler));
		}

		public void MapPost(string template, Func<HttpRequest, HttpResponse, RouteData, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPost(template, handler));
		}

		public void MapPut(string template, RequestDelegate handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, handler));
		}

		public void MapPut(string template, Func<HttpRequest, HttpResponse, RouteData, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapPut(template, handler));
		}

		public void MapRoute(string template, RequestDelegate handler) {
			RouteSetupActions.Add(builder => builder.MapRoute(template, handler));
		}

		public void MapVerb(string verb, string template, RequestDelegate handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, handler));
		}

		public void MapVerb(string verb, string template, Func<HttpRequest, HttpResponse, RouteData, Task> handler) {
			RouteSetupActions.Add(builder => builder.MapVerb(verb, template, handler));
		}
	}
}
