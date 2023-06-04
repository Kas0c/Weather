using System.Text.Json;

namespace Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Checkbtn_Click(object sender, EventArgs e)
        {
            //wysys³a ¿¹dania i odbiera odpowiedzi HTTP
            HttpClient client = new HttpClient();
            //asynchronicznie wysy³a ¿¹danie pod wskazany adreS URL
            string response = client.GetStringAsync("https://api.open-meteo.com/v1/forecast?latitude=54.35&longitude=18.65&hourly=temperature_2m&current_weather=true&timezone=auto").Result;
            JsonDocument document = JsonDocument.Parse(response);
            //pobiera wartoœci "current_weather" z dokumentu JSON
            JsonElement element = document.RootElement.GetProperty("current_weather");
            int day = int.Parse(element.GetProperty("is_day").ToString());
            if (day == 0)
            {
                TimeOfDay.Text = "Noc";
            }
            if (day == 1)
            {
                TimeOfDay.Text = "Dzieñ";
            }
            Time.Text = element.GetProperty("time").ToString();
            Temp.Text = element.GetProperty("temperature").ToString();
            WindSpeed.Text = element.GetProperty("windspeed").ToString();
            WindDir.Text = element.GetProperty("winddirection").ToString();
            int type = int.Parse(element.GetProperty("weathercode").ToString());
            if (type == 0)
            {
                Weather.Text = "Czyste niebo";
            }
            if (type == 1)
            {
                Weather.Text = "Przewa¿nie bezchmurne";
            }
            if (type == 2)
            {
                Weather.Text = "Czêœciowe zachmurzenie";
            }
            if (type == 3)
            {
                Weather.Text = "Pochmurno";
            }
        }
    }
}