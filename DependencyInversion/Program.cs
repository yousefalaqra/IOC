using System;
using Autofac;

namespace DependencyInversion
{
    class Program
    {
      public static void Main(string[] args){
          
          var container = Configration.Configure();
          
          using (var scope = container.BeginLifetimeScope())
          {
              var app = scope.Resolve<IApplication>();
              app.Run();
          }
        }
    }
}
