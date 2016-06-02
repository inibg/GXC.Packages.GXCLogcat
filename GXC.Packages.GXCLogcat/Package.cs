using Artech.Architecture.Common.Services;
using Artech.Architecture.UI.Framework.Packages;
using System;
using System.Runtime.InteropServices;

namespace GXC.Packages.GXCLogcat
{
    [Guid("8553003C-BF8E-4514-B3DC-03B0F034CAAF")]
    public class Package : AbstractPackageUI
    {
        public static Guid guid = typeof(Package).GUID;

        public override string Name
        {
            get { return "GXCLogcat"; }
        }

        public override void Initialize(IGxServiceProvider services)
        {
            base.Initialize(services);
            AddCommandTarget(new CommandManager());
        }
    }
}
