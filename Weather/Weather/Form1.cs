using System; 
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Запрос на сервер используем этот класс (в создать передаем параметр)
                WebRequest request = WebRequest.Create($"https://api.openweathermap.org/data/2.5/weather?q={gorod.Text}&units=metric&appid=f18faa547c63bdeb07930f615ac8104f");

                //задаем несколько свойств для запроса
                request.Method = "POST";
                request.ContentType = "application/x-www-urlencoded";

                //Нужно принять ответ от сервера
                //используем ассинхронные методы
                WebResponse webResponse = await request.GetResponseAsync();

                //Создадим пустую переменную
                string answer = string.Empty;

                //Получим поток ответа
                using (Stream s = webResponse.GetResponseStream())
                {
                    //в конструктор класса реадер передаем поток
                    using (StreamReader reader = new StreamReader(s))
                    {
                        //Записываем поток ответа в переменную
                        answer = await reader.ReadToEndAsync();
                    }
                }
                //закрываем объект response
                webResponse.Close();

                openWeather.OpneWeather o = JsonConvert.DeserializeObject<openWeather.OpneWeather>(answer);

                panel1.BackgroundImage = o.weather[0].Icon;

                label1.Text = o.weather[0].main;

                label2.Text = o.weather[0].description;

                label3.Text = "Средняя температура: " + o.main.temp.ToString("0.##");

                label6.Text = "Скорость: " + o.wind.speed.ToString();

                label7.Text = "Направление: " + o.wind.deg.ToString();

                label4.Text = "Влажность: " + o.main.humidity.ToString();

                label5.Text = "Давление: " + ((int)o.main.preasure).ToString();

                groupBox1.Visible = true;
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Eror");
            }

        }
    }
}
