#pragma checksum "C:\PROYECTOS\RRHH\Templates\ControllerGenerator\ApiControllerWithActions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17dbc9396e4997da3caf544f6806fc5eed1a83ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ControllerGenerator_ApiControllerWithActions), @"mvc.1.0.view", @"/Templates/ControllerGenerator/ApiControllerWithActions.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17dbc9396e4997da3caf544f6806fc5eed1a83ad", @"/Templates/ControllerGenerator/ApiControllerWithActions.cshtml")]
    public class Templates_ControllerGenerator_ApiControllerWithActions : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\nusing Microsoft.AspNetCore.Http;\r\nusing Microsoft.AspNetCore.Mvc;\r\n\r\n");
#nullable restore
#line 9 "C:\PROYECTOS\RRHH\Templates\ControllerGenerator\ApiControllerWithActions.cshtml"
  string modelName = (Model.ClassName.EndsWith("Controller") ? Model.ClassName.Substring(0, Model.ClassName.Length - 10) : Model.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("namespace ");
#nullable restore
#line 10 "C:\PROYECTOS\RRHH\Templates\ControllerGenerator\ApiControllerWithActions.cshtml"
     Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    [Route(\"api/[controller]\")]\r\n    [ApiController]\r\n    public class ");
#nullable restore
#line 14 "C:\PROYECTOS\RRHH\Templates\ControllerGenerator\ApiControllerWithActions.cshtml"
            Write(Model.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ControllerBase\r\n    {\r\n        // GET: api/");
#nullable restore
#line 16 "C:\PROYECTOS\RRHH\Templates\ControllerGenerator\ApiControllerWithActions.cshtml"
               Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        [HttpGet]\r\n        public IEnumerable<string> Get()\r\n        {\r\n            return new string[] { \"value1\", \"value2\" };\r\n        }\r\n\r\n        // GET: api/");
#nullable restore
#line 23 "C:\PROYECTOS\RRHH\Templates\ControllerGenerator\ApiControllerWithActions.cshtml"
               Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("/5\r\n        [HttpGet(\"{id}\", Name = \"Get\")]\r\n        public string Get(int id)\r\n        {\r\n            return \"value\";\r\n        }\r\n\r\n        // POST: api/");
#nullable restore
#line 30 "C:\PROYECTOS\RRHH\Templates\ControllerGenerator\ApiControllerWithActions.cshtml"
                Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        [HttpPost]\r\n        public void Post([FromBody] string value)\r\n        {\r\n        }\r\n\r\n        // PUT: api/");
#nullable restore
#line 36 "C:\PROYECTOS\RRHH\Templates\ControllerGenerator\ApiControllerWithActions.cshtml"
               Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("/5\r\n        [HttpPut(\"{id}\")]\r\n        public void Put(int id, [FromBody] string value)\r\n        {\r\n        }\r\n\r\n        // DELETE: api/ApiWithActions/5\r\n        [HttpDelete(\"{id}\")]\r\n        public void Delete(int id)\r\n        {\r\n        }\r\n    }\r\n}\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
