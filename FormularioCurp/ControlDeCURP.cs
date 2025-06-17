using System.Text.RegularExpressions;

namespace FormularioCurp
{
    public partial class ControlDeCURP : UserControl
    {
        public ControlDeCURP()
        {
            InitializeComponent();
            cbEntidadF.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;
        }



        // Variables
        private string curp { get; set; } = string.Empty;
        private string nombre { get; set; } = string.Empty;
        private string apellidoP { get; set; } = string.Empty;
        private string apellidoM { get; set; } = string.Empty;
        private string fechaNac { get; set; } = string.Empty;
        private string sexo { get; set; } = string.Empty;
        private string entidad { get; set; } = string.Empty;
        private bool valNombre { get; set; } = false;
        private bool valApellidoP { get; set; } = false;
        private bool valApellidoM { get; set; } = false;
        private bool valFechaNac { get; set; } = false;
        private bool valCurpPrimeraFase() => valNombre && valApellidoP && valApellidoM && valFechaNac;


        // Evento lanzado
        public event EventHandler<string>? CurpGenerada;

        //Metodos

        private void SeleccionarTodo_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
                txt.SelectAll();
        }

        private void SeleccionarTodo_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is TextBox txt)
                txt.SelectAll();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[A-Za-zÑñÁÉÍÓÚáéíóú ]{3,}$");
            Match match = regex.Match(txtNombre.Text.Trim());
            if (match.Success)
            {
                nombre = txtNombre.Text.Trim();
                valNombre = true;
                lblNombre.Text = "El nombre es valido :D";
            }
            else
            {
                nombre = "";
                valNombre = false;
                lblNombre.Text = "El nombre debe tener al menos 3 letras";
            }
            actualizaCurpLabel();
        }
        private void txtApellidoP_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[A-Za-zÑñÁÉÍÓÚáéíóú ]{3,}$");
            Match match = regex.Match(txtApellidoP.Text.Trim());
            if (match.Success)
            {
                apellidoP = txtApellidoP.Text.Trim();
                valApellidoP = true;
                lblApellidoP.Text = "El apellido es valido";
            }
            else
            {
                apellidoP = "";
                valApellidoP = false;
                lblApellidoP.Text = "El apellido debe tener al menos 3 letras";
            }
            actualizaCurpLabel();
        }
        private void txtApellidoM_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[A-Za-zÑñÁÉÍÓÚáéíóú ]{3,}$");
            Match match = regex.Match(txtApellidoM.Text.Trim());
            if (match.Success)
            {
                apellidoM = txtApellidoM.Text.Trim();
                valApellidoM = true;
                lblApellidoM.Text = "El apellido es valido";
            }
            else
            {
                apellidoM = "";
                valApellidoM = false;
                lblApellidoM.Text = "El apellido debe tener al menos 3 letras";
            }
            actualizaCurpLabel();
        }
        private void txtFechaNac_TextChanged(object sender, EventArgs e)
        {
            string fechaTexto = txtFechaNac.Text.Trim();
            if (DateTime.TryParseExact(fechaTexto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
            {
                fechaNac = fechaTexto;
                valFechaNac = true;
                lblFechaNac.Text = "La fecha es válida";
            }
            else
            {
                fechaNac = "";
                valFechaNac = false;
                lblFechaNac.Text = "La fecha debe tener el formato DD/MM/AAAA y ser una fecha válida";
            }
            actualizaCurpLabel();
        }

        public string ObtenerClaveEntidad(string nombreEntidad)
        {
            Dictionary<string, string> clavesEntidad = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Aguascalientes", "AS" },
                { "Baja California", "BC" },
                { "Baja California Sur", "BS" },
                { "Campeche", "CC" },
                { "Coahuila de Zaragoza", "CL" },
                { "Colima", "CM" },
                { "Chiapas", "CS" },
                { "Chihuahua", "CH" },
                { "Ciudad de México (CDMX)", "DF" },
                { "Durango", "DG" },
                { "Guanajuato", "GT" },
                { "Guerrero", "GR" },
                { "Hidalgo", "HG" },
                { "Jalisco", "JC" },
                { "México", "MC" },
                { "Michoacán de Ocampo", "MN" },
                { "Morelos", "MS" },
                { "Nayarit", "NT" },
                { "Nuevo León", "NL" },
                { "Oaxaca", "OC" },
                { "Puebla", "PL" },
                { "Querétaro", "QT" },
                { "San Luis Potosí", "SP" },
                { "Sinaloa", "SL" },
                { "Sonora", "SR" },
                { "Tabasco", "TC" },
                { "Tamaulipas", "TS" },
                { "Tlaxcala", "TL" },
                { "Veracruz", "VZ" },
                { "Yucatán", "YN" },
                { "Zacatecas", "ZS" },
                { "Nacido en el Extranjero", "NE" }
            };

            if (clavesEntidad.TryGetValue(nombreEntidad.Trim(), out string clave))
            {
                return clave;
            }
            else
            {
                return "XX";
            }
        }

        private string ExtraerConsonanteInterna(string palabra)
        {
            if (string.IsNullOrWhiteSpace(palabra) || palabra.Length < 2)
                return "X";

            string letras = palabra.Substring(1).ToUpper();
            foreach (char c in letras)
            {
                if ("BCDFGHJKLMNÑPQRSTVWXYZ".Contains(c))
                    return c.ToString();
            }
            return "X";
        }


        public string regresaCurp()
        {
            if (valCurpPrimeraFase())
            {
                string inicialP = apellidoP.Substring(0, 2).ToUpper();
                string inicialM = apellidoM.Length > 0 ? apellidoM.Substring(0, 1).ToUpper() : "X";
                string inicialN = nombre.Substring(0, 1).ToUpper();

                DateTime fecha = DateTime.ParseExact(fechaNac, "dd/MM/yyyy", null);
                string anio = fecha.ToString("yy");
                string mes = fecha.ToString("MM");
                string dia = fecha.ToString("dd");

                string claveEntidad = ObtenerClaveEntidad(entidad);

                string consP = ExtraerConsonanteInterna(apellidoP);
                string consM = apellidoM.Length > 0 ? ExtraerConsonanteInterna(apellidoM) : "X";
                string consN = ExtraerConsonanteInterna(nombre);

                return $"{inicialP}{inicialM}{inicialN}{anio}{mes}{dia}{sexo}{claveEntidad}{consP}{consM}{consN}";
            }

            return "No se puede generar la CURP con los datos proporcionados";
        }


        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            sexo = cbSexo.SelectedIndex == 1 ? "H" : "M";
            actualizaCurpLabel();
        }

        private void cbEntidadF_SelectedIndexChanged(object sender, EventArgs e)
        {
            entidad = cbEntidadF.SelectedItem.ToString();
            actualizaCurpLabel();
        }

        private void actualizaCurpLabel()
        {
            lblCURP.Text = regresaCurp();
        }

        private void txtDigitosDiferenciales_TextChanged(object sender, EventArgs e)
        {
            if (txtDigitosDiferenciales.Text.Length == 2 && valCurpPrimeraFase())
            {
                string ultimos2 = txtDigitosDiferenciales.Text.ToUpper();
                Regex regex = new Regex("^[A-Z0-9][0-9]$");

                if (regex.IsMatch(ultimos2))
                {
                    curp = regresaCurp() + ultimos2;
                    CurpGenerada?.Invoke(this, curp);
                }
                else
                {
                    MessageBox.Show("Los últimos 2 dígitos no son válidos. Deben tener formato: [letra o número][número].", "CURP inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDigitosDiferenciales.Clear();
                }
            }
        }

        public void LimpiarCampos()
        {
            txtApellidoP.Text = "Ej. Gonzales";
            txtApellidoM.Text = "Ej. Calderon";
            txtNombre.Text = "Ej. Bartolome";
            txtFechaNac.Text = "Ej. 14/05/2001";
            txtDigitosDiferenciales.Text = "";
            cbSexo.SelectedIndex = 0;        
            cbEntidadF.SelectedIndex = 0; 
            lblCURP.Text = "Llena los datos para generar una CURP valida";
        }
    }
}
