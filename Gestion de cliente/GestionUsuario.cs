namespace Gestion_de_cliente
{
    public partial class GestionUsuario : Form
    {
        public GestionUsuario()
        {
            InitializeComponent();
        }

        private void GestionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            string name = InputName.Text;
            string lastName = InputLastName.Text;
            string telefono = InputTelefono.Text;
            string addres = InputAddres.Text;

            client.Name = name;
            client.LastName = lastName;
            client.Telefono = telefono;
            client.Addres = addres;

            listView.Items.Add($"new client is: {client.ToString()}");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listView.SelectedIndex;
            listView.Items.RemoveAt(index);
        }
    }


}