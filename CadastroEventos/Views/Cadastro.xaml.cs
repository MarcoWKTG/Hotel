using CadastroEventos.Models;
using System.Security.Cryptography.X509Certificates;

namespace CadastroEventos.Views;

public partial class Cadastro : ContentPage
{
	App PropriedadesApp;
	public Cadastro()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;
		pk_local_evento.ItemsSource = PropriedadesApp.local_selecionado;

		//define a data minima do "inicio"
		dtpk_inicio.MinimumDate = DateTime.Now;
		//define a data máxima do "inicio"
		dtpk_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
		
		//define a data minima do "fim"
		dtpk_termino.MinimumDate = dtpk_inicio.Date.AddDays(1);
		//define a data máxima do "fim"
		dtpk_termino.MaximumDate = dtpk_inicio.Date.AddMonths(1);

		
	}
	//essa função é iniciada toda vez que uma data for selecionada no DatePicker inicio
    private void dtpk_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;
		DateTime data_selecionada = elemento.Date;
		//define uma data minima para DatePicker termino com base na data do DatePicker inicio
		dtpk_termino.MinimumDate = data_selecionada.Date.AddDays(1);
		//define uma da máxima para o DatePicker termino com base na data do DatePicker inicio
		dtpk_termino.MaximumDate = data_selecionada.Date.AddMonths(1);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		DadosInformados dados_informados = new DadosInformados
		{
			NomeEvento = Convert.ToString(txt_nome_evento.Text),
            LocalSelecionado = (Local)pk_local_evento.SelectedItem,
			QntParticipante = Convert.ToInt32(stp_participantes.Value),
			DataInicio = dtpk_inicio.Date,
			DataTermino = dtpk_termino.Date
		};

		await Navigation.PushAsync(new Views.EventoCadastrado()
		{
			BindingContext = dados_informados
		});
    }
}