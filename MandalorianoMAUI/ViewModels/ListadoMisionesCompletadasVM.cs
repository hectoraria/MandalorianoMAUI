using ENT;
using MandalorianoMAUI.Models;
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
    [QueryProperty(nameof(MisionCompletada), "MisionCompletada")]
    public class ListadoMisionesCompletadasVM :INotifyPropertyChanged
    {
        private DelegateCommand volver;
        private List<clsMisionCompletada> listadoMisionesCompletadas;
        private clsMision misionCompletada;
        

        public DelegateCommand Volver
        {
            get { return volver; }
        }

        public clsMision MisionCompletada
        {
            get { return misionCompletada; }
            set {misionCompletada = value; 
                NotifyPropertyChanged("MisionCompletada");
                clsMisionCompletada mision = new clsMisionCompletada(misionCompletada);
                listadoMisionesCompletadas.Add(mision);
                NotifyPropertyChanged("ListadoMisionesCompletadas");
                
            }
        }

        public List<clsMisionCompletada> ListadoMisionesCompletadas
        {
            get { return listadoMisionesCompletadas; }
            set { listadoMisionesCompletadas = value;}
        }

        public ListadoMisionesCompletadasVM() {
            listadoMisionesCompletadas= new List<clsMisionCompletada>();
            volver = new DelegateCommand(VolverCommandExecute);
        }

        private async void VolverCommandExecute()
        {
            await Shell.Current.GoToAsync("///MainPage");
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
