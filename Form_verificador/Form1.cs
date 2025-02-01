using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Form_verificador
{
    public partial class F_verificacion : Form
    {

        static string nombre = "";
        int edad = 0;
        string registros = ""; // Variable para almacenar todos los registros
        string registros_historial = "";

        public F_verificacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_nombre_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            nombre = tb_nombre.Text;
            // Evitar que el campo se borre si está vacío
            if (string.IsNullOrWhiteSpace(nombre)) return;

            // Validar si el nombre contiene números
            if (nombre.Any(char.IsDigit))
            {
                // Si contiene números, mostrar mensaje pero no borrar el campo.
                MessageBox.Show("⚠ Error: El nombre no puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            VerificarDatos();
        }

        private void tb_edad_TextChanged(object sender, EventArgs e)
        {
            // Validar la edad
            if (string.IsNullOrWhiteSpace(tb_edad.Text))
            {
                tb_resultado.Clear();
                return;
            }

            if (!int.TryParse(tb_edad.Text, out edad) || edad < 0)
            {
                tb_resultado.Clear();
                MessageBox.Show("⚠ Error: La edad no puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VerificarDatos();
        }

        private void VerificarDatos()
        {
            // Asegurarse de que tanto nombre como edad son válidos antes de ejecutar el análisis
            if (string.IsNullOrWhiteSpace(nombre) || nombre.Any(char.IsDigit) || edad < 0)
            {
                tb_resultado.Clear();
                return;
            }

            // Realizar el análisis
            string resultado = AnalizarPersona(nombre, edad);
            tb_resultado.Text = $"Nombre: {nombre} \n Edad: {edad} \n Resultado del Análisis: {resultado}";

            if (!string.IsNullOrWhiteSpace(nombre) && edad > 0)
            {
                // Acumular los resultados en el historial
                registros_historial = $"Nombre: {nombre} | Edad: {edad} | Resultado: {resultado}\n";
            }
        }

        public static string AnalizarPersona(string Nombre, int edad)
        {
            if (string.IsNullOrWhiteSpace(Nombre)) return "⚠️ Error: El nombre no puede estar vacío.";

            char primeraLetra = char.ToLower(Nombre[0]);

            if (edad >= 200)
                return $"🧛 La probabilidad de que sea vampiro es alta. \n⚠️ Activar protocolo vampiro para {nombre} ⚠️";
            else if ((primeraLetra == 'h' && edad >= 180 && edad <= 199) || (edad >= 111 && edad <= 179) || (edad >= 180 && edad <= 199))
                return $"🐺 La probabilidad de que sea hombre lobo es alta. \n⚠️ Activar protocolo hombre lobo para {nombre} ⚠️";
            else
                return $"✅ Es muy probable que sea humano. Bienvenide a la convención, {nombre} 😘";

        }

        private void tb_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_historial_TextChanged(object sender, EventArgs e)
        {
        }

        private void b_historial_Click(object sender, EventArgs e)
        {
            tb_historial.Text += registros_historial;
        }

        private void b_limpiar_datos_Click(object sender, EventArgs e)
        {
                tb_nombre.Clear();
                tb_edad.Clear();

        }
    }
}

