using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;
using todo7.Clases;

namespace todo7
{
    public partial class ListaTareas : ContentPage
    {
        void BotonNuevo_Clicked(object sender, EventArgs e)
        {

        }


        public ListaTareas()
        {
            InitializeComponent();

            var botonNuevo = new ToolbarItem()
            {
                Text = "+"

            };

            botonNuevo.Clicked += BotonNuevo_Clicked;
            ToolbarItem.add(botonNuevo);


        }

        async void Handle_Clicked(object sender, EventArgs e)

        {

            Navigation.PushAsync(new NuevoItem);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using(SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.RutaBD))
            {
                List<Tarea> listaTareas;
                listaTareas = conexion.Table<Tarea>().ToList();

                listaTareasListView.ItemsSource = listaTareas;



            }

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.RutaBD))

                var tereaAcompletar = (sender as MenuItem).CommandParameter as Tarea;
            tareaAcompletar.Completada = true;

            conexion.Update(tareaAcompletar);

            List<Tarea> listaTareasFiltrada;
            listaTareasFiltrada = conexion.Table<Tarea>().Where(t => t.Completada == false).ToList();
            listaTareasListView.ItemSource = listaTareasFiltrada;


 

        
        }
        }



    }
}
