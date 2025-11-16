using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class Contratacao : ContentPage
{
    public DateTime MinDatePickerDate => DateTime.Today;

    public Contratacao()
    {
        InitializeComponent();
    }

    public DateTime dataDeInicio => dataInicio.Date;

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Evento evento = new Evento
        {
            nome = txt_nome.Text,
            local = txt_local.Text,
            numeroDeParticipantes = Convert.ToInt32(stp_participantes.Value),
            dataInicio = dataInicio.Date,
            dataFim = dataFim.Date,
            precoPorParticipante = Convert.ToDouble(txt_precoParticipante.Text)

        };

        await Navigation.PushAsync(new Contratada()
        {
            BindingContext = evento
        });
    }
}
