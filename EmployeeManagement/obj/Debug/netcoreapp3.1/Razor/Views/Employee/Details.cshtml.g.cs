#pragma checksum "/Users/sagarshree/Projects/Dot Net/Sagar.Shree/EmployeeManagement/Views/Employee/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6037fe7ed782b56abab19e5f2b836ee6bf13243a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#nullable restore
#line 1 "/Users/sagarshree/Projects/Dot Net/Sagar.Shree/EmployeeManagement/Views/_ViewImports.cshtml"
using EmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sagarshree/Projects/Dot Net/Sagar.Shree/EmployeeManagement/Views/_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6037fe7ed782b56abab19e5f2b836ee6bf13243a", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af35a328bfe0c906f75d04efeba14f80e1f583b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/sagarshree/Projects/Dot Net/Sagar.Shree/EmployeeManagement/Views/Employee/Details.cshtml"
  
  ViewData["Title"] = @Model.FirstName + " " + @Model.Surname;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Employee Detail <a href=\"/employee/index\">Go Back</a></h1>\n\n<ul class=\"list-group list-group-flush\">\n  <li class=\"list-group-item\">First Name : ");
#nullable restore
#line 10 "/Users/sagarshree/Projects/Dot Net/Sagar.Shree/EmployeeManagement/Views/Employee/Details.cshtml"
                                      Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\">Sur Name : ");
#nullable restore
#line 11 "/Users/sagarshree/Projects/Dot Net/Sagar.Shree/EmployeeManagement/Views/Employee/Details.cshtml"
                                    Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\">Address : ");
#nullable restore
#line 12 "/Users/sagarshree/Projects/Dot Net/Sagar.Shree/EmployeeManagement/Views/Employee/Details.cshtml"
                                   Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\">Gender : ");
#nullable restore
#line 13 "/Users/sagarshree/Projects/Dot Net/Sagar.Shree/EmployeeManagement/Views/Employee/Details.cshtml"
                                  Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\">Salary : ");
#nullable restore
#line 14 "/Users/sagarshree/Projects/Dot Net/Sagar.Shree/EmployeeManagement/Views/Employee/Details.cshtml"
                                  Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
