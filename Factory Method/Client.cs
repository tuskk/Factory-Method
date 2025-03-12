namespace Factory_Method
{
    public partial class Client : Form
    {
        private ICreator creator;
        public static Client? Instance;

        public Client()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            listObject.Items.Add("Fighter 5E Creator");
            listObject.Items.Add("Barbarian 5E Creator");
        }

        private void listObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listObject.SelectedItem.ToString())
            {
                case "Fighter":
                    creator = new FighterCreator();
                    break;
                case "Barbarian":
                    creator = new Barbarian5ECreator();
                    break;
                default:
                    break;
            }
            string typeName = listObject.SelectedItem.ToString();
            IHumanoid vehicle = creator.Create();
            vehicle.Build(typeName);
        }

        public void ShowMessage(string message)
        {
            textResult.Text = message;
        }

        public void ShowMessageWithImage(string message, string imageName)
        {
            textResult.Text = message;
            pictureObject.Image = Image.FromFile(imageName);
        }

        public void ClearImage()
        {
            pictureObject.Image = null;
        }
    }
}
