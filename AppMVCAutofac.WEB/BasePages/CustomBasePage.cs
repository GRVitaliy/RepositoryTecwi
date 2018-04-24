using TamgaMVCAutofac.Core.Interfaces;
using System.Web.Mvc;

namespace TamgaMVCAutofac.Web.BasePages
{
    public class CustomBasePage : WebViewPage
    {
        public IUserRepository userRepo { get; set; }
        public IRepository repo { get; set; }

        public override void Execute() { }
    }
}