using Artech.Architecture.UI.Framework.Helper;
using Artech.Architecture.UI.Framework.Services;
using Artech.Common.Framework.Commands;

using System.Windows.Forms;

namespace GXC.Packages.GXCLogcat
{
    class CommandManager : CommandDelegator
    {
        public CommandManager()
        {
            AddCommand(CommandKeys.VerificarLocation, new ExecHandler(ExecVerificarLocation), new QueryHandler(QueryVerificarLocation));
            AddCommand(CommandKeys.ListarObjetos, new ExecHandler(ExecListarObjetos), new QueryHandler(QueryListarObjetos));
            AddCommand(CommandKeys.ListarObjetosJS, new ExecHandler(ExecListarObjetosJS), new QueryHandler(QueryListarObjetosJS));
            AddCommand(CommandKeys.ExportarObjetos, new ExecHandler(ExecExportarObjetos), new QueryHandler(QueryExportarObjetos));
        }

        public bool ExecVerificarLocation(CommandData data)
        {
            MessageBox.Show("Mi primer comando!");
            return true;
        }

        public bool ExecListarObjetos(CommandData data)
        {
            MessageBox.Show("Mi primer comando!");
            return true;
        }

        public bool ExecListarObjetosJS(CommandData data)
        {
            MessageBox.Show("Mi primer comando!");
            return true;
        }

        public bool ExecExportarObjetos(CommandData data)
        {
            MessageBox.Show("Mi primer comando!");
            return true;
        }

        private bool QueryListarObjetos(CommandData data, ref CommandStatus status)
        {
            //status.State = CommandState.Disabled;
            //if (UIServices.KB != null && UIServices.KB.CurrentKB != null)
            //{
            //    status.State = CommandState.Enabled;
            //}
            return true;
        }

        private bool QueryExportarObjetos(CommandData data, ref CommandStatus status)
        {
            //status.State = CommandState.Disabled;
            //if (UIServices.KB != null && UIServices.KB.CurrentKB != null)
            //{
            //    status.State = CommandState.Enabled;
            //}
            return true;
        }


        private bool QueryListarObjetosJS(CommandData data, ref CommandStatus status)
        {
            //status.State = CommandState.Disabled;
            //if (UIServices.KB != null && UIServices.KB.CurrentKB != null)
            //{
            //    status.State = CommandState.Enabled;
            //}
            return true;
        }


        private bool QueryVerificarLocation(CommandData data, ref CommandStatus status)
        {
            //status.State = CommandState.Disabled;
            //if (UIServices.KB != null && UIServices.KB.CurrentKB != null)
            //{
            //    status.State = CommandState.Enabled;
            //}
            return true;
        }

    }

}