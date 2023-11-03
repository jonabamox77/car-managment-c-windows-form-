
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ClosedXML.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mantenimientosvehiculos.Choferes;
using mantenimientosvehiculos.mantanimientos;
using mantenimientosvehiculos.Vehiculos;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Drawing;

using Microsoft.Office.Interop.Word;

namespace mantenimientosvehiculos
{
    public partial class Menu : Form
    {

        List<Mantenimiento> listaSolicitudes = new List<Mantenimiento>();
        private List<Chofer> listaChoferes = new List<Chofer>();
        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        public Menu()
        {
            InitializeComponent();
            InicializarComboBoxTipoVehiculo();
            CargarListaVehiculos();


        }

        private void tabPage_vehiculo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tipoVehiculoSeleccionado = comboBox_tipo.SelectedItem.ToString();
            int año = int.Parse(textBox_año.Text);
            string placa = textBox_placa.Text;
            string modelo = textBox_modelo.Text;

            // Crea una instancia del tipo de vehículo correspondiente y asigna los detalles
            Vehiculo vehiculo;


            if (tipoVehiculoSeleccionado == "Automóvil")
            {


                vehiculo = new Automovil
                {
                    Año = año,
                    Placa = placa,
                    Modelo = modelo,
                    TipodeVehiculo = tipoVehiculoSeleccionado,
                    CostoTotal = 0,
                    Puertas = 4
                };

            }
            else if (tipoVehiculoSeleccionado == "Microbús")
            {

                vehiculo = new Micorbus
                {
                    Año = año,
                    Placa = placa,
                    Modelo = modelo,
                    TipodeVehiculo = tipoVehiculoSeleccionado,
                    CostoTotal = 0,


                    CargaMaximaKg = 1000
                };
            }
            else
            {
                // Manejo de error si el tipo de vehículo no es válido
                MessageBox.Show("Tipo de vehículo no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agrega el vehículo a la lista
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new System.Drawing.Bitmap(ofd.FileName);
                    vehiculo.Foto = ofd.FileName;  // Save the path to the Vehiculo object
                }
            }
            listaVehiculos.Add(vehiculo);
            comboBox_autoscombustible.DataSource = null; // Resetear el DataSource
            comboBox_autoscombustible.DataSource = listaVehiculos; // Asumiendo que listaVehiculos es la lista donde guardas tus vehículos
            comboBox_autoscombustible.DisplayMember = "Placa";

            ActualizarComboBoxAutos();

            // Limpia los controles del formulario para futuros ingresos
            //  LimpiarControles();

            MessageBox.Show("Vehículo agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Agrega los vehículos al ListBox
            foreach (var vehiculo in listaVehiculos)
            {
                string infoVehiculo = $"ID: {vehiculo.Id}, ";
                infoVehiculo += $"Año: {vehiculo.Año}, ";
                infoVehiculo += $"Placa: {vehiculo.Placa}, ";
                infoVehiculo += $"Modelo: {vehiculo.Modelo}, ";
                infoVehiculo += $"Tipo: {vehiculo.TipodeVehiculo}";
                infoVehiculo += $"Costototal: {vehiculo.CostoTotal}";

                // Agrega información específica del tipo de vehículo (Automóvil o Microbús)
                if (vehiculo is Automovil automovil)
                {
                    infoVehiculo += $", Puertas: {automovil.Puertas}";
                }
                else if (vehiculo is Micorbus microbus)
                {
                    infoVehiculo += $", Carga Máxima (kg): {microbus.CargaMaximaKg}";
                }

                // Agrega la información del vehículo al ListBox
                listBox1.Items.Add(infoVehiculo);
            }

            // Muestra los vehículos en el ListBox
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add("No hay vehículos registrados.");
            }
        }

        private void InicializarComboBoxTipoVehiculo()
        {
            // Limpia el ComboBox para evitar duplicados si se llama varias veces
            comboBox_tipo.Items.Clear();

            // Agrega los tipos de vehículo disponibles al ComboBox
            comboBox_tipo.Items.Add("Automóvil");
            comboBox_tipo.Items.Add("Microbús");

            // Establece el valor predeterminado o selecciona el primer elemento si es necesario
            comboBox_tipo.SelectedIndex = 0; // Esto seleccionará "Automóvil" por defecto
        }

        private void ActualizarComboBoxAutos()
        {
            comboBox_autos.Items.Clear();


            // Llena el ComboBox de autos con la información de los autos disponibles
            foreach (Vehiculo auto in listaVehiculos)
            {
                comboBox_autos.Items.Add(auto.Placa); // Puedes mostrar el modelo del auto en el ComboBox
            }
        }
        private void comboBox_tipomante_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoMantenimiento tipoSeleccionado = (TipoMantenimiento)comboBox_tipomante.SelectedItem;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            comboBox_tipomante.DataSource = Enum.GetValues(typeof(TipoMantenimiento));
            comboBox_tipocombustible.DataSource = Enum.GetValues(typeof(TipoCombustible));

            // Esta función debería proporcionar la lista de vehículos

            // Configura el ComboBox con la lista de vehículos


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Asigna el origen de datos y el campo para mostrar en el ComboBox
            comboBox_autos.DataSource = listaVehiculos;
            comboBox_autos.DisplayMember = "Placa";

            try
            {
                if (comboBox_autos.SelectedItem is Vehiculo vehiculoSeleccionado)
                {
                    // Verifica si se ha seleccionado un vehículo válido
                    if (vehiculoSeleccionado == null)
                    {
                        MessageBox.Show("Por favor, seleccione un vehículo válido.");
                        return; // Sale del método sin continuar
                    }

                    // Obtén los valores de los TextBox y otros controles
                    int kilometrosActuales;
                    if (!int.TryParse(textBox_kmactuales.Text, out kilometrosActuales))
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para los kilómetros actuales.");
                        return; // Sale del método sin continuar
                    }

                    int kilometrosProximos;
                    if (!int.TryParse(textBox_kmproximos.Text, out kilometrosProximos))
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para los kilómetros próximos.");
                        return; // Sale del método sin continuar
                    }

                    string conductor = comboBox_choferes.SelectedItem?.ToString();

                    // Comprueba si se ha seleccionado un conductor válido
                    if (string.IsNullOrEmpty(conductor))
                    {
                        MessageBox.Show("Por favor, seleccione un conductor válido.");
                        return; // Sale del método sin continuar
                    }

                    string cedulaConductor = ObtenerCedulaConductor(conductor);
                    int numeroSolicitud;
                    if (!int.TryParse(textBox_numsolicitud.Text, out numeroSolicitud))
                    {
                        MessageBox.Show("Por favor, ingrese un número de solicitud válido.");
                        return; // Sale del método sin continuar
                    }

                    double costo;
                    if (!double.TryParse(textBox_costo.Text, out costo))
                    {
                        MessageBox.Show("Por favor, ingrese un costo válido.");
                        return; // Sale del método sin continuar
                    }

                    DateTime fechaVencimiento = dateTimePicker_fechavencimiento.Value;
                    DateTime fechaSolicitud = dateTimePicker_fechasolicitud.Value; // Debes proporcionar la fecha actual o la que corresponda aquí
                    DateTime fechaProximoMantenimiento = dateTimePicker_fechaproximo.Value;

                    // Crea la instancia de Mantenimiento con los valores obtenidos
                    Mantenimiento solicitudMantenimiento = new Mantenimiento(
          vehiculoSeleccionado,
          (TipoMantenimiento)comboBox_tipomante.SelectedIndex,
          kilometrosActuales,
          kilometrosProximos,
          conductor,
          cedulaConductor,
          numeroSolicitud,
          costo,
          fechaVencimiento,
          fechaSolicitud,
          fechaProximoMantenimiento
      );

                    // Agrega la solicitud de mantenimiento a la lista de solicitudes
                    try
                    {
                        listaSolicitudes.Add(solicitudMantenimiento);
                        vehiculoSeleccionado.AgregarGasto(costo);
                        vehiculoSeleccionado.AgregarMantenimiento(solicitudMantenimiento);
                        vehiculoSeleccionado.VerificarAlertaProximoMantenimiento();

                        CargarListaVehiculos();

                        // Limpia los controles después de guardar la solicitud
                        // LimpiarControles();

                        // Opcional: Actualiza el ComboBox de Choferes si es necesario
                        // ActualizarComboBoxChoferes();

                        MessageBox.Show("Solicitud de Mantenimiento guardada correctamente.");

                        // Agrega la información de la solicitud al ListBox
                        string infoSolicitud = $"ID: {solicitudMantenimiento.CedulaConductor}, ";
                        infoSolicitud += $"Fecha: {solicitudMantenimiento.NumeroSolicitud}, ";
                        infoSolicitud += $"Descripción: {solicitudMantenimiento.FechaProximoMantenimiento}";

                        listBox3.Items.Add(infoSolicitud);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar la solicitud: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un vehículo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void button_agregarchofer_Click(object sender, EventArgs e)
        {
            // Obtener datos del chofer desde los TextBox
            string nombre = textBox_nombre.Text;
            string cedula = textBox_cedula.Text;
            string licenciaConducir = textBox_licencia.Text;
            DateTime fechaNacimiento = dateTimePicker_fechanacimiento.Value; // Suponiendo que usas un DateTimePicker

            // Validar que los campos no estén vacíos (puedes agregar más validaciones según tus necesidades)
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(licenciaConducir))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear una instancia de Chofer con los datos obtenidos
            Chofer nuevoChofer = new Chofer
            {
                Nombre = nombre,
                Cedula = cedula,
                LicenciaConducir = licenciaConducir,
                FechaNacimiento = fechaNacimiento
                // Configura otras propiedades del chofer según sea necesario
            };

            // Agregar el nuevo chofer a la lista
            listaChoferes.Add(nuevoChofer);
            listBox2.Items.Add(listaChoferes);

            ActualizarComboBoxChoferes();

            // Puedes mostrar un mensaje o realizar otras acciones aquí
            MessageBox.Show("Chofer agregado correctamente.");

            // Limpia los controles o realiza otras operaciones de limpieza si es necesario
            //  LimpiarControles();
        }
        private void ActualizarComboBoxChoferes()
        {
            comboBox_choferes.Items.Clear();


            // Agrega los choferes de la lista al ComboBox
            foreach (Chofer chofer in listaChoferes)
            {
                comboBox_choferes.Items.Add(chofer.Nombre); // Puedes mostrar el nombre u otra información del chofer
            }
        }
        private string ObtenerCedulaConductor(string nombreConductor)
        {
            // Supongamos que tienes una lista de choferes llamada "listaChoferes" donde cada chofer tiene un nombre y una cédula
            // Puedes buscar el conductor por su nombre en la lista
            Chofer choferEncontrado = listaChoferes.FirstOrDefault(chofer => chofer.Nombre == nombreConductor);

            // Verificar si se encontró el chofer
            if (choferEncontrado != null)
            {
                // Retornar la cédula del conductor encontrado
                return choferEncontrado.Cedula;
            }
            else
            {
                // Manejar el caso en que el conductor no fue encontrado (por ejemplo, lanzar una excepción o retornar un valor por defecto)
                return "Cédula no encontrada"; // Puedes personalizar este mensaje de acuerdo a tus necesidades
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "ListaSolicitudesMantenimiento.docx";
            ExportarListaSolicitudesAExcel(listaSolicitudes, nombreArchivo);

        }
        public static List<Vehiculo> ObtenerListaDeVehiculos()
        {
            // Simulamos una lista de vehículos
            var listaDeVehiculos = new List<Vehiculo>
            {

                // Agrega más vehículos según tus necesidades
            };

            return listaDeVehiculos;
        }

        private void comboBox_autos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ExportarListaSolicitudesAExcel(List<Mantenimiento> listaSolicitudes, string nombreArchivo)
        {
            try
            {

                using (var workbook = new XLWorkbook())
                {

                    var worksheet = workbook.Worksheets.Add("Lista de Solicitudes");

                    // Configurar el estilo del encabezado de las columnas
                    var headerStyle = worksheet.Style;
                    headerStyle.Font.Bold = true;
                    headerStyle.Fill.BackgroundColor = XLColor.LightGray;
                    headerStyle.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Configurar el ancho de las columnas
                    worksheet.Column(1).Width = 15; // Vehículo
                    worksheet.Column(2).Width = 20; // Tipo de Mantenimiento
                    worksheet.Column(3).Width = 15; // Kilómetros Actuales
                    worksheet.Column(4).Width = 15; // Kilómetros Próximos
                    worksheet.Column(5).Width = 20; // Conductor
                    worksheet.Column(6).Width = 15; // Cédula del Conductor
                    worksheet.Column(7).Width = 15; // Número de Solicitud
                    worksheet.Column(8).Width = 15; // Costo
                    worksheet.Column(9).Width = 20; // Fecha de Vencimiento
                    worksheet.Column(10).Width = 20; // Fecha de Solicitud
                    worksheet.Column(11).Width = 20; // Fecha de Próximo Mantenimiento

                    // Agregar encabezados
                    worksheet.Cell(1, 1).Value = "Vehículo";
                    worksheet.Cell(1, 2).Value = "Tipo de Mantenimiento";
                    worksheet.Cell(1, 3).Value = "Kilómetros Actuales";
                    worksheet.Cell(1, 4).Value = "Kilómetros Próximos";
                    worksheet.Cell(1, 5).Value = "Conductor";
                    worksheet.Cell(1, 6).Value = "Cédula del Conductor";
                    worksheet.Cell(1, 7).Value = "Número de Solicitud";
                    worksheet.Cell(1, 8).Value = "Costo";
                    worksheet.Cell(1, 9).Value = "Fecha de Vencimiento";
                    worksheet.Cell(1, 10).Value = "Fecha de Solicitud";
                    worksheet.Cell(1, 11).Value = "Fecha de Próximo Mantenimiento";

                    int rowIndex = 2; // Comenzamos en la segunda fila, ya que la primera fila es para el encabezado
                    foreach (var solicitud in listaSolicitudes)
                    {
                        // Configurar estilos para las celdas de datos si es necesario
                        var dataStyle = worksheet.Cell(rowIndex, 1).Style;
                        dataStyle.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                        worksheet.Cell(rowIndex, 1).Value = solicitud.VehiculoSeleccionado.Placa;
                        worksheet.Cell(rowIndex, 2).Value = solicitud.TipoMantenimiento.ToString();
                        worksheet.Cell(rowIndex, 3).Value = solicitud.KilometrosActuales;
                        worksheet.Cell(rowIndex, 4).Value = solicitud.KilometrosProximos;
                        worksheet.Cell(rowIndex, 5).Value = solicitud.Conductor;
                        worksheet.Cell(rowIndex, 6).Value = solicitud.CedulaConductor;
                        worksheet.Cell(rowIndex, 7).Value = solicitud.NumeroSolicitud;
                        worksheet.Cell(rowIndex, 8).Value = solicitud.Costo;
                        worksheet.Cell(rowIndex, 9).Value = solicitud.FechaVencimiento.ToString("dd/MM/yyyy");
                        worksheet.Cell(rowIndex, 10).Value = solicitud.FechaSolicitud.ToString("dd/MM/yyyy");
                        worksheet.Cell(rowIndex, 11).Value = solicitud.FechaProximoMantenimiento.ToString("dd/MM/yyyy");

                        rowIndex++;
                    }

                    // Agregar espacio para firmas
                    worksheet.Range($"A{rowIndex}:K{rowIndex + 2}").Merge();
                    var signatureStyle = worksheet.Cell(rowIndex, 1).Style;
                    signatureStyle.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    signatureStyle.Font.Bold = true;
                    worksheet.Cell(rowIndex, 1).Value = "Firma De Solicitante : __________________________   ";

                    // Aumenta el valor de rowIndex para apuntar a la siguiente fila
                    rowIndex += 3;

                    // Agrega la segunda fila de firma
                    worksheet.Range($"A{rowIndex}:K{rowIndex + 2}").Merge();
                    signatureStyle = worksheet.Cell(rowIndex, 1).Style;
                    signatureStyle.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    signatureStyle.Font.Bold = true;
                    worksheet.Cell(rowIndex, 1).Value = "Firma De Autorizacion : __________________________  ";
                    // Guardar el archivo de Excel en disco

                    workbook.SaveAs(@"C:\Mante\Libro1mantenimientos.xlsx");
                }

                MessageBox.Show("Solicitud de Mantenimiento guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la solicitud: " + ex.Message);
            }
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            if (fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }

            return value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); // Limpia el contenido previo del ListBox

            // Agrega los choferes al ListBox
            foreach (var chofer in listaChoferes)
            {
                // Construye una cadena con información sobre el chofer
                string infoChofer = $"Nombre: {chofer.Nombre}, ";
                infoChofer += $"Cédula: {chofer.Cedula}, ";
                infoChofer += $"Licencia: {chofer.LicenciaConducir}, ";
                infoChofer += $"Fecha de Nacimiento: {chofer.FechaNacimiento}";

                // Agrega la información del chofer al ListBox
                listBox2.Items.Add(infoChofer);
            }

            // Muestra un mensaje si no hay choferes registrados
            if (listBox2.Items.Count == 0)
            {
                listBox2.Items.Add("No hay choferes registrados.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            // Agrega las solicitudes de mantenimiento al ListBox
            foreach (var solicitud in listaSolicitudes)
            {
                // Construye una cadena con información sobre la solicitud
                string infoSolicitud = $"ID: {solicitud.NumeroSolicitud}, ";
                infoSolicitud += $"FechaSolicitud: {solicitud.FechaSolicitud}, ";
                infoSolicitud += $"Nombre: {solicitud.Conductor}";
                infoSolicitud += $"Cedula: {solicitud.CedulaConductor}";
                infoSolicitud += $"Fechaproximomantenimiento: {solicitud.FechaProximoMantenimiento}";
                infoSolicitud += $"Vehiculo: {solicitud.VehiculoSeleccionado.Placa}";
                infoSolicitud += $"Tipomantenimiento : {solicitud.TipoMantenimiento}";
                // Agrega la información de la solicitud al ListBox
                listBox3.Items.Add(infoSolicitud);
            }

            // Muestra un mensaje si no hay solicitudes de mantenimiento registradas
            if (listBox3.Items.Count == 0)
            {
                listBox3.Items.Add("No hay solicitudes de mantenimiento registradas.");
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();

            // Obtiene el vehículo seleccionado del ComboBox
            if (comboBox_coches.SelectedItem is Vehiculo vehiculoSeleccionado)
            {
                // Accede a la lista de mantenimientos del vehículo
                foreach (Mantenimiento mantenimiento in vehiculoSeleccionado.Mantenimientos)
                {
                    listBox4.Items.Add($"Tipo de Mantenimiento: {mantenimiento.TipoMantenimiento}, Fecha de Proximo Mantenimiento: {mantenimiento.FechaProximoMantenimiento}");
                }
                vehiculoSeleccionado.VerificarAlertaProximoMantenimiento();
            }
            else
            {
                listBox4.Items.Add("No se ha seleccionado un vehículo.");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarListaVehiculos()
        {
            comboBox_coches.DataSource = null; // Limpia el ComboBox
            comboBox_coches.DataSource = listaVehiculos;
            comboBox_coches.DisplayMember = "Placa"; // Suponiendo que "Placa" es la propiedad que deseas mostrar en el ComboBox
        }

        private void comboBox_coches_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();

            // Obtiene el vehículo seleccionado del ComboBox
            if (comboBox_coches.SelectedItem is Vehiculo vehiculoSeleccionado)
            {
                // Accede a la lista de mantenimientos del vehículo
                foreach (Mantenimiento mantenimiento in vehiculoSeleccionado.Mantenimientos)
                {
                    listBox4.Items.Add($"Tipo de Mantenimiento: {mantenimiento.TipoMantenimiento}, Fecha de Proximo Mantenimiento: {mantenimiento.FechaProximoMantenimiento}");
                }
            }
            else
            {
                listBox4.Items.Add("No se ha seleccionado un vehículo.");
            }
        }

        private void tabPage_registrarchofer_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button_agregarcombustible_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_autoscombustible.SelectedItem is Vehiculo vehiculoSeleccionado)
                {
                    double litros = double.Parse(textBox_litros.Text);
                    double costoPorLitro = double.Parse(textBox_costoporlitro.Text);
                    TipoCombustible tipoCombustible = (TipoCombustible)comboBox_tipocombustible.SelectedIndex;
                    string estacionServicio = textBox_estacionservicio.Text;
                    double kilometrajeActual = double.Parse(textBox_kmactualcombus.Text);

                    RegistroCombustible nuevoRegistro = new RegistroCombustible
                    {
                        FechaAbastecimiento = DateTime.Now,
                        CantidadLitros = litros,
                        CostoPorLitro = costoPorLitro,
                        Tipo = tipoCombustible,
                        EstacionServicio = estacionServicio,
                        KilometrajeActual = kilometrajeActual
                    };

                    vehiculoSeleccionado.AgregarRegistroCombustible(nuevoRegistro);
                    MessageBox.Show("Registro de combustible agregado correctamente.");

                    // Agregando el registro al ListBox
                    string registroString = $"Fecha: {nuevoRegistro.FechaAbastecimiento.ToShortDateString()}, Litros: {nuevoRegistro.CantidadLitros}, Costo/Litro: {nuevoRegistro.CostoPorLitro}, Tipo: {nuevoRegistro.Tipo}, Estación: {nuevoRegistro.EstacionServicio}, Kilometraje: {nuevoRegistro.KilometrajeActual}";
                    listBox_combustible.Items.Add(registroString);

                    // Opcional: Limpia los controles después de agregar el registro
                    textBox_litros.Clear();
                    textBox_costoporlitro.Clear();
                    textBox_estacionservicio.Clear();
                    textBox_kmactualcombus.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un vehículo válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
        }

        private void comboBox_autoscombustible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedInfo = listBox1.SelectedItem.ToString();

                // Buscamos el vehículo en la lista de vehículos basándonos en su ID.
                var selectedVehicle = listaVehiculos.FirstOrDefault(v => selectedInfo.Contains($"ID: {v.Id},"));

                if (selectedVehicle != null && !string.IsNullOrEmpty(selectedVehicle.Foto) && File.Exists(selectedVehicle.Foto))
                {
                    // Cargamos la imagen del vehículo en el PictureBox desde la ruta especificada en la propiedad Foto.
                    pictureBox1.Image = Image.FromFile(selectedVehicle.Foto);
                }
                else
                {
                    pictureBox1.Image = null; // Si no hay imagen, limpiamos el PictureBox.
                }
            }
        }
    }

}

