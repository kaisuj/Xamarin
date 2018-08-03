using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinHelloWorldApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
        private int counter = 0;
        private readonly string[] quotes = new string[]
        {
            "Ludzie budują za dużo murów, a za mało mostów.",
            "To smutne, że głupcy są tacy pewni siebie, a ludzie rozsądni tacy pełni wątpliwości.",
            "Nigdy nie jest za późno, by stać się tym, kim chcemy być.",
            "Mówienie tak bardzo przeszkadza w myśleniu." ,
            "Żaden wiatr nie jest pomyślny temu, kto nie wie, do którego portu płynie.",
            "Mogę być bardzo wściekły na to, czego nie mam, albo bardzo wdzięczny za to, co mam.",
            "Wykop studnię, zanim poczujesz pragnienie.",
            "Bądź dobrej myśli, bo po co być złej.",
            "Nigdy nie trać nawet chwili na myślenie o kimś, kogo nie lubisz.",
            "Przygotowując się do bitwy, zawsze orientowałem się, że plany są bezużyteczne, ale planowanie jest nieodzowne.",
            "Zdrowy rozsądek to rzecz, której każdy potrzebuje, mało kto posiada, a nikt nie wie, że mu brakuje.",
            "Jeśli nie chcesz być zapomnianym szybko po śmierci, albo zaraz pisz rzeczy warte przeczytania, albo czyń rzeczy warte opisania.",
            "Dla ludu religia jest prawdą, dla mędrców fałszem, a dla władców jest po prostu użyteczna.",
            "Przyprawą potrawy jest głód.",
            "Prostota jest szczytem wyrafinowania.",
            "Polub twoją pracę, nawet gdyby była mało znacząca i odpoczywaj przy niej.",
            "Zastanów się, o ile częściej cierpisz z powodu swego gniewu i żalu, niż z powodu rzeczy, które wprawiają cię w gniew i wzbudzają żal.",
            "Łatwiej powiedzieć „nie” na początku, niż na końcu.",
            "Wszyscy ludzie są o tyle piękni, o ile mniej poznani.",
            "Obelgi – to argumenty tych, którzy nie mają argumentów."
        };
        public QuotesPage ()
		{
			InitializeComponent ();
            contentLabel.Text = quotes[0];
        }

        private void nextButton_Clicked(object sender, EventArgs e)
        {
            counter++;
            if (counter >= quotes.Length)
                counter = 0;

            contentLabel.Text = quotes[counter];
        }
    }
}