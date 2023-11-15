﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



using FontAwesome.Sharp; //nuevo 
using System.Drawing.Text;
using System.Windows.Media;

namespace Prototipo_CAI;

public partial class Itinerarios : Form
{
    private IconButton botonActual; //boton en el que estamos
    private Panel bordeIzquierdo; // para poner un borde izquierdo al boton
    public Itinerarios()
    {
        InitializeComponent();
        bordeIzquierdo = new Panel(); // inicializo lo de arriba
        bordeIzquierdo.Size = new Size(7, 60); //el 60 es igual al tamaño del boton
        panelMenuItinerario.Controls.Add(bordeIzquierdo); //lo agregamos al panel
        Size = new Size(740, 346);
    }

    //nuevos metodos
    private void botonActivado(object sender, System.Drawing.Color color)
    {
        if (sender != null)
        {
            BotonDesactivado();
            //boton
            botonActual = (IconButton)sender; // asignamos el boton actual al boton remitente 
            botonActual.BackColor = System.Drawing.Color.FromArgb(36, 72, 100);
            botonActual.ForeColor = color;
            //botonActual.TextAlign = ContentAlignment.MiddleCenter;
            botonActual.IconColor = color;
            //botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
            //botonActual.ImageAlign = ContentAlignment.MiddleRight;

            //ahora el borde del boton
            bordeIzquierdo.BackColor = color;
            bordeIzquierdo.Location = new Point(0, botonActual.Location.Y);
            bordeIzquierdo.Visible = true;
            bordeIzquierdo.BringToFront();
        }
    }

    private void BotonDesactivado()
    {
        if (botonActual != null)
        {
            botonActual.BackColor = System.Drawing.Color.FromArgb(8, 32, 50);
            botonActual.ForeColor = System.Drawing.Color.White;
            //botonActual.TextAlign = ContentAlignment.MiddleLeft;
            botonActual.IconColor = System.Drawing.Color.White;
            //botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
            //botonActual.ImageAlign = ContentAlignment.MiddleLeft;
        }
    }

    // ////////////////////////////////////////////////////////////////////////////////////////

    private void mostrarDatos()
    {
        Size = new Size(1050, 346);
        iconbtnNuevoItinerario.Enabled = false;
        //iconbtnNuevoItinerario.ForeColor = System.Drawing.Color.White;
        iconbtnDatosCliente.Enabled = false;
        //iconbtnDatosCliente.ForeColor = System.Drawing.Color.White;
        iconbtnEstItinerarioActivo.Enabled = false;
        //iconbtnEstItinerarioActivo.ForeColor = System.Drawing.Color.White;
        iconbtnEliminarItinerario.Enabled = false;
        //iconbtnEliminarItinerario.ForeColor= System.Drawing.Color.White;
        iconbtnCrearReservaItinerario.Enabled = false;
        //iconbtnCrearReservaItinerario.ForeColor = System.Drawing.Color.White;
    }

    private void esconderDatos()
    {
        Size = new Size(740, 346);
        txtNombreCliente.Clear();
        txtCuilCuit.Clear();
        iconbtnNuevoItinerario.Enabled = true;
        iconbtnDatosCliente.Enabled = true;
        iconbtnEstItinerarioActivo.Enabled = true;
        iconbtnEliminarItinerario.Enabled = true;
        iconbtnCrearReservaItinerario.Enabled = true;
    }

    // ////////////////////////////////////////////////////////////////////////////////////////


    ItinerariosModel model = new();

    private void Itinerarios_Load(object sender, EventArgs e)
    {
        foreach (ListViewItem item in model.FormatoItinerarios())
        {
            lsvItinerario.Items.Add(item);
        }
    }

    private void iconbtnNuevoItinerario_Click(object sender, EventArgs e)
    {
        botonActivado(sender, System.Drawing.Color.FromArgb(255, 255, 255));

        var r = MessageBox.Show("Desea agregar datos de cliente?", "Crear Itinerario", MessageBoxButtons.YesNoCancel);
        if (r == DialogResult.Yes)
        {
            mostrarDatos();

            //Acá hay que agregar los datos de la pantalla "AgregarClientes".
        }
        if (r == DialogResult.No)
        {
            int ultimoCodigo = ItinerariosAlmacen.Itinerarios.Count;
            int codigoSiguiente = ultimoCodigo + 1; //No sirve si se elemina un Itinerario.

            MessageBox.Show($"Se ha creado el itinerario correctamente. Su código de itinerario es {codigoSiguiente}.",
                "Itinerario Creado");
            //Falta que se agregue al Json.

            //Esto debería ir en otro lado?
            var item = new ListViewItem();
            item.Text = codigoSiguiente.ToString();
            item.SubItems.Add("");  
            item.SubItems.Add("");

            lsvItinerario.Items.Add(item);
        }
    }

    private void iconbtnDatosCliente_Click(object sender, EventArgs e)
    {
        botonActivado(sender, System.Drawing.Color.FromArgb(255, 255, 255));
     
        
        if (lsvItinerario.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selecciona un itinerario de la lista.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        lsvItinerario.Enabled = false;
        mostrarDatos();

        Itinerario ItinerarioSeleccionado = (Itinerario)lsvItinerario.SelectedItems[0].Tag;

        txtNombreCliente.Text = ItinerarioSeleccionado.NombreCliente;
        txtCuilCuit.Text = ItinerarioSeleccionado.CUILCUIT.ToString();
        //ItinerarioSeleccionado.Disponibilidades = null;
        //ItinerarioSeleccionado.EstaReservado = false;
        //ItinerarioSeleccionado.CodigoItinerario = 0;
        //ItinerarioSeleccionado.TarifasVuelos = null;
    }

    private void iconbtnEstItinerarioActivo_Click(object sender, EventArgs e)
    {
        botonActivado(sender, System.Drawing.Color.FromArgb(255, 255, 255));

        if (lsvItinerario.SelectedItems.Count == 0)
        {
            MessageBox.Show("Seleccione un itinerario.", "Error");
        }
        else
        {
            string codItinerario = lsvItinerario.SelectedItems[0].Text;
            model.CambiarItinerarioActivo(codItinerario);
            MessageBox.Show($"Se ha establecido el itinerario {codItinerario} como activo.");
        }
    }

    private void iconbtnEliminarItinerario_Click(object sender, EventArgs e)
    {
        botonActivado(sender, System.Drawing.Color.FromArgb(255, 255, 255));

        if (lsvItinerario.SelectedItems.Count == 0)
        {
            MessageBox.Show("Debe seleccionar un itinerario de la lista.", "Error");
        }
        else
        {
            lsvItinerario.SelectedItems[0].Remove();
            //Falta que lo elimine del Json.
        }
    }

    private void iconbtnCrearReservaItinerario_Click(object sender, EventArgs e)
    {
        botonActivado(sender, System.Drawing.Color.FromArgb(255, 255, 255));

        if (lsvItinerario.SelectedItems.Count > 0)
        {
            CrearReserva crearReserva = new();

            crearReserva.ShowDialog();
        }
        else
        {
            MessageBox.Show("Seleccione un itinerario.", "Error");
        }
    }

    /*Esto se puede mejorar con una función y llamar a la función directamente esto es una *****. También se puede agregar la función de 
    presionar enter y buscar*/

    private void btnBuscarItinerario_Click(object sender, EventArgs e)
    {
        BuscarItinerario(txtBuscarItinerario.Text);
    }


    private void btnAceptar_Click(object sender, EventArgs e)
    {
        Itinerario clienteAModificar = (Itinerario)lsvItinerario.SelectedItems[0].Tag;
        Itinerario clienteNuevaVersion = new Itinerario();

        string nombreRZ = txtNombreCliente.Text;
        string cuilcuit = txtCuilCuit.Text;
        string errores = model.ValidarCampos(nombreRZ, cuilcuit);

        if (!string.IsNullOrEmpty(errores))
        {
            MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);         
        }
        else
        {
            MessageBox.Show($"Se ha creado el itinerario correctamente. Su código de itinerario es {1}.", "Itinerario Creado");
        }

        clienteNuevaVersion.NombreCliente = txtNombreCliente.Text;
        clienteNuevaVersion.CUILCUIT = Convert.ToInt64(txtCuilCuit.Text);

        model.ModificarCliente(clienteAModificar, clienteNuevaVersion);
        var item = lsvItinerario.SelectedItems[0];
        item.Text = clienteAModificar.NombreCliente;
        item.SubItems[1].Text = clienteAModificar.CUILCUIT.ToString();
        esconderDatos();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        esconderDatos();
    }

    private void txtBuscarItinerario_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            BuscarItinerario(txtBuscarItinerario.Text);
        }
    }

    public void BuscarItinerario(string idItinerario)
    {
        if (!string.IsNullOrWhiteSpace(idItinerario))
        {
            foreach (ListViewItem item in lsvItinerario.Items)
            {
                string codigo = item.Text;
                string cuit = item.SubItems[0].Text;
                string razonsocial = item.SubItems[1].Text;

                if (codigo.Equals(idItinerario, StringComparison.OrdinalIgnoreCase))
                {
                    lsvItinerario.Items.Clear();
                    lsvItinerario.Items.Add(item);
                }
                if (cuit.Equals(idItinerario, StringComparison.OrdinalIgnoreCase))
                {
                    lsvItinerario.Items.Clear();
                    lsvItinerario.Items.Add(item);
                }
                /*
                if (razonsocial.Equals(idItinerario, StringComparison.OrdinalIgnoreCase))
                {
                    lsvItinerario.Items.Clear();
                    lsvItinerario.Items.Add(item);
                }
                */
            }
        }
        else
        {
            MessageBox.Show("Debe indicar el itinerario a buscar.");
        }
    }

    private void lsvItinerario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
