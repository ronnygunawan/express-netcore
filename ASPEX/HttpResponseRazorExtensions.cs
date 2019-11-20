using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace ASPEX {
	public static class HttpResponseRazorExtensions {
		public static async Task RenderRazorViewAsync(this HttpResponse response, string viewName, object model, CancellationToken cancellationToken = default) {
			IRazorViewEngine razorViewEngine = response.HttpContext.RequestServices.GetRequiredService<IRazorViewEngine>();
			ITempDataProvider tempDataProvider = response.HttpContext.RequestServices.GetRequiredService<ITempDataProvider>();

			ActionContext actionContext = new ActionContext(response.HttpContext, new RouteData(), new ActionDescriptor());
			ViewEngineResult viewEngineResult = razorViewEngine.FindView(actionContext, viewName, true);
			viewEngineResult.EnsureSuccessful(Array.Empty<string>());
			IView view = viewEngineResult.View;
			ViewDataDictionary viewDictionary = new ViewDataDictionary(new EmptyModelMetadataProvider(), actionContext.ModelState) {
				Model = model
			};
			TempDataDictionary tempData = new TempDataDictionary(actionContext.HttpContext, tempDataProvider);
			using TextWriter textWriter = new StringWriter();
			ViewContext viewContext = new ViewContext(actionContext, view, viewDictionary, tempData, textWriter, new HtmlHelperOptions());
			await view.RenderAsync(viewContext).ConfigureAwait(false);
			await response.WriteAsync(textWriter.ToString(), cancellationToken).ConfigureAwait(false);
		}
	}
}
