#pragma checksum "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f4c317a6a97ef9bae2c108f73fb186aec676c85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_RazorPageGenerator_Create), @"mvc.1.0.view", @"/Templates/RazorPageGenerator/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f4c317a6a97ef9bae2c108f73fb186aec676c85", @"/Templates/RazorPageGenerator/Create.cshtml")]
    public class Templates_RazorPageGenerator_Create : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@page\r\n");
            WriteLiteral("@model ");
#nullable restore
#line 6 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
   Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 6 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                        Write(Model.PageModelClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
  
    if (Model.IsPartialView)
    {
    }
    else if (Model.IsLayoutPageSelected)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("ViewData[\"Title\"] = \"");
#nullable restore
#line 15 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                      Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 16 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 18 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 19 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h1>");
#nullable restore
#line 22 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
 Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("Layout = null;\r\n");
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<html>\r\n");
            WriteLiteral("<head>\r\n    ");
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
            WriteLiteral("<title>");
#nullable restore
#line 36 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
        Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
        //    PushIndent("    ");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>");
#nullable restore
#line 42 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
 Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            WriteLiteral("<hr />\r\n");
            WriteLiteral("<div class=\"row\">\r\n    ");
            WriteLiteral("<div class=\"col-md-4\">\r\n        ");
            WriteLiteral("<form method=\"post\">\r\n            ");
            WriteLiteral("<div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n");
#nullable restore
#line 48 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
        foreach (var property in Model.ModelMetadata.Properties)
        {
            if (property.Scaffold && !property.IsAutoGenerated && !property.IsReadOnly)
            {
                if (property.IsForeignKey)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 55 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                              Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 55 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 56 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                               Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 56 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                     Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class =\"form-control\" asp-items=\"ViewBag.");
#nullable restore
#line 56 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                                                                                      Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></select>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 58 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                    continue;
                }

                bool isCheckbox = property.TypeName.Equals("System.Boolean");
                if (isCheckbox)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group form-check\">\r\n                ");
            WriteLiteral("<label class=\"form-check-label\">\r\n                    ");
            WriteLiteral("<input class=\"form-check-input\" asp-for=\"");
#nullable restore
#line 66 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                           Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 66 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                                                 Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" /> ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 66 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                                                                                                                  Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 66 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                                                                                                                                        Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                ");
            WriteLiteral("</label>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 69 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                }
                else if (property.IsEnum && !property.IsEnumFlags)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 73 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                              Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 73 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<select asp-for=\"");
#nullable restore
#line 74 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                               Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 74 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                     Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></select>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 75 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                        Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 75 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 77 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                }
                else if (property.IsMultilineText)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 81 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                              Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 81 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<textarea asp-for=\"");
#nullable restore
#line 82 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                 Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 82 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                       Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\"></textarea>\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 83 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                        Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 83 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 85 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"form-group\">\r\n                ");
            WriteLiteral("<label asp-for=\"");
#nullable restore
#line 89 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                              Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 89 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"control-label\"></label>\r\n                ");
            WriteLiteral("<input asp-for=\"");
#nullable restore
#line 90 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                              Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 90 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                    Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"form-control\" />\r\n                ");
            WriteLiteral("<span asp-validation-for=\"");
#nullable restore
#line 91 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                        Write(Model.ModelTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 91 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                                                              Write(property.PropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-danger\"></span>\r\n            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 93 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
                }
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-page=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
#nullable restore
#line 108 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
  
    if (Model.ReferenceScriptLibraries)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@section Scripts {\r\n    ");
            WriteLiteral("@{await Html.RenderPartialAsync(\"_ValidationScriptsPartial\");}\r\n");
            WriteLiteral("}\r\n");
#nullable restore
#line 114 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
    }
    // The following code closes the tag used in the case of a view using a layout page and the body and html tags in the case of a regular view page
    if (!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 120 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\proyectos\rrhh\Templates\RazorPageGenerator\Create.cshtml"
 
    // Do we need to use this in conjunction with the PrimaryKey check?
    bool IsPropertyGuid(IPropertyMetadata property)
    {
        return string.Equals("System.Guid", property.TypeName, StringComparison.OrdinalIgnoreCase);
    }

    string GetValueExpression(IPropertyMetadata property)
    {
        return property.PropertyName;
    }

#line default
#line hidden
#nullable disable
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
