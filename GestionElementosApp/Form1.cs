namespace GestionElementosApp
{
    public partial class Form1 : Form
    {
        // Definición de las colecciones genércias
        private List<string> miLista;
        private Dictionary<string, string> miDictionary;
        private Queue<string> miQueue;

        public Form1()
        {
            InitializeComponent();

            // Inicializamos las colecciones
            miLista = new List<string>();
            miDictionary = new Dictionary<string, string>();
            miQueue = new Queue<string>();
        }

        private void btnAgregarList_Click(object sender, EventArgs e)
        {
            // Agregar un elemento a la lista
            string elemento = txtElemento.Text.Trim();
            if (!string.IsNullOrEmpty(elemento))
            {
                miLista.Add(elemento);
                ActualizarListBox();
                txtElemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
            }
        }

        private void ActualizarListBox()
        {
            // Actualizar el ListBox con los elementos de las colecciones
            lstColecciones.Items.Clear();

            // Mostrar contenido de la lista
            lstColecciones.Items.Add("Lista:");
            foreach (var item in miLista)
            {
                lstColecciones.Items.Add(item);
            }

            // Mostrar contenido del diccionario
            lstColecciones.Items.Add("\nDiccionario (Clave-Valor):");
            foreach (var entry in miDictionary)
            {
                lstColecciones.Items.Add($"Clave: {entry.Key}, Valor: {entry.Value}");
            }

            // Mostrar contenido de la cola
            lstColecciones.Items.Add("\nCola:");
            foreach (var item in miQueue)
            {
                lstColecciones.Items.Add(item);
            }
        }

        private void btnAgregarDictionary_Click(object sender, EventArgs e)
        {
            // Agregar un par clave-valor al diccionario
            string clave = txtElemento.Text.Trim();
            string valor = txtValor.Text.Trim();

            if (!string.IsNullOrEmpty(clave) && !string.IsNullOrEmpty(valor))
            {
                if (!miDictionary.ContainsKey(clave))
                {
                    miDictionary.Add(clave, valor);
                    ActualizarListBox();
                    txtElemento.Clear();
                    txtValor.Clear();
                }
                else
                {
                    MessageBox.Show("La clave ya existe.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una clave y un valor válidos.");
            }
        }

        private void btnAgregarQueue_Click(object sender, EventArgs e)
        {
            // Agregar un elemento a la cola
            string elemento = txtElemento.Text.Trim();
            if (!string.IsNullOrEmpty(elemento))
            {
                miQueue.Enqueue(elemento);
                ActualizarListBox();
                txtElemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
            }
        }

        private void btnProcesarQueue_Click(object sender, EventArgs e)
        {
            // Procesar (remover) el primer elemento de la cola
            if(miQueue.Count > 0)
            {
                string procesado = miQueue.Dequeue();
                MessageBox.Show($"Elemento procesado: {procesado}");
                ActualizarListBox();
            }
            else
            {
                MessageBox.Show("No hay elementos en la cola.");
            }
        }
    }
}
