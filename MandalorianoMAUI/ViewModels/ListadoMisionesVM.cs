using BL;
using ENT;
using MandalorianoMAUI.ViewModels.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MandalorianoMAUI.ViewModels
{
    public class ListadoMisionesVM : INotifyPropertyChanged
    {
        #region Atributos
        private DelegateCommand completar;
        private List<clsMision> listadoMisiones;
        private clsMision seleccionarMision;
        #endregion

        #region Propiedades
        public DelegateCommand Completar
        {  
            get { return completar; } 
        }

        public List<clsMision> ListadoMisiones
        {
            get { return listadoMisiones; }
        }

        public clsMision SeleccionarMision
        {
            get { return seleccionarMision; }
            set { 
                seleccionarMision = value;
                NotifyPropertyChanged("SeleccionarMision");
                completar.RaiseCanExecuteChanged();
                }
        }
        #endregion

        #region Constructores
        public ListadoMisionesVM ()
        {
            listadoMisiones= clsListadosBL.obtenerListadoMisionesBL();
            completar=new DelegateCommand(completarCommandExecute,completarCommandCanExecute);

        }
        #endregion

        #region Eventos
        private async void completarCommandExecute()
		{
            Dictionary<string, object> diccionarioMandar = new Dictionary<string, object>();

            diccionarioMandar.Add("MisionCompletada", SeleccionarMision);

            await Shell.Current.GoToAsync("///misionesCompletadas", diccionarioMandar);

        }
        #endregion

        private bool completarCommandCanExecute()
        {
            bool visible = false;

            if (seleccionarMision != null)
            {
                visible = true;
            }

            return visible;

        }
        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
