using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artech.Common.Framework.Commands;

namespace GXC.Packages.GXCLogcat
{
    class CommandKeys
    {
        private static CommandKey AttrVerificarLocation = new CommandKey(Package.guid, "VerificarLocation");
        public static CommandKey VerificarLocation
        {
            get { return AttrVerificarLocation; }
        }

        private static CommandKey AttrListarObjetos = new CommandKey(Package.guid, "ListarObjetos");
        public static CommandKey ListarObjetos
        {
            get { return AttrListarObjetos; }
        }

        private static CommandKey AttrListarObjetosJS = new CommandKey(Package.guid, "ListarObjetosJS");
        public static CommandKey ListarObjetosJS
        {
            get { return AttrListarObjetosJS; }
        }

        private static CommandKey AttrExportarObjetos = new CommandKey(Package.guid, "ExportarObjetos");
        public static CommandKey ExportarObjetos
        {
            get { return AttrExportarObjetos; }
        }
    }
}
