using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using Autofac;
using Autofac.Core;
using Autofac.Features.ResolveAnything;
using DevExpress.Xpf.WindowsUI.Navigation;

using WPFTestTask.Common;
using WPFTestTask.Model.Services;

namespace WPFTestTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IContainer Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Container = BuildUpContainer();
            DISource.Resolver = Resolve;
        }

        object Resolve(Type type, object key, string name)
        {
            if (type == null)
                return null;
            if (key != null)
                return Container.ResolveKeyed(key, type);
            if (name != null)
                return Container.ResolveNamed(name, type);
            return Container.Resolve(type);
        }

        static IContainer BuildUpContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
            builder.RegisterType<PeopleService>().As<IPeopleService>().SingleInstance();
            builder.RegisterType<FileDialogService>().As<IFileDialogService>().SingleInstance();
            return builder.Build();
        }
    }
}
