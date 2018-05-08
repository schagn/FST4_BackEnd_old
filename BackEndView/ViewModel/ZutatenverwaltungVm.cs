using BackEndView.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndView.ViewModel
{
    public class ZutatenverwaltungVm : ViewModelBase
    {
        //TODO: BINDINGS
        public RelayCommand<Zutat> EditZutat { get; set; }

        public RelayCommand<Zutat> DeleteZutat { get; set; }

        public RelayCommand SaveEditZutat { get; set; }
        public RelayCommand SaveNewZutat { get; set; }

        public ObservableCollection<Zutat> Zutaten { get; set; }

        public string ZutatenName { get; set; }
        public double ZutatenPreis { get; set; }

        public string EditZutatenName { get; set; }
        public double EditZutatenPreis { get; set; }

        Guid SelectedProduktId;

        public ZutatenverwaltungVm()
        {
            Zutaten = new ObservableCollection<Zutat>();

            EditZutat = new RelayCommand<Zutat>(
                (p) =>
                {
                    EditZutatenName = p.Beschreibung;
                    EditZutatenPreis = p.Preis;
                    SelectedProduktId = p.ZutatenId;

                    //KUCHENATTRIBUT == SELECTED PRODUKT P 
                    //KUCHENATTRIBUTE LEER SETZEN
                });

            SaveNewZutat = new RelayCommand(SaveZutat);
            SaveEditZutat = new RelayCommand(EditExistingZutat);


            DeleteZutat = new RelayCommand<Zutat>(
                (p) =>
                {
                    DeleteSelectedProduct(p);
                });

        }

        private void EditExistingZutat()
        {
            // client.editZutaten(Guid selectedProduktId ,new Zutat)
            //Edit Zutaten Name, 
        }

        private void DeleteSelectedProduct(Zutat p)
        {
            //client.deleteZutat
            //client Zutat neu abfragen
            RaisePropertyChanged("Zutaten");
        }

        private void SaveZutat()
        {
            // client. SaveProduct ( new Zutat () {
            //});
        }
    }
}
