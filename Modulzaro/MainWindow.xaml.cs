using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modulzaro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PatientViewModel _vm; 

        public MainWindow()
        {
            InitializeComponent();
            _vm = new PatientViewModel();
            DataContext = _vm;
        }

        private void NewPatientButton_Click(object sender, RoutedEventArgs e)
        {
            PatientFormViewModel vm = new PatientFormViewModel(new Patient()) { IsNew = true };
            PatientFormView patientForm = new PatientFormView { DataContext = vm };
            patientForm.ShowDialog();
            var patientList = _vm.PatientList;
            if (patientForm.DialogResult==true)
            {
                patientList.Add(vm.Patient);
                vm.Save();
            }
        }

        private void EditPatientButton_Click(object sender, RoutedEventArgs e)
        {
            if (_vm.SelectPatient!=null)
            {
                PatientFormViewModel vm = new PatientFormViewModel(_vm.SelectPatient);
                PatientFormView patientForm = new PatientFormView { DataContext = vm };
                patientForm.ShowDialog();
            }
        }

        private void TreatmentButton_Click(object sender, RoutedEventArgs e)
        {
            if (_vm.SelectPatient != null)
            {
                TreatmentViewModel vm = new TreatmentViewModel();
                TreatmentSheetView reatmentForm = new TreatmentSheetView { DataContext = vm };
                reatmentForm.ShowDialog();
            }
        }

        private void StatisticButton_Click(object sender, RoutedEventArgs e)
        {
            var patients = _vm.PatientList;

            MessageBox.Show($"Kezelt betegek száma: {Statistics.NumberOfPatient(patients)}");

        }
    }
}
