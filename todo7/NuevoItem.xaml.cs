using System;
using System.Collections.Generic;
using todo7.Clases;
using Xamarin.Forms;

namespace todo7
{
    public partial class NuevoItem : ContentPage
    {
        public NuevoItem()
        {
            InitializeComponent();
        }

        void Handle_Clciked(object sender, System.EventArgs e)
        {
            Tarea nuevaTarea = new Tarea()
            {

                Nombre = nombreEntry.Text,
                Fecha = fechaLimiteDatePicker.Date,
                Hora = horaLimiteTimePicker.Time,
                Comlpetada = false

            };

            using(SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.RutaBD))
            {

                conexion.CreateTable<Tarea>();

                var resultado = conexion.Insert(nuevaTarea);

                if (resultado > 0)
                    DisplayAlert("Exito", "El elemento se guardo", "ok");
                else
                    DisplayAlert("Error", "Inteta de nuevo", "ok");
            }
            }
    }
}
