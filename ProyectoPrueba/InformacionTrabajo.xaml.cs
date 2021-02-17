using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoPrueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformacionTrabajo : ContentPage
    {
        ObservableCollection<MediaModel> Photos = new ObservableCollection<MediaModel>();
        public InformacionTrabajo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var isInitialize = await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.IsSupported || !isInitialize)
            {
                await DisplayAlert("Error", "La Camara No Esta Disponible", "OK");
                return;
            }

            var newPhotoID = Guid.NewGuid();
            using (var photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions()
            {
                Name = newPhotoID.ToString(),
                SaveToAlbum = true,
                DefaultCamera = CameraDevice.Rear,
                Directory = "Camera",
                CustomPhotoSize = 50
            }))
            {
                if (string.IsNullOrWhiteSpace(photo?.Path))
                {
                    return;
                }

                var newPhotoMedia = new MediaModel()
                {
                    MediaID = newPhotoID,
                    Path = photo.Path,
                    LocalDateTime = DateTime.Now
                };

                Photos.Add(newPhotoMedia);

                photo.Dispose();
            }

            listPhotos.ItemsSource = Photos;

        }
    }
}