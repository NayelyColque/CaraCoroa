namespace correcaoCaraCoroa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CoinFlipButton_Clicked(object sender, EventArgs e)
        {
            //Pegar o número selecionado pelo usuário no Picker
            string ladoSelecionado = CoinPicker.SelectedIndex.ToString();

            //Sortear um numero
            int numeroSorteado = new Random().Next(2);


            //Troco a img pelo resultado: Onde 0 eh cara
            if (numeroSorteado == 0 )
            {
                coinImage.Source = "cara.jpg";
            }
            //Troco a img pelo resultado: onde 1 eh coroa
            if (numeroSorteado == 1)
            {
                coinImage.Source = "coroa.jpg";
            }

            //Comparar com o que o usuario selecionou 0
            if (numeroSorteado == 0 && ladoSelecionado == "Cara")
            {
                Resultlabel.Text = "Parabens, deu cara!";
            }

            if (numeroSorteado == 0 && ladoSelecionado == "Cara")
            {
                Resultlabel.Text = "Que pena, vc selecionou cara e deu coroa!";
            }

            //Comparar com o que o usuario selecionou 1
            if (numeroSorteado == 1 && ladoSelecionado == "Coroa")
            {
                Resultlabel.Text = "Parabens, deu coroa!";
            }

            if (numeroSorteado == 1 && ladoSelecionado == "Coroa")
            {
                Resultlabel.Text = "Que pena, vc selecionou cara e deu cara!";
            }

            //Exibir o resultado, se a pessoa ganhou ou perdeu
        }
    }

}
