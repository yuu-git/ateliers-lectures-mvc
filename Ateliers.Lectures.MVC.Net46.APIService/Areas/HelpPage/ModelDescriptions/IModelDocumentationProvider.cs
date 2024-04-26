using System;
using System.Reflection;

namespace Ateliers.Lectures.MVC.Net46.APIService.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}