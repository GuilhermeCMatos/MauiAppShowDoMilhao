﻿using MauiAppShowDoMilhao.Models;
using Plugin.Maui.Audio;

namespace MauiAppShowDoMilhao
{
    public partial class MainPage : ContentPage
    {
        double premio = 1000;
        int pergunta_count = 1;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = App.getRandomPerguntaFacil();

            lbl_nivel.Text = "Fácil";
            lbl_premio.Text = premio.ToString("C");
            lbl_pergunta_numero.Text = pergunta_count.ToString();

            //Adiciona Som
            Stream track =
                FileSystem.OpenAppPackageFileAsync("0.mp3").Result;
            AudioManager.Current.CreatePlayer(track).Play();
        }

        private void toca_som()
        {
            string track = "";

            switch(pergunta_count)
            {
                case 1:
                    track = "1.wav"; //"1.wav"
                break;

                case 2:
                    track = "2.wav"; //"2.wav"
                break;

                case 3:
                    track = "3000.wav"; //"3.wav"
                break;

                case 4:
                    track = "4.wav"; //"4.wav"
                break;

                case 5:
                    track = "5.wav"; //"5.wav"
                break;

                case 6:
                    track = "6.wav"; //"6.wav"
                break;

                case 7:
                    track = "7.wav"; //"7.wav"
                break;

                case 8:
                    track = "8.wav"; //"8.wav"
                break;

                case 9:
                    track = "9.wav"; //"9.wav"
                break;

                case 10:
                    track = "10.wav";
                break;

                case 11:
                    track = "11.wav"; 
                break;

                case 12:
                    track = "12.wav";
                break;

                case 13:
                    track = "13.wav";
                break;

                case 14:
                    track = "14.wav"; 
                break;

                case 15:
                    track = "15.wav"; 
                break;
            }

            AudioManager.Current.CreatePlayer(
                FileSystem.OpenAppPackageFileAsync(track).Result).Play();
        }

        private void Button_Clicked_Proxima(object sender, EventArgs e)
        {
            string texto_alternativa = "";

            bool resposta_correta = false;

            if(alt_1.IsChecked)
            {
                texto_alternativa = alt_1.Content.ToString();
                resposta_correta = (bool)alt_1.Value;
            }

            if (alt_2.IsChecked)
            {
                texto_alternativa = alt_2.Content.ToString();
                resposta_correta = (bool)alt_2.Value;
            }

            if (alt_3.IsChecked)
            {
                texto_alternativa = alt_3.Content.ToString();
                resposta_correta = (bool)alt_3.Value;
            }

            if (alt_4.IsChecked)
            {
                texto_alternativa = alt_4.Content.ToString();
                resposta_correta = (bool)alt_4.Value;
            }

            if (resposta_correta)
            {
                this.BindingContext = App.getRandomPerguntaFacil();

                DisplayAlert("Acertou!", texto_alternativa, "Próxima");
            } else
            {
                DisplayAlert("Errou!", "burro!", "Tentar Novamente");
            }
            void avanca_pergunta()
            {
                if (pergunta_count <= 5)
                {
                    premio = premio + 1000;
                    this.BindingContext = App.getRandomPerguntaFacil();
                    lbl_nivel.Text = "Fácil";
                }

                if (pergunta_count > 5 && pergunta_count <= 10)
                {
                    premio = premio + 10000;
                    this.BindingContext = App.getRandomPerguntaMedia();
                    lbl_nivel.Text = "Média";
                }

                if (pergunta_count > 10 && pergunta_count < 15)
                {
                    premio = premio + 100000;
                    this.BindingContext = App.getRandomPerguntaDificil();
                    lbl_nivel.Text = "Dificil";
                }

                lbl_premio.Text = premio.ToString("C");
                lbl_pergunta_numero.Text = pergunta_count.ToString();
            }
        }
    }

}
