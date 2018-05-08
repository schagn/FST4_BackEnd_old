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
    public class KuchenverwaltungVm : ViewModelBase
    {
        //TODO: BINDINGS
        public RelayCommand<Kuchen> EditProduct { get; set; }

        public RelayCommand<Kuchen> DeleteProduct { get; set; }

        public RelayCommand SaveNewProduct { get; set; }

        public ObservableCollection<Kuchen> Kuchen { get; set; }

        public string ButtonName { get; set; }

        // KUCHENATTRIBUTE

        public KuchenverwaltungVm()
        {
            Kuchen = new ObservableCollection<Kuchen>();

            ButtonName = "Speichern";

            EditProduct = new RelayCommand<Kuchen>(
                (p) =>
                {
                    ButtonName = "Ändern";
                    //KUCHENATTRIBUT == SELECTED PRODUKT P 
                    SaveEditProduct(p);
                    ButtonName = "Speichern";
                    //KUCHENATTRIBUTE LEER SETZEN
                    
                });

            SaveNewProduct = new RelayCommand(SaveProduct);

            DeleteProduct = new RelayCommand<Kuchen>(
                (p) =>
                {
                    DeleteSelectedProduct(p);
                });

        }

        private void DeleteSelectedProduct(Kuchen p)
        {
            //client.deleteproduct
            //client produkte neu abfragen
            RaisePropertyChanged("Kuchen");
        }

        private void SaveProduct()
        {
            // client. SaveProduct ( new Kuchen () {
            //});
        }

        private void SaveEditProduct(Kuchen p)
        {
            if (ButtonName.Equals("Ändern"))
            {
                //client.SaveEditedProduct(new Kuchen);
            } else {
                SaveProduct();
            }

            // client. SaveEditedProduct(p);
        }
    }
}
