using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CatsAndDogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetaDog_Click(object sender, EventArgs e)
        {
            string dogImage = GetDogImageUrl();

            DogPicture.ImageLocation = dogImage;
            DogPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public static string GetDogImageUrl()
        {
            string url = "https://dog.ceo/api/breeds/image/random";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            var WebResponse = request.GetResponse();
            var webStream = WebResponse.GetResponseStream();

            string imageUrl;

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                Dog dog = JsonConvert.DeserializeObject<Dog>(response);

                imageUrl = dog.message;
            }

            return imageUrl;
            
        }

        private void GetaCat_Click(object sender, EventArgs e)
        {
            string catImage = GetCatImage();
            CatPicture.ImageLocation = catImage;
            CatPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public static string GetCatImage()
        {
            string url = "https://api.thecatapi.com/v1/images/search";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            string catImage;

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using(var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                JavaScriptSerializer ser = new JavaScriptSerializer();

                List<Cat> catList = ser.Deserialize<List<Cat>>(response);
                catImage = catList[0].url;
            }

            return catImage;
        }
    }
}
