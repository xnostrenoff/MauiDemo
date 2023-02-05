using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoApp
{
    public partial class SensorsPageViewModel : ObservableObject
    {
        #region Properties

        /// <summary>
        /// Definie if the sensor are supported.
        /// </summary>
        public bool SensorAreSupported
            => Accelerometer.Default.IsSupported;

        /// <summary>
        /// Obtain or definie if the sensors should be read.
        /// </summary>
        public bool CaptureMovements
        {
            get => _captureMovements;
            set
            {
                if (SetProperty(ref _captureMovements, value))
                {
                    this.ToggleAccelerometer(_captureMovements);
                }
            }
        }
        private bool _captureMovements = false;

        [ObservableProperty]
        string accelerations;

        #endregion Properties

        #region Commands

        [RelayCommand]
        async Task GoToBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        #endregion Commands

        #region Methods

        public void ToggleAccelerometer(bool capture)
        {
            if (!SensorAreSupported)
                return;

            if (capture)
            {
                if (!Accelerometer.Default.IsMonitoring)
                {
                    // Turn on accelerometer
                    Accelerometer.Default.ReadingChanged += Accelerometer_ReadingChanged;
                    Accelerometer.Default.Start(SensorSpeed.UI);
                }
            }
            else
            {
                if (Accelerometer.Default.IsMonitoring)
                {
                    // Turn off accelerometer
                    Accelerometer.Default.Stop();
                    Accelerometer.Default.ReadingChanged -= Accelerometer_ReadingChanged;
                }
            }
        }

        #endregion Methods

        #region Handlers 

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            // Update UI Label with accelerometer state
            const string P = "0.000";
            this.Accelerations = $"X: {e.Reading.Acceleration.X}{Environment.NewLine}Y: {e.Reading.Acceleration.Y}{Environment.NewLine}Z: {e.Reading.Acceleration.Z}";
        }

        #endregion Handlers

    }
}