#pragma checksum "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\Employee\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ac5405605a63347b5aba9ce71a349bfa88b726d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Employee_Detail), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Employee/Detail.cshtml")]
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
#line 1 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.ViewModels.CategoryViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.ViewModels.EmployeeViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.ViewModels.ProductViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac5405605a63347b5aba9ce71a349bfa88b726d", @"/Areas/AdminArea/Views/Employee/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f349d95766fecf302d149854311caa59140f692c", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_Employee_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\Employee\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid my-3 mx-3"">
    <div class=""table-responsive pt-3"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>
                        Fullname
                    </th>
                    <th>
                        Age
                    </th>
                    <th>
                        Position
                    </th>
                    <th>
                        Online/Offline
                    </th>
                </tr>
            </thead>
            <tbody>
                    <tr>
                        <td>
                            ");
#nullable restore
#line 30 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\Employee\Detail.cshtml"
                       Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 33 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\Employee\Detail.cshtml"
                       Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 36 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\Employee\Detail.cshtml"
                       Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 39 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\Employee\Detail.cshtml"
                             if (Model.IsActive)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div style=\"width:30px; height:30px; background-color:green; border-radius:50% \"></div>\r\n");
#nullable restore
#line 42 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\Employee\Detail.cshtml"
                            }
                            else
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div style=\"width:30px; height:30px; background-color:red; border-radius:50% \"></div>\r\n");
#nullable restore
#line 47 "C:\Users\Emil Abdullayev\Desktop\BackEnd\One two many crud\EntityFrameworkProject\Areas\AdminArea\Views\Employee\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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