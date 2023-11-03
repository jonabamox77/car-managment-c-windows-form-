namespace mantenimientosvehiculos
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            tabControl1 = new TabControl();
            tabPage_vehiculo = new TabPage();
            pictureBox1 = new PictureBox();
            comboBox_tipo = new ComboBox();
            listBox1 = new ListBox();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            textBox_año = new TextBox();
            textBox_modelo = new TextBox();
            textBox_placa = new TextBox();
            textBox_id = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage_registrarchofer = new TabPage();
            listBox2 = new ListBox();
            button5 = new Button();
            button_agregarchofer = new Button();
            textBox3 = new TextBox();
            label20 = new Label();
            dateTimePicker_fechanacimiento = new DateTimePicker();
            label19 = new Label();
            textBox_licencia = new TextBox();
            label18 = new Label();
            textBox_cedula = new TextBox();
            label17 = new Label();
            textBox_nombre = new TextBox();
            label16 = new Label();
            tabPage1 = new TabPage();
            textBox_kmactuales = new TextBox();
            comboBox_autos = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            dateTimePicker_fechavencimiento = new DateTimePicker();
            dateTimePicker_fechaproximo = new DateTimePicker();
            dateTimePicker_fechasolicitud = new DateTimePicker();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            textBox_costo = new TextBox();
            label12 = new Label();
            textBox_numsolicitud = new TextBox();
            label11 = new Label();
            label10 = new Label();
            comboBox_choferes = new ComboBox();
            textBox_kmproximos = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            comboBox_tipomante = new ComboBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            listBox3 = new ListBox();
            button6 = new Button();
            tabPage3 = new TabPage();
            Alertas = new GroupBox();
            label21 = new Label();
            comboBox_coches = new ComboBox();
            listBox4 = new ListBox();
            button7 = new Button();
            tabPage4 = new TabPage();
            groupBox3 = new GroupBox();
            button_mostrar = new Button();
            listBox_combustible = new ListBox();
            button_agregarcombustible = new Button();
            textBox_kmactualcombus = new TextBox();
            label27 = new Label();
            textBox_estacionservicio = new TextBox();
            label26 = new Label();
            comboBox_tipocombustible = new ComboBox();
            label25 = new Label();
            textBox_costoporlitro = new TextBox();
            label24 = new Label();
            textBox_litros = new TextBox();
            label23 = new Label();
            comboBox_autoscombustible = new ComboBox();
            label22 = new Label();
            tabControl1.SuspendLayout();
            tabPage_vehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage_registrarchofer.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            Alertas.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_vehiculo);
            tabControl1.Controls.Add(tabPage_registrarchofer);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(-10, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(765, 368);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage_vehiculo
            // 
            tabPage_vehiculo.BackColor = Color.DimGray;
            tabPage_vehiculo.BackgroundImage = (Image)resources.GetObject("tabPage_vehiculo.BackgroundImage");
            tabPage_vehiculo.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage_vehiculo.Controls.Add(pictureBox1);
            tabPage_vehiculo.Controls.Add(comboBox_tipo);
            tabPage_vehiculo.Controls.Add(listBox1);
            tabPage_vehiculo.Controls.Add(button2);
            tabPage_vehiculo.Controls.Add(button1);
            tabPage_vehiculo.Controls.Add(label7);
            tabPage_vehiculo.Controls.Add(textBox_año);
            tabPage_vehiculo.Controls.Add(textBox_modelo);
            tabPage_vehiculo.Controls.Add(textBox_placa);
            tabPage_vehiculo.Controls.Add(textBox_id);
            tabPage_vehiculo.Controls.Add(label4);
            tabPage_vehiculo.Controls.Add(label3);
            tabPage_vehiculo.Controls.Add(label2);
            tabPage_vehiculo.Controls.Add(label1);
            tabPage_vehiculo.Location = new Point(4, 24);
            tabPage_vehiculo.Name = "tabPage_vehiculo";
            tabPage_vehiculo.Padding = new Padding(3);
            tabPage_vehiculo.Size = new Size(757, 340);
            tabPage_vehiculo.TabIndex = 0;
            tabPage_vehiculo.Text = "Vehiculos";
            tabPage_vehiculo.Click += tabPage_vehiculo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(48, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // comboBox_tipo
            // 
            comboBox_tipo.FormattingEnabled = true;
            comboBox_tipo.Location = new Point(120, 161);
            comboBox_tipo.Name = "comboBox_tipo";
            comboBox_tipo.Size = new Size(121, 23);
            comboBox_tipo.TabIndex = 16;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Lime;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalExtent = 800;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(277, 90);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(307, 184);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(361, 21);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "mostrar vehuculos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(262, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 207);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 12;
            label7.Text = "año:";
            // 
            // textBox_año
            // 
            textBox_año.Location = new Point(120, 204);
            textBox_año.Name = "textBox_año";
            textBox_año.Size = new Size(100, 23);
            textBox_año.TabIndex = 11;
            // 
            // textBox_modelo
            // 
            textBox_modelo.Location = new Point(120, 118);
            textBox_modelo.Name = "textBox_modelo";
            textBox_modelo.Size = new Size(100, 23);
            textBox_modelo.TabIndex = 8;
            // 
            // textBox_placa
            // 
            textBox_placa.Location = new Point(120, 78);
            textBox_placa.Name = "textBox_placa";
            textBox_placa.Size = new Size(100, 23);
            textBox_placa.TabIndex = 7;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(120, 39);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(100, 23);
            textBox_id.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 169);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "tipo de vehiculo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 126);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "modelo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 81);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "placa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 39);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // tabPage_registrarchofer
            // 
            tabPage_registrarchofer.BackColor = Color.IndianRed;
            tabPage_registrarchofer.BackgroundImage = (Image)resources.GetObject("tabPage_registrarchofer.BackgroundImage");
            tabPage_registrarchofer.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage_registrarchofer.Controls.Add(listBox2);
            tabPage_registrarchofer.Controls.Add(button5);
            tabPage_registrarchofer.Controls.Add(button_agregarchofer);
            tabPage_registrarchofer.Controls.Add(textBox3);
            tabPage_registrarchofer.Controls.Add(label20);
            tabPage_registrarchofer.Controls.Add(dateTimePicker_fechanacimiento);
            tabPage_registrarchofer.Controls.Add(label19);
            tabPage_registrarchofer.Controls.Add(textBox_licencia);
            tabPage_registrarchofer.Controls.Add(label18);
            tabPage_registrarchofer.Controls.Add(textBox_cedula);
            tabPage_registrarchofer.Controls.Add(label17);
            tabPage_registrarchofer.Controls.Add(textBox_nombre);
            tabPage_registrarchofer.Controls.Add(label16);
            tabPage_registrarchofer.Location = new Point(4, 24);
            tabPage_registrarchofer.Name = "tabPage_registrarchofer";
            tabPage_registrarchofer.Padding = new Padding(3);
            tabPage_registrarchofer.Size = new Size(757, 340);
            tabPage_registrarchofer.TabIndex = 1;
            tabPage_registrarchofer.Text = "choferes";
            tabPage_registrarchofer.Click += tabPage_registrarchofer_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(128, 255, 128);
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalExtent = 1000;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(376, 87);
            listBox2.Name = "listBox2";
            listBox2.ScrollAlwaysVisible = true;
            listBox2.Size = new Size(357, 199);
            listBox2.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new Point(468, 22);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 11;
            button5.Text = "ver";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button_agregarchofer
            // 
            button_agregarchofer.Location = new Point(351, 22);
            button_agregarchofer.Name = "button_agregarchofer";
            button_agregarchofer.Size = new Size(75, 23);
            button_agregarchofer.TabIndex = 10;
            button_agregarchofer.Text = "agregar";
            button_agregarchofer.UseVisualStyleBackColor = true;
            button_agregarchofer.Click += button_agregarchofer_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 272);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(38, 275);
            label20.Name = "label20";
            label20.Size = new Size(99, 15);
            label20.TabIndex = 8;
            label20.Text = "licencia categroia";
            // 
            // dateTimePicker_fechanacimiento
            // 
            dateTimePicker_fechanacimiento.Location = new Point(148, 225);
            dateTimePicker_fechanacimiento.Name = "dateTimePicker_fechanacimiento";
            dateTimePicker_fechanacimiento.Size = new Size(200, 23);
            dateTimePicker_fechanacimiento.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(35, 231);
            label19.Name = "label19";
            label19.Size = new Size(102, 15);
            label19.TabIndex = 6;
            label19.Text = "fecha nacimento :";
            // 
            // textBox_licencia
            // 
            textBox_licencia.Location = new Point(148, 163);
            textBox_licencia.Name = "textBox_licencia";
            textBox_licencia.Size = new Size(100, 23);
            textBox_licencia.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(37, 171);
            label18.Name = "label18";
            label18.Size = new Size(100, 15);
            label18.TabIndex = 4;
            label18.Text = "licencia conducir:";
            // 
            // textBox_cedula
            // 
            textBox_cedula.Location = new Point(148, 103);
            textBox_cedula.Name = "textBox_cedula";
            textBox_cedula.Size = new Size(100, 23);
            textBox_cedula.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(67, 111);
            label17.Name = "label17";
            label17.Size = new Size(45, 15);
            label17.TabIndex = 2;
            label17.Text = "cedula:";
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(148, 51);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(100, 23);
            textBox_nombre.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(59, 59);
            label16.Name = "label16";
            label16.Size = new Size(52, 15);
            label16.TabIndex = 0;
            label16.Text = "nombre:";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.IndianRed;
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(textBox_kmactuales);
            tabPage1.Controls.Add(comboBox_autos);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(dateTimePicker_fechavencimiento);
            tabPage1.Controls.Add(dateTimePicker_fechaproximo);
            tabPage1.Controls.Add(dateTimePicker_fechasolicitud);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(textBox_costo);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(textBox_numsolicitud);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(comboBox_choferes);
            tabPage1.Controls.Add(textBox_kmproximos);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(comboBox_tipomante);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(757, 340);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "mantenimiento ";
            tabPage1.Click += tabPage1_Click;
            // 
            // textBox_kmactuales
            // 
            textBox_kmactuales.Location = new Point(151, 71);
            textBox_kmactuales.Name = "textBox_kmactuales";
            textBox_kmactuales.Size = new Size(130, 23);
            textBox_kmactuales.TabIndex = 25;
            // 
            // comboBox_autos
            // 
            comboBox_autos.FormattingEnabled = true;
            comboBox_autos.Location = new Point(151, 109);
            comboBox_autos.Name = "comboBox_autos";
            comboBox_autos.Size = new Size(150, 23);
            comboBox_autos.TabIndex = 24;
            comboBox_autos.SelectedIndexChanged += comboBox_autos_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(282, 277);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 23;
            button4.Text = "guardar solictud";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(64, 271);
            button3.Name = "button3";
            button3.Size = new Size(168, 35);
            button3.TabIndex = 22;
            button3.Text = "imprimir solicitud";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker_fechavencimiento
            // 
            dateTimePicker_fechavencimiento.Location = new Point(460, 169);
            dateTimePicker_fechavencimiento.Name = "dateTimePicker_fechavencimiento";
            dateTimePicker_fechavencimiento.Size = new Size(200, 23);
            dateTimePicker_fechavencimiento.TabIndex = 21;
            // 
            // dateTimePicker_fechaproximo
            // 
            dateTimePicker_fechaproximo.Location = new Point(473, 206);
            dateTimePicker_fechaproximo.Name = "dateTimePicker_fechaproximo";
            dateTimePicker_fechaproximo.Size = new Size(200, 23);
            dateTimePicker_fechaproximo.TabIndex = 20;
            // 
            // dateTimePicker_fechasolicitud
            // 
            dateTimePicker_fechasolicitud.Location = new Point(401, 18);
            dateTimePicker_fechasolicitud.Name = "dateTimePicker_fechasolicitud";
            dateTimePicker_fechasolicitud.Size = new Size(211, 23);
            dateTimePicker_fechasolicitud.TabIndex = 19;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(295, 24);
            label15.Name = "label15";
            label15.Size = new Size(87, 15);
            label15.TabIndex = 18;
            label15.Text = "fecha solicitud:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(295, 212);
            label14.Name = "label14";
            label14.Size = new Size(172, 15);
            label14.TabIndex = 16;
            label14.Text = "fecha proximo mantenimiento ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(334, 169);
            label13.Name = "label13";
            label13.Size = new Size(108, 15);
            label13.TabIndex = 14;
            label13.Text = "fecha vencimiento ";
            // 
            // textBox_costo
            // 
            textBox_costo.Location = new Point(491, 119);
            textBox_costo.Name = "textBox_costo";
            textBox_costo.Size = new Size(100, 23);
            textBox_costo.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(372, 127);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 12;
            label12.Text = "costo :";
            // 
            // textBox_numsolicitud
            // 
            textBox_numsolicitud.Location = new Point(491, 76);
            textBox_numsolicitud.Name = "textBox_numsolicitud";
            textBox_numsolicitud.Size = new Size(100, 23);
            textBox_numsolicitud.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(357, 79);
            label11.Name = "label11";
            label11.Size = new Size(110, 15);
            label11.TabIndex = 10;
            label11.Text = "numero de solictud";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(64, 220);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 9;
            label10.Text = "conductor";
            // 
            // comboBox_choferes
            // 
            comboBox_choferes.FormattingEnabled = true;
            comboBox_choferes.Location = new Point(160, 212);
            comboBox_choferes.Name = "comboBox_choferes";
            comboBox_choferes.Size = new Size(121, 23);
            comboBox_choferes.TabIndex = 8;
            // 
            // textBox_kmproximos
            // 
            textBox_kmproximos.Location = new Point(151, 161);
            textBox_kmproximos.Name = "textBox_kmproximos";
            textBox_kmproximos.Size = new Size(130, 23);
            textBox_kmproximos.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 169);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 6;
            label9.Text = "KilometrosProximos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 119);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 4;
            label8.Text = "autos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 71);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 2;
            label6.Text = "km actuales:";
            // 
            // comboBox_tipomante
            // 
            comboBox_tipomante.FormattingEnabled = true;
            comboBox_tipomante.Location = new Point(151, 29);
            comboBox_tipomante.Name = "comboBox_tipomante";
            comboBox_tipomante.Size = new Size(121, 23);
            comboBox_tipomante.TabIndex = 1;
            comboBox_tipomante.SelectedIndexChanged += comboBox_tipomante_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 32);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 0;
            label5.Text = "tipo de mantemiento :";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(757, 340);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Solicitudes Mantenimiento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(listBox3);
            groupBox1.Controls.Add(button6);
            groupBox1.Location = new Point(74, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 274);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.Lime;
            listBox3.FormattingEnabled = true;
            listBox3.HorizontalExtent = 1000;
            listBox3.HorizontalScrollbar = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(69, 98);
            listBox3.Name = "listBox3";
            listBox3.ScrollAlwaysVisible = true;
            listBox3.Size = new Size(529, 154);
            listBox3.TabIndex = 1;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.Location = new Point(31, 52);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 0;
            button6.Text = "ver ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(Alertas);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(757, 340);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "Alertas Proximos Mantenimentos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Alertas
            // 
            Alertas.BackColor = Color.Olive;
            Alertas.BackgroundImageLayout = ImageLayout.Stretch;
            Alertas.Controls.Add(label21);
            Alertas.Controls.Add(comboBox_coches);
            Alertas.Controls.Add(listBox4);
            Alertas.Controls.Add(button7);
            Alertas.ForeColor = Color.FromArgb(192, 0, 0);
            Alertas.Location = new Point(76, 64);
            Alertas.Name = "Alertas";
            Alertas.Size = new Size(549, 223);
            Alertas.TabIndex = 0;
            Alertas.TabStop = false;
            Alertas.Text = "Alertas";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.IndianRed;
            label21.ForeColor = Color.Lime;
            label21.Location = new Point(51, 107);
            label21.Name = "label21";
            label21.Size = new Size(34, 15);
            label21.TabIndex = 6;
            label21.Text = "auto:";
            // 
            // comboBox_coches
            // 
            comboBox_coches.FormattingEnabled = true;
            comboBox_coches.Location = new Point(24, 144);
            comboBox_coches.Name = "comboBox_coches";
            comboBox_coches.Size = new Size(121, 23);
            comboBox_coches.TabIndex = 5;
            comboBox_coches.SelectedIndexChanged += comboBox_coches_SelectedIndexChanged;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.HorizontalExtent = 100;
            listBox4.HorizontalScrollbar = true;
            listBox4.IntegralHeight = false;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(185, 34);
            listBox4.MultiColumn = true;
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(331, 169);
            listBox4.TabIndex = 4;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.Location = new Point(24, 33);
            button7.Name = "button7";
            button7.Size = new Size(124, 37);
            button7.TabIndex = 3;
            button7.Text = "Alertas";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.BackgroundImageLayout = ImageLayout.Center;
            tabPage4.Controls.Add(groupBox3);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(757, 340);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "Registro Combustible";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox3.Controls.Add(button_mostrar);
            groupBox3.Controls.Add(listBox_combustible);
            groupBox3.Controls.Add(button_agregarcombustible);
            groupBox3.Controls.Add(textBox_kmactualcombus);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(textBox_estacionservicio);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(comboBox_tipocombustible);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(textBox_costoporlitro);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(textBox_litros);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(comboBox_autoscombustible);
            groupBox3.Controls.Add(label22);
            groupBox3.ForeColor = Color.Lime;
            groupBox3.Location = new Point(47, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(667, 262);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Combustible";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button_mostrar
            // 
            button_mostrar.Location = new Point(461, 22);
            button_mostrar.Name = "button_mostrar";
            button_mostrar.Size = new Size(75, 23);
            button_mostrar.TabIndex = 14;
            button_mostrar.Text = "Mostar";
            button_mostrar.UseVisualStyleBackColor = true;
            // 
            // listBox_combustible
            // 
            listBox_combustible.FormattingEnabled = true;
            listBox_combustible.HorizontalExtent = 1000;
            listBox_combustible.HorizontalScrollbar = true;
            listBox_combustible.ItemHeight = 15;
            listBox_combustible.Location = new Point(316, 77);
            listBox_combustible.Name = "listBox_combustible";
            listBox_combustible.ScrollAlwaysVisible = true;
            listBox_combustible.Size = new Size(329, 169);
            listBox_combustible.TabIndex = 13;
            // 
            // button_agregarcombustible
            // 
            button_agregarcombustible.Location = new Point(346, 22);
            button_agregarcombustible.Name = "button_agregarcombustible";
            button_agregarcombustible.Size = new Size(75, 23);
            button_agregarcombustible.TabIndex = 12;
            button_agregarcombustible.Text = "agregar registro";
            button_agregarcombustible.UseVisualStyleBackColor = true;
            button_agregarcombustible.Click += button_agregarcombustible_Click;
            // 
            // textBox_kmactualcombus
            // 
            textBox_kmactualcombus.Location = new Point(146, 224);
            textBox_kmactualcombus.Name = "textBox_kmactualcombus";
            textBox_kmactualcombus.Size = new Size(136, 23);
            textBox_kmactualcombus.TabIndex = 11;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(44, 232);
            label27.Name = "label27";
            label27.Size = new Size(59, 15);
            label27.TabIndex = 10;
            label27.Text = "km actual";
            // 
            // textBox_estacionservicio
            // 
            textBox_estacionservicio.Location = new Point(146, 193);
            textBox_estacionservicio.Name = "textBox_estacionservicio";
            textBox_estacionservicio.Size = new Size(136, 23);
            textBox_estacionservicio.TabIndex = 9;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(6, 201);
            label26.Name = "label26";
            label26.Size = new Size(113, 15);
            label26.TabIndex = 8;
            label26.Text = "estacion de servicio:";
            // 
            // comboBox_tipocombustible
            // 
            comboBox_tipocombustible.FormattingEnabled = true;
            comboBox_tipocombustible.Location = new Point(142, 154);
            comboBox_tipocombustible.Name = "comboBox_tipocombustible";
            comboBox_tipocombustible.Size = new Size(140, 23);
            comboBox_tipocombustible.TabIndex = 7;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(6, 162);
            label25.Name = "label25";
            label25.Size = new Size(113, 15);
            label25.TabIndex = 6;
            label25.Text = "tipo de combustible";
            // 
            // textBox_costoporlitro
            // 
            textBox_costoporlitro.Location = new Point(150, 112);
            textBox_costoporlitro.Name = "textBox_costoporlitro";
            textBox_costoporlitro.Size = new Size(132, 23);
            textBox_costoporlitro.TabIndex = 5;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(15, 120);
            label24.Name = "label24";
            label24.Size = new Size(84, 15);
            label24.TabIndex = 4;
            label24.Text = "costo por litro:";
            // 
            // textBox_litros
            // 
            textBox_litros.Location = new Point(150, 75);
            textBox_litros.Name = "textBox_litros";
            textBox_litros.Size = new Size(132, 23);
            textBox_litros.TabIndex = 3;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(52, 83);
            label23.Name = "label23";
            label23.Size = new Size(36, 15);
            label23.TabIndex = 2;
            label23.Text = "litros:";
            // 
            // comboBox_autoscombustible
            // 
            comboBox_autoscombustible.FormattingEnabled = true;
            comboBox_autoscombustible.Location = new Point(142, 31);
            comboBox_autoscombustible.Name = "comboBox_autoscombustible";
            comboBox_autoscombustible.Size = new Size(132, 23);
            comboBox_autoscombustible.TabIndex = 1;
            comboBox_autoscombustible.SelectedIndexChanged += comboBox_autoscombustible_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(52, 34);
            label22.Name = "label22";
            label22.Size = new Size(36, 15);
            label22.TabIndex = 0;
            label22.Text = "autos";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 363);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Sistema Mantenimiento Vehiculos";
            Load += Menu_Load;
            tabControl1.ResumeLayout(false);
            tabPage_vehiculo.ResumeLayout(false);
            tabPage_vehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage_registrarchofer.ResumeLayout(false);
            tabPage_registrarchofer.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            Alertas.ResumeLayout(false);
            Alertas.PerformLayout();
            tabPage4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage_vehiculo;
        private TextBox textBox_modelo;
        private TextBox textBox_placa;
        private TextBox textBox_id;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage_registrarchofer;
        private TabPage tabPage1;
        private Label label7;
        private TextBox textBox_año;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private ComboBox comboBox_tipo;
        private Label label6;
        private ComboBox comboBox_tipomante;
        private Label label5;
        private Label label8;
        private Label label9;
        private TextBox textBox_kmproximos;
        private Label label10;
        private ComboBox comboBox_choferes;
        private TextBox textBox_numsolicitud;
        private Label label11;
        private TextBox textBox_costo;
        private Label label12;
        private Label label13;
        private Label label14;
        private DateTimePicker dateTimePicker_fechavencimiento;
        private DateTimePicker dateTimePicker_fechaproximo;
        private DateTimePicker dateTimePicker_fechasolicitud;
        private Label label15;
        private Button button4;
        private Button button3;
        private Label label16;
        private TextBox textBox_nombre;
        private TextBox textBox_cedula;
        private Label label17;
        private TextBox textBox_licencia;
        private Label label18;
        private TextBox textBox3;
        private Label label20;
        private DateTimePicker dateTimePicker_fechanacimiento;
        private Label label19;
        private Button button_agregarchofer;
        private TextBox textBox_kmactuales;
        private ComboBox comboBox_autos;
        private ListBox listBox2;
        private Button button5;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private ListBox listBox3;
        private Button button6;
        private TabPage tabPage3;
        private GroupBox groupBox2;
        private Button button7;
        private ListBox listBox4;
        private Label label21;
        private ComboBox comboBox_coches;
        private GroupBox Alertas;
        private TabPage tabPage4;
        private GroupBox groupBox3;
        private ComboBox comboBox_tipocombustible;
        private Label label25;
        private TextBox textBox_costoporlitro;
        private Label label24;
        private TextBox textBox_litros;
        private Label label23;
        private ComboBox comboBox_autoscombustible;
        private Label label22;
        private TextBox textBox_estacionservicio;
        private Label label26;
        private Button button_mostrar;
        private ListBox listBox_combustible;
        private Button button_agregarcombustible;
        private TextBox textBox_kmactualcombus;
        private Label label27;
        private PictureBox pictureBox1;
    }
}